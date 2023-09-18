using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace loja.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }

        public Order() { }

        public Order(int id, int customerId, DateTime date)
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.Date = date;
        }
    }
}
