using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookGallery.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionHtml { get; set; }
        public Book[] Issues { get; set; }
    }
}