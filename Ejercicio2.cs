using System.Linq;
namespace Ejercicios;
static partial class ej
{
    public static void ej2()
    {
        var PERSONAS = LEERPERSONAS().AsQueryable();// AsQueryable for flexibility
        var plus_eightteen_q = from p in PERSONAS
                               where p.EDAD >= 18
                               select p;
        System.Console.WriteLine($"a.- Personas mayores de edad (+18):{plus_eightteen_q.Count()}");
        var less_eightteen_q = from p in PERSONAS
                               where p.EDAD < 18
                               select p;
        System.Console.WriteLine($"b.- Personas menores de edad (<18):{less_eightteen_q.Count()}");
        var male_plus_eighteen_q = plus_eightteen_q.Where(p => p.SEXO == "MALE");
        System.Console.WriteLine($"c.- Personas masculinas, mayores de edad (+18):{male_plus_eighteen_q.Count()}");
        var female_less_eighteen_q = less_eightteen_q.Where(p => p.SEXO == "FEMALE");
        System.Console.WriteLine($"d.- Personas femeninas, menores de edad (-18):{female_less_eighteen_q.Count()}");
        var percent_mayores=plus_eightteen_q.Count()/(double)PERSONAS.Count()*100;
        System.Console.WriteLine($"e.- Porcentaje de personas mayores(+18):{percent_mayores}%");
        var percent_female=(from p in PERSONAS
                            where p.SEXO=="FEMALE"
                            select p).Count()/(double)PERSONAS.Count()*100;
        System.Console.WriteLine($"f.- Porcentaje de mujeres:{percent_female}%");
    }
    public struct person
    {
        public string SEXO;
        public int EDAD;
    }
    //Used once for making the dataset
    static void genPersonas()
    {
        var rnd = new Random();
        for (int i = 0; i < 50; i++)
        {
            var p = new person
            {
                SEXO = rnd.Next(2) == 0 ? "MALE" : "FEMALE",
                EDAD = rnd.Next(10, 100)
            };
            System.Console.WriteLine("new person{sex=\"" + p.SEXO + "\",age=" + p.EDAD + "},");
        }
    }
    //Copy-pasted from genPersonas(
    static person[] LEERPERSONAS()
    {
        return new person[]{
        new person{SEXO="MALE",EDAD=21},
        new person{SEXO="MALE",EDAD=94},
        new person{SEXO="MALE",EDAD=92},
        new person{SEXO="FEMALE",EDAD=60},
        new person{SEXO="FEMALE",EDAD=28},
        new person{SEXO="MALE",EDAD=26},
        new person{SEXO="MALE",EDAD=43},
        new person{SEXO="MALE",EDAD=30},
        new person{SEXO="MALE",EDAD=50},
        new person{SEXO="MALE",EDAD=35},
        new person{SEXO="MALE",EDAD=88},
        new person{SEXO="FEMALE",EDAD=35},
        new person{SEXO="FEMALE",EDAD=99},
        new person{SEXO="FEMALE",EDAD=37},
        new person{SEXO="FEMALE",EDAD=44},
        new person{SEXO="MALE",EDAD=19},
        new person{SEXO="MALE",EDAD=69},
        new person{SEXO="MALE",EDAD=94},
        new person{SEXO="FEMALE",EDAD=31},
        new person{SEXO="MALE",EDAD=38},
        new person{SEXO="FEMALE",EDAD=92},
        new person{SEXO="MALE",EDAD=23},
        new person{SEXO="FEMALE",EDAD=34},
        new person{SEXO="MALE",EDAD=32},
        new person{SEXO="FEMALE",EDAD=78},
        new person{SEXO="MALE",EDAD=97},
        new person{SEXO="FEMALE",EDAD=92},
        new person{SEXO="MALE",EDAD=42},
        new person{SEXO="MALE",EDAD=34},
        new person{SEXO="FEMALE",EDAD=66},
        new person{SEXO="MALE",EDAD=26},
        new person{SEXO="FEMALE",EDAD=81},
        new person{SEXO="FEMALE",EDAD=21},
        new person{SEXO="FEMALE",EDAD=82},
        new person{SEXO="MALE",EDAD=22},
        new person{SEXO="FEMALE",EDAD=21},
        new person{SEXO="FEMALE",EDAD=62},
        new person{SEXO="MALE",EDAD=52},
        new person{SEXO="FEMALE",EDAD=14},
        new person{SEXO="FEMALE",EDAD=56},
        new person{SEXO="FEMALE",EDAD=12},
        new person{SEXO="FEMALE",EDAD=73},
        new person{SEXO="FEMALE",EDAD=90},
        new person{SEXO="FEMALE",EDAD=15},
        new person{SEXO="MALE",EDAD=65},
        new person{SEXO="FEMALE",EDAD=33},
        new person{SEXO="FEMALE",EDAD=25},
        new person{SEXO="FEMALE",EDAD=61},
        new person{SEXO="MALE",EDAD=77},
        new person{SEXO="MALE",EDAD=29}
    };
    }

}