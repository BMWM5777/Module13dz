using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            
            BankQueue bankQueue = new BankQueue();

            while (true)
            {
                
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить клиента в очередь");
                Console.WriteLine("2. Обслуживайте следующего клиента");
                Console.WriteLine("3. Показать текущую очередь");
                Console.WriteLine("0. Выйти из программы");

                string choice = Console.ReadLine();

                
                
                switch (choice)
                {
                    
                    
                    
                    case "1":
                        Console.Write("Введите идентификатор клиента: ");
                        string clientId = Console.ReadLine();
                        Console.Write("Выберите тип услуги (кредит, депозит, консультация и т.д.): ");
                        string serviceType = Console.ReadLine();
                        bankQueue.Enqueue(new Client(clientId, serviceType));
                        break;
                    case "2":
                        bankQueue.Dequeue();
                        break;
                    case "3":
                        bankQueue.DisplayQueue();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод. Пожалуйста, выберите действие из списка.");
                        break;
                }
            }
        }
    }
}
