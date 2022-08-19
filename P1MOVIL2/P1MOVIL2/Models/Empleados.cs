using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace P1MOVIL2.Models
{
    public class Empleados
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }
        [MaxLength(100)]
        public String nombre { get; set; }
        [MaxLength(100)]
        public String apellidos { get; set; }
        public Int32 edad { get; set; }

        public String ocupacion { get; set; }



        public String direccion { get; set; }


    }
}
