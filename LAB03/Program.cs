namespace LAB03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Задание 1.1 (Код проверки пишем ниже)
            Rational r1 = new Rational(3, 8);
            Console.WriteLine($"Задание 1.1 Дробь {r1}");


            // Задание 1.2 (Код проверки пишем ниже)
            Rational r2 = new Rational(5);
            Console.WriteLine($"Задание 1.2 Целое число {r2}");

            // Задание 1.3 (Код проверки пишем ниже)
            Rational r3 = new Rational();
            Console.WriteLine($"Задание 1.4 Вывод нуля {r3}");

            // Задание 1.4 (Код проверки пишем ниже)
            Rational r_error = new Rational(-3, 0);

            // Задание 2.1 (Код проверки пишем ниже)
            Rational r4 = new Rational(4, 8);
            Console.WriteLine($"2.1 Сокращение 4/8 {r4}");

            // Задание 2.2 (Код проверки пишем ниже)
            Rational r5 = new Rational(4, -9);
            Console.WriteLine($"2.2 Знак {r5}");
            Rational r6 = new Rational(-2, -10);
            Console.WriteLine($"2.2 Минус {r6}");
            // Задание 3.1 (Код проверки пишем ниже)
            Rational a = new Rational(1, 2);  // 1/2
            Rational b = new Rational(1, 4);  // 1/4
            // Проверка суммы (1/2 + 1/4 = 3/4)
            Console.WriteLine($"{a} + {b} = {a + b}");
            // Проверка разности (1/2 - 1/4 = 1/4)
            Console.WriteLine($"{a} - {b} = {a - b}");
            // Проверка произведения (1/2 * 1/4 = 1/8)
            Console.WriteLine($"{a} * {b} = {a * b}");
            // Проверка деления (1/2 / 1/4 = 2)
            Console.WriteLine($"{a} / {b} = {a / b}");
            // Задание 3.2 (Код проверки пишем ниже)
            Rational c = new Rational(2, 4);  // После сокращения станет 1/2
            Rational d = new Rational(1, 2);  // 1/2
            Rational e = new Rational(3, 8);  // 3/8
            // Проверка равенства
            Console.WriteLine($"{c} == {d}: {c == d}");
            // Проверка неравенства 
            Console.WriteLine($"{c} != {e}: {c != e}");
        }
    }
}