using Composite.Components;
using Composite;
using System;

namespace CreateArmy
{
    /// <summary>
    /// The entry point for the application
    /// </summary>
    /// <param name="args"> Command line argument list </param>
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer1 = new Archer("Вася");
            Archer archer2 = new Archer("Петя");
            Archer archer3 = new Archer("Саша");
            Archer archer4 = new Archer("Ваня");
            Archer archer5 = new Archer("Митя");

            Cavalryman cavalryman1 = new Cavalryman("Дима");
            Cavalryman cavalryman2 = new Cavalryman("Паша");
            Cavalryman cavalryman3 = new Cavalryman("Гена");
            Cavalryman cavalryman4 = new Cavalryman("Вова");

            Infantryman infantryman1 = new Infantryman("Даня");
            Infantryman infantryman2 = new Infantryman("Тима");
            Infantryman infantryman3 = new Infantryman("Егор");
            Infantryman infantryman4 = new Infantryman("Витя");
            Infantryman infantryman5 = new Infantryman("Женя");
            Infantryman infantryman6 = new Infantryman("Олег");

            Squad army = new Squad("Армия");
            Cavalryman general = new Cavalryman("Генерал");

            Squad division1 = new Squad("Первый дивизион");
            Archer commander1 = new Archer("Командир");
            Squad division2 = new Squad("Второй дивизион");
            Archer commander2 = new Archer("Командир");

            Squad company1 = new Squad("Первая рота");
            Infantryman officer1 = new Infantryman("Офицер");

            Squad company2 = new Squad("Вторая рота");
            Infantryman officer2 = new Infantryman("Офицер");

            Squad company3 = new Squad("Первая рота");
            Infantryman officer3 = new Infantryman("Офицер");

            army.Add(general); 
            army.Add(division1); army.Add(division2);

            division1.Add(commander1); 
            division1.Add(company1);

            division2.Add(commander2); 
            division2.Add(company3); division2.Add(company2);

            company1.Add(officer1); 
            company1.Add(infantryman1); company1.Add(infantryman2); 
            company1.Add(archer1); company1.Add(archer2);
            company1.Add(cavalryman1);

            company2.Add(officer2); 
            company2.Add(infantryman3); company2.Add(infantryman4);
            company2.Add(archer3); company2.Add(archer4);
            company2.Add(cavalryman2);

            company3.Add(officer3); 
            company3.Add(infantryman5); company3.Add(infantryman6);
            company3.Add(archer5);
            company3.Add(cavalryman3); company3.Add(cavalryman4);

            army.Print(0);

            Console.WriteLine();
            Console.WriteLine("Удаляем часть компонентов");
            Console.WriteLine();

            army.Remove(division1);
            division2.Remove(company2);
            company3.Remove(archer5);
            company3.Remove(officer3);

            army.Print(0);
        }
    }
}
