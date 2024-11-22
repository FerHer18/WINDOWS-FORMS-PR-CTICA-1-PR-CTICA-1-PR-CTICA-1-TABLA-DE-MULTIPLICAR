namespace PRÁCTICA__1_TABLA_DE_MULTIPLICAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void labelNumero_Click(object sender, EventArgs e)
        {

        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            this.NuestraTabla();
        }

        private void NuestraTabla()
        {
            int n  = Convert.ToInt32(this.textBoxNumero.Text); //ES COMO UN METODO GET

            string Tabla = " ";
            Console.WriteLine("Fernando Gabriel Hernandez Junco\n");
            Console.WriteLine("\tBienvenido\n\n");
            for (int i = 0; i < 11; i++)
            {
                Tabla = Tabla + n + "x" + i + "=" + (n * i) + "\n";
            }
            this.richTextBoxResultados.AppendText(Tabla);

        }
    }
}
