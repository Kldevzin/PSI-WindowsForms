namespace WindowsForm1
{
    public partial class Form1 : Form
    {
        public string User = "Facinoficial_";
        public string Password = "123456789";
        // texto de interação com o usuário
        public string usuario = "";
        public string senha = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_conectar_Click(object sender, EventArgs e)
        {
            usuario = textBox1_usuario.Text;
            senha = textBox_senha.Text;
            if (usuario == User && senha == Password)
            {
                MessageBox.Show("Login realizado com sucesso!");
                Form2 pagina_usuario = new Form2(usuario,senha);
                pagina_usuario.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
                textBox1_usuario.Clear();
                textBox_senha.Clear();
            }

        }
    }
}
