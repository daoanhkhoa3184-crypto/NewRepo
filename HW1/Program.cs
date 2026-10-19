using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Các thông tin cách nhau đúng 1 dấu tab '\t'
            string fullName = "Đào Anh Khoa";
            string studentId = "12425035";
            string className = "124251";
            string githubUsername = "daoanhkhoa3184-crypto";
            // email cá nhân 
            string email = "daoanhkhoa3184@gmail.com"; 

            Console.WriteLine($"{fullName}\t{studentId}\t{className}\t{githubUsername}\t{email}");
        }
    }
}