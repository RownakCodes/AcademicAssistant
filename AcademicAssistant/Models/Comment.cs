using System.ComponentModel.DataAnnotations;

namespace AcademicAssistant.Models
{
    /// <summary>
    /// Represents the view model for a comment.
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Gets or sets the ID of the comment.
        /// </summary>
        [Key]
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who made the comment.
        /// </summary>
        [Required]
        public string UserID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the post to which the comment belongs.
        /// </summary>
        [Required]
        public string PostID { get; set; }

        /// <summary>
        /// Gets or sets the content of the comment.
        /// </summary>
        [Required]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the status of the comment.
        /// </summary>
        [Required]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the comment was made.
        /// </summary>
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;

    }
}
