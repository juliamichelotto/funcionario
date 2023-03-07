namespace funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSalario_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.CPF = txtCPF.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.ValorHora = double.Parse(txtValorHora.Text);
            funcionario.Hora = double.Parse(txtHoras.Text);

            funcionario.CalcularSalario();

            lblSalario.Visible = true;
            txtSalario.Visible = true;
            txtSalario.Text = funcionario.Salario.ToString("n2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSalario.Visible = false;
            txtSalario.Visible = false;
        }
    }
}