using procedure_kullanımı.Models;
using procedure_kullanımı.Models.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace procedure_kullanımı.ViewModels.Home
{
    public class HomePageViewModel
    {
        public List<Persons> kisiler_primitive_object { get; set; }
        public List<Addresses> adresler_primitive_object { get; set; }
        public List<my_procedure_class> my_procedure_class_primitive_object { get; set; }

        public int alt_sinir { get; set; }
        public int ust_sinir { get; set; }
        
    }
}