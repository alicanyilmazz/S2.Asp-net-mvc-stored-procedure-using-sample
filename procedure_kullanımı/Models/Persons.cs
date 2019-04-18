using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace procedure_kullanımı.Models
{
    [Table("Persons")]
    public class Persons
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(20), Required]
        public string ad { get; set; }

        [StringLength(20), Required]
        public string soyad { get; set; }

        [Required]
        public int yas { get; set; }

        public virtual List<Addresses> adreslers { get; set; }
    }
}