namespace Ejercicios;
static partial class ej{
    public static void ej3(){
        var HORASTRABAJADAS=LEERHORASTRABAJADAS();
        var TARIFA=LEERTARIFA();
        System.Console.WriteLine($"Sueldo:{calcular(HORASTRABAJADAS,TARIFA)}");
    }

    public static decimal calcular(int horas,decimal tarifa)
        {
        tarifa= horas>40?tarifa*1.5m:tarifa;
        return tarifa*horas;
        }
    public static int LEERHORASTRABAJADAS()
        {
            return 60;
        }
    public static decimal LEERTARIFA()
    {
        return 10m;
    }
    public static void ej3_test()
        {
           System.Diagnostics.Debug.Assert(calcular(40,40)==40*40);
           System.Diagnostics.Debug.Assert(calcular(45,10)==45*15, "Error when horas > 40");
        }
}