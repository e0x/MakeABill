using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeABill.Domain.Generic;


namespace MakeABill.Domain.Entity
{
    public class ArticleCategory : AuditableEntity
    {

        
        public int Description { get; set; }
    }
}
