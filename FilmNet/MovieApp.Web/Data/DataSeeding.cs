using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Web.Entitiy;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder App)
        {
            var scope = App.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieContext>();

            context.Database.Migrate();

            var genres = new List<Genre>()
                        {
                            new Genre {Name = "Macera",Movies = new List<Movie>(){
                                 new Movie {
                                Title = "Yeni macera filmi 1",
                                Description = "Açıklama",
                                ImageUrl = "resim1.jpg",
                            },

                            new Movie {
                                Title = "Yeni macera filmi 2",
                                Description = "Açıklama",
                                ImageUrl = "resim2.jpg",
                                },
                            }
                        },
                            new Genre {Name = "Komedi"},
                            new Genre {Name = "Romantik"},
                            new Genre {Name = "Savaş"},
                            new Genre {Name = "Bilim Kurgu"}
                        };
            var movies = new List<Movie>()
                        {
                            new Movie {
                                Title = "Uçurtma Avcısı",
                                Description = "Açıklama",
                                ImageUrl = "resim1.jpg",
                                Genre = genres[0]
                            },

                            new Movie {
                                Title = "Buz Devri: Büyük Çarpışma",
                                Description = "Açıklama",
                                ImageUrl = "resim2.jpg",
                                Genre = genres[2]
                            },

                            new Movie {
                                Title = "Avatar: Suyun Yolu",
                                Description="Açıklama",
                                ImageUrl = "resim3.jpg",
                                Genre = genres[1]
                            },
                            new Movie {
                                Title = "Titanik",
                                Description="Açıklama",
                                ImageUrl = "resim4.jpg",
                                Genre = genres[3]
                            },

                            new Movie {
                                Title = "Oppenheimer",
                                Description="Açıklama",
                                ImageUrl = "resim5.jpg",
                                Genre = genres[2]
                            },

                            new Movie {
                                Title = "Barbie",
                                Description="Açıklama",
                                ImageUrl = "resim6.jpg",
                                Genre = genres[1]
                            }
                        };

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(movies);               
                }
                
                context.SaveChanges();
            }
        }
    }
}
