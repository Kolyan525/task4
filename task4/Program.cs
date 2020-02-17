using System;
using System.IO;
using System.Text;

namespace Files
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            Console.InputEncoding = Encoding.Default;

            bool cycle = true;
            string path = "file.txt";
            while (cycle)
            {
                Console.WriteLine("\nPress : \n1 to Create file and add data into\n" +
                    "2 to Show file contents\n3 to Add data into file\n" +
                    "4 to Remove data (record) from file\n5 to Output by condition\n" +
                    "6 to Exit\n");
                int caseSwitch = Convert.ToInt32(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("File Created");

                        //Console.WriteLine("Enter file name (+ .txt ) :");
                        //string fileName = Console.ReadLine();
                        //Console.WriteLine("Enter full path for a file with 2 \\");
                        //string path1 = ""; path1 += Console.ReadLine();
                        //path1 += fileName;
                        //path = path1;
                        //Console.WriteLine($"full path : {path1}");
                            break;
                    case 2:
                        //Console.WriteLine("Case 2");
                        using (StreamReader streamR = new StreamReader(path, System.Text.Encoding.UTF8))
                        {
                            string lineStream;
                            while ((lineStream = streamR.ReadLine()) != null)
                            {
                                Console.WriteLine(lineStream);
                            }
                        }
                        break;
                    case 3:
                        //Console.WriteLine("Case 3");
                        Console.WriteLine("Write your info:");
                        string line = Console.ReadLine();
                        using (StreamWriter stream = new StreamWriter(path, true))
                            stream.WriteLine(line);
                        break;
                    case 4:
                        //Console.WriteLine("Case 4");
                        Console.WriteLine("What data?\n(Enter string):");
                        string remove = Console.ReadLine();
                        using (StreamWriter stream = new StreamWriter(path, true))
                        {
                            if (path.Contains(remove))
                            {
                                path.Replace(remove, "Deleted");
                            }
                            else
                            {
                                Console.WriteLine("No such record!");
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Case 5");
                        break;
                    case 6:
                        cycle = false;
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }
                //Console.Clear();
            }
        }
    }
}
/*
 * string path = "stud.txt";

            string[] surname = { "Берестяк Г.С.", "Заєць О.М.", "Зоренко П.М", "Іванчук С.О",
                "Кравченко З.І.", "Панченко І.А.", "Сидорук В.Р.", "Снопок П.О.", "Якимець Н.С.", "Якубів Р.Н."};
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] mark = { 4, 5, 3, 4, 3, 5, 4, 3, 5, 4 };

            //for (int i = 0; i < 10; i++)
            //{
            //    using (StreamWriter stream = new StreamWriter(path, true))
            //        stream.WriteLine(surname[i] + " " + number[i] + " " + mark[i]);
            //}

            Console.WriteLine($"file {path}:");

            using (StreamReader streamR = new StreamReader(path, System.Text.Encoding.UTF8))
            {
                string line;
                while ((line = streamR.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            int mid = 0;
            for (int i = 0; i < 10; i++)
            {
                mid += mark[i];
            }
            Console.WriteLine($"Middle mark for math is {(double)(mid / 10)}");
 */
