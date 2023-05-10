using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> blog { get; set; }
        public IEnumerable<Blog> sonBloglar { get; set; }
        public IEnumerable<Yorumlar> yorum { get; set; }
        public IEnumerable<Yorumlar> SonYorumlar { get; set; }
    }
}