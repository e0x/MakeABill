using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeABill.Domain.Generic;


namespace MakeABill.Domain.Entity
{
    public class Company : AuditableEntity
    {
        public string Name { get; set; }
        public string Acronym { get; set; }
        public string  Phone { get; set; }
        public string WebSite { get; set; }
        public string  Address { get; set; }
        public int FromHoursOfServices { get; set; }
        public int ToHoursOfServices { get; set; }

    }
}
