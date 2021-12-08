using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public virtual ICollection<Genre> Genres { get; set; }  // ponatamu smeni go ova vo enumeracija 
        public string CoverImage { get; set; }
        public List<string> ExtraImages { get; set; }   // URLs
        public decimal Price { get; set; }  // rabotime samo so euraaa
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Client> Clients { get; set; }

        public Game()
        {
            this.Genres = new List<Genre>();
            this.ExtraImages = new List<string>();
            this.Clients = new List<Client>();
        }
    }
}