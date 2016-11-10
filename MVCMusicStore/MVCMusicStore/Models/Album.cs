using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class Album
    {
        //[Key]
        //[ScaffoldColumn(false)]
        public int AlbumId{get; set;}

        //[ScaffoldColumn(false)]
        public int GenreId { get; set; }

        //[ScaffoldColumn(false)]
        public int ArtistId { get; set; }

        //[DisplayName("Album Title")]
        [Required(ErrorMessage ="Album Title is a required field.")]
        public string Title { get; set; }

        //[Required(ErrorMessage ="Price is Required.")]
        //[Range(0.01,100.0,ErrorMessage ="Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; } = "~/Content/Images/aart.png";
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
    }
}