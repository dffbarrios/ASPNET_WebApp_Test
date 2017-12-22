using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaSFS.Models
{
    public class Course
    {
        [Required]
        [Display(Name="Id Curso")]
        [RegularExpression("[0-9]+", ErrorMessage = "No ingresar caracteres especiales.")]
        [Range(0, 99999999999, ErrorMessage = "No ingresar más de 11 caracteres.")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [RegularExpression("^([A-z Á-ú]*)", ErrorMessage = "No ingresar caracteres especiales.")]
        [StringLength(30, ErrorMessage = "No debe ingresar mas de 30 caracteres.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Año Lectivo")]
        [RegularExpression("[0-9]+", ErrorMessage = "No ingresar caracteres especiales.")]
        [Range(2017,2999, ErrorMessage = "Años desde 2017 hasta 2999")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Semestre")]
        public SemesterEnum Semester { get; set; }

        public virtual ObservableCollection<Student>
            Students
        { get; set; }
    }
}