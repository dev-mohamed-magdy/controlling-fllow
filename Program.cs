namespace controllingFollwTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number ");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest numbers");
                Console.WriteLine("Q - Quit");

                char choice = Convert.ToChar(Console.ReadLine().ToUpper());

                List<int> numbers = new List<int>() {};
                int value = 0;

                switch (choice)
                {
                    case 'P':
                        for( int x = 0; x < numbers.Count(); x++ )
                        {
                            Console.WriteLine(numbers[x]);
                        }
                        if(numbers.Count() < 1)
                        {
                            Console.WriteLine("The list is empty");
                        }
                        break;
                    case 'A':
                        numbers.Add(Convert.ToInt32(Console.ReadLine()));
                        for (int x = 0; x < numbers.Count(); x++)
                        {
                            Console.WriteLine(numbers[x]);
                        }
                        continue;
                        //break;
                    case 'M':
                        
                        double avg = 0;
                        for (int x = 0; x < numbers.Count(); x++)
                        {
                            value += numbers[x];
                        }
                        avg = value / numbers.Count;
                        Console.WriteLine(avg);
                        break;
                    case 'S':
                        int smaller = 100;
                        for (int x = 0; x < numbers.Count(); x++)
                        {
                            if (smaller > numbers[x])
                            {
                                smaller = numbers[x];
                            }
                        }
                        Console.WriteLine(smaller);
                        break;
                    case 'L':
                        int largest = 0;
                        for (int x = 0; x < numbers.Count(); x++)
                        {
                            if (largest < numbers[x])
                            {
                                largest = numbers[x];
                            }
                        }
                        Console.WriteLine(largest);
                        break;
                    case 'Q':
                        Console.WriteLine("Quit");
                        break;
                }
                i++;
            } while (i > 1);
        }
    }
}
