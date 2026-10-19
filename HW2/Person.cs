using System;

namespace HW2
{
    public class Person
    {
        // Thuộc tính đóng gói
        private string name;
        private string address;
        private double salary;

        // Constructors
        public Person() { }

        public Person(string name, string address, double salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }

        // Getters / Setters
        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }

        public string GetAddress() { return address; }
        public void SetAddress(string address) { this.address = address; }

        public double GetSalary() { return salary; }
        public void SetSalary(double salary) { this.salary = salary; }

        // Hàm 1: Kiểm tra dữ liệu lương và khởi tạo Person
        public static Person inputPersonInfo(string name, string address, string sSalary)
        {
            if (string.IsNullOrWhiteSpace(sSalary))
            {
                throw new Exception("You must input Salary.");
            }

            if (!double.TryParse(sSalary, out double salary))
            {
                throw new Exception("You must input digit.");
            }

            if (salary <= 0)
            {
                throw new Exception("Salary is greater than zero");
            }

            return new Person(name, address, salary);
        }

        // Hàm 2: Hiển thị thông tin 1 Person
        public static void displayPersonInfo(Person person)
        {
            if (person != null)
            {
                Console.WriteLine("Information of Person you have entered:");
                Console.WriteLine($"Name:{person.GetName()}");
                Console.WriteLine($"Address:{person.GetAddress()}");
                Console.WriteLine($"Salary:{person.GetSalary():F1}");
            }
        }

        // Hàm 3: Sắp xếp mảng Person theo lương tăng dần bằng Bubble Sort
        public static Person[] sortBySalary(Person[] person)
        {
            try
            {
                int n = person.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (person[j].GetSalary() > person[j + 1].GetSalary())
                        {
                            Person temp = person[j];
                            person[j] = person[j + 1];
                            person[j + 1] = temp;
                        }
                    }
                }
                return person;
            }
            catch (Exception)
            {
                throw new Exception("Can't Sort Person");
            }
        }
    }
}