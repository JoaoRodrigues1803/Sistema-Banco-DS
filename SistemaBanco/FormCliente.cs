using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBanco
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FormCliente f_cliente = new FormCliente();
            f_cliente.MdiParent = this;
            f_cliente.Show();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.cpf = txt_cpf.Text;
            cliente.nome = txt_nome.Text;
            cliente.telefone = txt_telefone.Text;

            bool result = FormContainer.agencia.addCliente(cliente);
            if (result)
            {
                MessageBox.Show("Cliente cadastrado com sucesso", "Info");
                txt_nome.Clear();
                txt_cpf.Clear();
                txt_telefone.Clear();
                txt_cpf.Focus();

                dtvCliente.Rows.Clear();
                foreach(Cliente c in FormContainer.agencia.exibirClientes())
                {
                    dtvCliente.Rows.Add(c.cpf, c.nome, c.telefone);
                }
            }
            else
            {
                MessageBox.Show(FormContainer.agencia.erro, "Info");
            }
        }
    }
}
