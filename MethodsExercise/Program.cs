using System.Data;
using System.Globalization;
using System.Reflection.Metadata;
using System.Xml.XPath;
using System.Collections.Generic;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string name = GetName();
            string color = GetColor();
            string[] food = GetFood();

            StoryTime(name, color);


            DoTheMath(food);
        }
        public static string GetName()
        {
            Console.WriteLine("What is your name (or a name you like)?");
            string name = Console.ReadLine();
            return char.ToUpper(name[0]) + name.Substring(1);
        }
        public static string GetColor()
        {
            Console.WriteLine("What is your favorite color?");
            return Console.ReadLine().ToLower();
        }

        public static string[] GetFood()
        {
            string[] foods = new string[3];
            Console.WriteLine("What if your favorite food?");
            foods[0] = Console.ReadLine().ToLower();
            Console.WriteLine("What is your second favorite food?");
            foods[1] = Console.ReadLine().ToLower();
            Console.WriteLine("What is your third favorite food?");
            foods[2] = Console.ReadLine().ToLower();
            return foods;
        }

        public static string UserChoice()
        {
            do
            {
                string input = Console.ReadLine();
                if (input == "1" || input == "2")
                    return input;
                else
                {
                    Console.WriteLine("I'm sorry, but that isn't a valid choice. You must decide between the two paths before you.");
                    Console.WriteLine("Please enter '1' or '2' to continue");
                }
            } while (true);
        }

        public static void StoryTime(string name, string color)
        {
            Console.WriteLine("\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n");
            Console.WriteLine("Greetings, adventurer. The night has been long and unkind, and your memories of it are ");
            Console.WriteLine("little more than a haze.");
            StartInRoom(name, color);
        }
        public static void StartInRoom(string name, string color)
        {
            Console.WriteLine("You wake, dazed and disoriented, your senses slow to return as you instinctively groom your");
            Console.WriteLine($" soft {color} coat. You feel a collar around your neck and notice a tag with the");
            Console.WriteLine($"name \"{name}\" attached. Hmmmm that name seems faintly familiar? Is it yours? A loved one's?");
            Console.WriteLine("The air is damp and heavy, thick with the scent of old stone and");
            Console.WriteLine(" something faintly metallic. A chill clings to your fur, creeping in from the cold");
            Console.WriteLine("stone floor beneath you. The dim light from a single flickering torch casts long,");
            Console.WriteLine("wavering shadows across the chamber, making the jagged cracks in the walls seem");
            Console.WriteLine("to shift and writhe");
            Console.WriteLine("The hairs along your spine bristle. Something about this place feels wrong,");
            Console.WriteLine("as though unseen eyes watch from the darkness, waiting.");
            Console.WriteLine("You must escape.");
            Console.WriteLine("\nTwo ways out present themselves:");
            Console.WriteLine("A heavy wooden door, its iron hinges rusted with age.");
            Console.WriteLine("A narrow, arched window, its edges worn smooth by time.");
            Console.WriteLine("\nWhich path will you take?");
            Console.WriteLine("Press '1' to approach the window, or '2' to test the door.");
            Console.WriteLine("\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n");

            if (UserChoice() == "1")
                ExploreWindow(name, color);
            else
                ExploreDoor(name, color);
        }

        public static void ExploreWindow(string name, string color)
        {

            Console.WriteLine("\n   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n");
            Console.WriteLine("You move toward the window, and as you draw closer, the suffocating weight of");
            Console.WriteLine("the castle's gloom seems to ease—if only slightly. Pressing yourself against the");
            Console.WriteLine("cold stone, you peer outside. Below, the ground looms a daunting thirty feet");
            Console.WriteLine("down, bathed in the pale glow of the moon. A fall from this height would be dangerous,");
            Console.WriteLine("but not impossible.");
            Console.WriteLine("Your muscles tense as you consider your options. You could take the leap, relying");
            Console.WriteLine("on your feline agility and luck to land safely. Yet, another course presents itself—stripping");
            Console.WriteLine("the bed of its sheets and fashioning a rope to ease your descent. The eerie stillness");
            Console.WriteLine("of the castle gnaws at your nerves, urging you to act quickly.");
            Console.WriteLine("\nHow will you proceed?");
            Console.WriteLine("Press '1' to use the sheets as a makeshift rope, or '2' to take the risk and jump.");
            Console.WriteLine("\n   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n");
            if (UserChoice() == "1")
                UseSheets();
            else
                JumpDown(name, color);
        }
        public static void UseSheets()
        {

            Console.WriteLine("\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n");
            Console.WriteLine("You err on the side of caution, deciding to use the sheets. Quickly, you tie them");
            Console.WriteLine("together, securing one end to the bedframe. With a deep breath, you throw the");
            Console.WriteLine("rest out the window and begin your careful descent. The cold night air nips at your");
            Console.WriteLine("skin as you climb down, each movement measured and deliberate.");
            Console.WriteLine("At last, your feet touch the ground—rough soil beneath you, a welcome change");
            Console.WriteLine("from the damp stone. ");
            SuccessfulEscape();
        }
        public static void SuccessfulEscape()
        {
            Console.WriteLine("The terrain ahead is dark and shrouded in mist, but already the oppressive atmosphere of");
            Console.WriteLine("the castle begins to lift. You've escaped—and you silently thank your lucky stars");
            Console.WriteLine("for it. As you stand there, the cold fog wrapping around you, you realize the path");
            Console.WriteLine("home is unclear.");
            Console.WriteLine("For now, the only thing that matters is that you are free.");
            Console.WriteLine("The journey ahead may be uncertain, but one thing is sure: you've survived the night.");
            Console.WriteLine("\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n");
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();


        }
        public static void JumpDown(string name, string color)
        {

            Console.WriteLine("\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n");
            Console.WriteLine("you take a deep breath and leap into the night, trusting your agility. For a brief");
            Console.WriteLine("moment, you feel weightless—until you land with a jarring thud. The ground is");
            Console.WriteLine("unforgiving, and your 4 legs give way beneath you and your head smacks against the hard earth.");
            PassOut(name, color);
            StartInRoom(name, color);
        }
        public static void PassOut(string name, string color)
        {
            Console.WriteLine("The pain is immediate and blinding, and the world tilts around you, fading to black... =x.x=\n");

        }
        public static void ExploreDoor(string name, string color)
        {

            Console.WriteLine("\n   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n");
            Console.WriteLine("You approach the heavy wooden door, your eyes drawn to the thick, old lock");
            Console.WriteLine("hanging from the latch. The lock is sturdy, but you know you must find a way out");
            Console.WriteLine("quickly.");
            Console.WriteLine("Looking around the room, you notice two possible solutions:");
            Console.WriteLine("By the hearth, a jagged stone rests near the fire, large and heavy.");
            Console.WriteLine("With a strong swing, it might be enough to smash the lock off the door, ");
            Console.WriteLine("though it could be loud and draw attention.");
            Console.WriteLine("On a shelf, you notice an old, rusted set of tools, perhaps containing something small");
            Console.WriteLine("and delicate enough to fit through the padlock's latch. ");
            Console.WriteLine("\nWhat will you do?");
            Console.WriteLine("Press '1' to try and pick the lock with the tools on the shelf, or '2' to use the");
            Console.WriteLine("large stone to smash the lock off the door.");
            Console.WriteLine("\n   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n");
            if (UserChoice() == "1")
                PickLock();
            else
                LargeStone(name, color);
        }
        public static void LargeStone(string name, string color)
        {

            Console.WriteLine("\n   >   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n");
            Console.WriteLine("You decide to use the large stone near the fireplace. With a grunt, you lift the");
            Console.WriteLine("jagged rock, its weight heavy in your hands. You aim it carefully at the lock and");
            Console.WriteLine("swing with all your might. The stone slams into the lock with a loud crack, but the");
            Console.WriteLine("force causes it to bounce off the door, sending the stone ricocheting back toward");
            Console.WriteLine("you.");
            Console.WriteLine("Before you can react, the stone strikes your head with a sharp blow.");
            PassOut(name, color);
            StartInRoom(name, color);

        }
        public static void PickLock()
        {

            Console.WriteLine("\n   >   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n");
            Console.WriteLine("You carefully examine the rusty set of tools. With steady hands,");
            Console.WriteLine("you select a small pick and a thin rod, using them to work the lock. The old lock");
            Console.WriteLine("resists at first, but with a soft click, it finally gives way.");
            Console.WriteLine("With a sigh of relief, you open the door slowly, careful not to make a sound.");
            Console.WriteLine("Beyond, a narrow spiral staircase winds down into the shadows. You step carefully,");
            Console.WriteLine("feeling the weight of the moment.");
            Console.WriteLine("As you near the bottom of the staircase, you notice a faint sliver of moonlight");
            Console.WriteLine("filtering through a door that's slightly open. The light cuts through the darkness");
            Console.WriteLine("like a beacon, guiding your way. With each step, the cold night air seems to draw");
            Console.WriteLine("closer. With a final glance behind you, you sneak out the door, your heart pounding ");
            Console.WriteLine("in your chest.");
            SuccessfulEscape();
        }





        // Math Methods start here
        public static void DoTheMath(string[] foods) // this method tests out all the math operations methods
        {
            Console.WriteLine("\n     ~   *   ~  *  ~   *   ~     =^.^=     ~   *   ~  *  ~   *   ~           ");
            Console.WriteLine("\nAs a reward for your bravery and cunning, you are granted a most wondrous");
            Console.WriteLine("prize... Math facts! ");
            //addition
            Console.WriteLine($"\nYou gathered supplies before your escape. You packed 6 {foods[0]}, 3 {foods[1]},");
            Console.WriteLine($"12 {foods[2]}, and 9 pouches of water. Good thing you were able to pillage all ");
            Console.WriteLine("your favorite foods! How many total provisions do you have?");
            Console.WriteLine($"6 + 3 + 12 + 9 = {Sum(6, 3, 12, 9)}");
            Console.WriteLine("That’s 30 provisions—enough to last a few days on the road!");

            //multiplication
            Console.WriteLine("\nThe castle had 3 floors, and each floor had 4 locked doors just like yours.");
            Console.WriteLine("How many total locked doors were in the castle?");
            Console.WriteLine($"3 x 4 = {Multiply(3, 4)}");
            Console.WriteLine("That's a lot of trapped souls… Hopefully, they all escaped too.");


            //division
            Console.WriteLine("\nAs you ran into the forest, you found a 64-foot-long rope tied between the trees.");
            Console.WriteLine("If it was cut into 8 equal sections, how long was each piece?");
            Console.WriteLine($"64 ÷ 8  = {Divide(64, 8)}");
            Console.WriteLine("Each piece was 8 feet long—perfect for climbing or setting traps.");

            //subtraction
            Console.WriteLine("\nYou escaped the castle with 150 gold coins. After spending 30 for a map ");
            Console.WriteLine("and 25 for a safe passage through a toll, how many coins do you have left?");
            Console.WriteLine($"150 - 30 - 25 = {Subtract(150, 30, 25)}");
            Console.WriteLine("You still have 95 gold coins—a nice stash for the next town!");

            Console.WriteLine("\n\nMore math means more adventures—keep your wits sharp!");
            Console.WriteLine("\n     ~   *   ~  *  ~   *   ~     =^.^=     ~   *   ~  *  ~   *   ~           ");
        }

        public static int Sum(params int[] numbers)
        {
            int result = 0;
            foreach (int num in numbers)
                result += num;
            return result;
        }
        public static int Multiply(params int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                result *= numbers[i];
            return result;
        }

        public static int Subtract(params int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                result -= numbers[i];
            return result;
        }

        public static int Divide(params int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                result /= numbers[i];
            return result;
        }
    }

}

