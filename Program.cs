using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    // MooseSays("I really am enthusiastic");
    Moose8Ball();
    // Ask some questions
    // Questions();
}

// void Questions()
// {
//     //Canada Question
//     bool isTrue = MooseAsks("Is Canada real?");
//     if (isTrue)
//     {
//         MooseSays("Really? It seems very unlikely.");
//     }
//     else
//     {
//         MooseSays("I  K N E W  I T !!!");
//     }

//     //Enthusiastic Question
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }

//     //C# Question
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }

//     //Secret Question
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }



void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

// bool MooseAsks(string question)
// {
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower();

//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }

//     if (answer == "y")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

void Moose8Ball()
{
    Console.Write("Ask me any question! ");
    string question = Console.ReadLine();

    Random r = new Random();
      int genRand= r.Next(0,19);
    
    if (genRand == 0)
    {
        Console.Write("As I see it, yes.");
    }
    else if (genRand == 1)
    {
        Console.Write("Ask again later.");
    }
    else if (genRand == 2)
    {
        Console.Write("Better not tell you now.");
    }
    else if (genRand == 3)
    {
        Console.Write("Cannot predict now.");
    }
    else if (genRand == 4)
    {
        Console.Write("Concentrate and ask again.");
    }
    else if (genRand == 5)
    {
        Console.Write("Don’t count on it.");
    }
    else if (genRand == 6)
    {
        Console.Write("It is certain.");
    }
    else if (genRand == 7)
    {
        Console.Write("It is decidedly so.");
    }
    else if (genRand == 8)
    {
        Console.Write("Most likely.");
    }
    else if (genRand == 9)
    {
        Console.Write("My reply is no.");
    }
    else if (genRand == 10)
    {
        Console.Write("My sources say no.");
    }
    else if (genRand == 11)
    {
        Console.Write("Outlook not so good.");
    }
    else if (genRand == 12)
    {
        Console.Write("Outlook good.");
    }
    else if (genRand == 13)
    {
        Console.Write("Reply hazy, try again.");
    }
    else if (genRand == 14)
    {
        Console.Write("Signs point to yes.");
    }
    else if (genRand == 15)
    {
        Console.Write("Very doubtful.");
    }
    else if (genRand == 16)
    {
        Console.Write("Without a doubt.");
    }
    else if (genRand == 17)
    {
        Console.Write("Yes.");
    }
    else if (genRand == 18)
    {
        Console.Write("Yes – definitely.");
    }
    else if (genRand == 19)
    {
        Console.Write("You may rely on it.");
    }

}