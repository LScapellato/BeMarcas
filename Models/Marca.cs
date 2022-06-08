using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeMarcas.Models
{
    public class Marca
    {
        [Key]
        public int Id_Marca { get; set; }
        [Required]
        [Column(TypeName ="varchar(100)")]
        public string Den_marca { get; set; }
        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Cmarca { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string RegistroMca { get; set; }
        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Estado { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Viña { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime FECHA_CARGA { get; set; }


    }
}
