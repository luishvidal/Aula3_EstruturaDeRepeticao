using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe_ConsumoDeEnergia
{
    public partial class frmConsumoEnergia_V1 : Form
    {
        int numLinha = 0;
        public frmConsumoEnergia_V1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!TemRegistroCasa(txtNCasa.Text, numLinha))
            {
                dgvLeituras.Rows.Add();
                dgvLeituras[0, numLinha].Value = txtNCasa.Text;
                dgvLeituras[1, numLinha].Value = txtConsumo.Text;
                dgvLeituras[2, numLinha].Value = (Convert.ToDouble(txtConsumo.Text) * 0.2).ToString();

                numLinha++;

                txtNCasa.Clear();
                txtConsumo.Clear();
                txtNCasa.Focus();
            }
            
        }
        private bool TemRegistroCasa(string casa, int numLinha)
        {
            bool registro = false;

            for (int i = 0; i < numLinha; i++)
            {
                if (dgvLeituras[0, i].Value.Equals(casa))
                {
                    MessageBox.Show("A leitura para essa casa já foi registrada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return registro;
        }

        private void ProcessarDados(int numLinha)
        {
            double totalConsumo = 0;
            double totalDesconto = 0;

            for (int i = 0; i < numLinha; i++)
            {
                totalConsumo = totalConsumo + Convert.ToDouble(dgvLeituras[1, i].Value);
                totalDesconto = totalDesconto + Convert.ToDouble(dgvLeituras[2, i].Value);
            }

            dgvLeituras[0, numLinha].Value = "Total";
            dgvLeituras[1, numLinha].Value = totalConsumo.ToString();
            dgvLeituras[2, numLinha].Value = totalDesconto.ToString();

            lblTotalConsumo.Text = "Total com Desconto: " + (totalConsumo - totalDesconto).ToString();
        }

        private void btnProcessarDados_Click(object sender, EventArgs e)
        {
            ProcessarDados(numLinha);
        }

    }
}
