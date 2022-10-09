using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Коллекции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //коллекция List.

            //Добавление значений в коллекцию.
            Console.WriteLine("Добавление значений в коллекцию.");

            List<int> numbers = new List<int>(5);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(4);//Имя_коллекции.Add(Нуэжное значение) - добавляет объект в конец очереди.

            numbers.AddRange(new int[] { 1, 2, 3, 9 }); //Добавление нескольких элементов в конец очереди.

            numbers.RemoveAt(4); //удаление значения под индексом 4. 

            numbers.Remove(9); //Удаление первого попавшегося элемента 9.

            numbers.Insert(0, 45); //Изменение значения на нужное в индексе 0.

            Console.WriteLine("Число 4 на позиции - " + numbers.IndexOf(4)); //Система найдёт позицию числа 4.


            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            //коллекция queue - очередь, работает по правилу: кто первый вошёл, тот первый и вышел.
            Console.WriteLine("\n\nКоллекция queue.");

            Queue<string> patients = new Queue<string>();

            patients.Enqueue("Василий"); //добавление объекта в очередь.
            patients.Enqueue("Алексей");
            patients.Enqueue("Роман");
            patients.Enqueue("Владимир");

            foreach(var patient in patients)
            {
                Console.WriteLine(patient);
            }

            Console.WriteLine("Сейчас на приём идет - " + patients.Dequeue()); //Взяятие первого человека из очереди.
            Console.WriteLine("Следующим идет - " + patients.Peek()); //Это значение просто берёт и показывает следующего из очереди, но возвращает его обратно.

            foreach (var patient in patients)
            {
                Console.WriteLine(patient);
            }

            //коллекция Stack - тоже самое, что и очередь, но есть отличие: Последний вошёл, последний и выходит.
            Console.WriteLine("\nКоллекция Stack.");

            Stack<int> Numbers = new Stack<int>();

            Numbers.Push(0); //Добавление значения.
            Numbers.Push(1);
            Numbers.Push(2);
            Numbers.Push(3);
            Numbers.Push(4);
            Numbers.Push(5);

            while(Numbers.Count > 0)
            {
                Console.WriteLine("Седующее число в стеке - " + Numbers.Pop());
            }

            //коллекция Dictionary.
            Console.WriteLine("\nколлекция Dictionary.");

            Dictionary<string, string> countries = new Dictionary<string, string>();

            countries.Add("Россия", "Москва");

            if (countries.ContainsKey("Россия")) //ContainsKey  будет искать ключ и выведет его, а если не найдет, то ничего не выведет.
                Console.WriteLine(countries["Россия"]);

            countries.Add("Украина", "Москва");
            countries.Add("Беларусь", "Минск");

            foreach (var item in countries)
            {
                Console.WriteLine($"Страна - {item.Key}, а столица - {item.Value}");
            }















            Console.ReadKey();
        }
    }
}
