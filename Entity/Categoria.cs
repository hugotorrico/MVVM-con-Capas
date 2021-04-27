using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public string Desripcion { get; set; }
        
        [NotMapped]
        public string NombresCompletos { get; set; }
    }
}
