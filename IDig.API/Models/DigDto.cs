using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemInfo.API.Models
{
    public enum COLORS
    {
        RED,
        ORANGE,
        BLUE,
        GREEEN
    }
    public class DigDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public COLORS Theme { get; set; }
        public string TeamName { get; set; }
        public bool Active { get; set; }
        public List<string> Tags { get; set; }
        public List<int> Digs { get; set;  }
    }
}
