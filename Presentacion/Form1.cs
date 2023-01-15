using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gridMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridMedicos.DataSource = AdmMedico.Listar();

            gridPacientes.DataSource = AdmPaciente.Listar();

            foreach (Medico medico in AdmMedico.Listar("Clínico"))
            {
                clinicos.Items.Add("Nombre: " + medico.Nombre + " " + medico.Apellido);
            }

            foreach (Habitacion habitacion in AdmHabitacion.Listar())
            {
                string estadoHabitacion;

                if (habitacion.Estado) estadoHabitacion = "Ocupada";
                else estadoHabitacion = "Libre";

                habitaciones.Items.Add("Número: " + habitacion.Numero + "  Estado: " + estadoHabitacion);
            }
            

        }

        private void clinicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void habitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
