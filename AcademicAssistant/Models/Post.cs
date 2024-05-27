using System.ComponentModel.DataAnnotations;

namespace AcademicAssistant.Models
{
    /// <summary>
    /// Represents a post entity.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Gets or sets the ID of the post.
        /// </summary>
        [Key]
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the title of the post.
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the content of the post.
        /// </summary>
        [Required]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the image URL of the post.
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the post.
        /// </summary>
        [Required]
        public DateTime DateTime { get; set;}

        /// <summary>
        /// Gets or sets the user ID of the post.
        /// </summary>
        [Required]
        public string UserID { get; set; }

        /// <summary>
        /// Gets or sets the status of the post.
        /// </summary>
        [Required]
        public string Status { get; set; }
    }
}
