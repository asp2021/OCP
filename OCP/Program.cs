using System;
using System.Collections.Generic;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicant> persons = new List<IApplicant>()
            {
                new Person{ FirstName = "Laura", LastName="Grande" },
                new Doctor{ FirstName = "Paola", LastName="Pica"},
                new Nurse{ FirstName = "Silvia", LastName="Perez"}
            };
            List<Staff> staffs = new List<Staff>();
            foreach(var staff in persons)
            {
                staffs.Add(staff.Proccesor.Create(staff));
            }

            Console.WriteLine("OCP - Open Closed Principle\n");
            Console.WriteLine("Una clase debe estar abierta para extensiones pero cerrada para modificaciones\n");


            foreach(var staff in staffs)
            {
                Console.WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName}, {staff.Email}");
            }
        }
    }
}
