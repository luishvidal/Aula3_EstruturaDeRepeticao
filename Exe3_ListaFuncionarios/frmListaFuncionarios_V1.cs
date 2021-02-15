using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_ListaFuncionarios
{
    public partial class frmListaFuncionarios_V1 : Form
    {
        public frmListaFuncionarios_V1()
        {
            InitializeComponent();
            dgvFuncionarios.ColumnCount = 2;
            dgvFuncionarios.Columns[0].HeaderText = "Nome";
            dgvFuncionarios.Columns[0].Width = 230;
            dgvFuncionarios.Columns[1].HeaderText = "Salário";
            dgvFuncionarios.Columns[0].Width = 100;
        }

        private void btnCriarLinhas_Click(object sender, EventArgs e)
        {
            int numFuncionarios = Convert.ToInt32(txtNumFuncionarios.Text);

            int i = 0;

            do
            {
                dgvFuncionarios.Rows.Add();
                dgvFuncionarios[0, i].Value = String.Empty;
                dgvFuncionarios[1, i].Value = "0";
                i++;
            } while (i < numFuncionarios);

            txtNumFuncionarios.Enabled = false;
            btnCriarLinhas.Enabled = false;
            btnCriarArquivo.Enabled = true;
            btnReiniciar.Enabled = true;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.Rows.Clear();
            txtNumFuncionarios.Text = string.Empty;
            txtNumFuncionarios.Enabled = true;
            btnCriarLinhas.Enabled = true;
            btnCriarArquivo.Enabled = false;
            btnReiniciar.Enabled = false;
        }

        private void GerarArquivo()
        {
            StreamWriter wr = new StreamWriter(sfdSalvarArquivo.FileName, true);

            for (int i = 0; i < dgvFuncionarios.Rows.Count - 1; i++)
            {
                wr.WriteLine(dgvFuncionarios[0, i].Value.ToString() + ";" + dgvFuncionarios[1, i].Value.ToString());
            }

            wr.Close();
        }

        private bool ValidaDados()
        {
            bool dadosValidos = true;
            int i = 0;
            double d;

            do
            {
                if (string.IsNullOrWhiteSpace(dgvFuncionarios[0, i].Value.ToString()))
                    dadosValidos = false;

                if (!Double.TryParse(dgvFuncionarios[1, i].Value.ToString(), out d))
                    dadosValidos = false;

                i++;

            } while (i < dgvFuncionarios.Rows.Count - 1);

            return dadosValidos;
        }

        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            if (!ValidaDados())
            {
                MessageBox.Show("Os dados possuem problemas. Verifique se você não deixou nenhum nome em branco ou se existe um valor correto para os salários de cada um!");
            } else if (sfdSalvarArquivo.ShowDialog() == DialogResult.OK) 
            {
                GerarArquivo();
                MessageBox.Show("Arquivo gerado com sucesso");
            }
        }
    }
}
