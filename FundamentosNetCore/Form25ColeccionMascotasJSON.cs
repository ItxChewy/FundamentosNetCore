using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form25ColeccionMascotasJSON : Form
    {
        
        ColeccionMascotas mascotasList;
        public Form25ColeccionMascotasJSON()
        {
            InitializeComponent();
            this.mascotasList = new ColeccionMascotas();
        }
        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }
        private void btnLeerMascotas_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("mascotaslist2.json"))
            {
                string json = reader.ReadToEnd();
                this.mascotasList = JsonSerializer.Deserialize<ColeccionMascotas>(json);
                reader.Close();
                this.DibujarMascotas();
            }
        }

        private async void btnGuardarMascotas_Click(object sender, EventArgs e)
        {
            using(StreamWriter writer = new StreamWriter("mascotaslist2.json"))
            {
                string json = JsonSerializer.Serialize(this.mascotasList);
                await writer.WriteAsync(json);
                await writer.FlushAsync();
            }

            this.lstMascotas.Items.Clear();
            this.mascotasList.Clear();
        }
  

        private void btnNuevaMascota_Click_1(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtAnio.Text);
            this.mascotasList.Add(mascota);
            this.DibujarMascotas();
            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtAnio.Clear();
        }
    }
}
