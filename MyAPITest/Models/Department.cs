using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Models
{
    /// <summary>
    /// Department entity
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        [Required]
        public int Level { get; set; }
        /// <summary>
        /// Gets or sets the bedrooms.
        /// </summary>
        /// <value>
        /// The bedrooms.
        /// </value>
        [Required]
        public int Bedrooms { get; set; }
    }
}
