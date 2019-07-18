using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Utility.Enums
{
    /// <summary>
    /// جنسیت
    /// </summary>
    public static class Gender
    {
        [DisplayName("مذکر")]
        public const bool Men = true;
        [DisplayName("مونث")]
        public const bool Women = false;
    }
}
