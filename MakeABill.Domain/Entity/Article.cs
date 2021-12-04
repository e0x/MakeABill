using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MakeABill.Domain.Generic;

namespace MakeABill.Domain.Entity
{
    public class Article : AuditableEntity
    {
        [StringLength(50)]
        public string Description { get; set; } // Description

        public string Unit { get; set; } // Measure Unit

        public double PriceUnit { get; set; } // Price without taxes

        public double PriceUnitTaxed { get; set; } // Price with taxes

        [StringLength(50)]
        public string PerfomanceObs { get; set; } // Perfomance OBS

        public int RecomendSupplierId { get; set; }

        [ForeignKey("ArticleCategory")]
        public Guid? CategoryId { get; set; }
        public virtual ArticleCategory Category { get; set; }



    }
}
