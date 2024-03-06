using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public static class OnlineStuff
    {
        public static NewsWriter OnlineNewsWriter { get; set; }
        public static Admin OnlineAdmin { get; set; }
        public static List<News> NewsListInTheSelectedCategory { get; set; }
        public static Category SelectedCategory { get; set; }
    }
}
