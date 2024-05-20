namespace SistemaBanco
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastro_de_cliente = new System.Windows.Forms.GroupBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lista_de_cliente = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtvCliente = new System.Windows.Forms.DataGridView();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cadastro_de_cliente.SuspendLayout();
            this.Lista_de_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastro_de_cliente
            // 
            this.cadastro_de_cliente.Controls.Add(this.txt_telefone);
            this.cadastro_de_cliente.Controls.Add(this.txt_nome);
            this.cadastro_de_cliente.Controls.Add(this.txt_cpf);
            this.cadastro_de_cliente.Controls.Add(this.btn_cadastrar);
            this.cadastro_de_cliente.Controls.Add(this.label3);
            this.cadastro_de_cliente.Controls.Add(this.label2);
            this.cadastro_de_cliente.Controls.Add(this.label1);
            this.cadastro_de_cliente.Location = new System.Drawing.Point(12, 28);
            this.cadastro_de_cliente.Name = "cadastro_de_cliente";
            this.cadastro_de_cliente.Size = new System.Drawing.Size(273, 196);
            this.cadastro_de_cliente.TabIndex = 0;
            this.cadastro_de_cliente.TabStop = false;
            this.cadastro_de_cliente.Text = "Cadastro de cliente";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(81, 110);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(162, 20);
            this.txt_telefone.TabIndex = 6;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(81, 66);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(162, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(81, 28);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(162, 20);
            this.txt_cpf.TabIndex = 4;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(29, 153);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(214, 23);
            this.btn_cadastrar.TabIndex = 3;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // Lista_de_cliente
            // 
            this.Lista_de_cliente.Controls.Add(this.label4);
            this.Lista_de_cliente.Controls.Add(this.txtBuscar);
            this.Lista_de_cliente.Controls.Add(this.dtvCliente);
            this.Lista_de_cliente.Location = new System.Drawing.Point(12, 270);
            this.Lista_de_cliente.Name = "Lista_de_cliente";
            this.Lista_de_cliente.Size = new System.Drawing.Size(550, 242);
            this.Lista_de_cliente.TabIndex = 1;
            this.Lista_de_cliente.TabStop = false;
            this.Lista_de_cliente.Text = "Lista de clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(52, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(379, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // dtvCliente
            // 
            this.dtvCliente.AllowUserToAddRows = false;
            this.dtvCliente.AllowUserToDeleteRows = false;
            this.dtvCliente.AllowUserToOrderColumns = true;
            this.dtvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPF,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtvCliente.Location = new System.Drawing.Point(6, 45);
            this.dtvCliente.Name = "dtvCliente";
            this.dtvCliente.ReadOnly = true;
            this.dtvCliente.Size = new System.Drawing.Size(538, 191);
            this.dtvCliente.TabIndex = 0;
            // 
            // CPF
            // 
            this.CPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Telefone";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Editar";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Delete";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 524);
            this.Controls.Add(this.Lista_de_cliente);
            this.Controls.Add(this.cadastro_de_cliente);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.cadastro_de_cliente.ResumeLayout(false);
            this.cadastro_de_cliente.PerformLayout();
            this.Lista_de_cliente.ResumeLayout(false);
            this.Lista_de_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cadastro_de_cliente;
        private System.Windows.Forms.GroupBox Lista_de_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.DataGridView dtvCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}