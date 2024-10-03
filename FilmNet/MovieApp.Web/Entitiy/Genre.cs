using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Entitiy
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
