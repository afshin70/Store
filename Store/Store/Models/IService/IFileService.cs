using Microsoft.AspNetCore.Http;
using Store.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService
{
    public interface IFileService
    {
        /// <summary>
        /// ذخیره فایل
        /// </summary>
        /// <param name="file">فایل</param>
        /// <param name="fileName">نام فایل</param>
        /// <param name="savePath">دایرکتوری</param>
        /// <returns></returns>
        bool SaveFile(IFormFile file,string fileName,string savePath);
        /// <summary>
        /// حذف فایل
        /// </summary>
        /// <param name="fileName">نام فایل</param>
        /// <param name="savePath">دایرکتوری</param>
        /// <returns></returns>
        bool DeleteFile(string fileName, string Path);
        /// <summary>
        /// به روز رسانی یک فایل
        /// </summary>
        /// <param name="newFile">فایل جدید</param>
        /// <param name="newFileName">نام فایل جدید</param>
        /// <param name="oldFileName">نام فعلی فایل</param>
        /// <param name="savePath">دایرکتوری</param>
        /// <returns></returns>
        bool UpdateFile(IFormFile newFile, string newFileName,string oldFileName, string savePath);
        /// <summary>
        /// چک کردن فرمت عکس بصورت jpeg
        /// </summary>
        /// <param name="file">فایل عکس</param>
        /// <returns></returns>
        bool CheckJPEGContentType(IFormFile file);
        
       /// <summary>
       /// ذخیره تصویر
       /// </summary>
       /// <param name="img">تصویر بایت شده</param>
       /// <param name="width">طول</param>
       /// <param name="height">ارتفاع</param>
       /// <param name="savePath">دایرکتوری</param>
       /// <param name="imageName">نام تصویر</param>
       /// <returns></returns>
        bool SaveImageFile(byte[] img, int width, int height, string savePath, string imageName);
        /// <summary>
        /// ذخیره تصویر
        /// </summary>
        /// <param name="img">فایل تصویر</param>
        /// <param name="width">طول</param>
        /// <param name="height">ارتفاع</param>
        /// <param name="savePath">دایرکتوری</param>
        /// <param name="imageName">نام تصویر</param>
        /// <returns></returns>
        bool SaveImageFile(IFormFile img, int width, int height, string savePath, string imageName);
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
        bool UpdateImageFile(IFormFile newImg, int width, int height, string path, string NewimageName,string oldImageName);

    }
  
}
