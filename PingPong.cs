using System;

class PingPong
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        string stringNumber = Console.ReadLine();
        int userNumber = int.Parse(stringNumber); 
        string[] stringArray = new string[userNumber+1];
        for (int i = 1; i <= userNumber; i++)
        {
            if (i % 15 == 0)
            {
                stringArray[i] = "Ping-Pong";
            }
            else if (i % 3 == 0)
            {
                stringArray[i] = "Ping";
            }
            else if (i % 5 == 0)
            {
                stringArray[i]= "Pong";
            }
            else
            {
                stringArray[i]= i.ToString();
            }
            Console.Write("{0} ", stringArray[i]);
            
            //Console.WriteLine(string.Join("\n", stringArray));
            // Console.WriteLine(stringArray);
           // Console.WriteLine("[{0}]",string.Join(" ", stringArray));
        }
        Console.Write("\n");
    }
}

// using System;

// class PingPong
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a number");
//         string stringNumber = C
//     }
// }