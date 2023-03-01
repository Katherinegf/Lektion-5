
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01_EFC.Models.Enteties
{

    internal class AddressEntity
    {
        [Key] // Key blir automatisk not null eftersom de sätts som primär nyckel
       // [Required] // not null ett måste
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string StreetName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "char(6)")]
        public string PostalCode { get; set; } = string.Empty;

        [Required] // behöver inte sätta Required ifall jag har det string.Empty
        [Column(TypeName = "nvarchar(50)")] // om jag inte sätter det så blir det max. 
        public string City { get; set; } = string.Empty;

        public ICollection<CustomerEntity>Customers = new HashSet<CustomerEntity>(); // HashSet kan avgöra om ett element finns i samlingen eller inte

        // Array       = fixerad lista med ett givet antal platser
        //List<>         = Lägga till/ ta bort / sortera mm. Har mest funktianaliteter
        // IEnumerable = Har inte lägg till eller ta bort komando. Bra om man vill flytta listan men ej kunna påverka den. Tex.från databas-
        // IObservableCollection = Lista som har INotfify collection. Tex. Den meddelar när saker har uppdaterats eller tagits bort. Flagga.
        // HashSet   = Skapar unika listan så att vi ej får dubletter.
        // ICollection = ett interface som klarar av vilken lista som helst oavsett vilken lista jag stoppar in. 

    }
}
