using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventoryControl.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ClientNum { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }


        public static implicit operator Client(int v)
        {
            throw new NotImplementedException();
        }
    }
}
