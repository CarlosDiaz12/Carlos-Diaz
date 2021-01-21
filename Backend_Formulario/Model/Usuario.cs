using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Formulario.Model
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public string Cedula{ get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public int IdDepartamento { get; set; }
        [ForeignKey("IdDepartamento")]
        public virtual Departamento Departamento { get; set; }
        [Required]
        public string Cargo { get; set; }
        [Required]
        public string SupervisorDirecto { get; set; }

    }
}
