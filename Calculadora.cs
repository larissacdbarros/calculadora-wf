using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            //conta de adição
            lblResulltado.Text = $"{it.Parse(txtNum1.Text) + int.Parse(txtNum2.Text)}";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            //subtraçao
            
            lblResulltado.Text = $"{int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text)}";
        }

        private void btnMultipli_Click(object sender, EventArgs e)
        {
            //multiplicacao
            lblResulltado.Text = $"{int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text)}";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            //divisao
            lblResulltado.Text = $"{double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text)}";

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
