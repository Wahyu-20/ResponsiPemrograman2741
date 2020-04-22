using System;
using System.Collections.Generic;

namespace LatClass{
    class Program{
        static void Main(string[] args){
            Person person1 = new Person("Wahyu Nugroho", "19.11.2741" , 5000000);
            Person person2 = new Person("Jono Sujono", "19.11.6844", 0);
            
            Console.WriteLine("<========================================>");
            Console.WriteLine("| NO | NIK / NAMA\t\t | Gaji  |");
            Console.WriteLine("<========================================>");
            Console.WriteLine("| 1. |{0} {1}\t |{2}|", person1.NIK, person1.Nama, person1.Gaji);
            Console.WriteLine("| 2. |{0} {1}\t |{2}\t |", person2.NIK, person2.Nama, person2.Gaji);
            Console.WriteLine("<========================================>");
            Console.WriteLine(" Alhamdulillah Naik Gaji 10%");
            Console.WriteLine("<========================================>");
            Console.WriteLine("| NO | NIK / NAMA\t\t | Gaji  |");
            Console.WriteLine("<========================================>");
            Console.WriteLine("| 1. |{0} {1}\t |{2}|", person1.NIK, person1.Nama, person1.Naik);
            Console.WriteLine("| 2. |{0} {1}\t |{2}\t |", person2.NIK, person2.Nama, person2.Naik);
            Console.WriteLine("<========================================>");
        }
    }
    class Person
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public int Gaji { get; set; }
        public int Naik { get; set; }

        public Person (string nama ,string nik ,int gaji){
            this.NIK = nik;
            this.Nama = nama;
            if (gaji < 0){
                this.Gaji = 0;
                Naik = Convert.ToInt32((Gaji * 1.1));
            }else{
                this.Gaji = gaji;
                Naik = Convert.ToInt32((Gaji * 1.1));
            }

        }
    }
}