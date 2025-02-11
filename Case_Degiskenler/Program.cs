using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            string customername;
            string customersurname;
            string customerphone;
            string customeremail, district, city;

            customername = "Ali";
            customersurname = "Çınar";
            customerphone = "+90 500 400 30 20";
            customeremail = "deneme@mail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Müşteri: " + customername + " " + customersurname);
            Console.WriteLine("İletişim: " + customerphone);
            Console.WriteLine("Email Adresi: " + customeremail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine();

            customername = "Ayşegül";
            customersurname = "Kaya";
            customerphone = "+90 400 300 80 70";
            customeremail = "test@gmail.com";
            district = "Sapanca";
            city = "Sakarya";

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Müşteri: " + customername + " " + customersurname);
            Console.WriteLine("İletişim: " + customerphone);
            Console.WriteLine("Email Adresi: " + customeremail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-------------------------------------------------");
            Console.ReadLine();
        }
    }
}
