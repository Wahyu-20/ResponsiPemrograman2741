using System;
using System.Collections.Generic;

namespace LatClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Wahyu Nugroho", "19.11.2741" , 5000000);
            person.Get();
          
            Console.ReadKey();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string NIM { get; set; }
        public int Gaji {get ; set; }
        public int Naik {get ; set;}
        
        public Person(string name, string nim, int gaji)
        {
            this.Name = name;
            this.NIM = nim;
            this.Gaji = gaji;
            if (gaji < 0)
            {
                this.Gaji = 0;
                Naik = Convert.ToInt32((Gaji * 1.1));
            }
            else
            {
                this.Gaji = gaji;
                Naik = Convert.ToInt32((Gaji * 1.1));
            }
        }
        
    public void Get()
        {
            Console.WriteLine("Karyawan Teladan PT Aladin Jaya");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Nama Karyawan : "+ Name);
            Console.WriteLine("NIM  Karyawan : "+ NIM);
            Console.WriteLine("Gaji Karyawan : "+ Gaji);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Gaji Anda Naik 10%");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Nama Karyawan : "+ Name);
            Console.WriteLine("NIM  Karyawan : "+ NIM);
            Console.WriteLine("Gaji Karyawan : "+ Naik);
            Console.WriteLine("-------------------------------");
        }
    }
}