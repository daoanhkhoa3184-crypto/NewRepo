using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Management Person programer=====");

            int n = 3;
            Person[] persons = new Person[n];

            // 1. Nhập thông tin 3 người
            for (int i = 0; i < n; i++)
            {
                if (i > 0) Console.WriteLine("Input Information of Person");

                Console.Write("Please input name:");
                string name = Console.ReadLine()?.Trim();

                Console.Write("Please input address:");
                string address = Console.ReadLine()?.Trim();

                double salary = 0;
                while (true)
                {
                    Console.Write("Please input salary:");
                    string sSalary = Console.ReadLine();

                    try
                    {
                        Person pTemp = Person.inputPersonInfo(name, address, sSalary);
                        salary = pTemp.GetSalary();
                        break; // Nhập đúng thì thoát vòng lặp
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message); // In thông báo lỗi exact như đề bài
                    }
                }

                persons[i] = new Person(name, address, salary);
            }

            // 2. Sắp xếp tăng dần theo lương
            try
            {
                persons = Person.sortBySalary(persons);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 3. Hiển thị danh sách sau khi sắp xếp
            foreach (var p in persons)
            {
                Person.displayPersonInfo(p);
            }
        }
    }
}