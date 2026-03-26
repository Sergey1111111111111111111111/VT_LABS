namespace LAB03
{
    public class Rational
    {
        // Поля (Числитель и Знаменатель)
        private int numerator;
        private int denominator;

        // Свойства (Доступ к Полям)
        public int Numerator
        {
            get => numerator;
            set => numerator = value;
        }

        public int Denominator
        {
            get => denominator;
            set
            {
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                denominator = value;
            }
        }

        // Конструкторы
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");

            this.numerator = numerator;
            this.denominator = denominator;
            Reduce();
            Normalize();
        }

        public Rational(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        public Rational()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        // ToString
        public override string ToString()
        {
            if (denominator == 1)
                return numerator.ToString();
            return $"{numerator} / {denominator}";
        }

        // Метод нормализации знака дроби
        private void Normalize()
        {
            // Если минус внизу (1/-2) его наверх (-1/2)
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
        }

        // НОД (алгоритм Евклида). Нужен для сокращения дроби
        private static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        // Сокращение дроби (делим числитель и знаменатель на НОД)
        public void Reduce()
        {
            int gcd = GCD(this.numerator, this.denominator);
            this.numerator /= gcd;
            this.denominator /= gcd;
        }

        // Перегрузка операторов

        /* 
           Метод суммы (Суммой двух дробей (a и b) является новая Дробь)
           С числителем и знаменателем, расчитаным по формуле:
        */
        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational(
                a.numerator * b.denominator + b.numerator * a.denominator,
                a.denominator * b.denominator
            );
        }

        public static Rational operator -(Rational a, Rational b)
        {
            // Формула разности: (a.n * b.d - b.n * a.d) / (a.d * b.d)
            return new Rational(a.numerator * b.denominator - b.numerator * a.denominator,a.denominator * b.denominator);
        }

        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(a.numerator * b.numerator, a.denominator * b.denominator);
        }

        public static Rational operator /(Rational a, Rational b)
        {
            if (b.numerator == 0)
                throw new DivideByZeroException("Деление на ноль");

            // При делении переворачиваем вторую дробь (умножаем на обратную)
            return new Rational(a.numerator * b.denominator, a.denominator * b.numerator);
        }

        // Сравнение

        public static bool operator ==(Rational a, Rational b)
        {
            return a.numerator == b.numerator && a.denominator == b.denominator;
        }
        public static bool operator !=(Rational a, Rational b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Rational other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }
    }
}