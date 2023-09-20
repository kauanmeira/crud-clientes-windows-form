using CRUD_CLIENTES_WF.Repositorio;

namespace CRUD_CLIENTES_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void limparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtEndereco.Text = string.Empty;
        }

        private void BuscarTodosOsClientes(ClienteRepositorio clienteRepositorio)
        {
            var clientes = clienteRepositorio.BuscarTodosClientes();
            dgCliente.DataSource = clientes.ToList();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text, txtSenha.Text, txtEndereco.Text);
            var clienteRepositorio = new ClienteRepositorio();

            clienteRepositorio.Adicionar(cliente);
            limparCampos();
            BuscarTodosOsClientes(clienteRepositorio);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var clienteRepositorio = new ClienteRepositorio();
            BuscarTodosOsClientes(clienteRepositorio);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtCodigo.Text = dgv.CurrentRow.Cells["Codigo"]?.Value?.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"]?.Value?.ToString();
            txtCpf.Text = dgv.CurrentRow.Cells["Cpf"]?.Value?.ToString();
            txtEmail.Text = dgv.CurrentRow.Cells["Email"]?.Value?.ToString();
            txtSenha.Text = dgv.CurrentRow.Cells["Senha"]?.Value?.ToString();
            txtEndereco.Text = dgv.CurrentRow.Cells["Endereco"]?.Value?.ToString();







        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtCpf.Text, txtEmail.Text, txtSenha.Text, txtEndereco.Text);
            var clienteRepositorio = new ClienteRepositorio();
            clienteRepositorio.Atualizar(cliente);
            limparCampos();
            BuscarTodosOsClientes(clienteRepositorio);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var clienteRepositorio = new ClienteRepositorio();
            clienteRepositorio.Deletar(Convert.ToInt32(txtCodigo.Text));
            limparCampos();
            BuscarTodosOsClientes(clienteRepositorio);

        }
    }
}