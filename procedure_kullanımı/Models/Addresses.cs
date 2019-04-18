using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace procedure_kullanımı.Models
{
    [Table("Addresses")]
    public class Addresses
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(300)]
        public string adres_tanim { get; set; }

        public virtual Persons kisi { get; set; }
    }
}