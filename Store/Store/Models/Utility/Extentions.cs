using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Utility
{
    public static class Extentions
    {
        public static bool IsImageValid(this IFormFile formFile)
        {
            try
            {
                Image image = Image.FromStream(formFile.OpenReadStream());
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
