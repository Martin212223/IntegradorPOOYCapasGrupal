using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> Listar()
        {
            List<Paciente> listaPacientes = new List<Paciente>();

            //Paciente paciente1 = new Paciente();

            //paciente1.Id = 1;
            //paciente1.Nombre = "Gerardo";
            //paciente1.Apellido = "Rodriguez";
            //paciente1.Domicilio = "Calle Por Ahí 45";
            //paciente1.Telefono = "2615544332";
            //paciente1.Email = "otrocorreo@email.com";
            //paciente1.NroHistoriaClinica = 1234;

            //listaPacientes.Add(paciente1);

            listaPacientes.Add(new Paciente() 
            {
                Id = 1,
                Nombre = "Gerardo",
                Apellido = "Rodriguez",
                Domicilio = "Calle Por Ahí 45",
                Telefono = "2615544332",
                Email = "otrocorreo@email.com",
                NroHistoriaClinica = 1234
            });

            //Paciente paciente2 = new Paciente();

            //paciente2.Id = 2;
            //paciente2.Nombre = "Fernando";
            //paciente2.Apellido = "Torres";
            //paciente2.Domicilio = "Calle Por Acá 987";
            //paciente2.Telefono = "2615544332";
            //paciente2.Email = "otrocorreomas@email.com";
            //paciente2.NroHistoriaClinica = 5436;

            //listaPacientes.Add(paciente2);

            listaPacientes.Add(new Paciente()
            {
                Id = 2,
                Nombre = "Joaquín",
                Apellido = "Rodriguez",
                Domicilio = "Calle Por Ahí 45",
                Telefono = "2615544332",
                Email = "otrocorreo@email.com",
                NroHistoriaClinica = 5432
            });

            //Paciente paciente3 = new Paciente();

            //paciente3.Id = 3;
            //paciente3.Nombre = "Florencia";
            //paciente3.Apellido = "Carrizo";
            //paciente3.Domicilio = "Calle Algo 567";
            //paciente3.Telefono = "2615544332";
            //paciente3.Email = "otrocorreomas2@email.com";
            //paciente3.NroHistoriaClinica = 9876;

            //listaPacientes.Add(paciente3);

            listaPacientes.Add(new Paciente()
            {
                Id = 3,
                Nombre = "Verónica",
                Apellido = "Saltieri",
                Domicilio = "Calle Por Ahí 45",
                Telefono = "2615544332",
                Email = "otrocorreo@email.com",
                NroHistoriaClinica = 7564
            });

            //Paciente paciente4 = new Paciente();

            //paciente4.Id = 4;
            //paciente4.Nombre = "Amelia";
            //paciente4.Apellido = "Larreta";
            //paciente4.Domicilio = "Calle Lugar 678";
            //paciente4.Telefono = "2615544332";
            //paciente4.Email = "otrocorreomas2@email.com";
            //paciente4.NroHistoriaClinica = 6543;

            //listaPacientes.Add(paciente4);

            listaPacientes.Add(new Paciente()
            {
                Id = 4,
                Nombre = "Sofía",
                Apellido = "Nuñes",
                Domicilio = "Calle Por Ahí 45",
                Telefono = "2615544332",
                Email = "otrocorreo@email.com",
                NroHistoriaClinica = 10927
            });

            //Paciente paciente5 = new Paciente();

            //paciente5.Id = 5;
            //paciente5.Nombre = "Rosa";
            //paciente5.Apellido = "Olavarría";
            //paciente5.Domicilio = "Calle Lugar 123";
            //paciente5.Telefono = "2615544332";
            //paciente5.Email = "otrocorreomas2@email.com";
            //paciente5.NroHistoriaClinica = 2964;

            //listaPacientes.Add(paciente5);

            listaPacientes.Add(new Paciente()
            {
                Id = 5,
                Nombre = "Federica",
                Apellido = "Silvestre",
                Domicilio = "Calle Por Ahí 45",
                Telefono = "2615544332",
                Email = "otrocorreo@email.com",
                NroHistoriaClinica = 9876
            });

            return listaPacientes;
        }

        public static int Insertar(Paciente paciente)
        {
            //TODO
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO
            return 0;
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            //TODO
            return null;
        }
    }
}
