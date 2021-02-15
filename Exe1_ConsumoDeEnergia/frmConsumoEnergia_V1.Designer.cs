namespace Exe_ConsumoDeEnergia
{
    partial class frmConsumoEnergia_V1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNCasa = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnProcessarDados = new System.Windows.Forms.Button();
            this.lblTotalConsumo = new System.Windows.Forms.Label();
            this.dgvLeituras = new System.Windows.Forms.DataGridView();
            this.Casa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° da Casa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumo:";
            // 
            // txtNCasa
            // 
            this.txtNCasa.Location = new System.Drawing.Point(79, 20);
            this.txtNCasa.Name = "txtNCasa";
            this.txtNCasa.Size = new System.Drawing.Size(100, 20);
            this.txtNCasa.TabIndex = 2;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(255, 20);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo.TabIndex = 3;
            // 
            // btnProcessarDados
            // 
            this.btnProcessarDados.Location = new System.Drawing.Point(12, 281);
            this.btnProcessarDados.Name = "btnProcessarDados";
            this.btnProcessarDados.Size = new System.Drawing.Size(100, 23);
            this.btnProcessarDados.TabIndex = 4;
            this.btnProcessarDados.Text = "Processar Dados";
            this.btnProcessarDados.UseVisualStyleBackColor = true;
            this.btnProcessarDados.Click += new System.EventHandler(this.btnProcessarDados_Click);
            // 
            // lblTotalConsumo
            // 
            this.lblTotalConsumo.AutoSize = true;
            this.lblTotalConsumo.Location = new System.Drawing.Point(229, 291);
            this.lblTotalConsumo.Name = "lblTotalConsumo";
            this.lblTotalConsumo.Size = new System.Drawing.Size(106, 13);
            this.lblTotalConsumo.TabIndex = 5;
            this.lblTotalConsumo.Text = "Total com Desconto:";
            // 
            // dgvLeituras
            // 
            this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeituras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Casa,
            this.Consumo,
            this.Desconto});
            this.dgvLeituras.Location = new System.Drawing.Point(12, 103);
            this.dgvLeituras.Name = "dgvLeituras";
            this.dgvLeituras.Size = new System.Drawing.Size(345, 161);
            this.dgvLeituras.TabIndex = 6;
            // 
            // Casa
            // 
            this.Casa.HeaderText = "Casa";
            this.Casa.Name = "Casa";
            // 
            // Consumo
            // 
            this.Consumo.HeaderText = "Consumo";
            this.Consumo.Name = "Consumo";
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(147, 61);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmConsumoEnergia_V1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 315);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvLeituras);
            this.Controls.Add(this.lblTotalConsumo);
            this.Controls.Add(this.btnProcessarDados);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtNCasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConsumoEnergia_V1";
            this.Text = "Consumo de Energia de um Condomínio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNCasa;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnProcessarDados;
        private System.Windows.Forms.Label lblTotalConsumo;
        private System.Windows.Forms.DataGridView dgvLeituras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Casa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

