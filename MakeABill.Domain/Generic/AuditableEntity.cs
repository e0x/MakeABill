using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakeABill.Domain.Generic
{
    public class AuditableEntity
    {
        [Required, Key]
        public Guid Id { get; set; }
        public string LastModifyBy { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public bool IsActive { get; set; }
        public string Commentary { get; set; }
    }
}
