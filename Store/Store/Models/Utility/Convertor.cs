using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Utility
{
    public class Convertor
    {
<<<<<<< HEAD
        /// <summary>
        /// ریسایز کردن تصویر با طول و عرض یکسان
        /// </summary>
        /// <param name="input_Image_Path">آدرس فایل</param>
        /// <param name="output_Image_Path">آدرس خروجی فایل</param>
        /// <param name="new_Width">طول یا عرض</param>
=======

>>>>>>> d78447a7d2cfbbcade1a538949e5b6006109d36a
        public void Image_resize(string input_Image_Path, string output_Image_Path, int new_Width)
        {

            const long quality = 50L;

            Bitmap source_Bitmap = new Bitmap(input_Image_Path);



            double dblWidth_origial = source_Bitmap.Width;
            double dblHeigth_origial = source_Bitmap.Height;
            double relation_heigth_width = dblHeigth_origial / dblWidth_origial;
            int new_Height = (int)(new_Width * relation_heigth_width);
            

            var new_DrawArea = new Bitmap(new_Width, new_Height);

            using (var graphic_of_DrawArea = Graphics.FromImage(new_DrawArea))
            {
                graphic_of_DrawArea.CompositingQuality = CompositingQuality.HighSpeed;

                graphic_of_DrawArea.InterpolationMode = InterpolationMode.HighQualityBicubic;

                graphic_of_DrawArea.CompositingMode = CompositingMode.SourceCopy;

                graphic_of_DrawArea.DrawImage(source_Bitmap, 0, 0, new_Width, new_Height);

                using (var output = File.Open(output_Image_Path, FileMode.Create))
                {

                    var qualityParamId = Encoder.Quality;

                    var encoderParameters = new EncoderParameters(1);

                    encoderParameters.Param[0] = new EncoderParameter(qualityParamId, quality);

                    var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);

                    new_DrawArea.Save(output, codec, encoderParameters);

                    output.Close();
                }

                graphic_of_DrawArea.Dispose();
            }
            source_Bitmap.Dispose();
        }
        /// <summary>
        /// ریسایز کردن تصویر
        /// </summary>
        /// <param name="img">بایت شده ی فایل تصویر</param>
        /// <param name="_width">طول</param>
        /// <param name="_height">عرض</param>
        /// <param name="SavePath">محل ذخیره</param>
        /// <param name="Output_ImageName">نام تصویر خروجی</param>
        /// <returns></returns>
        public bool ResizeImage(byte[] img, int _width, int _height, string SavePath, string Output_ImageName)
        {
            try
            {
                using (Image<Rgba32> image = SixLabors.ImageSharp.Image.Load(img))
                {
                    image.Mutate(x => x.Resize(width: _width,height: _height));
                   
                    image.Save(SavePath + "/" + Output_ImageName);
                 // image.Save(SavePath + "/" + Output_ImageName,encoder:new PngEncoder());
                  
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }

}
