using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Program_UI
    {
          private readonly Room3_Repo _room3ItemRepo = new Room3_Repo();

        public void Run()
        {
            SeedData();
            RoomOne();
        }

    public void RoomOne()
    {
        DisplayRoomOneDescription();
        System.Console.WriteLine("Please enter in what order you pour the contents of the containers into the coffee cup (by their numbers): ");
        int passwordAttempt = int.Parse(Console.ReadLine());
        int password = 123;
        while(passwordAttempt != password)
            {
                System.Console.WriteLine("This is not a good cup of coffee, you empty the cup and try again.");
                passwordAttempt = int.Parse(Console.ReadLine());
            }
            if(passwordAttempt == password)
            {
                System.Console.WriteLine("That is a great cup of coffee, you hear the door to the hallway unlock. You can now enter the next room!");
                RoomTwo();
            }
    }

    private void DisplayRoomOneDescription()
    {
        System.Console.WriteLine("this is room one description");
    }

    public void RoomTwo()
    {
        DisplayRoomTwoDescription();
        System.Console.WriteLine("Please enter the order you would knock on the doors using their specific numbers:");
        int passwordAttempt = int.Parse(Console.ReadLine());
        int Password = 213;
        while (passwordAttempt != Password)
        {
            System.Console.WriteLine("Incorrect Sequence. Please Try Again.");
            passwordAttempt = int.Parse(Console.ReadLine());
        }
        if (passwordAttempt == Password)
        {
            System.Console.WriteLine("The Door is Unlocked! You Can Enter The Next Room!");
        }
        PressEnterToContinue();
        RoomThree();
    }

     private void DisplayRoomTwoDescription()
    {
        System.Console.WriteLine(
            "As you exit the kitchen, you enter a hallway. There are 4 doors in the hallway, you try to open each of the doors, and they all appear locked. One has a note written on it,\n" +
            "In order to enter the next room, you must knock on each of the doors in a specific order. A hint for the order is: \n " +
            "A woodpecker makes its home knocking first on a soft tree, next in a tree that is made of wood colored like fire, and finally knocking in the blackest of trees, where it will make its nest.\n”" +
            "As you look around at the other three doors, you notice that one is a Dark Ebony wood(Door 1), the next is made of Soft Cedar wood(Door 2), and the final door is a Bright Red Oak wood(Door 3).\n"
        );
    } 

    private void RoomThree()
    {
        RoomThreeDescription();
        Door3IsLocked();
    }

    private void Door3IsLocked()
    {
        bool DoorIsLocked = true;
        while (DoorIsLocked)
        {
            System.Console.WriteLine("Would You Like To Try To Enter The Code? Y/N");
            string userInput = Console.ReadLine();

            if (userInput == "Y".ToLower())
                {
                    System.Console.WriteLine("Please Enter 4 Letter Word:\n");
                    string passwordAttempt = Console.ReadLine();
                    string Password = "GROW".ToLower();

                    while (passwordAttempt != Password)
                    {
                        System.Console.WriteLine("Incorrect Word.");
                        PressEnterToContinue();
                        break;
                    }

                    if (passwordAttempt == Password)
                    {
                        DoorIsLocked = false;
                    }
                }

            if (userInput == "N".ToLower())
            {
                DisplayRoom3Items();
            }
        }
        EndOfGame();
    }

    private void EndOfGame ()
    {
                System.Console.WriteLine("The Door is unlocked. Congrats! You made it out of the house and get to re-enter the real world! Good luck out there!");
                CloseAppilication();

    }
    private void DisplayRoom3ItemDescription(Room3Items userSelectedItem)
    {
        System.Console.WriteLine($"{userSelectedItem.Description}");
        PressEnterToContinue();
        DisplayRoom3Items();
    }

    private void CloseAppilication()
    {
        
    }

    private void DisplayRoom3Items()
    { 
    
        System.Console.WriteLine("Dresser\n" + "Mirror\n" + "Bed\n" + "Chair\n");
        System.Console.WriteLine("What would you like to investigate?");
        var userInputSelectedItem = Console.ReadLine();
        var userSelectedItem = _room3ItemRepo.GetRoom3ItemDescriptionByName(userInputSelectedItem);
        
        if(userSelectedItem != null)
        {
            DisplayRoom3ItemDescription(userSelectedItem);
        }
    }

    private void RoomThreeDescription()
    {
        System.Console.WriteLine
        ("You walk into the guest bedroom of the house and the door suddenly shuts behind you and it appears to have locked.\n" +
        "It’s asking for a 4 letter word in order to unlock the door. You look around the room and you see a dresser with a some décor and a clock on it, a mirror surrounded by house plants, a bed, and a chair that has a blanket on it. \n" +
        "As you scan the room you are notice that there’s a piece of paper poking out from under the blanket on the chair. You go over to inspect it.\n" + 

        "You look around the chair and notice that there’s a letter ‘R’ stitched into the blanket. That must be a letter in the word!\n");
    }

    private void PressEnterToContinue()
    {
        System.Console.WriteLine("Press the Enter key to Continue.");
        Console.ReadKey();
    }

    private void SeedData()
    {
        Room3Items Dresser = new Room3Items("Dresser", "You look around on top of the dresser and see nothing that catches your eye besides a clock sitting on top of it that reads 7 o’clock. You check your watch and see that the time is actually 4:00 pm, so the clock must be stuck at that time. You inspect the clock some more and see that the letter ‘A’ is etched underneath the number ‘1’.");
        Room3Items Mirror = new Room3Items("Mirror", "You begin to look around at the mirror and the plants surrounding it. You see a pothos, a spider plant, a cactus, and an orchid flower. As you look closer at the plants, you see a plant label sticking out of the orchid flower that has a capital 'O' on it. You inspect the other plants and see no other labels on them.");
        Room3Items Bed = new Room3Items("Bed", "You begin to inspect the bed, moving the blankets and pillows when you notice a tag sticking out of the pillowcase with a capital ‘W’ on it, followed by the brand. There is no other notable information found.");
        Room3Items Chair = new Room3Items("Chair", "You look around the chair and notice that there's a letter 'R' stitched into the blanket. That must be a letter in the word! ");

        _room3ItemRepo.AddContentToDirectory(Dresser);
        _room3ItemRepo.AddContentToDirectory(Mirror);
        _room3ItemRepo.AddContentToDirectory(Bed);
        _room3ItemRepo.AddContentToDirectory(Chair);
    }
    }
