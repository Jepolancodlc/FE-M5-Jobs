using System;
using System.Collections.Generic;
using System.Text;

namespace M5
{
    class Milestone1
    {
        public static void Milestone01()
        {
            Empleado emp1 = new Empleado();

            emp1.PedirRol(emp1.empleado);
            emp1.PedirSueldo(emp1.salari);
            emp1.Sueldo(emp1.empleado, emp1.salari);
        }
    }
}
