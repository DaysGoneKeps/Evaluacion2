using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluacion2.Models
{
    public class Pet
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Tipo { get; set; }
            public string Estado { get; set; } // "Adoptado" o "No adoptado"

            public Adoption? Adoption { get; set; }
        
    }
}