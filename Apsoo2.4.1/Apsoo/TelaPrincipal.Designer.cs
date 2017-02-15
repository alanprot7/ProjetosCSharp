namespace Apsoo
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.abasGeral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picFametro = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbSenhAdmin = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnNovaSenha = new System.Windows.Forms.Panel();
            this.btnCadastraSenha = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabFuncionario = new System.Windows.Forms.TabPage();
            this.btnNovoFuncionario = new System.Windows.Forms.Button();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnCancelarFuncionario = new System.Windows.Forms.Button();
            this.btnSalvarFuncionario = new System.Windows.Forms.Button();
            this.dataGridFuncionario = new System.Windows.Forms.DataGridView();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.txbFuncionarioMatricula = new System.Windows.Forms.TextBox();
            this.txbFuncionarioNome = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabHorario = new System.Windows.Forms.TabPage();
            this.btnCancelHorario = new System.Windows.Forms.Button();
            this.btnNovoHorario = new System.Windows.Forms.Button();
            this.btnPesquisarHorario = new System.Windows.Forms.Button();
            this.btnExcluirHorario = new System.Windows.Forms.Button();
            this.btnSalvarHorario = new System.Windows.Forms.Button();
            this.dataGridHorario = new System.Windows.Forms.DataGridView();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTolerancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbEntrada = new System.Windows.Forms.TextBox();
            this.txbSaida = new System.Windows.Forms.TextBox();
            this.txbTolerancia = new System.Windows.Forms.TextBox();
            this.lblTolerancia = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.lblentrada = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbFuncionarioLista = new System.Windows.Forms.GroupBox();
            this.lblNomeConsulta = new System.Windows.Forms.Label();
            this.dgRelatorioFuncionario = new System.Windows.Forms.DataGridView();
            this.btnConsultaFuncionario = new System.Windows.Forms.Button();
            this.txbRelatorioFuncionario = new System.Windows.Forms.TextBox();
            this.radioFuncionario = new System.Windows.Forms.RadioButton();
            this.radioIndividual = new System.Windows.Forms.RadioButton();
            this.radioPorDia = new System.Windows.Forms.RadioButton();
            this.btnImprimirRelatorio = new System.Windows.Forms.Button();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.colRelatorioMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abasGeral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFametro)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnNovaSenha.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionario)).BeginInit();
            this.tabHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHorario)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.gbFuncionarioLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRelatorioFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // abasGeral
            // 
            this.abasGeral.Controls.Add(this.tabPage1);
            this.abasGeral.Controls.Add(this.tabPage2);
            this.abasGeral.Controls.Add(this.tabPage3);
            this.abasGeral.Controls.Add(this.tabPage4);
            this.abasGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abasGeral.Location = new System.Drawing.Point(4, 3);
            this.abasGeral.Name = "abasGeral";
            this.abasGeral.SelectedIndex = 0;
            this.abasGeral.Size = new System.Drawing.Size(675, 391);
            this.abasGeral.TabIndex = 0;
            this.abasGeral.Click += new System.EventHandler(this.abasGeral_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.picFametro);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txbMatricula);
            this.tabPage1.ForeColor = System.Drawing.Color.DarkGreen;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PONTO";
            // 
            // picFametro
            // 
            this.picFametro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picFametro.InitialImage = null;
            this.picFametro.Location = new System.Drawing.Point(522, 259);
            this.picFametro.Name = "picFametro";
            this.picFametro.Size = new System.Drawing.Size(139, 100);
            this.picFametro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFametro.TabIndex = 14;
            this.picFametro.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(155, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 164);
            this.panel1.TabIndex = 13;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(99, 121);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(131, 29);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "00/00/0000";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(23, 40);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(290, 75);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "RELÓGIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "MATRICULA:";
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(239, 92);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(178, 20);
            this.txbMatricula.TabIndex = 6;
            this.txbMatricula.Leave += new System.EventHandler(this.txbMatricula_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.txbSenhAdmin);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.pnNovaSenha);
            this.tabPage2.Controls.Add(this.btnLogin);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.ForeColor = System.Drawing.Color.Green;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONFIG";
            // 
            // txbSenhAdmin
            // 
            this.txbSenhAdmin.Location = new System.Drawing.Point(222, 57);
            this.txbSenhAdmin.Name = "txbSenhAdmin";
            this.txbSenhAdmin.Size = new System.Drawing.Size(197, 20);
            this.txbSenhAdmin.TabIndex = 10;
            this.txbSenhAdmin.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(386, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Caso seja a primeira senha clique em \"Login\" com o campo vazio.";
            // 
            // pnNovaSenha
            // 
            this.pnNovaSenha.Controls.Add(this.btnCadastraSenha);
            this.pnNovaSenha.Controls.Add(this.label12);
            this.pnNovaSenha.Controls.Add(this.txtNovaSenha);
            this.pnNovaSenha.Controls.Add(this.label11);
            this.pnNovaSenha.Controls.Add(this.txtConfirmaSenha);
            this.pnNovaSenha.Location = new System.Drawing.Point(201, 110);
            this.pnNovaSenha.Name = "pnNovaSenha";
            this.pnNovaSenha.Size = new System.Drawing.Size(239, 197);
            this.pnNovaSenha.TabIndex = 8;
            this.pnNovaSenha.Visible = false;
            // 
            // btnCadastraSenha
            // 
            this.btnCadastraSenha.Location = new System.Drawing.Point(79, 164);
            this.btnCadastraSenha.Name = "btnCadastraSenha";
            this.btnCadastraSenha.Size = new System.Drawing.Size(75, 23);
            this.btnCadastraSenha.TabIndex = 8;
            this.btnCadastraSenha.Text = "Cadastrar";
            this.btnCadastraSenha.UseVisualStyleBackColor = true;
            this.btnCadastraSenha.Click += new System.EventHandler(this.btnCadastraSenha_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(65, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "NOVA SENHA";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(21, 59);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(197, 20);
            this.txtNovaSenha.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "CONFIRMA SENHA";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(21, 131);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(197, 20);
            this.txtConfirmaSenha.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(483, 53);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SENHA ADMIN* :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(667, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CADASTRO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabFuncionario);
            this.tabControl2.Controls.Add(this.tabHorario);
            this.tabControl2.Location = new System.Drawing.Point(0, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(650, 359);
            this.tabControl2.TabIndex = 0;
            // 
            // tabFuncionario
            // 
            this.tabFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabFuncionario.Controls.Add(this.btnNovoFuncionario);
            this.tabFuncionario.Controls.Add(this.btnPesquisarFuncionario);
            this.tabFuncionario.Controls.Add(this.btnExcluirFuncionario);
            this.tabFuncionario.Controls.Add(this.btnCancelarFuncionario);
            this.tabFuncionario.Controls.Add(this.btnSalvarFuncionario);
            this.tabFuncionario.Controls.Add(this.dataGridFuncionario);
            this.tabFuncionario.Controls.Add(this.cbHorario);
            this.tabFuncionario.Controls.Add(this.txbFuncionarioMatricula);
            this.tabFuncionario.Controls.Add(this.txbFuncionarioNome);
            this.tabFuncionario.Controls.Add(this.lblHorario);
            this.tabFuncionario.Controls.Add(this.lblMatricula);
            this.tabFuncionario.Controls.Add(this.lblNome);
            this.tabFuncionario.ForeColor = System.Drawing.Color.Green;
            this.tabFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionario.Name = "tabFuncionario";
            this.tabFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionario.Size = new System.Drawing.Size(642, 333);
            this.tabFuncionario.TabIndex = 0;
            this.tabFuncionario.Text = "FUNCIONÁRIO";
            // 
            // btnNovoFuncionario
            // 
            this.btnNovoFuncionario.Location = new System.Drawing.Point(65, 18);
            this.btnNovoFuncionario.Name = "btnNovoFuncionario";
            this.btnNovoFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnNovoFuncionario.TabIndex = 17;
            this.btnNovoFuncionario.Text = "Novo";
            this.btnNovoFuncionario.UseVisualStyleBackColor = true;
            this.btnNovoFuncionario.Click += new System.EventHandler(this.btnNovoFuncionario_Click);
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(501, 18);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarFuncionario.TabIndex = 16;
            this.btnPesquisarFuncionario.Text = "Pesquisar";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click);
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(392, 18);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFuncionario.TabIndex = 15;
            this.btnExcluirFuncionario.Text = "Excluir";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = true;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
            // 
            // btnCancelarFuncionario
            // 
            this.btnCancelarFuncionario.Location = new System.Drawing.Point(174, 18);
            this.btnCancelarFuncionario.Name = "btnCancelarFuncionario";
            this.btnCancelarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarFuncionario.TabIndex = 14;
            this.btnCancelarFuncionario.Text = "Cancelar";
            this.btnCancelarFuncionario.UseVisualStyleBackColor = true;
            this.btnCancelarFuncionario.Click += new System.EventHandler(this.btnCancelarFuncionario_Click);
            // 
            // btnSalvarFuncionario
            // 
            this.btnSalvarFuncionario.Location = new System.Drawing.Point(283, 18);
            this.btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            this.btnSalvarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarFuncionario.TabIndex = 13;
            this.btnSalvarFuncionario.Text = "Salvar";
            this.btnSalvarFuncionario.UseVisualStyleBackColor = true;
            this.btnSalvarFuncionario.Click += new System.EventHandler(this.btnSalvarFuncionario_Click);
            // 
            // dataGridFuncionario
            // 
            this.dataGridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMatricula,
            this.colNome,
            this.colHorario});
            this.dataGridFuncionario.Location = new System.Drawing.Point(6, 153);
            this.dataGridFuncionario.Name = "dataGridFuncionario";
            this.dataGridFuncionario.ReadOnly = true;
            this.dataGridFuncionario.Size = new System.Drawing.Size(630, 174);
            this.dataGridFuncionario.TabIndex = 12;
            this.dataGridFuncionario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridFuncionario_CellMouseDoubleClick);
            // 
            // colMatricula
            // 
            this.colMatricula.DataPropertyName = "matricula";
            this.colMatricula.HeaderText = "Matricula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 370;
            // 
            // colHorario
            // 
            this.colHorario.DataPropertyName = "horario";
            this.colHorario.HeaderText = "Horario";
            this.colHorario.Name = "colHorario";
            this.colHorario.ReadOnly = true;
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(122, 111);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(165, 21);
            this.cbHorario.TabIndex = 11;
            // 
            // txbFuncionarioMatricula
            // 
            this.txbFuncionarioMatricula.Location = new System.Drawing.Point(122, 85);
            this.txbFuncionarioMatricula.Name = "txbFuncionarioMatricula";
            this.txbFuncionarioMatricula.Size = new System.Drawing.Size(165, 20);
            this.txbFuncionarioMatricula.TabIndex = 10;
            // 
            // txbFuncionarioNome
            // 
            this.txbFuncionarioNome.Location = new System.Drawing.Point(122, 59);
            this.txbFuncionarioNome.Name = "txbFuncionarioNome";
            this.txbFuncionarioNome.Size = new System.Drawing.Size(342, 20);
            this.txbFuncionarioNome.TabIndex = 9;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(38, 114);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(64, 13);
            this.lblHorario.TabIndex = 8;
            this.lblHorario.Text = "HORARIO";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(38, 88);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(78, 13);
            this.lblMatricula.TabIndex = 7;
            this.lblMatricula.Text = "MATRICULA";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(38, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "NOME";
            // 
            // tabHorario
            // 
            this.tabHorario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabHorario.Controls.Add(this.btnCancelHorario);
            this.tabHorario.Controls.Add(this.btnNovoHorario);
            this.tabHorario.Controls.Add(this.btnPesquisarHorario);
            this.tabHorario.Controls.Add(this.btnExcluirHorario);
            this.tabHorario.Controls.Add(this.btnSalvarHorario);
            this.tabHorario.Controls.Add(this.dataGridHorario);
            this.tabHorario.Controls.Add(this.txbEntrada);
            this.tabHorario.Controls.Add(this.txbSaida);
            this.tabHorario.Controls.Add(this.txbTolerancia);
            this.tabHorario.Controls.Add(this.lblTolerancia);
            this.tabHorario.Controls.Add(this.lblSaida);
            this.tabHorario.Controls.Add(this.lblentrada);
            this.tabHorario.Controls.Add(this.txbDescricao);
            this.tabHorario.Controls.Add(this.lblDescricao);
            this.tabHorario.ForeColor = System.Drawing.Color.Green;
            this.tabHorario.Location = new System.Drawing.Point(4, 22);
            this.tabHorario.Name = "tabHorario";
            this.tabHorario.Padding = new System.Windows.Forms.Padding(3);
            this.tabHorario.Size = new System.Drawing.Size(642, 333);
            this.tabHorario.TabIndex = 1;
            this.tabHorario.Text = "HORÁRIO";
            // 
            // btnCancelHorario
            // 
            this.btnCancelHorario.Location = new System.Drawing.Point(173, 20);
            this.btnCancelHorario.Name = "btnCancelHorario";
            this.btnCancelHorario.Size = new System.Drawing.Size(75, 23);
            this.btnCancelHorario.TabIndex = 23;
            this.btnCancelHorario.Text = "Cancelar";
            this.btnCancelHorario.UseVisualStyleBackColor = true;
            this.btnCancelHorario.Click += new System.EventHandler(this.btnCancelHorario_Click);
            // 
            // btnNovoHorario
            // 
            this.btnNovoHorario.Location = new System.Drawing.Point(68, 20);
            this.btnNovoHorario.Name = "btnNovoHorario";
            this.btnNovoHorario.Size = new System.Drawing.Size(75, 23);
            this.btnNovoHorario.TabIndex = 22;
            this.btnNovoHorario.Text = "Novo";
            this.btnNovoHorario.UseVisualStyleBackColor = true;
            this.btnNovoHorario.Click += new System.EventHandler(this.btnNovoHorario_Click);
            // 
            // btnPesquisarHorario
            // 
            this.btnPesquisarHorario.Location = new System.Drawing.Point(488, 20);
            this.btnPesquisarHorario.Name = "btnPesquisarHorario";
            this.btnPesquisarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarHorario.TabIndex = 21;
            this.btnPesquisarHorario.Text = "Pesquisar";
            this.btnPesquisarHorario.UseVisualStyleBackColor = true;
            this.btnPesquisarHorario.Click += new System.EventHandler(this.btnPesquisarHorario_Click);
            // 
            // btnExcluirHorario
            // 
            this.btnExcluirHorario.Location = new System.Drawing.Point(383, 20);
            this.btnExcluirHorario.Name = "btnExcluirHorario";
            this.btnExcluirHorario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirHorario.TabIndex = 20;
            this.btnExcluirHorario.Text = "Excluir";
            this.btnExcluirHorario.UseVisualStyleBackColor = true;
            this.btnExcluirHorario.Click += new System.EventHandler(this.btnExcluirHorario_Click);
            // 
            // btnSalvarHorario
            // 
            this.btnSalvarHorario.Location = new System.Drawing.Point(278, 20);
            this.btnSalvarHorario.Name = "btnSalvarHorario";
            this.btnSalvarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarHorario.TabIndex = 18;
            this.btnSalvarHorario.Text = "Salvar";
            this.btnSalvarHorario.UseVisualStyleBackColor = true;
            this.btnSalvarHorario.Click += new System.EventHandler(this.btnSalvarHorario_Click);
            // 
            // dataGridHorario
            // 
            this.dataGridHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDescricao,
            this.colEntrada,
            this.colSaida,
            this.colTolerancia});
            this.dataGridHorario.Location = new System.Drawing.Point(62, 177);
            this.dataGridHorario.Name = "dataGridHorario";
            this.dataGridHorario.ReadOnly = true;
            this.dataGridHorario.Size = new System.Drawing.Size(506, 150);
            this.dataGridHorario.TabIndex = 9;
            this.dataGridHorario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridHorario_CellMouseDoubleClick);
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "descricao";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 130;
            // 
            // colEntrada
            // 
            this.colEntrada.DataPropertyName = "entrada";
            this.colEntrada.HeaderText = "Hora Entrada";
            this.colEntrada.Name = "colEntrada";
            this.colEntrada.ReadOnly = true;
            this.colEntrada.Width = 110;
            // 
            // colSaida
            // 
            this.colSaida.DataPropertyName = "saida";
            this.colSaida.HeaderText = "Hora Saída";
            this.colSaida.Name = "colSaida";
            this.colSaida.ReadOnly = true;
            this.colSaida.Width = 110;
            // 
            // colTolerancia
            // 
            this.colTolerancia.DataPropertyName = "tolerancia";
            this.colTolerancia.HeaderText = "Tolerância";
            this.colTolerancia.Name = "colTolerancia";
            this.colTolerancia.ReadOnly = true;
            this.colTolerancia.Width = 110;
            // 
            // txbEntrada
            // 
            this.txbEntrada.Location = new System.Drawing.Point(139, 85);
            this.txbEntrada.Name = "txbEntrada";
            this.txbEntrada.Size = new System.Drawing.Size(230, 20);
            this.txbEntrada.TabIndex = 2;
            // 
            // txbSaida
            // 
            this.txbSaida.Location = new System.Drawing.Point(139, 110);
            this.txbSaida.Name = "txbSaida";
            this.txbSaida.Size = new System.Drawing.Size(230, 20);
            this.txbSaida.TabIndex = 3;
            // 
            // txbTolerancia
            // 
            this.txbTolerancia.Location = new System.Drawing.Point(139, 135);
            this.txbTolerancia.Name = "txbTolerancia";
            this.txbTolerancia.Size = new System.Drawing.Size(230, 20);
            this.txbTolerancia.TabIndex = 4;
            // 
            // lblTolerancia
            // 
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTolerancia.Location = new System.Drawing.Point(31, 142);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(85, 13);
            this.lblTolerancia.TabIndex = 5;
            this.lblTolerancia.Text = "TOLERANCIA";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(31, 117);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(44, 13);
            this.lblSaida.TabIndex = 4;
            this.lblSaida.Text = "SAIDA";
            // 
            // lblentrada
            // 
            this.lblentrada.AutoSize = true;
            this.lblentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentrada.Location = new System.Drawing.Point(31, 92);
            this.lblentrada.Name = "lblentrada";
            this.lblentrada.Size = new System.Drawing.Size(66, 13);
            this.lblentrada.TabIndex = 3;
            this.lblentrada.Text = "ENTRADA";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(139, 60);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(230, 20);
            this.txbDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(31, 67);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(78, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage4.Controls.Add(this.gbFuncionarioLista);
            this.tabPage4.Controls.Add(this.radioFuncionario);
            this.tabPage4.Controls.Add(this.radioIndividual);
            this.tabPage4.Controls.Add(this.radioPorDia);
            this.tabPage4.Controls.Add(this.btnImprimirRelatorio);
            this.tabPage4.Controls.Add(this.dtpDataFinal);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.dtpDataInicial);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.ForeColor = System.Drawing.Color.Green;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(667, 365);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "RELATÓRIO";
            // 
            // gbFuncionarioLista
            // 
            this.gbFuncionarioLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbFuncionarioLista.Controls.Add(this.lblNomeConsulta);
            this.gbFuncionarioLista.Controls.Add(this.dgRelatorioFuncionario);
            this.gbFuncionarioLista.Controls.Add(this.btnConsultaFuncionario);
            this.gbFuncionarioLista.Controls.Add(this.txbRelatorioFuncionario);
            this.gbFuncionarioLista.Location = new System.Drawing.Point(9, 101);
            this.gbFuncionarioLista.Name = "gbFuncionarioLista";
            this.gbFuncionarioLista.Size = new System.Drawing.Size(645, 210);
            this.gbFuncionarioLista.TabIndex = 23;
            this.gbFuncionarioLista.TabStop = false;
            this.gbFuncionarioLista.Text = "Funcionarios Lista";
            // 
            // lblNomeConsulta
            // 
            this.lblNomeConsulta.AutoSize = true;
            this.lblNomeConsulta.Location = new System.Drawing.Point(20, 29);
            this.lblNomeConsulta.Name = "lblNomeConsulta";
            this.lblNomeConsulta.Size = new System.Drawing.Size(109, 13);
            this.lblNomeConsulta.TabIndex = 20;
            this.lblNomeConsulta.Text = "Nome Funcionario";
            // 
            // dgRelatorioFuncionario
            // 
            this.dgRelatorioFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRelatorioFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRelatorioMatricula,
            this.colNomeConsulta});
            this.dgRelatorioFuncionario.Location = new System.Drawing.Point(37, 63);
            this.dgRelatorioFuncionario.Name = "dgRelatorioFuncionario";
            this.dgRelatorioFuncionario.ReadOnly = true;
            this.dgRelatorioFuncionario.Size = new System.Drawing.Size(570, 141);
            this.dgRelatorioFuncionario.TabIndex = 22;
            // 
            // btnConsultaFuncionario
            // 
            this.btnConsultaFuncionario.Location = new System.Drawing.Point(541, 24);
            this.btnConsultaFuncionario.Name = "btnConsultaFuncionario";
            this.btnConsultaFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaFuncionario.TabIndex = 19;
            this.btnConsultaFuncionario.Text = "Consulta";
            this.btnConsultaFuncionario.UseVisualStyleBackColor = true;
            this.btnConsultaFuncionario.Click += new System.EventHandler(this.btnConsultaFuncionario_Click);
            // 
            // txbRelatorioFuncionario
            // 
            this.txbRelatorioFuncionario.Location = new System.Drawing.Point(144, 26);
            this.txbRelatorioFuncionario.Name = "txbRelatorioFuncionario";
            this.txbRelatorioFuncionario.Size = new System.Drawing.Size(375, 20);
            this.txbRelatorioFuncionario.TabIndex = 21;
            // 
            // radioFuncionario
            // 
            this.radioFuncionario.AutoSize = true;
            this.radioFuncionario.Location = new System.Drawing.Point(527, 57);
            this.radioFuncionario.Name = "radioFuncionario";
            this.radioFuncionario.Size = new System.Drawing.Size(97, 17);
            this.radioFuncionario.TabIndex = 18;
            this.radioFuncionario.TabStop = true;
            this.radioFuncionario.Text = "Funcionarios";
            this.radioFuncionario.UseVisualStyleBackColor = true;
            this.radioFuncionario.CheckedChanged += new System.EventHandler(this.radioFuncionario_CheckedChanged);
            // 
            // radioIndividual
            // 
            this.radioIndividual.AutoSize = true;
            this.radioIndividual.Location = new System.Drawing.Point(420, 57);
            this.radioIndividual.Name = "radioIndividual";
            this.radioIndividual.Size = new System.Drawing.Size(80, 17);
            this.radioIndividual.TabIndex = 17;
            this.radioIndividual.TabStop = true;
            this.radioIndividual.Text = "Individual";
            this.radioIndividual.UseVisualStyleBackColor = true;
            this.radioIndividual.CheckedChanged += new System.EventHandler(this.radioIndividual_CheckedChanged);
            // 
            // radioPorDia
            // 
            this.radioPorDia.AutoSize = true;
            this.radioPorDia.Location = new System.Drawing.Point(321, 56);
            this.radioPorDia.Name = "radioPorDia";
            this.radioPorDia.Size = new System.Drawing.Size(67, 17);
            this.radioPorDia.TabIndex = 16;
            this.radioPorDia.TabStop = true;
            this.radioPorDia.Text = "Por Dia";
            this.radioPorDia.UseVisualStyleBackColor = true;
            this.radioPorDia.CheckedChanged += new System.EventHandler(this.radioPorDia_CheckedChanged);
            // 
            // btnImprimirRelatorio
            // 
            this.btnImprimirRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelatorio.Location = new System.Drawing.Point(234, 324);
            this.btnImprimirRelatorio.Name = "btnImprimirRelatorio";
            this.btnImprimirRelatorio.Size = new System.Drawing.Size(189, 28);
            this.btnImprimirRelatorio.TabIndex = 0;
            this.btnImprimirRelatorio.Text = "IMPRIMIR RELATÓTIO";
            this.btnImprimirRelatorio.UseVisualStyleBackColor = true;
            this.btnImprimirRelatorio.Click += new System.EventHandler(this.btnImprimirRelatorio_Click);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(172, 54);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(107, 20);
            this.dtpDataFinal.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data Final";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(33, 54);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(107, 20);
            this.dtpDataInicial.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data Inicial";
            // 
            // colRelatorioMatricula
            // 
            this.colRelatorioMatricula.DataPropertyName = "matricula";
            this.colRelatorioMatricula.HeaderText = "Matrícula";
            this.colRelatorioMatricula.Name = "colRelatorioMatricula";
            this.colRelatorioMatricula.ReadOnly = true;
            // 
            // colNomeConsulta
            // 
            this.colNomeConsulta.DataPropertyName = "nome";
            this.colNomeConsulta.HeaderText = "Funcionário";
            this.colNomeConsulta.Name = "colNomeConsulta";
            this.colNomeConsulta.ReadOnly = true;
            this.colNomeConsulta.Width = 400;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 397);
            this.Controls.Add(this.abasGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "RELÓGIO DE PONTO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.abasGeral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFametro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnNovaSenha.ResumeLayout(false);
            this.pnNovaSenha.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabFuncionario.ResumeLayout(false);
            this.tabFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionario)).EndInit();
            this.tabHorario.ResumeLayout(false);
            this.tabHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHorario)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gbFuncionarioLista.ResumeLayout(false);
            this.gbFuncionarioLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRelatorioFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl abasGeral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabFuncionario;
        private System.Windows.Forms.TabPage tabHorario;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.TextBox txbFuncionarioMatricula;
        private System.Windows.Forms.TextBox txbFuncionarioNome;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Panel pnNovaSenha;
        private System.Windows.Forms.DataGridView dataGridFuncionario;
        private System.Windows.Forms.Button btnNovoFuncionario;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnCancelarFuncionario;
        private System.Windows.Forms.Button btnSalvarFuncionario;
        private System.Windows.Forms.DataGridView dataGridHorario;
        private System.Windows.Forms.TextBox txbEntrada;
        private System.Windows.Forms.TextBox txbSaida;
        private System.Windows.Forms.TextBox txbTolerancia;
        private System.Windows.Forms.Label lblTolerancia;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label lblentrada;
        private System.Windows.Forms.Button btnNovoHorario;
        private System.Windows.Forms.Button btnPesquisarHorario;
        private System.Windows.Forms.Button btnExcluirHorario;
        private System.Windows.Forms.Button btnSalvarHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimirRelatorio;
        private System.Windows.Forms.DataGridView dgRelatorioFuncionario;
        private System.Windows.Forms.TextBox txbRelatorioFuncionario;
        private System.Windows.Forms.Label lblNomeConsulta;
        private System.Windows.Forms.Button btnConsultaFuncionario;
        private System.Windows.Forms.RadioButton radioFuncionario;
        private System.Windows.Forms.RadioButton radioIndividual;
        private System.Windows.Forms.RadioButton radioPorDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastraSenha;
        private System.Windows.Forms.MaskedTextBox txbSenhAdmin;
        private System.Windows.Forms.GroupBox gbFuncionarioLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTolerancia;
        private System.Windows.Forms.PictureBox picFametro;
        private System.Windows.Forms.Button btnCancelHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRelatorioMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeConsulta;

    }
}

