using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DeviantGames.Models
{
    public class Wishlist
    {
        [Key, ForeignKey("Client")]
        public int Id { get; set; }
        public Client Client { get; set; }
        public virtual ICollection<Game> GamesOnWishlist { get; set; }

        public Wishlist()
        {
            this.GamesOnWishlist = new List<Game>();
        }
    }
}