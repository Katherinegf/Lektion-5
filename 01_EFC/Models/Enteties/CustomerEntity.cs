using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01_EFC.Models.Enteties
{

    [Index(nameof(Email),IsUnique =true)]
    internal class CustomerEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [StringLength(50)]
        public string FirstName { get; set; }= string.Empty;

        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [StringLength(100)]
        public string Email { get; set; } = string.Empty;  // sätter uppe i koden att adressen ska vara unique

        [Column(TypeName = "char(13)")]
        public string? PhoneNumber { get; set; } //frpågetecekn gör den nulleble

        [Required]
       
        public int AddressId { get; set; }    // de här tillsammans skapar kopplingen som finns i SQLQuery
        public AddressEntity Address { get; set; } = null!; // refererar till adresser



    }
}
