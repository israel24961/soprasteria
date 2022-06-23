namespace Ejercicios;
static partial class ej{
    public static void ej1()
    {
        var a = LEERNUMERO();
        if ((a >> 1) << 1 != a)
            System.Console.WriteLine($"{a} es Impar");
        else
            System.Console.WriteLine($"{a} es Par");
        while ((a-=2) >= 1)
            System.Console.WriteLine(a);
    }
    static int LEERNUMERO()
        {
            System.Console.Write("Input number>");
            int output;
            while(!int.TryParse(Console.ReadLine(),out output))
                {
                    System.Console.Write("\nInput number>");
                }
            return output;
        }
}