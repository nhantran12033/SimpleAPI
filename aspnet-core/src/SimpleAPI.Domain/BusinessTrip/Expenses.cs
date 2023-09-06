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
    public class Expenses : AuditedAggregateRoot<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid InformationsId { get; set; }
        public string? Purpose { get; set; }
        public string? Destination { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public int TotalNights { get; set; }
        public float TotalAmount { get; set; }
        public List<Items>? ItemDetail { get; set; }
    }
}
