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
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnApagarAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1NomeCanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1QuantidadedeInscritos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1QuantidadeDeVisu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditarAluno.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarAluno.Location = new System.Drawing.Point(17, 66);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(140, 36);
            this.btnEditarAluno.TabIndex = 24;
            this.btnEditarAluno.Text = "EDITAR";
            this.btnEditarAluno.UseVisualStyleBackColor = false;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdicionarAluno.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarAluno.Location = new System.Drawing.Point(178, 66);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1Nome,
            this.Column1NomeCanal,
            this.Column1Apelido,
            this.Column1QuantidadedeInscritos,
            this.Column1QuantidadeDeVisu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 407);
            this.dataGridView1.TabIndex = 22;
            // 
            // btnApagarAluno
            // 
            this.btnApagarAluno.BackColor = System.Drawing.Color.DarkRed;
            this.btnApagarAluno.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagarAluno.Location = new System.Drawing.Point(337, 66);
            this.btnApagarAluno.Name = "btnApagarAluno";
            this.btnApagarAluno.Size = new System.Drawing.Size(140, 36);
            this.btnApagarAluno.TabIndex = 21;
            this.btnApagarAluno.Text = "APAGAR";
            this.btnApagarAluno.UseVisualStyleBackColor = false;
            this.btnApagarAluno.Click += new System.EventHandler(this.btnApagarAluno_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Square721 BT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(210, 9);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 25;
            this.label1.Text = "LISTA DE";
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
            this.ClientSize = new System.Drawing.Size(497, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.btnAdicionarAluno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnApagarAluno);
            this.Name = "ListaYoutubers";
            this.Text = "ListaYoutubers";
            this.Activated += new System.EventHandler(this.ListaYoutubers_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnAdicionarAluno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnApagarAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1NomeCanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1QuantidadedeInscritos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1QuantidadeDeVisu;
    }
}