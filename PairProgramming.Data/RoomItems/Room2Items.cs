using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


   public class Room2Items 
{
    public string ItemName { get; set; }
    public string ItemDescription { get; set; }

    public Room2Items(string itemName, string itemDescription)
    {
        ItemName = itemName;
        ItemDescription = itemDescription;
    }
}