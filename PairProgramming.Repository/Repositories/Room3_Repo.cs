using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Room3_Repo
    {
         private List<Room3Items>_room3ItemDatabase = new List<Room3Items>();

        public List<Room3Items> GetRoom3Items()
        {
            return _room3ItemDatabase;
        }

        public Room3Items GetRoom3ItemDescriptionByName(string name)
        {
            foreach(var room3Item in _room3ItemDatabase)
            {
                if(room3Item.Name == name)
                {
                    return room3Item;
                }
               
            }
            return null;
        }

        public bool AddContentToDirectory (Room3Items room3Items)
        {
            int startingCount = _room3ItemDatabase.Count();

            _room3ItemDatabase.Add(room3Items);

            bool wasAdded = (_room3ItemDatabase.Count > startingCount) ? true : false;
            return wasAdded;
        }
    }
