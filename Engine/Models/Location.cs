using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public string ImageName { get; set; }
        public List<Quest> QuestAvailableHere { get; set; } = new List<Quest>();
    }
}
