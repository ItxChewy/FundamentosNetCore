using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Aarón";
            persona.Apellidos = "García";
            persona.Genero = TipoGenero.Masculino;

            this.lstClases.Items.Add("Indizada : "+ persona[0]);
            persona.Nacionalidad = Paises.España;

            

            persona.Domicilio.Calle = "c/ almonte";
            persona.Domicilio.Ciudad = "Madrid";
            persona.Domicilio.CodigoPostal = 28031;

            this.lstClases.Items.Add(persona.GetNombreCompleto(true));

            this.lstClases.Items.Add("Direccion: " + persona.Domicilio.Calle + ", " + persona.Domicilio.Ciudad +
                ", " + persona.Domicilio.CodigoPostal);
            this.lstClases.Items.Add("Género: " + persona.Genero);
            this.lstClases.Items.Add("Nacionalidad: " + persona.Nacionalidad);
            persona.Edad = -20;
            this.lstClases.Items.Add("Edad: " + persona.Edad);
        }
    }
}
