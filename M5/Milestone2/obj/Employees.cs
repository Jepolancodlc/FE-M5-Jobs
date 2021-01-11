using System;
using System.Collections.Generic;
using System.Text;

namespace M5
{
    class Employees : Empleado
    {
        // Constantes
        const int SENIOR = 5;
        const int MID = 10;
        const int JUNIOR = 15;

        public string tipoEmp { get; set; }

        public Employees()
        {

        }
        public Employees(string tipoEmp)
        {
            this.tipoEmp = tipoEmp;
        }
        public void PedirRolE(string tipoEmp)
        {
            Console.WriteLine("Que empleado eres? (Senior/Mid/Junior)");
            this.tipoEmp = Console.ReadLine().ToLower();
        }
        public void SueldoE(string empleado, int salari)
        {
            bool error = false;

            if (empleado.Equals("senior"))
            {
                if (salari > 2700 && salari < 4000)
                {
                    error = true;
                }
                salari -= salari / 100 * SENIOR;
            }
            else if (empleado.Equals("mid"))
            {
                if (salari > 1800 && salari < 2500)
                {
                    error = true;
                }
                salari -= salari / 100 * MID;
            }
            else
            {
                if (salari > 900 && salari < 1600)
                {
                    error = true;
                }
                salari -= salari / 100 * JUNIOR;
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
