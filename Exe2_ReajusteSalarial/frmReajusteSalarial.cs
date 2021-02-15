using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2_ReajusteSalarial
{
    public partial class frmReajusteSalarial : Form
    {
        int numLinha = 0;


        public frmReajusteSalarial()
        {
            InitializeComponent();
        }

        private void ProcessarArquivos(string nomeArquivo)
        {
            string linhaLida;
            int codigo = 0;
            double salario = 0;
            double percentual = 0;
            double novoSalario = 0;

            var arquivo = new System.IO.StreamReader(@nomeArquivo);

            while ((linhaLida = arquivo.ReadLine()) != null)
            {
                var dadosLidos = linhaLida.Split(';');
                codigo = Convert.ToInt32(dadosLidos[0]);
                salario = Convert.ToDouble(dadosLidos[1]);
                percentual = GetPercentual(salario);
                novoSalario = salario * percentual + salario;

                dgvSalarios.Rows.Add();
                dgvSalarios[0, numLinha].Value = codigo.ToString();
                dgvSalarios[1, numLinha].Value = salario.ToString();
                dgvSalarios[2, numLinha].Value = percentual.ToString();
                dgvSalarios[3, numLinha].Value = novoSalario.ToString();

                numLinha++;
            }
        }

        private double GetPercentual(double salario)
        {
            double percentual = 0;

            if (salario < 1000)
            {
                percentual = 0.15;
            } 
            else if (salario <= 1500)
            {
                percentual = 0.10;
            } 
            else
            {
                percentual = 0.05;
            }


            return percentual;
        }

        private void TotalValores()
        {
            double totalComReajuste = 0;
            double totalSemReajuste = 0;
            double percentualReajuste = 0;

            for (int i = 0; i < numLinha; i++)
            {
                totalSemReajuste = totalSemReajuste + Convert.ToDouble(dgvSalarios[1, i].Value);
                totalComReajuste = totalComReajuste + Convert.ToDouble(dgvSalarios[3, i].Value);
            }

            percentualReajuste = (totalComReajuste - totalSemReajuste) * 100 / totalSemReajuste;

            lblTotalSemReajuste.Text = totalSemReajuste.ToString();
            lblTotalComReajuste.Text = totalComReajuste.ToString();
            lblPercentualReajuste.Text = percentualReajuste.ToString("N2");
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            if (ofdListaFuncionarios.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = ofdListaFuncionarios.FileName;
                ProcessarArquivos(txtArquivo.Text);
                TotalValores();
            }
        }
    }  
}
