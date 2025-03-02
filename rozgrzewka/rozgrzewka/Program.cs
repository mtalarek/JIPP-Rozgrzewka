namespace Rozgrzewka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie1
            int number = 19;
            float money = 19.1f;
            string text = "jeden";
            bool isLogged = true;
            char myChar = 'a';
            decimal price = 1.2345m;
            Console.WriteLine(number);
            Console.WriteLine(money);
            Console.WriteLine(text);
            Console.WriteLine(isLogged);
            Console.WriteLine(myChar);
            Console.WriteLine(price);

            //zadanie2
            string myAge = "Age:";
            int wifeAge = 18;
            string result = myAge + wifeAge;
            Console.WriteLine(result);
            //wniosek: można dodawać int do stringa

            //zadanie3
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;

            bool and = isTrue & isFalse;
            bool or = isTrue | isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine(and);
            Console.WriteLine(or);
            Console.WriteLine(negative);

            //zadanie4
            int a = 5;
            int b = 12;
            int add = 5 + 12;
            int sub = 5 - 12;
            double div = 5 / 12;
            int mul = 5 * 12;
            decimal mod = 5 % 12;

            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.WriteLine(mod);

        }
    }
}
