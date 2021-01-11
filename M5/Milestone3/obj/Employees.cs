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
        const int IRPFSENIOR = 24;
        const int IRPFMID = 15;
        const int IRPFJUNIOR = 2;

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
        public void SueldoE(string empleado, int salari, bool bonus)
        {
            bool error = false;

            if (empleado.Equals("senior"))
            {
                if (salari > 2700 && salari < 4000)
                {
                    error = true;
                }
                salari -= salari / 100 * SENIOR;
                salMensLimp = salari - (salari / 100 * IRPFSENIOR);
                salAnuBru = salari * 12;
                salAnuLimp = salMensLimp * 12;
            }
            else if (empleado.Equals("mid"))
            {
                if (salari > 1800 && salari < 2500)
                {
                    error = true;
                }
                salari -= salari / 100 * MID;
                salMensLimp = salari - (salari / 100 * IRPFMID);
                salAnuBru = salari * 12;
                salAnuLimp = salMensLimp * 12;
            }
            else
            {
                if (salari > 900 && salari < 1600)
                {
                    error = true;
                }
                salari -= salari / 100 * JUNIOR;
                salMensLimp = salari - (salari / 100 * IRPFJUNIOR);
                salAnuBru = salari * 12;
                salAnuLimp = salMensLimp * 12;
            }
            if (error)
            {
                if (bonus)
                {
                    salAnuLimp += salAnuLimp / 100 * 10;
                }
                Console.WriteLine("Tu salario mensual bruto es {0}\n" +
                    "Tu salario mensual limpio es {1}\n" +
                    "Tu salario anual bruto es {3}\n" +
                    "Tu salario anual limpio es {2}", salari, salMensLimp, salAnuLimp, salAnuBru);
            }
            else
            {
                Console.WriteLine("Tu salario no coincide con tu rol");
            }
        }
    }
}
