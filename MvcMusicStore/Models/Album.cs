using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }

        public string Genere { get; set; }
        public System.DateTime? CreationDate { get; set; }
        public Artist Artist { get; set; }

        public virtual List<Review> Review { get; set; }

    }

}