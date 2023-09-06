using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SimpleAPI.BusinessTrip
{
    public class Informations: AuditedAggregateRoot<Guid>
    {
        public string? OperaterName { get; set; } 
        public string? RequestNumber { get; set; } 
        public DateTime RequestDate { get; set; } 
        public string? LegalEntity { get; set; } 
        public string? Department { get; set; }
        public string? VerifierUsername { get; set; } 
        public string? VerifierName { get; set; } 
        public string? ExpenseCode { get; set; } 
        public string? BusinessType { get; set; } 
        public string? Notes { get; set; } 
        public List<Expenses>? ExpenseDetail { get; set; } 

    }
}
