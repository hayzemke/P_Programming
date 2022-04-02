using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface IRooms
    {
        bool ExitUnlocked { get; set; }

        string Password { get; set; }

        string RoomDescription { get; set; }

        string Clue { get; set; }
    }
