using System;
using System.ComponentModel.DataAnnotations;
namespace InventoryControl.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
