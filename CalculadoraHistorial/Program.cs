// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
using EspacioOperacion;

Calculadora calc = new Calculadora();
// creo un lista con el tipo de dato Operacion
List<Operacion> operaciones = new List<Operacion>();

Console.WriteLine("--------------------------------------");
Console.WriteLine(".............CALCULADORA..............");
Console.WriteLine("--------------------------------------");
int opern = 1;

// hasta que no hayas mas operaciones
while (opern != 0)
{
    Console.WriteLine("Que operacion desea realizar?");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("0. Salir");

    string oper = Console.ReadLine();

    if (int.TryParse(oper, out opern))
    {
        if (opern != 0)
        {
            Console.WriteLine("Ingrese el numero a computar:");
            string termino = Console.ReadLine();

            double terminon;

            if (double.TryParse(termino, out terminon))
            {
                switch (opern)
                {
                    case 1:
                        operaciones.Add(new Operacion
                            {
                                NuevoValor = terminon,
                                ResultadoAnterior = calc.Resultado,
                                Toperacion = TipoOperacion.Suma
                            });
                        calc.Sumar(terminon);
                        Console.WriteLine("Resultado:" + calc.Resultado.ToString());
                        Console.WriteLine("");
                        operaciones.Last().Resultado = calc.Resultado;
                        break;
                    case 2:
                        operaciones.Add(new Operacion
                            {
                                NuevoValor = terminon,
                                ResultadoAnterior = calc.Resultado,
                                Toperacion = TipoOperacion.Resta
                            });
                        calc.Restar(terminon);
                        Console.WriteLine("Resultado:" + calc.Resultado.ToString());
                        Console.WriteLine("");
                        operaciones.Last().Resultado = calc.Resultado;
                        break;
                    case 3:
                        operaciones.Add(new Operacion
                            {
                                NuevoValor = terminon,
                                ResultadoAnterior = calc.Resultado,
                                Toperacion = TipoOperacion.Multiplicacion
                            });
                        calc.Multiplicar(terminon);
                        Console.WriteLine("Resultado:" + calc.Resultado.ToString());
                        Console.WriteLine("");
                        operaciones.Last().Resultado = calc.Resultado;
                        break;
                    case 4:
                        operaciones.Add(new Operacion
                            {
                                NuevoValor = terminon,
                                ResultadoAnterior = calc.Resultado,
                                Toperacion = TipoOperacion.Division
                            });
                        calc.Dividir(terminon);
                        Console.WriteLine("Resultado:" + calc.Resultado.ToString());
                        Console.WriteLine("");
                        operaciones.Last().Resultado = calc.Resultado;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

// mosatrar el historial de operaciones
Console.WriteLine("Historial de operaciones:");
foreach (Operacion operacion in operaciones)
{
    Console.WriteLine($"Operacion: {operacion.Toperacion}, Valor: {operacion.NuevoValor}, Resultado Anterior: {operacion.ResultadoAnterior}, Resultado Actual: {operacion.Resultado}");
}
