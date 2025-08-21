class Program
{
     static void Main()
    {
        //كل نقطه ف التاسك انا فاهمه جدا وعملت سيرش كتير ومعتمدش علي الذكاء الاصطناعي كليا 
        List<double> numbers = new List<double>();
        bool checkToContinue = false;

        while (!checkToContinue)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("F - Find a number");
            Console.WriteLine("C - Clear the whole list");
            Console.WriteLine("ASC - Sort List ASC");
            Console.WriteLine("DESC - Sort List DESC");
            Console.WriteLine("SWAP- To swab a two number");
            Console.WriteLine("Q - Quit");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine().ToUpper();

            switch (choice)
            {
                case "P":
                    Print(numbers);
                    break;

                case "A":
                    Add(numbers);

                    break;

                case "M":
                 double avg=   AVG(numbers);
                        Console.WriteLine($"Average: {avg}");
                    break;
 
                case "S":
                 double min=Smal(numbers);
                        Console.WriteLine($"Smallest number: {min}");
                     break;

                case "L":
                  double max=Large(numbers);
                        Console.WriteLine($"Largest number: {max}");
 
                    break;

                case "F":
                    double index = Find(numbers);
                        Console.WriteLine($"Number found at index: {index}");
                     break;

                case "C":
                  Clear(numbers);
                    break;

                case "ASC":
                    ASC(numbers);
                    break;

                case "DESC":
                  DESC(numbers);
                    break;

                case "SWAP":
                  Swap(numbers);
                    break;

                case "Q":
                    Quit(checkToContinue);        
                     break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
        static void Print(List<double> numbers)
        {
            Console.Write("List of Numbers: ");
            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

        }
        static void Add (List<double> numbers)
        {
            Console.Write("Please enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            //i'm Don't use Dublicate
            if (numbers.Contains(number))

                Console.WriteLine("This number is already in the list. Don't write it again.");

            else

                numbers.Add(number);

        }
        static Double  AVG(List<double> numbers)
        {
            if (numbers.Count > 0)
            {
                double sum = 0;
                foreach (double num in numbers)
                    sum += num;

                double avg = sum / numbers.Count;
                return avg;
            }
            else
                return 0;
        }
        static Double Smal(List<double> numbers)
     
        {
            if (numbers.Count > 0)
            {
                double min = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] < min)
                        min = numbers[i];
                }
                return min;

            }
            else
                return 0;       
        }
        static Double Large(List<double> numbers)
        {
            if (numbers.Count > 0)
            {
                double max = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] > max)
                        max = numbers[i];
                }
                 return max;
            }
            else
                return 0;
        }
        static double Find(List<double> numbers)
        {
            Console.Write("Enter number to find: ");
            double numFind = Convert.ToDouble(Console.ReadLine());

            int index = numbers.IndexOf(numFind);
            if (index != -1)
                return index;
            else
                return 0;
        } 
        static void Clear(List<double>numbers) 
        {
            numbers.Clear();
            Console.WriteLine("List cleared.");
        }
        static void ASC (List<double> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {

                        double temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("List sorted  ASC");
        }
        static void DESC(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        double temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("List sorted DESC");
        }
        static void Swap(List<double> numbers)
        {
            Console.Write("Enter first index: ");
            int index1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second index: ");
            int index2 = int.Parse(Console.ReadLine());

            if (index1 >= 0 && index1 < numbers.Count &&
                index2 >= 0 && index2 < numbers.Count)
            {
                double temp = numbers[index1];
                numbers[index1] = numbers[index2];
                numbers[index2] = temp;

                Console.WriteLine($"Swapped index {index1} with index {index2}.");
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
            }
        }
        static void Quit(bool checkToContinue)
        {
            checkToContinue = true;
            Console.WriteLine("Thes is End");
        }

    }

}
