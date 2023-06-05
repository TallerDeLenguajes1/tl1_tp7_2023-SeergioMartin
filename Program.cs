// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora calculadora = new Calculadora();
bool calculadoraOn = true, resultado;
int opcion;
double num;

System.Console.WriteLine("Calculadora Encendida");
do
{
    System.Console.WriteLine("Seleccione la operacion a realizar:\n 1. Sumar \n 2. Restar \n 3. Multiplicar \n 4. Dividir \n 5. Limpiar \n");
    resultado = int.TryParse(Console.ReadLine(), out opcion);
    if (opcion >= 1 && opcion < 5)
    {
        System.Console.WriteLine("Ingrese numero a operar:");
        resultado = double.TryParse(Console.ReadLine(), out num);
    }else
    {
        num = 0;
        resultado = true;
    }
    if (resultado)
    {
        switch (opcion){
            case 1:
                calculadora.Sumar(num);
                break;
            case 2:
                calculadora.Restar(num);
                break;
            case 3:
                calculadora.Multiplicar(num);
                break;
            case 4:
                calculadora.Dividir(num);
                break;
            case 5:
                calculadora.Limpiar();
                break;
            default:
                System.Console.WriteLine("Operacion seleccionada invalida!");
                break;
            }
        if (opcion >= 1 && opcion <= 5)
        {
            System.Console.WriteLine("Resultado: "+ calculadora.Resultado);
            System.Console.WriteLine("Desea realizar otra operacion?\n 1. Si\n 2. No");
            resultado = int.TryParse(Console.ReadLine(), out opcion);
            if (resultado)
            {
                if (opcion == 2)
                {
                    calculadoraOn = false;
                    Console.Clear();
                }
            }
        }
    }else
    {
        System.Console.WriteLine("No ingreso un numero");
    }
} while (calculadoraOn);