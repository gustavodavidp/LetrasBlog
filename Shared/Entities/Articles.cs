using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetrasBlog.Infraestructure.Entities
{
    public class Articles
    {
        public int IdArticle { get; set; }
        public int IdUser { get; set; }
        public int IdCategory { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
    }
}
