namespace carrental2
{
    public class rental
    {
        public DateTimeOffset startingDate;
        public int numberOfDays;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var rental1 = new rental();
            Console.WriteLine("Enter starting date");
            rental1.startingDate = DateTimeOffset.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of days");
            rental1.numberOfDays = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(rental1.startingDate.ToString("M/dd/yyyy"));
            //Console.WriteLine(rental1.numberOfDays);
            var month = rental1.startingDate.DateTime.Month;
            //Console.WriteLine(month);
            switch(month)
            {
                case 0:
                    Console.WriteLine("Error");
                    break;
                case 1:
                    if (rental1.numberOfDays <= 3)
                    Console.WriteLine(50 * rental1.numberOfDays);

                    if (rental1.numberOfDays>=4 && rental1.numberOfDays <= 8)
                        Console.WriteLine(49 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 9 && rental1.numberOfDays <= 15)
                        Console.WriteLine(48 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 16)
                        Console.WriteLine(45 * rental1.numberOfDays);
                    break;
                case 2:
                    if (rental1.numberOfDays <= 3)
                        Console.WriteLine(50 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 4 && rental1.numberOfDays <= 8)
                        Console.WriteLine(49 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 9 && rental1.numberOfDays <= 15)
                        Console.WriteLine(48 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 16)
                        Console.WriteLine(45 * rental1.numberOfDays);
                    break;
                case 3:
                    if (rental1.numberOfDays <= 3)
                        Console.WriteLine(50 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 4 && rental1.numberOfDays <= 8)
                        Console.WriteLine(49 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 9 && rental1.numberOfDays <= 15)
                        Console.WriteLine(48 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 16)
                        Console.WriteLine(45 * rental1.numberOfDays);
                    break;
                case 4:
                    if (rental1.numberOfDays <= 3)
                        Console.WriteLine(51 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 4 && rental1.numberOfDays <= 8)
                        Console.WriteLine(50 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 9 && rental1.numberOfDays <= 15)
                        Console.WriteLine(49 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 16)
                        Console.WriteLine(48 * rental1.numberOfDays);
                    break;
                case 5:
                    if (rental1.numberOfDays <= 3)
                        Console.WriteLine(52 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 4 && rental1.numberOfDays <= 8)
                        Console.WriteLine(51 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 9 && rental1.numberOfDays <= 15)
                        Console.WriteLine(50 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 16)
                        Console.WriteLine(50 * rental1.numberOfDays);
                    break;
                case 6:
                    if (rental1.numberOfDays <= 3)
                        Console.WriteLine(54 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 4 && rental1.numberOfDays <= 8)
                        Console.WriteLine(54 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 9 && rental1.numberOfDays <= 15)
                        Console.WriteLine(54 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 16)
                        Console.WriteLine(54 * rental1.numberOfDays);
                    break;
                default:
                    if (rental1.numberOfDays <= 3)
                        Console.WriteLine(54 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 4 && rental1.numberOfDays <= 8)
                        Console.WriteLine(54 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 9 && rental1.numberOfDays <= 15)
                        Console.WriteLine(54 * rental1.numberOfDays);

                    if (rental1.numberOfDays >= 16)
                        Console.WriteLine(54 * rental1.numberOfDays);
                    break;

            }

        }
    }
}