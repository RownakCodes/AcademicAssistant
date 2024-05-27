using System.ComponentModel.DataAnnotations;

namespace AcademicAssistant.Models
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the ID of the user.
        /// </summary>
        [Key]
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password of the user.
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the user.
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the status of the user.
        /// </summary>
        [Required]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the user was created.
        /// </summary>
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the account type of the user.
        /// </summary>
        [Required]
        public string AccountType { get; set; }

    }
}
