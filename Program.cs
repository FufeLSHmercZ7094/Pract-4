using System;

namespace Pract4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vert = 0;
            int a = 0;
            while (true)
            {
                ConsoleKeyInfo kl = Console.ReadKey();
                if (kl.Key == ConsoleKey.UpArrow)
                {
                    vert--;
                }
                else if (kl.Key == ConsoleKey.DownArrow)
                {
                    vert++;
                }
                else if (kl.Key == ConsoleKey.RightArrow)
                {
                    ++a;
                    a = a_spisok(a);
                }
                else if (kl.Key == ConsoleKey.LeftArrow)
                {
                    --a;
                    a = a_spisok(a);
                }
                else if (kl.Key == ConsoleKey.Enter)
                {
                    while (kl.Key != ConsoleKey.Backspace)
                    {
                        Console.Clear();
                        kl = Console.ReadKey();
                    }
                }
                else if (kl.Modifiers.HasFlag(ConsoleModifiers.Alt) && kl.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("Вы вышли из заметок");
                }
                Console.Clear();
                Console.SetCursorPosition(0, vert);
                Console.WriteLine("->");
            }
        }
        static int notes(int a)
        {


            Console.WriteLine("Заметки");
            var all_list = List_note();
            int Lenght_arr = all_list.Count;
            var list = all_list[a];
            if (list[0].name == " ")
            {
                Console.WriteLine("Нету никаких записей . ");
                return (0);
            }
            else
            {
                Console.WriteLine(list[1].data);
                foreach (Zametka cto in list)
                {
                    Console.WriteLine(cto.name);
                }
                return (list.Count);
            }
        }
        static int a_spisok(int a)
        {
            var lenght_List_all = List_note().Count;
            if (a == lenght_List_all)
            {
                a = 0;
                return (a);
            }
            else if (a < 0)
            {
                a = lenght_List_all - 1;
                return (a);
            }
            else
            {
                return (a);
            }
        }
        static void vse_zametki(int a, int vert)
        {
            var spisok = List_note();
            var element = spisok[a];
            var elem = element[vert];
            Console.WriteLine("Заметка: " + elem.name);
            Console.WriteLine("Дата заметки: " + elem.data);
            Console.WriteLine("Время заметки: " + elem.time);
            Console.WriteLine("Цель заметки: " + elem.cto);
            Console.WriteLine("Крайний срок: " + elem.kogda);
        }
        static List<List<Zametka>> List_note()
        {
            List<List<Zametka>> List_note = new List<List<Zametka>>
            {
                new List<Zametka>
                {
                    new Zametka()
                    {
                        name = "Вторник",
                        data = "01.11.22",
                        time = "17:00",
                        cto = "  Скачать Visual Studio",
                        kogda = "08.11.22",
                    },
                    new Zametka()
                    {
                        name = "Вторник",
                        data = "01.11.22",
                        time = "18:11",
                        cto = "  Почилить с пацанами)",
                        kogda = "01.11.22"
                    }
                },
                new List<Zametka>
                {
                    new Zametka()
                    {
                        name = "Среда",
                        data = "02.11.22",
                        time = "21:00",
                        cto = "  Практическая 1 по С#",
                        kogda = "08.11.22"
                    },
                    new Zametka()
                    {
                        name = "Среда",
                        data = "02.11.22",
                        time = "18:23",
                        cto = "  Отдохнуть от МПТ",
                        kogda = "02.11.22"
                    }
                },
                new List<Zametka>
                {
                    new Zametka()
                    {
                        name = "Четверг",
                        data = "04.11.22",
                        time = "22:00",
                        cto = "  Практическая 3 по С#",
                        kogda = "08.11.22"
                    },
                    new Zametka()
                    {
                        name = "Четверг",
                        data = "04.11.22",
                        time = "18:40",
                        cto = "  Сыграть за сборную",
                        kogda = "04.11.22"
                     }
                },
                new List<Zametka>
                {
                    new Zametka()
                    {
                        name = "Пятница (Ура, ура) День народного единства!",
                        data = "04.11.22",
                        time = "14:00",
                        cto = "  Практическая 3 по С#",
                        kogda = "08.11.22"
                    },
                    new Zametka()
                    {
                        name = "Пятница (Ура, ура) День народного единства!",
                        data = "04.11.22",
                        time = "17:20",
                        cto = "  Погклять с кентами",
                        kogda = "04.11.22"
                    }
                },
                new List<Zametka>
                {
                    new Zametka()
                    {
                        name = "Суббота (не работа))",
                        data = "05.11.22",
                        time = "14:00",
                        cto = "  Сходить в МПТ",
                        kogda = "05.11.22"
                    },
                    new Zametka()
                    {
                        name = "Суббота (не работа))",
                        data = "05.11.22",
                        time = "21:00",
                        cto = "  Сделать практическую по C#",
                        kogda = "08.11.22"
                    }
                }
            };
            return (List_note);
        }
    }
}