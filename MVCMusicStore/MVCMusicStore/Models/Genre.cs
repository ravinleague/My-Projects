using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class Genre
    {
        //[Key]
        //[ScaffoldColumn(false)]
        public int GenreId { get; set; }

        //[Required]
        //[MinLength(4,ErrorMessage ="Genre name must contain at least 4 characters.")]
        public string Name { get; set; }

        //[MaxLength(140, ErrorMessage = "Genre name can contain no more that 140 characters.")]
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}