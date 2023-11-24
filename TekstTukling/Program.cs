namespace TekstTukling
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
            static void Init()
            {
                Run();
            }

            static void Run()
            {
                while (true)
                {
                    Console.WriteLine("Write some text!");
                    string input = Console.ReadLine();
                    Console.WriteLine("Do you want to (1) Reverse your text or (2) Replace all e's with a's");
                    string reply = Console.ReadLine();
                    switch (reply)
                    {
                        case "1":
                            string inputReversed = ReverseInput(input);
                            Console.WriteLine(inputReversed);
                            break;
                        case "2":
                            string inputEWithA = ReplaceEWithA(input);
                            Console.WriteLine(inputEWithA);
                            break;
                        default:
                            Console.WriteLine("No option Chosen");
                            break;
                    }
                }
            }

            static string ReverseInput(string input)
            {
                char[] inputArray = input.ToCharArray();
                Array.Reverse(inputArray);
                return new string(inputArray);
            }

            static string ReplaceEWithA(string input)
            {
                char[] inputArray = input.ToCharArray();
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] == 'a')
                    {
                        inputArray[i] = 'e';
                    } else if (inputArray[i] == 'A')
                    {
                        inputArray[i] = 'E';
                    }
                }
                return new string(inputArray);
            }
        }
    }
}