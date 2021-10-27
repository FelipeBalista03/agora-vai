using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_principal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            txtCelular.Text += "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text += "";
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            txtCidade.Text += "";
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.Text += "";
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            txtCpf.Text += "";
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNascimento_TextChanged(object sender, EventArgs e)
        {
            txtNascimento.Text += "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtCelular.Text = "";
            txtNascimento.Text = "";
            comboBox1.Text = "";

        }
    }
}
