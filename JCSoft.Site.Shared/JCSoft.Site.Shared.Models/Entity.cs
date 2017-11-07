using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.Site.Shared.Models
{
    public class Entity : BaseEntity<Int32>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public Category Category { get; set; }
    }
}
