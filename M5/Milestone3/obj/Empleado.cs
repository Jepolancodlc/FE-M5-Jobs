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
        const int IRPFMANAGER = 26;
        const int IRPFBOSS= 26;

        public int salari { get; set; }
        public string empleado { get; set; }
        public bool bonus { get; set; }
        public double salAnuLimp { get; set; }
        public double salMensLimp { get; set; }
        public double salAnuBru { get; set; }

        // Constructores
        public Empleado()
        {

        }

        public Empleado(int salari, string empleado, double salAnuLimp, double salMensLimp, double salAnuBru)
        {
            this.salari = salari;
            this.empleado = empleado;
            this.salAnuLimp = salAnuLimp;
            this.salMensLimp = salMensLimp;
            this.salAnuBru = salAnuBru;
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
        public void Bonus(bool bonus)
        {
            string siNo;
            Console.WriteLine("Dispones de bonus?");
            siNo = Console.ReadLine().ToLower();
            if (siNo.Equals("si"))
            {
                this.bonus = true;
            }
            else
            {
                this.bonus = false;
            }
        }

        public void Sueldo(string empleado, int salari, double salAnuLimp, double salMensLimp, double salAnuBru, bool bonus)
        {
            bool error = true, volunteer = true;

            if (empleado.Equals("volunteer"))
            {
                volunteer = false;
            }

            if (empleado.Equals("manager"))
            {
                if (salari > 3000 && salari < 5000)
                {
                    error = false;
                }
                salari += salari / 100 * MANAGER;
                salMensLimp = salari - (salari / 100 * IRPFMANAGER);
                salAnuBru = salari * 12;
                salAnuLimp = salMensLimp * 12;

            }
            else if (empleado.Equals("boss"))
            {
                if (salari > 8000)
                {
                    error = false;
                }
                salari += salari / 100 * BOSS;
                salMensLimp = salari - (salari / 100 * IRPFBOSS);
                salAnuBru = salari * 12;
                salAnuLimp = salMensLimp * 12;
            }
            else if (empleado.Equals("volunteer"))
            {
                if (salari != 0)
                {
                    if(salari < 300)
                    {
                        error = false;
                        Console.WriteLine("Ayuda guvernamental");
                    }
                }

            }
            if (!error && volunteer)
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
            else if (!error && !volunteer)
            {
                Console.WriteLine("Tu salario mensual bruto es {0}", salari);
            }
            else
            {
                Console.WriteLine("Tu salario no coincide con tu rol");
            }
        }
    }
}
