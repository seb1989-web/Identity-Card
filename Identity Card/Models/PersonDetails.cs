using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Identity_Card.Models
{
    public class PersonDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Fotografie")]
        public string Photo { get; set; }
        [Required]
        
        public int CNP { get; set; }
        [Required]
        [DisplayName("Nume")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Prenume")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Nationalitate")]
        public string Nationality { get; set; }
        [Required]
        [DisplayName("Locul Nasterii")]
        public string PlaceOfBirth { get; set; }
        [Required]
        [DisplayName("Oras")]
        public string City { get; set; }
        [Required]
        [DisplayName("Strada")]
        public string Street { get; set; }
        [Required]
        [DisplayName("Numar")]
        public int Number { get; set; }

    }
}