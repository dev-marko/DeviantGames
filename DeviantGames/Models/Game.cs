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
        public string CoverImage { get; set; }
        public decimal Price { get; set; }  // rabotime samo so euraaa
        public string Description { get; set; }
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
    }
}