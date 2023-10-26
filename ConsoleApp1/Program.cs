class Zad
{
    static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Podaj a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj b: ");
        b = int.Parse(Console.ReadLine());
        if(a%b==0)
        {
            Console.WriteLine("liczba {0} jest dzielnikiem liczby {1}", b, a);
        }
        else
        {
            Console.WriteLine("liczba {0} nie jest dzielnikiem liczby {1}", b, a);
        }
        Console.ReadKey();
    }
}