using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Web.Entitiy
{
    public class Movie
    {
        //[Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
