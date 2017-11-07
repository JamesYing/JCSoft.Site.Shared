using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.Site.Shared.Models
{
    public class SharedRule : BaseEntity<Int32>
    {
        public string Name { get; set; }

        public Int32 Code { get; set; }

        public string Description { get; set; }
    }
}
