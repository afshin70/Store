using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// نقش کاربر
    /// </summary>
    public class Role
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// نام نقش
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// نامی که استفاده میشود جهت استفاده آیدنتیتی
        /// </summary>
        public string RoleUniqName { get; set; }
    }
}
