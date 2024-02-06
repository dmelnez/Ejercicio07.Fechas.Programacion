namespace Ejercicio07.Fechas.Programacion
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("INTRODUZCA UNA FECHA: ");
            DateTime fechaDada = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("NUMERO DE DIAS A SUMAR: ");
            int numeroASumar = Convert.ToInt32(Console.ReadLine());


            DateTime fechaSumada = fechaDada.AddDays(numeroASumar);
            Console.WriteLine("DIAS SUMADOS: " + fechaSumada);


            DateTime fechaRestada = fechaDada.AddDays(-numeroASumar);
            Console.WriteLine("DIAS RESTADOS: " + fechaRestada);





        }
    }


}