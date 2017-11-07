using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.Site.Shared.Models
{
    public class SharedItem : BaseEntity<Guid>
    {
        public Entity Entity { get; set; }

        public Dictionary<SharedRule, decimal> RulePrices { get; set; }
    }
}
