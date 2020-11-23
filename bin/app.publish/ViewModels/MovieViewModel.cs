using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class MovieViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number In Stock")]
        public byte? NumberInStock { get; set; }
        public IEnumerable<Genre> Genres { get; set; }  

        
        public string Title
        {
            get
            {
                if (Id != 0)
                {
                    return "Edit Movie";
                }

                return "New Movie";
            }
        }


        public MovieViewModel()
        {
            Id = 0;
        }
        public MovieViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

       
    }

}