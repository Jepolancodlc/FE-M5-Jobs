using System;
using System.Collections.Generic;
using System.Text;

namespace M5
{
    class Milestone3
    {
        public static void Milestone03()
        {
            Empleado emp1 = new Empleado();
            Employees empl1 = new Employees();

            emp1.PedirRol(emp1.empleado);
            emp1.PedirSueldo(emp1.salari);
            emp1.Bonus(emp1.bonus);

            if (emp1.empleado.Equals("employee"))
            {
                empl1.PedirRolE(empl1.tipoEmp);
                empl1.SueldoE(empl1.tipoEmp, emp1.salari, emp1.bonus);
            }
            else
            {
                emp1.Sueldo(emp1.empleado, emp1.salari, emp1.salAnuLimp, emp1.salMensLimp, emp1.salAnuBru, emp1.bonus);
            }
        }
    }
}
