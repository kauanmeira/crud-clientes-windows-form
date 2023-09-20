namespace CRUD_CLIENTES_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgCliente = new DataGridView();
            label1 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            Nome = new Label();
            txtEndereco = new TextBox();
            Endereco = new Label();
            txtCpf = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            Email = new Label();
            txtSenha = new TextBox();
            Senha = new Label();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCliente).BeginInit();
            SuspendLayout();
            // 
            // dgCliente
            // 
            dgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCliente.Location = new Point(12, 263);
            dgCliente.Name = "dgCliente";
            dgCliente.RowTemplate.Height = 25;
            dgCliente.Size = new Size(616, 150);
            dgCliente.TabIndex = 0;
            dgCliente.CellClick += dgCliente_CellClick;
            dgCliente.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(12, 48);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(220, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 105);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(220, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(12, 87);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 3;
            Nome.Text = "Nome";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(271, 165);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(220, 23);
            txtEndereco.TabIndex = 6;
            // 
            // Endereco
            // 
            Endereco.AutoSize = true;
            Endereco.Location = new Point(271, 147);
            Endereco.Name = "Endereco";
            Endereco.Size = new Size(56, 15);
            Endereco.TabIndex = 5;
            Endereco.Text = "Endereco";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 165);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(220, 23);
            txtCpf.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 7;
            label4.Text = "Cpf";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(271, 48);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 23);
            txtEmail.TabIndex = 10;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(271, 30);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 9;
            Email.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(271, 105);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(220, 23);
            txtSenha.TabIndex = 12;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(271, 87);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 11;
            Senha.Text = "Senha";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(120, 231);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(216, 231);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(318, 231);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 454);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtSenha);
            Controls.Add(Senha);
            Controls.Add(txtEmail);
            Controls.Add(Email);
            Controls.Add(txtCpf);
            Controls.Add(label4);
            Controls.Add(txtEndereco);
            Controls.Add(Endereco);
            Controls.Add(txtNome);
            Controls.Add(Nome);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(dgCliente);
            Name = "Form1";
            Text = "Crud de Clientes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCliente;
        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private Label Nome;
        private TextBox txtEndereco;
        private Label Endereco;
        private TextBox txtCpf;
        private Label label4;
        private TextBox txtEmail;
        private Label Email;
        private TextBox txtSenha;
        private Label Senha;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}