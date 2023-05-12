namespace myTest // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lvl = 5;
            int ki = lvl;

            int statStr = -1;
            int statDex = 4;
            int statCon = 2;
            int statInt = 1;
            int statWis = 3;
            int statCha = 2;

            int prf = 2;
            int hp = (lvl*5)+ statCon;

            int acrobatics    = statDex;
            int sleightofHand = statDex;
            int stealth       = statDex+prf;

            int animalHandling= statWis;
            int insight       = statWis;
            int medicine      = statWis;
            int perception    = statWis+prf;
            int survival      = statWis;

            int arcana        = statInt;
            int history       = statInt;
            int investigation = statInt;
            int nature        = statInt;
            int religion      = statInt;

            int athletics     = statStr;

            int deception     = statCha;
            int intimidation  = statCha;
            int performance   = statCha;
            int persuasion    = statCha;


            System.Random dice = new System.Random();
            int d20     = dice.Next(1, 21);
            int d100    = dice.Next(1, 101);
            int d12     = dice.Next(1, 13);
            int d10     = dice.Next(1, 11);
            int d8      = dice.Next(1, 9);
            int d6      = dice.Next(1, 7);
            int d4      = dice.Next(1, 5);

// begin code!
            Console.WriteLine("type it in: ");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "strength":
                Console.WriteLine(statStr+d20);
                break;

                case "charisma":
                Console.WriteLine(statCha+d20);
                break;
                
                case "dexterity":
                Console.WriteLine(statDex+d20);
                break;

                case "constitution":
                Console.WriteLine(statCon+d20);
                break;

                case "wisdom":
                Console.WriteLine(statWis+d20);
                break;

                case "intelligence":
                Console.WriteLine(statInt+d20);
                break;

                case "acrobatics":
                Console.WriteLine(acrobatics+d20);
                break;

                case "sleight of hand":
                Console.WriteLine(sleightofHand+d20);
                break;

                case "stealth":
                Console.WriteLine(stealth+d20);
                break;

    

            }
        
Console.WriteLine("you have reached the end");

        }
    }
}
