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
        const int EMPLOYEE = 15;
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
            if (empleado.Equals("manager"))
            {
                salari += salari / 100 * MANAGER;
            }
            else if (empleado.Equals("boss"))
            {
                salari += salari / 100 * BOSS;
            }
            else if (empleado.Equals("employee"))
            {
                salari -= salari / 100 * EMPLOYEE;
            }
            else if (empleado.Equals("volunteer"))
            {
                salari =EMPLOYEE; // 0 porque cobra nada
            }
            Console.WriteLine("Tu salario es {0}", salari);
        }
    }
}
