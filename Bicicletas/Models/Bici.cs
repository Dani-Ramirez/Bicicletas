using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bicicletas.Models
{
    [Table("BICICLETAS")]
    public class Bici
    {
        [PrimaryKey]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Caracteristicas { get; set; }
        

    }
}
