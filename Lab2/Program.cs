using System;
using System.Collections.Generic;

namespace Lab2
{
    // Базовый класс
    class MolodoiChelovek
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public MolodoiChelovek()
        {
            Name = "Неизвестно";
            Age = 0;
        }

        public MolodoiChelovek(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Молодой человек: имя = {Name}, возраст = {Age}");
        }
    }

    // Производный класс Студент
    class Student : MolodoiChelovek
    {
        public string College { get; set; }
        public int Course { get; set; }

        public Student() : base()
        {
            College = "Неизвестно";
            Course = 0;
        }

        public Student(string name, int age, string college, int course) : base(name, age)
        {
            College = college;
            Course = course;
        }

        public override void Show()
        {
            Console.WriteLine($"Студент: имя = {Name}, возраст = {Age}, колледж = {College}, курс = {Course}");
        }
    }

    // Производный класс Рабочий
    class Rabochiy : MolodoiChelovek
    {
        public string MestoRaboty { get; set; }

        public Rabochiy() : base()
        {
            MestoRaboty = "Неизвестно";
        }

        public Rabochiy(string name, int age, string mestoRaboty) : base(name, age)
        {
            MestoRaboty = mestoRaboty;
        }

        public override void Show()
        {
            Console.WriteLine($"Рабочий: имя = {Name}, возраст = {Age}, место работы = {MestoRaboty}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем коллекцию (список) базового типа
            List<MolodoiChelovek> people = new List<MolodoiChelovek>();

            // Добавляем объекты
            people.Add(new MolodoiChelovek("Алексей", 25));
            people.Add(new Student("Мария", 19, "Колледж связи", 2));
            people.Add(new Rabochiy("Иван", 30, "Завод Металлист"));
            people.Add(new Student("Дмитрий", 20, "Техникум информатики", 3));
            people.Add(new Rabochiy("Ольга", 28, "Стройка №7"));

            // В цикле вызываем метод Show()
            Console.WriteLine("=== Список людей ===\n");
            foreach (var person in people)
            {
                person.Show();
            }

            Console.ReadKey();
        }
    }
}