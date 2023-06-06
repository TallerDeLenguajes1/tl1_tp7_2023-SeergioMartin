namespace EspacioEmpleado
{   
    public enum Cargos
        {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
        }

    public class Empleado
    {
        private string? nombre;

        private string? apellido;

        private DateTime fechaNac;
        private char estadoCivil;

        private char genero;

        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        public string? Nombre { 
            get => nombre; 
            set => nombre = value; 
        }
        public string? Apellido {
            get => apellido; 
            set => apellido = value; 
        }
        public DateTime FechaNac { 
            get => fechaNac; 
            set => fechaNac = value; 
        }
        public char EstadoCivil { 
            get => estadoCivil; 
            set => estadoCivil = value; 
        }
        public char Genero { 
            get => genero; 
            set => genero = value; 
        }
        public DateTime FechaIngreso { 
            get => fechaIngreso; 
            set => fechaIngreso = value;
        }
        public double SueldoBasico { 
            get => sueldoBasico; 
            set => sueldoBasico = value; 
        }
        public Cargos Cargo {
            get => cargo; 
            set => cargo = value; 
        }

        public int Antiguedad(){
            int aux;
            DateTime hoy = DateTime.Now;
            aux = Math.Abs(fechaIngreso.Year - hoy.Year);
            return aux;
        }
        public int Edad(){
            int aux;
            DateTime hoy = DateTime.Now;
            aux = Math.Abs(fechaNac.Year - hoy.Year);
            return aux;
        }
        public int Jubilacion(){
            int edad = Edad();
            int edadJubilado;
            int anios;

            if (genero == 'M')
            {
                edadJubilado = 65;
            } else
            {
                edadJubilado = 60;
            }

            anios = edadJubilado - edad;

            if (anios < 0)
            {
                return 0;
            }else
            {
                return anios;                
            }
        }

        public double Salario(){
            double adicional = 0.00;
            double salario = 0.00;
            if (Antiguedad() < 20){
                for (int i = 0; i < Antiguedad(); i++){
                    adicional += sueldoBasico * 0.01;
                }
            }else{
                for (int i = 0; i < Antiguedad(); i++){
                    adicional += sueldoBasico * 0.25;
                }
            }

            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional *= 1.50;
            }

            if (estadoCivil == 'C')
            {
                adicional += 15000.00;
            }

            salario = sueldoBasico + adicional;

            return salario;
        }
    }
}