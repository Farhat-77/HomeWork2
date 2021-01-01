using System;

namespace HomeWork2
{
    class Program
    {
        // Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними
        static void Main(string[] args)
        {
            double a, b, c;
            a = 5;
            b = 7;
            c = 9;
            Console.WriteLine($"{a}  {b}  {c}");
            Console.ReadKey();

        }
        // Вывести на экран числа 5, 10 и 21 одно под другим
        public Program()
        {
            int a = 5;
            int b = 10;
            int c = 21;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }

        // Дано расстояние в сантиметрах.Найти число полных метров в нем
        public Program()
        {
            Console.WriteLine("Введите расстояние в см :");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Полных м: ");
            Console.WriteLine(i / 100);
        }
        // С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
        static void Main(string[] args)
        {
            const int daysInWeek = 7;
            int days = 234;
            int weeks = days / daysInWeek;
            Console.WriteLine("дней: {0}\nнедель: {1}", days, weeks);
            Console.ReadLine();
        }
        /* Дано двузначное число. Найти:
               a.	число десятков в нем;
               b.	число единиц в нем;
               c.	сумму его цифр;
               d.	произведение его цифр
               */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двух значное число: ");
            int number = Int32.Parse(Console.ReadLine());
            int dec = number / 10;
            int unt = number % 10;
            int sum = dec + unt;
            int mult = dec * unt;
            Console.WriteLine("Число десяток: " + dec);
            Console.WriteLine("Число единиц: " + unt);
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + mult);
            Console.ReadLine();
        }
        /* Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
           b.	А и В; 
           c.	В или С.
           */
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            bool C = false;
            bool result1 = A || B;
            bool result2 = A && B;
            bool result3 = B || C;
            Console.WriteLine("A || B = " + result1);
            Console.WriteLine("A && B = " + result2);
            Console.WriteLine("B || C = " + result3);
            Console.ReadLine();
        }
        // Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
        static void Main(string[] args)
        {
            double radius, side;
            Console.WriteLine("У какой фигуры площадь больше?\n");
            Console.Write("Радиус круга: ");
            radius = Double.Parse(Console.ReadLine());
            Console.Write("Строна квадрата: ");
            side = Double.Parse(Console.ReadLine());
            double areaCircle = Math.PI * Math.Pow(radius, 2);
            double areaSqure = Math.Pow(side, 2);
            Console.WriteLine("\nПлощадь круга = " + areaCircle);
            Console.WriteLine("Площадь квадрата = " + areaSqure);
            string answer = areaCircle > areaSqure ? "круга" : "квадрата";
            Console.WriteLine("\nПлощадь {0} больше", answer);
            Console.ReadLine();
        }
        // Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?
        static double Density(double mass, double volume)
        {
            return mass / volume;
        }
        static void Main(string[] args)
        {
            double volume1, mass1, volume2, mass2;

            Console.WriteLine("У какого материала бОльшая плотность?\n");
            Console.WriteLine("Материал 1");
            Console.Write("Объем: ");
            volume1 = Double.Parse(Console.ReadLine());
            Console.Write("Масса: ");
            mass1 = Double.Parse(Console.ReadLine());
            double density1 = Density(mass1, volume1);
            Console.WriteLine("Плотность: " + density1);
            Console.WriteLine("\nМатериал 2");
            Console.Write("Объем: ");
            volume2 = Double.Parse(Console.ReadLine());
            Console.Write("Масса: ");
            mass2 = Double.Parse(Console.ReadLine());
            double density2 = Density(mass2, volume2);
            Console.WriteLine("Плотность: " + density2);
            string answer = density1 > density2 ? "первого" : "второго";
            Console.WriteLine("\nНаибольшая плотность у {0} материала", answer);
            Console.ReadLine();
        }
        // Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. 
        // По какому участку протекает меньший ток?
        static double Current(double resistance, double voltage)
        {
            return voltage / resistance;
        }
        static void Main(string[] args)
        {
            double resistance1, voltage1, resistance2, voltage2;
            Console.WriteLine("По какому участку цепи проходит меньший ток?\n");
            Console.WriteLine("Участок 1");
            Console.Write("Сопротивление: ");
            resistance1 = Double.Parse(Console.ReadLine());
            Console.Write("Напряжение: ");
            voltage1 = Double.Parse(Console.ReadLine());
            double elCurrent1 = Current(resistance1, voltage1);
            Console.WriteLine("Ток: " + elCurrent1);
            Console.WriteLine("\nУчасток 2");
            Console.Write("Сопротивление: ");
            resistance2 = Double.Parse(Console.ReadLine());
            Console.Write("Напряжение: ");
            voltage2 = Double.Parse(Console.ReadLine());
            double elCurrent2 = Current(resistance2, voltage2);
            Console.WriteLine("Ток: " + elCurrent2);
            string answer = elCurrent1 < elCurrent2 ? "первому" : "второму";
            Console.WriteLine("\nМеньший ток проходит по {0} участку цепи", answer);
            Console.ReadLine();
        }
        /*Напечатать "столбиком": 
          a.	все целые числа от 20 до 35;
          b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
          c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
          d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
          */
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 целые числа от 20 до 25");
            Console.WriteLine("2 квадраты всех целых чисел от 10 до b");
            Console.WriteLine("3 третьи степени всех целых чисел от a до 50");
            Console.WriteLine("4 все целые числа от a до b");
            Console.WriteLine("\n0 выход");
        }

        static void Main(string[] args)
        {
            string menu = "#";
            while (menu != "0")
            {
                Menu();
                Console.Write("Выберать действие: ");
                menu = Console.ReadLine();
                Console.Clear();
                if (menu == "1")
                {
                    for (int i = 20; i < 25; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                }
                else if (menu == "2")
                {
                    Console.Write("Верхняя граница(b > 10): ");
                    int number = Int32.Parse(Console.ReadLine());
                    number = number < 10 ? 20 : number;
                    for (int i = 10; i < number; i++)
                    {
                        Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
                    }
                    Console.ReadLine();
                }
                else if (menu == "3")
                {
                    Console.Write("Нижняя граница(a < 50): ");
                    int number = Int32.Parse(Console.ReadLine());
                    number = number > 50 ? 40 : number;
                    for (int i = number; i < 50; i++)
                    {
                        Console.WriteLine(i + "^3 = " + Math.Pow(i, 2));
                    }
                    Console.ReadLine();
                }
                else if (menu == "4")
                {
                    Console.Write("Нижняя граница: ");
                    int numberA = Int32.Parse(Console.ReadLine());
                    Console.Write("Верхняя граница: ");
                    int numberB = Int32.Parse(Console.ReadLine());
                    if (numberA > numberB)
                    {
                        int tmp = numberB;
                        numberB = numberA;
                        numberA = tmp;
                    }
                    for (int i = number; numberA < numberB; numberA++)
                    {
                        Console.WriteLine(numberA);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
