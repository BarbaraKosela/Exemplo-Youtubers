namespace ExemploYoutubers
{
    partial class ListaYoutubers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaYoutubers));
            this.btnEditarYoutuber = new System.Windows.Forms.Button();
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnApagarYoutuber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1NomeCanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1QuantidadedeInscritos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1QuantidadeDeVisu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarYoutuber
            // 
            this.btnEditarYoutuber.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditarYoutuber.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarYoutuber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarYoutuber.Location = new System.Drawing.Point(43, 66);
            this.btnEditarYoutuber.Name = "btnEditarYoutuber";
            this.btnEditarYoutuber.Size = new System.Drawing.Size(140, 36);
            this.btnEditarYoutuber.TabIndex = 24;
            this.btnEditarYoutuber.Text = "EDITAR";
            this.btnEditarYoutuber.UseVisualStyleBackColor = false;
            this.btnEditarYoutuber.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdicionarAluno.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarAluno.Location = new System.Drawing.Point(204, 66);
            this.btnAdicionarAluno.Name = "btnAdicionarAluno";
            this.btnAdicionarAluno.Size = new System.Drawing.Size(140, 36);
            this.btnAdicionarAluno.TabIndex = 23;
            this.btnAdicionarAluno.Text = "ADICIONAR";
            this.btnAdicionarAluno.UseVisualStyleBackColor = false;
            this.btnAdicionarAluno.Click += new System.EventHandler(this.btnAdicionarAluno_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1Codigo,
            this.Column1Nome,
            this.Column1NomeCanal,
            this.Column1Apelido,
            this.Column1QuantidadedeInscritos,
            this.Column1QuantidadeDeVisu});
            this.dataGridView1.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(536, 407);
            this.dataGridView1.TabIndex = 22;
            // 
            // btnApagarYoutuber
            // 
            this.btnApagarYoutuber.BackColor = System.Drawing.Color.DarkRed;
            this.btnApagarYoutuber.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarYoutuber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagarYoutuber.Location = new System.Drawing.Point(363, 66);
            this.btnApagarYoutuber.Name = "btnApagarYoutuber";
            this.btnApagarYoutuber.Size = new System.Drawing.Size(140, 36);
            this.btnApagarYoutuber.TabIndex = 21;
            this.btnApagarYoutuber.Text = "APAGAR";
            this.btnApagarYoutuber.UseVisualStyleBackColor = false;
            this.btnApagarYoutuber.Click += new System.EventHandler(this.btnApagarAluno_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Square721 BT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 45);
            this.label2.TabIndex = 26;
            this.label2.Text = "YOUTUBERS!";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 25;
            this.label1.Text = "LISTA DE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(408, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1Codigo
            // 
            this.Column1Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1Codigo.HeaderText = "Código";
            this.Column1Codigo.Name = "Column1Codigo";
            this.Column1Codigo.ReadOnly = true;
            // 
            // Column1Nome
            // 
            this.Column1Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1Nome.HeaderText = "Nome";
            this.Column1Nome.Name = "Column1Nome";
            this.Column1Nome.ReadOnly = true;
            // 
            // Column1NomeCanal
            // 
            this.Column1NomeCanal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1NomeCanal.HeaderText = "Nome do canal";
            this.Column1NomeCanal.Name = "Column1NomeCanal";
            this.Column1NomeCanal.ReadOnly = true;
            // 
            // Column1Apelido
            // 
            this.Column1Apelido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1Apelido.HeaderText = "Apelido";
            this.Column1Apelido.Name = "Column1Apelido";
            this.Column1Apelido.ReadOnly = true;
            // 
            // Column1QuantidadedeInscritos
            // 
            this.Column1QuantidadedeInscritos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1QuantidadedeInscritos.HeaderText = "Quantidade de inscritos";
            this.Column1QuantidadedeInscritos.Name = "Column1QuantidadedeInscritos";
            this.Column1QuantidadedeInscritos.ReadOnly = true;
            // 
            // Column1QuantidadeDeVisu
            // 
            this.Column1QuantidadeDeVisu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1QuantidadeDeVisu.HeaderText = "Quantidade de visualizações";
            this.Column1QuantidadeDeVisu.Name = "Column1QuantidadeDeVisu";
            this.Column1QuantidadeDeVisu.ReadOnly = true;
            // 
            // ListaYoutubers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 583);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditarYoutuber);
            this.Controls.Add(this.btnAdicionarAluno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnApagarYoutuber);
            this.Name = "ListaYoutubers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Youtubers";
            this.Activated += new System.EventHandler(this.ListaYoutubers_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarYoutuber;
        private System.Windows.Forms.Button btnAdicionarAluno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnApagarYoutuber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1NomeCanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1QuantidadedeInscritos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1QuantidadeDeVisu;
    }
}