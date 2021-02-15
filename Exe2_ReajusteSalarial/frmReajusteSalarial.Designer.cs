namespace Exe2_ReajusteSalarial
{
    partial class frmReajusteSalarial
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
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPercentualReajuste = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSalarios = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NovoSalário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(13, 12);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(491, 20);
            this.txtArquivo.TabIndex = 0;
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(547, 12);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirArquivo.TabIndex = 1;
            this.btnAbrirArquivo.Text = "...";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPercentualReajuste);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTotalComReajuste);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTotalSemReajuste);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 100);
            this.panel1.TabIndex = 2;
            // 
            // lblPercentualReajuste
            // 
            this.lblPercentualReajuste.AutoSize = true;
            this.lblPercentualReajuste.Location = new System.Drawing.Point(558, 38);
            this.lblPercentualReajuste.Name = "lblPercentualReajuste";
            this.lblPercentualReajuste.Size = new System.Drawing.Size(40, 17);
            this.lblPercentualReajuste.TabIndex = 5;
            this.lblPercentualReajuste.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Percentual de Reajuste";
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.AutoSize = true;
            this.lblTotalComReajuste.Location = new System.Drawing.Point(322, 38);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(40, 17);
            this.lblTotalComReajuste.TabIndex = 3;
            this.lblTotalComReajuste.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total com Reajuste";
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.AutoSize = true;
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(123, 38);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(40, 17);
            this.lblTotalSemReajuste.TabIndex = 1;
            this.lblTotalSemReajuste.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total sem Reajuste";
            // 
            // dgvSalarios
            // 
            this.dgvSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Salário,
            this.Percentual,
            this.NovoSalário});
            this.dgvSalarios.Location = new System.Drawing.Point(12, 179);
            this.dgvSalarios.Name = "dgvSalarios";
            this.dgvSalarios.Size = new System.Drawing.Size(610, 233);
            this.dgvSalarios.TabIndex = 3;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Salário
            // 
            this.Salário.HeaderText = "Salário";
            this.Salário.Name = "Salário";
            // 
            // Percentual
            // 
            this.Percentual.HeaderText = "Percentual";
            this.Percentual.Name = "Percentual";
            // 
            // NovoSalário
            // 
            this.NovoSalário.HeaderText = "Novo Salário";
            this.NovoSalário.Name = "NovoSalário";
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "Carregar arquivo";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do Arquivo ";
            // 
            // frmReajusteSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 428);
            this.Controls.Add(this.dgvSalarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Name = "frmReajusteSalarial";
            this.Text = "Reajuste Salarial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPercentualReajuste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalComReajuste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSalarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn NovoSalário;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
    }
}

