using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoicesAppASP.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public bool Paid { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Company { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
