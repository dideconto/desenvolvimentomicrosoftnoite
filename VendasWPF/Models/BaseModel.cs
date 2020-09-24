using System;
using System.ComponentModel.DataAnnotations;

namespace VendasWPF.Models
{
    class BaseModel
    {
        public BaseModel() => CriadoEm = DateTime.Now;

        [Key]
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
