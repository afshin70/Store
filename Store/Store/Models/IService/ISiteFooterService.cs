using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService
{
    /// <summary>
    /// سرویس فوتر
    /// </summary>
    public interface ISiteFooterService
    {
        /// <summary>
        /// عضویت در خبرنامه
        /// </summary>
        /// <returns></returns>
        bool SubscribeByEmail();

    }
}
