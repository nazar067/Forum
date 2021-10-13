using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Message
    {
        static Theme theme = new Theme();
        public int Id { get; set; }
        //public int IDMessage { get; set; }
        public string Messages { get; set; } = theme.Title;
        public string Themenames { get; set; }
    }
}
