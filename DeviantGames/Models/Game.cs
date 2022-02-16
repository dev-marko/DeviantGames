using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DeviantGames.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        [Display(Name = "Cover Image")]
        public string CoverImage { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Description { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }

        public Game()
        {
            this.Genres = new List<Genre>();
            this.Clients = new List<Client>();
            this.Wishlists = new List<Wishlist>();
        }

        public void AddGenre(Genre g)
        {
            this.Genres.Add(g);
        }
    }
}