using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {

            List<Habitacion> listaHabitaciones = new List<Habitacion>();

            //Habitacion habitacion1 = new Habitacion();

            //habitacion1.Id = 1;
            //habitacion1.Numero = 26;
            //habitacion1.Estado = true;

            //listaHabitaciones.Add(habitacion1);

            listaHabitaciones.Add(new Habitacion() 
            {
                Id = 1,
                Numero = 26,
                Estado = true
            });

            //Habitacion habitacion2 = new Habitacion();

            //habitacion2.Id = 2;
            //habitacion2.Numero = 27;
            //habitacion2.Estado = false;

            //listaHabitaciones.Add(habitacion2);

            listaHabitaciones.Add(new Habitacion()
            {
                Id = 2,
                Numero = 27,
                Estado = false
            });

            //Habitacion habitacion3 = new Habitacion();

            //habitacion3.Id = 3;
            //habitacion3.Numero = 34;
            //habitacion3.Estado = true;

            //listaHabitaciones.Add(habitacion3);

            listaHabitaciones.Add(new Habitacion() 
            {
                Id = 3,
                Numero = 34,
                Estado = true
            });

            //Habitacion habitacion4 = new Habitacion();

            //habitacion4.Id = 4;
            //habitacion4.Numero = 37;
            //habitacion4.Estado = false;

            //listaHabitaciones.Add(habitacion4);

            listaHabitaciones.Add(new Habitacion() 
            {
                Id = 4,
                Numero = 37,
                Estado = false
            });

            //Habitacion habitacion5 = new Habitacion();

            //habitacion5.Id = 5;
            //habitacion5.Numero = 40;
            //habitacion5.Estado = true;

            //listaHabitaciones.Add(habitacion5);

            listaHabitaciones.Add(new Habitacion() 
            {
                Id = 5,
                Numero = 40,
                Estado = true
            });

            return listaHabitaciones;
        }

        public static List<Habitacion> Listar(bool estado)
        {
            //TODO
            return null;
        }

        public static int Insertar(Habitacion habitacion)
        {
            //TODO
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO
            return 0;
        }

        public static Habitacion TraerUno(int numero)
        {
            //TODO
            return null;
        }
    }
}
