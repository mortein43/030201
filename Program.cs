using System;
using System.Net;
using System.Net.Sockets;
namespace _030201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("Введіть будь ласка ip-адресу за інтернет протоколом версії 4:");
                string address = Console.ReadLine();
                IPAddress ip;
                if (IPAddress.TryParse(address, out ip) && ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPEndPoint endp = new IPEndPoint(ip, 80);
                    Console.WriteLine($"Кінцеву точку успішно створено: \n {endp}");
                    break;
                }
                else
                {
                     Console.WriteLine("Введена неіснуюча ip-адреса. Спробуйте ще раз.");
                }


            }

        }
    }
}