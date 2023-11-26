using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13HW
{
    class BankQueue
    {
        private Queue<Client> queue = new Queue<Client>();

        public void Enqueue(Client client)
        {
            queue.Enqueue(client);
            Console.WriteLine($"{client.Id} встать в очередь на {client.ServiceType}. Текущая длина очереди: {queue.Count}");
        }

        public void Dequeue()
        {
            if (queue.Count > 0)
            {
                Client servedClient = queue.Dequeue();
                Console.WriteLine($"Клиент обслуживается {servedClient.Id} ({servedClient.ServiceType}). Текущая длина очереди: {queue.Count}");
            }
            else
            {
                Console.WriteLine("Очередь пуста. Нет клиентов, которых нужно обслуживать.");
            }
        }
        public void DisplayQueue()
        {
            Console.WriteLine("\nТекущая очередь:");
            foreach (var client in queue)
            {
                Console.WriteLine($"- {client.Id} ({client.ServiceType})");
            }
        }
    }
}
