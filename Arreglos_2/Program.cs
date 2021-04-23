using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_2
{
    class Program
    {
        //La empresa Apple cuenta con 2 turnos (matutino y vespertino) 
        //La plantilla es de 10 empleados (5 en el turno matutino y 5 en el turno vespertino)
        //Desarrollar un programa que almacene los sueldos de los empleados agrupados por turno.
        //Y calcular  el total de gastos en sueldos por turno
        //Vector unidimensional de tipo Float
        private float[] turnoMatutino;
        private float[] turnoVespertino;

        public void Cargar()
        {
            string lineaCaptura;
            turnoMatutino = new float[4]; //Asignar al vector longitud de 4
            turnoVespertino = new float[4]; //Asignar al vector longitud de 4
            //Turno Matutino
            Console.WriteLine("Sueldos de empleados del turno Matutino");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el sueldo " + (i + 1) + ": ");
                lineaCaptura = Console.ReadLine();
                turnoMatutino[i] = float.Parse(lineaCaptura);//Asignar valores al vector
            }

            //Turno Vespertino
            Console.WriteLine("Sueldos de empleados del turno Vespertino");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el sueldo " + (i + 1) + ": ");
                lineaCaptura = Console.ReadLine();
                turnoVespertino[i] = float.Parse(lineaCaptura);//Asignar valores al vector
            }
        }

        public void CalcularGastos()
        {
            float sueldosMatutino = 0;
            float sueldosVespertino = 0;

            for (int i = 0; i < 4; i++)
            {
                sueldosMatutino = sueldosMatutino + turnoMatutino[i];
            }


            for (int i = 0; i < 4; i++)
            {
                sueldosVespertino = sueldosVespertino + turnoVespertino[i];
            }

            Console.WriteLine("Total de Gastos en sueldo del turno matutino" + sueldosMatutino);
            Console.WriteLine("Total de Gastos en sueldo del turno Vespertino" + sueldosVespertino);
            Console.ReadKey();


        }


        

        static void Main(string[] args)
        {
            Program sueldos = new Program();
            sueldos.Cargar();
            sueldos.CalcularGastos();
        }
    }
}
