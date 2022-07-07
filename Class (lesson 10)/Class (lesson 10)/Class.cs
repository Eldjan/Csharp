using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__lesson_10_
{
    public class Student
    {
        public string FullName;
        public string GroupNumber;
        public byte Age;

        public Student(string fn, string grNum, byte age)
        {
            FullName = fn;
            GroupNumber = grNum;
            Age = age;
        }
        public Student(string grNum,string fn)
        {
            FullName = fn;
            GroupNumber=grNum;

        }
        public static void GetBirthdaYear(Student student)
        {
            Console.WriteLine(DateTime.Now.Year - student.Age+ " dogum ili ");
        }
        public static void CheckGroupNumberByStName(string fullname, Student[] stds )
        {
            foreach(var item in stds)
            {
                if(item.FullName == fullname)
                {
                    Console.WriteLine(item.GroupNumber + " bu qrupda oxuyur");
                }    
            }
        }
        public static void CheckGroupNumber(string groupNum, Student[] stds)
        {
            int count = 0;
            foreach(var item in stds)
            {
                if(item.GroupNumber==groupNum)
                {
                    count++;
                    Console.WriteLine(item.FullName);
                }
            }
            Console.WriteLine(groupNum + $" qrupunda {count} oxuyur");
        }
     
        static void Main(string[] args)
        {
            Student[] students = new Student[3];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{i + 1} -ci telebeni sisteme elave et");
                Console.WriteLine("Fullname");
                string fullname = Console.ReadLine();
                Console.WriteLine("Qrupu");
                string qrupnum = Console.ReadLine();
                Console.WriteLine("Yasi");
                byte age = Convert.ToByte(Console.ReadLine());

                Student student = new Student(fullname, qrupnum, age);
                Student.GetBirthdaYear(student);

                students[i] = student;
            }
            Console.WriteLine("1.Qrup nomresini oyren \n 2.Qrupda nece telebe oldugunu oyren");
            int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Axtardiginiz telebenin adini daxil edin");
                    string telebeAdi=Console.ReadLine();
                        Student.CheckGroupNumberByStName(telebeAdi, students);
                        break;
                    case 2:
                        Console.WriteLine("Qrup nomresini daxil etmekle telebe sayi");
                        string qrupAdi = Console.ReadLine();
                        Student.CheckGroupNumber(qrupAdi, students);
                        break;
                        default: Console.WriteLine("bele secim yoxdur");
                        break;
                    }


        }
    }
}
 
