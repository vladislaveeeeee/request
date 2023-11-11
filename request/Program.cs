﻿using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace Запити
{
    class Студенти
    {
        public string імйа { get; set; }
        public string прізвище { get; set; }
        public int номер_групи { get; set; }
    }
    class Групи
    {
        public int ідентифікатор { get; set; }
        public string назва { get; set; }
    }
    class Програма
    {
        static void Main(string[] арґументи)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Групи> групи = new List<Групи> {
      new Групи { ідентифікатор = 1, назва = "індивідуальні" },
      new Групи { ідентифікатор = 2, назва = "групові" }
    };
            List<Студенти> студенти = new List<Студенти> {
      new Студенти { імйа = "Вадим",
      прізвище = "Тесліцький", номер_групи = 2 },
      new Студенти { імйа = "Олександра",
      прізвище = "Мандиринка", номер_групи = 1 },
      new Студенти { імйа = "Анна",
      прізвище = "Ґант", номер_групи = 1 },
      new Студенти { імйа = "Мирослав",
      прізвище = "Садовський", номер_групи = 2 },
      new Студенти { імйа = "Ніколь",
      прізвище = "Князева", номер_групи = 3 }
    };
            var запит = from студент in студенти
                        from група in групи
                        where студент.номер_групи == група.ідентифікатор
                        select new { студент.імйа, студент.прізвище, група.назва };
            WriteLine("\tСписок студентів по групах:");
            foreach (var елемент in запит)
            {
                WriteLine(елемент);
            }
        }
    }
}