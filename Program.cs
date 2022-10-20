
Console.Clear();
bool validNum;
long resultNum = 0;
string numInput;


string playAgain = "yes";
while (playAgain == "yes")
{

    bool num = false;
    while (!num)
    {
        Console.WriteLine("Put some numbers in and see them get reversed!");
        numInput = Console.ReadLine();
        validNum = Int64.TryParse(numInput, out resultNum);
        if (validNum)
        {
            num = true;
            string reverseString = "";
            for (int i = numInput.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + numInput.Substring(i, 1);
            }
            Console.WriteLine(reverseString);
        }
        else
        {
            Console.WriteLine("not a number please enter a number");
        }

    }


    string word;
    string reverseStr = "";


    Console.WriteLine("Now enter a word or letters and see it get reversed!");
    word = Console.ReadLine();
    while(string.IsNullOrEmpty(word))
    {
        Console.WriteLine("You didn't enter anything please enter a word to reverse.");
        word = Console.ReadLine();
    }
    for (int i = word.Length - 1; i >= 0; i--)
    {
        reverseStr = reverseStr + word[i];
    }
    Console.WriteLine(reverseStr);

    Console.Write("Would you like to try again? Enter in Yes to retry or No to quit: ");

    string playAgainInput = "Nothing";

    while (playAgainInput != "yes" || playAgainInput != "no")
    {
        playAgainInput = Console.ReadLine().ToLower();
        if (playAgainInput == playAgain)
        {
            break;
        }
        else if (playAgainInput == "no")
        {
            Console.WriteLine("Thanks for playing!");
            playAgain = playAgainInput;
            break;

        }
        else
        {
            Console.WriteLine("Invalid Input");
            playAgainInput = "invalid";
        }

    }
}
