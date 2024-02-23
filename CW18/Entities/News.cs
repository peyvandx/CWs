using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class News
    {
        public int Id { get; set; }
        public string ImgPath { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public int NewsWriterId { get; set; }
        public int CategoryId { get; set; }
        //navigation properties
        public Category Category { get; set; }
        public NewsWriter NewsWriter { get; set; }
    }
}
