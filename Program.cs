namespace FileManagementExerciseTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"MyText.txt";

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                Console.WriteLine("Creating a file that contains text:");
                Console.WriteLine("-----------------------------------");


                Console.WriteLine("How many lines of text do you want to enter:");
                int n = int.Parse(Console.ReadLine()!);
                string[] ArrLines = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Input line {i + 1}:\n ");
                    ArrLines[i] = Console.ReadLine()!;
                }
                File.WriteAllLines(filePath, ArrLines);

            }
        }
    }

