using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu tarp -99 ir 99: ");
            string a = Console.ReadLine();
            for (; checknumber(a) == false;)
            {
                Console.WriteLine("Skaicius ivestas blogu formatu.");
                Console.WriteLine("Bandykite dar karta.");
                a = Console.ReadLine();
            }
            Console.WriteLine(printnumbers(convert(ref a)));
            Console.ReadLine();

        }
        static bool checknumber(string x)
        {
            // jei skaicius yra dvizenklis su minusu
            if(x.Length >2 && x[0] == '-')
            {
                if ((x[1] == '1' || x[1] == '2' || x[1] == '3' || x[1] == '4' || x[1] == '5' || x[1] == '6' || x[1] == '7' || x[1] == '8' || x[1] == '9') &&
                (x[2] == '1' || x[2] == '2' || x[2] == '3' || x[2] == '4' || x[2] == '5' || x[2] == '6' || x[2] == '7' || x[2] == '8' || x[2] == '9'))
                {
                    return true;
                }
            }
            // jei skaicius vienzenklis su minusu
            else if (x.Length == 2 && x[0] == '-')
            {
                if (x[1] == '1' || x[1] == '2' || x[1] == '3' || x[1] == '4' || x[1] == '5' || x[1] == '6' || x[1] == '7' || x[1] == '8' || x[1] == '9')
                {
                    return true;
                }
            }
            // vienzenklis teigiamas skaicius ir nulis
            else if (x.Length == 1 && (x[0] == '0' || x[0] == '1' || x[0] == '2' || x[0] == '3' || x[0] == '4' || x[0] == '5' || x[0] == '6' || x[0] == '7' || x[0] == '8' || x[0] == '9'))
            {
                return true;
            }
            //dvizenklis teigiamas skaicius
            else if (x.Length == 2 && x[0] != '-')
            {
                if ((x[0] == '1' || x[0] == '2' || x[0] == '3' || x[0] == '4' || x[0] == '5' || x[0] == '6' || x[0] == '7' || x[0] == '8' || x[0] == '9') &&
                (x[1] == '1' || x[1] == '2' || x[1] == '3' || x[1] == '4' || x[1] == '5' || x[1] == '6' || x[1] == '7' || x[1] == '8' || x[1] == '9'))
                { 
                    return true;
                }
            }
            return false;
        }
        //konvertavimo ir reziu tikrinimo funkcija
        static int convert(ref string x)
        {

            int a = Convert.ToInt32(x);
            if (a < 100 && a > -100)
            {
                Console.WriteLine("Jus ivedet");
            }
            else
            {
                Console.WriteLine("skaicius nepatenka i rezius");

            }
            return a;
        }
        // konvertavimo skaiciu i zodini formata funkcija
        static string printnumbers(int x)
        {
            string z = "";
            if (x == 0)
            {
                z = "nuli";
            }
            else if (x < 10 && x > 0)
            {
                switch (x)
                {
                    case 1:
                        z = "vieneta";
                        break;
                    case 2:
                        z = "dvejeta";
                        break;
                    case 3:
                        z = "trejeta";
                        break;
                    case 4:
                        z = "ketverta";
                        break;
                    case 5:
                        z = "penketa";
                        break;
                    case 6:
                        z = "seseta";
                        break;
                    case 7:
                        z = "septyneta";
                        break;
                    case 8:
                        z = "astuoneta";
                        break;
                    case 9:
                        z = "devyneta";
                        break;
                }
            }
            else if (x > 9 && x < 20)
            {
                switch (x)
                {
                    case 10:
                        z = "desimt";
                        break;
                    case 11:
                        z = "vienuolika";
                        break;
                    case 12:
                        z = "dvylika";
                        break;
                    case 13:
                        z = "trylika";
                        break;
                    case 14:
                        z = "keturiolika";
                        break;
                    case 15:
                        z = "penkiolika";
                        break;
                    case 16:
                        z = "sesiolika";
                        break;
                    case 17:
                        z = "septyniolika";
                        break;
                    case 18:
                        z = "astuoniolika";
                        break;
                    case 19:
                        z = "devyniolika";
                        break;
                }
            }
            else if (x < 0 && x > -9)
            {
                switch (x)
                {
                    case -1:
                        z = "minus vieneta";
                        break;
                    case -2:
                        z = "minus  dvejeta";
                        break;
                    case -3:
                        z = "minus trejeta";
                        break;
                    case -4:
                        z = "minus ketverta";
                        break;
                    case -5:
                        z = "minus penketa";
                        break;
                    case -6:
                        z = "minus seseta";
                        break;
                    case -7:
                        z = "minus septyneta";
                        break;
                    case -8:
                        z = "minus astuoneta";
                        break;
                    case -9:
                        z = "minus devyneta";
                        break;

                }
            }
            else if (x < -9 && x > -20)
            {
                switch (x)
                {
                    case -10:
                        z = "minus desimt";
                        break;
                    case -11:
                        z = "minus vienuolika";
                        break;
                    case -12:
                        z = "minus dvylika";
                        break;
                    case -13:
                        z = "minus trylika";
                        break;
                    case -14:
                        z = "minus keturiolika";
                        break;
                    case -15:
                        z = "minus penkiolika";
                        break;
                    case -16:
                        z = "minus sesiolika";
                        break;
                    case -17:
                        z = "minus septyniolika";
                        break;
                    case -18:
                        z = "minus astuoniolika";
                        break;
                    case -19:
                        z = "minus devyniolika";
                        break;

                }
            }
            return z;
        }

    }
}
