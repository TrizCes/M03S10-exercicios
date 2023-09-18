using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace loja.Model
{
    public class Customer
    {
        public int Id { get; private set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        public Customer(int id, string name, string email) 
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

    }
}