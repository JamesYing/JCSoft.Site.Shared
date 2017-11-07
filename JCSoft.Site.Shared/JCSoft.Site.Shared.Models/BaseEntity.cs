using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.Site.Shared.Models
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime UpdateOnTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
