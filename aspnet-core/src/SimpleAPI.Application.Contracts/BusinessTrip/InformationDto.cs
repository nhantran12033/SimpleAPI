using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAPI.BusinessTrip
{
    public class InformationDto
    {
        public Guid Id { get; set; }
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
        public List<ExpenseDto>? ExpenseDetail { get; set; }
    }
}
