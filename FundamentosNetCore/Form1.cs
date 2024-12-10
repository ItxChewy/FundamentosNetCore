namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Algo aqui...";
            this.SuspendLayout();
        }


        private void btnPulsar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Location = new Point(20, 10);
            this.txtNombre.Text = "Soy un string";
            this.txtNombre.Width = 220;
            this.txtNombre.TextAlign = HorizontalAlignment.Right;
            this.btnPulsar.BackColor = Color.Green;


            //CONVERSION AUTOMATICA
            short pequeño = 88;
            int mayor = pequeño;

            //STRING A PRIMITIVO
            string textoNumero = "12345";
            int numero = int.Parse(textoNumero);
            
           
           

        }

       
    }
}
