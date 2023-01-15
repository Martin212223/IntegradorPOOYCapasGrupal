using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmMedico
    {
        public static List<Medico> listaMedicos = new List<Medico>();

        public static List<Medico> Listar()
        {
            List<Medico> listaMedicos = new List<Medico>();

            //Medico medico1 = new Medico();

            //medico1.Id = 1;
            //medico1.Nombre = "Sebastián";
            //medico1.Apellido = "Sebastianelli";
            //medico1.Domicilio = "Calle Alguna 123";
            //medico1.Telefono = "2615123456";
            //medico1.Email = "alguncorreo90@email.com";
            //medico1.Especialidad = "Otorrinolaringólogo";
            //medico1.Matricula = 23445;

            //listaMedicos.Add(medico1);

            listaMedicos.Add(new Medico() 
            {
                Id = 1,
                Nombre = "Sebastián",
                Apellido = "Sebastianelli",
                Domicilio = "Calle Alguna 123",
                Telefono = "2615123456",
                Email = "alguncorreo90@email.com",
                Especialidad = "Otorrinolaringólogo",
                Matricula = 23445
            });

            //Medico medico2 = new Medico();

            //medico2.Id = 2;
            //medico2.Nombre = "Jorge";
            //medico2.Apellido = "Jorginelli";
            //medico2.Domicilio = "Calle Alguna 123";
            //medico2.Telefono = "2615123456";
            //medico2.Email = "alguncorreo90@email.com";
            //medico2.Especialidad = "Clínico";
            //medico2.Matricula = 32456;

            //listaMedicos.Add(medico2);

            listaMedicos.Add(new Medico()
            {
                Id = 2,
                Nombre = "Federico",
                Apellido = "Perez",
                Domicilio = "Calle Alguna 321",
                Telefono = "2615123456",
                Email = "alguncorreo90@email.com",
                Especialidad = "Clínico",
                Matricula = 9876
            });

            //Medico medico3 = new Medico();

            //medico3.Id = 3;
            //medico3.Nombre = "Hernán";
            //medico3.Apellido = "Jorginelli";
            //medico3.Domicilio = "Calle Alguna 123";
            //medico3.Telefono = "2615123456";
            //medico3.Email = "alguncorreo90@email.com";
            //medico3.Especialidad = "Pediatra";
            //medico3.Matricula = 10235;

            //listaMedicos.Add(medico3);

            listaMedicos.Add(new Medico()
            {
                Id = 3,
                Nombre = "Candela",
                Apellido = "Solares",
                Domicilio = "Calle Alguna 123",
                Telefono = "2615123456",
                Email = "alguncorreo90@email.com",
                Especialidad = "Pediatra",
                Matricula = 22643
            });

            //Medico medico4 = new Medico();

            //medico4.Id = 4;
            //medico4.Nombre = "Hernán";
            //medico4.Apellido = "Jorginelli";
            //medico4.Domicilio = "Calle Alguna 123";
            //medico4.Telefono = "2615123456";
            //medico4.Email = "alguncorreo90@email.com";
            //medico4.Especialidad = "Clínico";
            //medico4.Matricula = 10235;

            //listaMedicos.Add(medico4);

            listaMedicos.Add(new Medico()
            {
                Id = 4,
                Nombre = "Luciana",
                Apellido = "Venegas",
                Domicilio = "Calle Alguna 123",
                Telefono = "2615123456",
                Email = "alguncorreo90@email.com",
                Especialidad = "Clínico",
                Matricula = 7563
            });

            //Medico medico5 = new Medico();

            //medico5.Id = 5;
            //medico5.Nombre = "Hernán";
            //medico5.Apellido = "Jorginelli";
            //medico5.Domicilio = "Calle Alguna 123";
            //medico5.Telefono = "2615123456";
            //medico5.Email = "alguncorreo90@email.com";
            //medico5.Especialidad = "Cardiólogo";
            //medico5.Matricula = 10235;

            //listaMedicos.Add(medico5);

            listaMedicos.Add(new Medico()
            {
                Id = 5,
                Nombre = "Julieta",
                Apellido = "Sosa",
                Domicilio = "Calle Alguna 123",
                Telefono = "2615123456",
                Email = "alguncorreo90@email.com",
                Especialidad = "Dentista",
                Matricula = 87634
            });

            return listaMedicos;
        }

        public static List<Medico> Listar(string especialidad)
        {
            List<Medico> todos = Listar();

            List<Medico> medicosClinicos = new List<Medico>();

            foreach (Medico medClinico in todos)
            {
                if(medClinico.Especialidad.Equals(especialidad))
                {
                    medicosClinicos.Add(medClinico);
                }
            }

            return medicosClinicos;
        }

        public static int Insertar(Medico medico)
        {
            //TODO
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO
            return 0;
        }

        public static Medico TraerUno(int id)
        {
            //TODO
            return null;
        }
    }
}
