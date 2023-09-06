namespace Projeto_Academia
{
    partial class GestaoUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_Salvar = new Button();
            btn_Excluir = new Button();
            btn_NovoUsuario = new Button();
            dgv_Usuarios = new DataGridView();
            label7 = new Label();
            label10 = new Label();
            label2 = new Label();
            label4 = new Label();
            txt_FirstName = new TextBox();
            txt_LastName = new TextBox();
            txt_Responsavel = new TextBox();
            label9 = new Label();
            txt_Email = new TextBox();
            txt_Telefone = new TextBox();
            label6 = new Label();
            txt_TipoContrato = new TextBox();
            label5 = new Label();
            label8 = new Label();
            txt_ValorMensal = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txt_ID = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Usuarios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Salvar);
            panel1.Controls.Add(btn_Excluir);
            panel1.Controls.Add(btn_NovoUsuario);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 476);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 0;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Cursor = Cursors.Hand;
            btn_Salvar.Location = new Point(598, 0);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(202, 25);
            btn_Salvar.TabIndex = 1;
            btn_Salvar.Text = "Salvar Alterações";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Cursor = Cursors.Hand;
            btn_Excluir.Location = new Point(303, -1);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(190, 26);
            btn_Excluir.TabIndex = 2;
            btn_Excluir.Text = "Excluir Aluno";
            btn_Excluir.UseVisualStyleBackColor = true;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // btn_NovoUsuario
            // 
            btn_NovoUsuario.Cursor = Cursors.Hand;
            btn_NovoUsuario.Location = new Point(0, 0);
            btn_NovoUsuario.Name = "btn_NovoUsuario";
            btn_NovoUsuario.Size = new Size(200, 25);
            btn_NovoUsuario.TabIndex = 0;
            btn_NovoUsuario.Text = "Novo Aluno";
            btn_NovoUsuario.UseVisualStyleBackColor = true;
            btn_NovoUsuario.Click += btn_NovoUsuario_Click;
            // 
            // dgv_Usuarios
            // 
            dgv_Usuarios.AllowUserToAddRows = false;
            dgv_Usuarios.AllowUserToDeleteRows = false;
            dgv_Usuarios.AllowUserToResizeColumns = false;
            dgv_Usuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Usuarios.EnableHeadersVisualStyles = false;
            dgv_Usuarios.Location = new Point(303, 12);
            dgv_Usuarios.MultiSelect = false;
            dgv_Usuarios.Name = "dgv_Usuarios";
            dgv_Usuarios.ReadOnly = true;
            dgv_Usuarios.RowHeadersVisible = false;
            dgv_Usuarios.RowTemplate.Height = 25;
            dgv_Usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Usuarios.Size = new Size(497, 447);
            dgv_Usuarios.TabIndex = 1;
            dgv_Usuarios.SelectionChanged += dgv_Usuarios_SelectionChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(288, -98);
            label7.Name = "label7";
            label7.Size = new Size(224, 28);
            label7.TabIndex = 4;
            label7.Text = "Informações Do Aluno";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 19);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 0;
            label10.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Sobrenome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 3;
            label4.Text = "Nome Do Responsável:";
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(12, 37);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(169, 23);
            txt_FirstName.TabIndex = 4;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(12, 92);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(169, 23);
            txt_LastName.TabIndex = 5;
            // 
            // txt_Responsavel
            // 
            txt_Responsavel.Location = new Point(12, 146);
            txt_Responsavel.Name = "txt_Responsavel";
            txt_Responsavel.Size = new Size(169, 23);
            txt_Responsavel.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 181);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 8;
            label9.Text = "Endereço De Email:";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(12, 199);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(169, 23);
            txt_Email.TabIndex = 9;
            // 
            // txt_Telefone
            // 
            txt_Telefone.Location = new Point(12, 253);
            txt_Telefone.Name = "txt_Telefone";
            txt_Telefone.Size = new Size(169, 23);
            txt_Telefone.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 235);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "Telefone:";
            // 
            // txt_TipoContrato
            // 
            txt_TipoContrato.Location = new Point(12, 307);
            txt_TipoContrato.Name = "txt_TipoContrato";
            txt_TipoContrato.Size = new Size(169, 23);
            txt_TipoContrato.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 347);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 10;
            label5.Text = "Valor Mensal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 289);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 14;
            label8.Text = "Modalidade:";
            // 
            // txt_ValorMensal
            // 
            txt_ValorMensal.Location = new Point(12, 365);
            txt_ValorMensal.Name = "txt_ValorMensal";
            txt_ValorMensal.Size = new Size(169, 23);
            txt_ValorMensal.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_ID);
            groupBox1.Controls.Add(txt_ValorMensal);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_TipoContrato);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_Telefone);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_Responsavel);
            groupBox1.Controls.Add(txt_LastName);
            groupBox1.Controls.Add(txt_FirstName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 447);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 400);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(12, 418);
            txt_ID.Name = "txt_ID";
            txt_ID.ReadOnly = true;
            txt_ID.Size = new Size(54, 23);
            txt_ID.TabIndex = 16;
            // 
            // GestaoUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(dgv_Usuarios);
            Controls.Add(panel1);
            Name = "GestaoUser";
            Load += GestaoUser_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Usuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button btn_Excluir;
        private Button btn_Salvar;
        private Button btn_NovoUsuario;
        private DataGridView dgv_Usuarios;
        private Label label7;
        private Label label10;
        private Label label2;
        private Label label4;
        private TextBox txt_FirstName;
        private TextBox txt_LastName;
        private TextBox txt_Responsavel;
        private Label label9;
        private TextBox txt_Email;
        private TextBox txt_Telefone;
        private Label label6;
        private TextBox txt_TipoContrato;
        private Label label5;
        private Label label8;
        private TextBox txt_ValorMensal;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txt_ID;
    }
}