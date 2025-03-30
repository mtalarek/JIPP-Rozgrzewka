namespace Rozgrzewka
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            //OPERATORY
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


            //Zadanie5
            string c, d, e;
            c = "Ala ";
            d = "ma ";
            e = "kota";
            string result2;
            result2 = a + b + c;
            Console.WriteLine(result2);
            //można dodawać-łączyć stringi*/


            //INSTRUKCJE STERUJĄCE I PĘTLE
            //Zadanie1
            int n1, n2;
            n1 = 10;
            n2 = 20;
            if (n1 > n2) Console.WriteLine("n1 jest wieksze od n2");
            if (n1 < n2) Console.WriteLine("n2 jest wieksze od n1");
            else Console.WriteLine("n1 jest równe n2");

            //Zadanie2
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }

            int a = 0;
            while(a<10)
            {
                Console.WriteLine("C#");
                a++;
            }

            //Zadanie3
            int n = 10;
            for (int i = 0; i < n+1; i++) {
                if (i % 2 == 0) Console.WriteLine(i + "- parzysta"); else Console.WriteLine(i + "- nieparzysta");
            }

            //KOLEKCJE
            //Zadanie1
            string[] colors = new string[4];
            colors = ["blue", "red", "yellow", "green"];
            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[3]);

            //Zadanie2
            int[] liczby = new int[10];
            liczby = [4, 2, 22, 5, 87, 11, 23, 9, 2, 32];
            for(int i = 0;i < 10;i++) { Console.WriteLine("Liczba: " + liczby[i]); }

            int b = 0;
            while (b < liczby.Length) { Console.WriteLine("Liczba: " + liczby[b]);
                b++;
            }

            foreach (int element in liczby)
            {
                Console.WriteLine("Liczba: " + element);
            }

            //Zadanie3
            List<string> fruits = new List<string>();

         }
    }
}
