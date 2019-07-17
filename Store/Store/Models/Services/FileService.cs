using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using Store.Models.IService;
using Store.Models.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services
{
    public class FileService : IFileService
    {
     
        /// <summary>
        /// چک کردن فرمت عکس بصورت jpeg
        /// </summary>
        /// <param name="file">فایل عکس</param>
        /// <returns></returns>
        public bool CheckJPEGContentType(IFormFile file)
        {
            string content_type = file.ContentType.ToLower();
            string extention = Path.GetExtension(file.FileName).ToLower();
            if (content_type== MediaTypeNames.image_jpeg)
            {
                if (extention==FileExtention.JPEG||extention==FileExtention.JPG)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// حذف فایل
        /// </summary>
        /// <param name="fileName">نام فایل</param>
        /// <param name="savePath">دایرکتوری</param>
        /// <returns></returns>
        public bool DeleteFile(string fileName, string Path)
        {
            try
            {
                File.Delete(Path + @"\" + fileName);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool SaveFile(IFormFile file, string fileName, string savePath)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// ذخیره تصویر
        /// </summary>
        /// <param name="img">تصویر بایت شده</param>
        /// <param name="width">طول</param>
        /// <param name="height">ارتفاع</param>
        /// <param name="savePath">دایرکتوری</param>
        /// <param name="imageName">نام تصویر</param>
        /// <returns></returns>
        public bool SaveImageFile(byte[] img, int width, int height, string savePath, string imageName)
        {
            try
            {
                using (Image<Rgba32> image = Image.Load(img))
                {
                    image.Mutate(x => x.Resize(width: width, height: height));
                    image.Save(savePath + @"\" + imageName);
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// ذخیره تصویر
        /// </summary>
        /// <param name="img">فایل تصویر</param>
        /// <param name="width">طول</param>
        /// <param name="height">ارتفاع</param>
        /// <param name="savePath">دایرکتوری</param>
        /// <param name="imageName">نام تصویر</param>
        /// <returns></returns>
        public bool SaveImageFile(IFormFile img, int width, int height, string savePath, string imageName)
        {
            try
            {

                using (Image<Rgba32> image = Image.Load(img.OpenReadStream()))
                {
                    image.Mutate(x => x.Resize(width: width, height: height));
                    image.Save(savePath + @"\" + imageName);
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateFile(IFormFile newFile, string newFileName, string oldFileName, string savePath)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// بروزرسانی فایل تصویر
        /// </summary>
        /// <param name="newImg">فایل جدید</param>
        /// <param name="width">طول</param>
        /// <param name="height">ارتفاع</param>
        /// <param name="path">دایرکتوری</param>
        /// <param name="NewimageName">نام جدید</param>
        /// <param name="oldImageName">نام قبلی</param>
        /// <returns></returns>
        public bool UpdateImageFile(IFormFile newImg, int width, int height, string path, string NewimageName, string oldImageName)
        {
            try
            {
                if (DeleteFile(oldImageName, path))
                {
                    using (Image<Rgba32> image = Image.Load(newImg.OpenReadStream()))
                    {
                        image.Mutate(x => x.Resize(width: width, height: height));
                        image.Save(path + @"\" + NewimageName);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
