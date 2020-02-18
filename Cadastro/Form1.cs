using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
            DialogResult dialogResult = MessageBox.Show("Deseja criar um novo resgistro" + "?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        public void limpaCampos()
        {
            txtNome.Text = "";
            txtNascimento.Text = "";
            txtCPF.Text = "";
            comboBoxSexo.Text = "";
            dataGridView.Rows.Clear();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja gravar o Cliente com o CPF: " + txtCPF.Text + "?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o Cliente com o CPF: " + txtCPF.Text + "?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
