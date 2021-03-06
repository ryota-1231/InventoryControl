﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventoryControl.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int SupplierNum { get; set; }
        public virtual ICollection<Item> Items { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public static implicit operator Supplier(int v)
        {
            throw new NotImplementedException();
        }
    }
}
