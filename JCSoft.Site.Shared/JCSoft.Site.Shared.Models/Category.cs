using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.Site.Shared.Models
{
    public class Category : BaseEntity<Int32>
    {
        public string EnName { get; set; }

        public string CnName { get; set; }

        public Int32 ParentId { get; set; } = 0;
    }
}
