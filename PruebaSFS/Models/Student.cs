using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaSFS.Models
{
    public class Student
    {
        [Required]
        [Display(Name = "Id Estudiante")]
        [RegularExpression("[0-9]+", ErrorMessage = "No ingresar caracteres especiales.")]
        [Range(0, 99999999999, ErrorMessage = "No ingresar más de 11 caracteres.")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tipo Documento")]
        public DocumentTypeEnum DocumentType { get; set; }

        [Required]
        [Display(Name = "N° Documento")]
        [RegularExpression("[0-9]+", ErrorMessage = "No ingresar caracteres especiales.")]
        [Range(0, 99999999999, ErrorMessage = "No ingresar más de 11 caracteres.")]
        public int DocumentId { get; set; }

        [Required]
        [Display(Name = "Nombres")]
        [RegularExpression("^([A-z Á-ú]*)", ErrorMessage = "No ingresar caracteres especiales.")]
        [StringLength(30, ErrorMessage = "No debe ingresar mas de 30 caracteres.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        [RegularExpression("^([A-z Á-ú]*)", ErrorMessage = "No ingresar caracteres especiales.")]
        [StringLength(30, ErrorMessage = "No debe ingresar mas de 30 caracteres.")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Fecha Nacimiento (DD/MM/YYYY)")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        [Required]
        [Display(Name = "Curso")]
        public int IdCourse { get; set; }

        [Display(Name="CURSO")]
        public virtual Course Course { get; set; }
    }
}