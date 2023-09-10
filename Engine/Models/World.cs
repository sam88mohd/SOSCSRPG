using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            Location location = new Location();
            location.YCoordinate = yCoordinate;
            location.XCoordinate = xCoordinate;
            location.Name = name;
            location.Descriptions = description;
            location.ImageName = imageName;
            locations.Add(location);
        }

        public Location LocationAt (int xCoordinate, int yCoordinate)
        {
            foreach (Location location in locations)
            {
                if (location.XCoordinate == xCoordinate && location.YCoordinate == yCoordinate)
                {
                    return location;
                }
            } 
            return null;
        }
    }
}
