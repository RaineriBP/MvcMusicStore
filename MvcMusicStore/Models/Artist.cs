using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Artist
    {
        
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string NameGroup { get; set; }

        public int WinAwards { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}