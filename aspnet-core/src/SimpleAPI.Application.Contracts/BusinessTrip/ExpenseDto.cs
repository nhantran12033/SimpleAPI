using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAPI.BusinessTrip
{
    public class ExpenseDto
    {
        public Guid Id { get; set; }
        public Guid InformationsId { get; set; }
        public string? Purpose { get; set; }
        public string? Destination { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public int TotalNights { get; set; }
        public float TotalAmount { get; set; }
        public List<ItemDto>? ItemDetail { get; set; }
    }
}
