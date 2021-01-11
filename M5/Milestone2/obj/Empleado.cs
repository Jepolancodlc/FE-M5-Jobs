using System;
using System.Collections.Generic;
using System.Text;

namespace M5
{
    class Empleado
    {
        // Constantes
        // por si se quiere cambiar rapido el aumento o reduccion
        const int MANAGER = 10;
        const int BOSS = 50;
        const int VOLUNTEER = 0;
        public int salari { get; set; }
        public string empleado { get; set; }

        // Constructores
        public Empleado()
        {
        }

        public Empleado(int salari, string empleado)
        {
            this.salari = salari;
            this.empleado = empleado;
        }

        // Metodos
        public void PedirRol(string empleado)
        {
            Console.WriteLine("Que rol tienes? (Manager/Boss/Employee/Volunteer");
            this.empleado = Console.ReadLine().ToLower();
        }
        public void PedirSueldo(int salari)
        {
            Console.WriteLine("Que salario tienes?");
            this.salari = Int32.Parse(Console.ReadLine());
        }

        public void Sueldo(string empleado, int salari)
        {
            bool error = false;

            if (empleado.Equals("manager"))
            {
                if (salari > 3000 && salari < 5000)
                {
                    error = true;
                }
                salari += salari / 100 * MANAGER;
            }
            else if (empleado.Equals("boss"))
            {
                if (salari > 8000)
                {
                    error = true;
                }
                salari += salari / 100 * BOSS;
            }
            else if (empleado.Equals("volunteer"))
            {
                if (salari != 0)
                {
                    error = true;
                }

            }
            if (error)
            {
                Console.WriteLine("Tu salario es {0}", salari);
            }
            else
            {
                Console.WriteLine("Tu salario no coincide con tu rol");
            }
        }
    }
}
