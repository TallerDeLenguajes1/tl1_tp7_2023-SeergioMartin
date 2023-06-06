// See https://aka.ms/new-console-template for more information
/*
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
*/

// EJERCICIO 2
using EspacioEmpleado;
double montoTotalSalarios=0;

Empleado empleado1 = new Empleado();
empleado1.Nombre = "Sergio";
empleado1.Apellido = "Martin";
empleado1.FechaNac = new DateTime(2003,04,20);
empleado1.EstadoCivil = 'C';
empleado1.Genero = 'M';
empleado1.FechaIngreso = new DateTime(2008,04,20);
empleado1.SueldoBasico = 65000.00;
empleado1.Cargo = Cargos.Ingeniero;
int anti1 = empleado1.Antiguedad();
int edad1 = empleado1.Edad();
int jubi1 = empleado1.Jubilacion();
double salario1 = empleado1.Salario();
System.Console.WriteLine("---Empleado: "+empleado1.Nombre+"---\nAntiguedad: "+anti1+"\nEdad: "+edad1+"\nAnios para jubilacion: "+jubi1+"\nSalario: $"+salario1);

Empleado empleado2 = new Empleado();
empleado2.Nombre = "Maria";
empleado2.Apellido = "Perez";
empleado2.FechaNac = new DateTime(1995,06,29);
empleado2.EstadoCivil = 'C';
empleado2.Genero = 'F';
empleado2.FechaIngreso = new DateTime(2007,05,25);
empleado2.SueldoBasico = 80000.00;
empleado2.Cargo = Cargos.Administrativo;
int anti2 = empleado2.Antiguedad();
int edad2 = empleado2.Edad();
int jubi2 = empleado2.Jubilacion();
double salario2 = empleado2.Salario();
System.Console.WriteLine("---Empleado: "+empleado2.Nombre+"---\nAntiguedad: "+anti2+"\nEdad: "+edad2+"\nAnios para jubilacion: "+jubi2+"\nSalario: $"+salario2);

Empleado empleado3 = new Empleado();
empleado3.Nombre = "Mariano";
empleado3.Apellido = "Martin";
empleado3.FechaNac = new DateTime(1999,11,6);
empleado3.EstadoCivil = 'S';
empleado3.Genero = 'M';
empleado3.FechaIngreso = new DateTime(2015,1,17);
empleado3.SueldoBasico = 75000.00;
empleado3.Cargo = Cargos.Especialista;
int anti3 = empleado3.Antiguedad();
int edad3 = empleado3.Edad();
int jubi3 = empleado3.Jubilacion();
double salario3 = empleado3.Salario();
System.Console.WriteLine("---Empleado: "+empleado3.Nombre+"---\nAntiguedad: "+anti3+"\nEdad: "+edad3+"\nAnios para jubilacion: "+jubi3+"\nSalario: $"+salario3);

Empleado empleadoMasProxJubi = empleado1;
if (empleadoMasProxJubi.Jubilacion() > jubi2){
    empleadoMasProxJubi = empleado2;
}else{
    if(empleadoMasProxJubi.Jubilacion() > jubi3){
        empleadoMasProxJubi = empleado3;
    }
}
System.Console.WriteLine("\n---Empleado Mas Proximo a Jubilarse: "+empleadoMasProxJubi.Nombre+", "+empleadoMasProxJubi.Apellido+"---\nAntiguedad: "+empleadoMasProxJubi.Antiguedad()+"\nEdad: "+empleadoMasProxJubi.Edad()+"\nAnios para jubilacion: "+empleadoMasProxJubi.Jubilacion()+"\nSalario: $"+empleadoMasProxJubi.Salario());

montoTotalSalarios = salario1 + salario2 + salario3;
System.Console.WriteLine("[[El Monto total en concepto Salarios es: $"+montoTotalSalarios+"]]");