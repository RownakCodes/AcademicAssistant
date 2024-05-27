using System.ComponentModel.DataAnnotations;

namespace AcademicAssistant.Models
{
    /// <summary>
    /// Represents a test entity.
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Gets or sets the ID of the test.
        /// </summary>
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the test.
        /// </summary>
        public string Name { get; set; }
    }
}
