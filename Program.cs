using System;
using System.Text;

namespace DeliveryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== ТЕСТУВАННЯ REPOSITORY ДЛЯ POSTING ===");
            IRepository<Posting> postingRepo = new GenericRepository<Posting>();

            postingRepo.Add(new Posting { Id = 1, TrackingNumber = "UA1001", Weight = 2.5, SenderAddress = "Київ", ReceiverAddress = "Львів", Status = "В дорозі" });
            postingRepo.Add(new Posting { Id = 2, TrackingNumber = "UA1002", Weight = 4.0, SenderAddress = "Одеса", ReceiverAddress = "Харків", Status = "Створено" });
            postingRepo.Add(new Posting { Id = 3, TrackingNumber = "UA1003", Weight = 1.0, SenderAddress = "Дніпро", ReceiverAddress = "Полтава", Status = "У відділенні" });

            Console.WriteLine("\n--- Отримання за ID = 2 ---");
            Console.WriteLine(postingRepo.GetById(2));

            Console.WriteLine("\n--- Оновлення ID = 1 ---");
            postingRepo.Update(new Posting { Id = 1, TrackingNumber = "UA1001", Weight = 2.5, SenderAddress = "Київ", ReceiverAddress = "Львів", Status = "Вручено" });

            Console.WriteLine("\n--- Видалення ID = 3 ---");
            postingRepo.Delete(3);

            Console.WriteLine("\n--- Список відправлень, що залишилися: ---");
            foreach (var item in postingRepo.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n=============================================");
            Console.WriteLine("=== ТЕСТУВАННЯ REPOSITORY ДЛЯ CONTACTPERSON ===");
            IRepository<ContactPerson> contactRepo = new GenericRepository<ContactPerson>();

            contactRepo.Add(new ContactPerson { Id = 1, Name = "Олександр Коваленко", Phone = "+380501112233", Email = "oleksandr@gmail.com" });
            contactRepo.Add(new ContactPerson { Id = 2, Name = "Марія Шевченко", Phone = "+380674445566", Email = "mariya@gmail.com" });
            contactRepo.Add(new ContactPerson { Id = 3, Name = "Іван Бондаренко", Phone = "+380937778899", Email = "ivan@gmail.com" });

            Console.WriteLine("\n--- Отримання за ID = 1 ---");
            Console.WriteLine(contactRepo.GetById(1));

            Console.WriteLine("\n--- Оновлення ID = 2 ---");
            contactRepo.Update(new ContactPerson { Id = 2, Name = "Марія Шевченко-Петренко", Phone = "+380679998877", Email = "m_petrenko@gmail.com" });

            Console.WriteLine("\n--- Видалення ID = 3 ---");
            contactRepo.Delete(3);

            Console.WriteLine("\n--- Список контактних осіб, що залишилися: ---");
            foreach (var item in contactRepo.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n=============================================");
            Console.WriteLine("=== ПЕРЕВІРКА НЕЗАЛЕЖНОСТІ СХОВИЩ У ПАМ'ЯТІ ===");
            Console.WriteLine($"Кількість у postingRepo: {postingRepo.GetAll().Count}");
            Console.WriteLine($"Кількість у contactRepo: {contactRepo.GetAll().Count}");
            Console.WriteLine("Дані успішно розділені завдяки статичним полям узагальненого типу.");

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
