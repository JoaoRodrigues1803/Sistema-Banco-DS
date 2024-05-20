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
    public partial class FormContainer : Form
    {
        public static Agencia agencia = new Agencia();


        public FormContainer()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FormCliente f_cliente = new FormCliente();
            f_cliente.MdiParent = this;
            f_cliente.Show();
        }
    }
}
