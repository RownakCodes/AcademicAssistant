using System.ComponentModel.DataAnnotations;

namespace AcademicAssistant.Models
{
    /// <summary>
    /// Represents a book entity.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the ID of the book.
        /// </summary>
        [Key]
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the course related to the book.
        /// </summary>
        [Required]
        public string Course { get; set; }

        /// <summary>
        /// Gets or sets the file URL of the book.
        /// </summary>
        public string FileUrl { get; set; }


        /// <summary>
        /// Gets or sets the date and time when the book was added.
        /// </summary>
        [Required]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who added the book.
        /// </summary>
        [Required]
        public string UserID { get; set; }

        /// <summary>
        /// Gets or sets the status of the book.
        /// </summary>
        [Required]
        public string Status { get; set; }
    }
}
