using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeviantGames.Models
{
    public class Game
    {
        // ke treba da dodades ID property
        public string Title { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public List<Genre> Genres { get; set; }  // ponatamu smeni go ova vo enumeracija 
        public string CoverImage { get; set; }
        public List<string> ExtraImages { get; set; }   // URLs
        public decimal Price { get; set; }  // rabotime samo so euraaa
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Game()
        {
            this.Genres = new List<Genre>();
            this.ExtraImages = new List<string>();
        }
    }
}