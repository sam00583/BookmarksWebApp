using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookmarksWebApp.Models
{
    public class Bookmark
    {
        [Key] // Précise que ces une Key (ici, ces logique comme ces déjà un Id)
        public int Id { get; set; }

        [Required] // Précise que la donnée est require
        public string Title { get; set; }

        [Required] // Précise que la donnée est require
        [Url] // Précise que la data est un URL
        public string Url { get; set; }
    }
}
