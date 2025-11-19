namespace Finance_CRUD
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
            txtDescricao = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            cboTipo = new ComboBox();
            dtpData = new DateTimePicker();
            label2 = new Label();
            txtValor = new TextBox();
            label1 = new Label();
            btnSalvar = new Button();
            btnLimpar = new Button();
            groupBox2 = new GroupBox();
            dgvLancamentos = new DataGridView();
            btnExcluir = new Button();
            btnEditar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLancamentos).BeginInit();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(25, 47);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtDescricao.Size = new Size(356, 106);
            txtDescricao.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboTipo);
            groupBox1.Controls.Add(dtpData);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(143, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 316);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Lançamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 204);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 6;
            label3.Text = "Tipo:";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Entrada", "Saída" });
            cboTipo.Location = new Point(25, 230);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 26);
            cboTipo.TabIndex = 5;
            // 
            // dtpData
            // 
            dtpData.CalendarFont = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpData.CalendarMonthBackground = SystemColors.InactiveCaption;
            dtpData.Location = new Point(182, 179);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 22);
            dtpData.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 154);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 3;
            label2.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(25, 179);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(151, 22);
            txtValor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 1;
            label1.Text = "Descrição";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(25, 262);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(169, 28);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(212, 262);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(169, 28);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(dgvLancamentos);
            groupBox2.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(552, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 578);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Painel de Visualização";
            // 
            // dgvLancamentos
            // 
            dgvLancamentos.AllowUserToAddRows = false;
            dgvLancamentos.AllowUserToDeleteRows = false;
            dgvLancamentos.BackgroundColor = SystemColors.ButtonFace;
            dgvLancamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLancamentos.Location = new Point(17, 47);
            dgvLancamentos.MultiSelect = false;
            dgvLancamentos.Name = "dgvLancamentos";
            dgvLancamentos.ReadOnly = true;
            dgvLancamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLancamentos.Size = new Size(527, 451);
            dgvLancamentos.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(17, 520);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(234, 28);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(310, 520);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(234, 28);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 679);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Entrada";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLancamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDescricao;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dtpData;
        private Label label2;
        private TextBox txtValor;
        private Label label3;
        private ComboBox cboTipo;
        private Button btnLimpar;
        private Button btnSalvar;
        private GroupBox groupBox2;
        private Button btnExcluir;
        private DataGridView dgvLancamentos;
        private Button btnEditar;
    }
}
