namespace AcademicAssistant.Models
{
    /// <summary>
    /// Represents the view model for displaying a book.
    /// </summary>
    public class _ShowBook
    {
        /// <summary>
        /// Gets or sets the ID of the book.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the course related to the book.
        /// </summary>
        public string Course { get; set; }

        /// <summary>
        /// Gets or sets the URL of the file associated with the book.
        /// </summary>
        public string FileUrl { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the book information was created.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets the username of the user who uploaded the book.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the status of the book.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who uploaded the book.
        /// </summary>
        public string UserID { get; set; }
    }
}
