namespace CadastroManager
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PainelBtn = new System.Windows.Forms.Panel();
            this.PainelEmpresa = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Remover = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.AplicarMudanca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbQueryCpf = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TbNumEnd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TbLograd = new System.Windows.Forms.TextBox();
            this.TbTelef = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TbEstado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TbCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbBairro = new System.Windows.Forms.TextBox();
            this.TbTelefEnd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbCPF = new System.Windows.Forms.TextBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PainelBtn.SuspendLayout();
            this.PainelEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check.png");
            this.imageList1.Images.SetKeyName(1, "white-cross-icon-26.jpg");
            // 
            // PainelBtn
            // 
            this.PainelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.PainelBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelBtn.Controls.Add(this.PainelEmpresa);
            this.PainelBtn.Controls.Add(this.Adicionar);
            this.PainelBtn.Controls.Add(this.Editar);
            this.PainelBtn.Controls.Add(this.Remover);
            this.PainelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelBtn.Location = new System.Drawing.Point(0, 0);
            this.PainelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PainelBtn.Name = "PainelBtn";
            this.PainelBtn.Size = new System.Drawing.Size(161, 469);
            this.PainelBtn.TabIndex = 0;
            // 
            // PainelEmpresa
            // 
            this.PainelEmpresa.Controls.Add(this.label2);
            this.PainelEmpresa.Controls.Add(this.pictureBox2);
            this.PainelEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelEmpresa.Location = new System.Drawing.Point(0, 0);
            this.PainelEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.PainelEmpresa.Name = "PainelEmpresa";
            this.PainelEmpresa.Size = new System.Drawing.Size(159, 120);
            this.PainelEmpresa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadastramento";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Adicionar
            // 
            this.Adicionar.BackColor = System.Drawing.Color.Transparent;
            this.Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adicionar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar.ForeColor = System.Drawing.Color.LightGray;
            this.Adicionar.Image = ((System.Drawing.Image)(resources.GetObject("Adicionar.Image")));
            this.Adicionar.Location = new System.Drawing.Point(10, 238);
            this.Adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(138, 45);
            this.Adicionar.TabIndex = 1;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Adicionar.UseVisualStyleBackColor = false;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.Transparent;
            this.Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.ForeColor = System.Drawing.Color.LightGray;
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Location = new System.Drawing.Point(10, 138);
            this.Editar.Margin = new System.Windows.Forms.Padding(2);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(138, 45);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Editar";
            this.Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Remover
            // 
            this.Remover.BackColor = System.Drawing.Color.Transparent;
            this.Remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remover.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remover.ForeColor = System.Drawing.Color.LightGray;
            this.Remover.Image = ((System.Drawing.Image)(resources.GetObject("Remover.Image")));
            this.Remover.Location = new System.Drawing.Point(10, 341);
            this.Remover.Margin = new System.Windows.Forms.Padding(2);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(138, 45);
            this.Remover.TabIndex = 1;
            this.Remover.Text = "Remover";
            this.Remover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Remover.UseVisualStyleBackColor = false;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.Transparent;
            this.Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.ForeColor = System.Drawing.Color.LightGray;
            this.Consultar.Image = ((System.Drawing.Image)(resources.GetObject("Consultar.Image")));
            this.Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultar.Location = new System.Drawing.Point(424, 51);
            this.Consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Consultar.Size = new System.Drawing.Size(163, 38);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar";
            this.Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(this.AplicarMudanca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Consultar);
            this.panel1.Controls.Add(this.TbQueryCpf);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TbNumEnd);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TbLograd);
            this.panel1.Controls.Add(this.TbTelef);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.TbEstado);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.TbCidade);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TbBairro);
            this.panel1.Controls.Add(this.TbTelefEnd);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TbEmail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TbCPF);
            this.panel1.Controls.Add(this.TbNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(165, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 448);
            this.panel1.TabIndex = 1;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.LightGray;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimize.Location = new System.Drawing.Point(691, 4);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.Minimize.Name = "Minimize";
            this.Minimize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 31;
            this.Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.Color.LightGray;
            this.Quit.Image = ((System.Drawing.Image)(resources.GetObject("Quit.Image")));
            this.Quit.Location = new System.Drawing.Point(725, 4);
            this.Quit.Margin = new System.Windows.Forms.Padding(2);
            this.Quit.Name = "Quit";
            this.Quit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Quit.Size = new System.Drawing.Size(30, 30);
            this.Quit.TabIndex = 30;
            this.Quit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // AplicarMudanca
            // 
            this.AplicarMudanca.BackColor = System.Drawing.Color.Transparent;
            this.AplicarMudanca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AplicarMudanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AplicarMudanca.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AplicarMudanca.ForeColor = System.Drawing.Color.LightGray;
            this.AplicarMudanca.Image = ((System.Drawing.Image)(resources.GetObject("AplicarMudanca.Image")));
            this.AplicarMudanca.Location = new System.Drawing.Point(265, 400);
            this.AplicarMudanca.Margin = new System.Windows.Forms.Padding(2);
            this.AplicarMudanca.Name = "AplicarMudanca";
            this.AplicarMudanca.Size = new System.Drawing.Size(188, 46);
            this.AplicarMudanca.TabIndex = 2;
            this.AplicarMudanca.Text = "Aplicar";
            this.AplicarMudanca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AplicarMudanca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AplicarMudanca.UseVisualStyleBackColor = false;
            this.AplicarMudanca.Click += new System.EventHandler(this.AplicarMudanca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar CPF:";
            // 
            // TbQueryCpf
            // 
            this.TbQueryCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbQueryCpf.Location = new System.Drawing.Point(24, 58);
            this.TbQueryCpf.Margin = new System.Windows.Forms.Padding(2);
            this.TbQueryCpf.Name = "TbQueryCpf";
            this.TbQueryCpf.Size = new System.Drawing.Size(384, 27);
            this.TbQueryCpf.TabIndex = 29;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 26);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(592, 74);
            this.dataGridView2.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cadastro:";
            // 
            // TbNumEnd
            // 
            this.TbNumEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNumEnd.Location = new System.Drawing.Point(25, 302);
            this.TbNumEnd.Margin = new System.Windows.Forms.Padding(2);
            this.TbNumEnd.Name = "TbNumEnd";
            this.TbNumEnd.Size = new System.Drawing.Size(120, 27);
            this.TbNumEnd.TabIndex = 25;
            this.TbNumEnd.Text = "210000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(22, 282);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 22);
            this.label14.TabIndex = 24;
            this.label14.Text = "Número:";
            // 
            // TbLograd
            // 
            this.TbLograd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLograd.Location = new System.Drawing.Point(25, 252);
            this.TbLograd.Margin = new System.Windows.Forms.Padding(2);
            this.TbLograd.Name = "TbLograd";
            this.TbLograd.Size = new System.Drawing.Size(692, 27);
            this.TbLograd.TabIndex = 23;
            // 
            // TbTelef
            // 
            this.TbTelef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTelef.Location = new System.Drawing.Point(523, 202);
            this.TbTelef.Margin = new System.Windows.Forms.Padding(2);
            this.TbTelef.Name = "TbTelef";
            this.TbTelef.Size = new System.Drawing.Size(194, 27);
            this.TbTelef.TabIndex = 22;
            this.TbTelef.Text = "+55 11 94593-4443";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(519, 178);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 22);
            this.label15.TabIndex = 20;
            this.label15.Text = "Telefone Pessoal:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(22, 228);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 22);
            this.label16.TabIndex = 21;
            this.label16.Text = "Logradouro:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbEstado
            // 
            this.TbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEstado.Location = new System.Drawing.Point(523, 354);
            this.TbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.TbEstado.Name = "TbEstado";
            this.TbEstado.Size = new System.Drawing.Size(194, 27);
            this.TbEstado.TabIndex = 16;
            this.TbEstado.Text = "Rio Grande do Norte";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(519, 331);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 22);
            this.label12.TabIndex = 14;
            this.label12.Text = "Estado:";
            // 
            // TbCidade
            // 
            this.TbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCidade.Location = new System.Drawing.Point(25, 354);
            this.TbCidade.Margin = new System.Windows.Forms.Padding(2);
            this.TbCidade.Name = "TbCidade";
            this.TbCidade.Size = new System.Drawing.Size(486, 27);
            this.TbCidade.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cidade";
            // 
            // TbBairro
            // 
            this.TbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbBairro.Location = new System.Drawing.Point(162, 302);
            this.TbBairro.Margin = new System.Windows.Forms.Padding(2);
            this.TbBairro.Name = "TbBairro";
            this.TbBairro.Size = new System.Drawing.Size(349, 27);
            this.TbBairro.TabIndex = 11;
            // 
            // TbTelefEnd
            // 
            this.TbTelefEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTelefEnd.Location = new System.Drawing.Point(523, 302);
            this.TbTelefEnd.Margin = new System.Windows.Forms.Padding(2);
            this.TbTelefEnd.Name = "TbTelefEnd";
            this.TbTelefEnd.Size = new System.Drawing.Size(194, 27);
            this.TbTelefEnd.TabIndex = 10;
            this.TbTelefEnd.Text = "+55 11 94593-4443";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(519, 282);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefone Endereço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(158, 281);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Bairro:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbEmail
            // 
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.Location = new System.Drawing.Point(24, 202);
            this.TbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(487, 27);
            this.TbEmail.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail:";
            // 
            // TbCPF
            // 
            this.TbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCPF.Location = new System.Drawing.Point(523, 149);
            this.TbCPF.Margin = new System.Windows.Forms.Padding(2);
            this.TbCPF.Name = "TbCPF";
            this.TbCPF.Size = new System.Drawing.Size(194, 27);
            this.TbCPF.TabIndex = 4;
            this.TbCPF.Text = "454.599.928-00";
            // 
            // TbNome
            // 
            this.TbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNome.Location = new System.Drawing.Point(24, 149);
            this.TbNome.Margin = new System.Windows.Forms.Padding(2);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(487, 27);
            this.TbNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(519, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPF";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 128);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 268);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PainelBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Stock Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PainelBtn.ResumeLayout(false);
            this.PainelEmpresa.ResumeLayout(false);
            this.PainelEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel PainelBtn;
        private System.Windows.Forms.Panel PainelEmpresa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TbCPF;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbQueryCpf;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbNumEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbLograd;
        private System.Windows.Forms.TextBox TbTelef;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TbEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TbCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbBairro;
        private System.Windows.Forms.TextBox TbTelefEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.Button AplicarMudanca;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Minimize;
    }
}

