using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SimpleAPI.BusinessTrip
{
    public class Items : AuditedAggregateRoot<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid ExpensesId { get; set; }
        public string? Item { get; set; }
        public string? Specification { get; set; }
        public string? OriginalCurrency { get; set; }
        public float OriginalUnit { get; set; }
        public float Volume { get; set; }
        public float OriginalAmount { get; set; }
        public float EquivalentInVND { get; set; }
        public string? Notes { get; set; }


    }
}
