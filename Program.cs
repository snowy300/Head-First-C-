using System;

class Elephant
{
    public int EarSize;
    public string Name;

    
    
    public void WhoAmI()
    {
        Console.WriteLine("My name is " + Name);
        Console.WriteLine("My ears are " + EarSize + " inches tall");

    }
    public void HearMessage(string message , Elephant whoSaidIt)
    {
        Console.WriteLine(Name + " heard a message");
        Console.WriteLine(whoSaidIt.Name + " said this: " + message);
    }
    public void SpeakTo(Elephant whoToTalkTo , string message)
    {
        whoToTalkTo.HearMessage(message, this);
    }

    static void Main(string[] args)
    {
        bool[] myArray;
        myArray = new bool[15];
        myArray[4] = true;
        

        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        Console.WriteLine("Press 1 for Lloyd , 2 for Lycinda");
        Random random = new Random();
        while (true)
        {
            char input = Console.ReadKey(true).KeyChar;
            Console.WriteLine("You pressed " + input);
            if (input == '1')
            {
                Console.WriteLine("Calling lloyd.WhoAmI");
                lloyd.WhoAmI();
            }
            else if (input == '2')
            {
                Console.WriteLine("Calling lucinda.WhoAmI");
                lucinda.WhoAmI();
            }
            else if (input == '3')
            {
                Elephant holder;
                holder = lloyd;
                lloyd = lucinda;
                lucinda = holder;
                Console.WriteLine("References has been swapped");
            }
            else if (input == '4')
            {
                
                lloyd = lucinda;
                lloyd.EarSize = random.Next(100000);
                lloyd.WhoAmI();
            }else if(input == '5')
            {
                lucinda.SpeakTo(lloyd, "Hi , Lloyd");

            }
            else return;
            Console.WriteLine();
            
        }
    }
}