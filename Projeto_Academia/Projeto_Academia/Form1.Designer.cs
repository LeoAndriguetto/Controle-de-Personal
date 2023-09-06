namespace Projeto_Academia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lb_Usuario = new Label();
            Label_Acesso = new Label();
            lb_Acesso = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            manutençãoToolStripMenuItem = new ToolStripMenuItem();
            ms_Login = new ToolStripMenuItem();
            ms_Logoff = new ToolStripMenuItem();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            ambienteDoAlunoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            gestãoUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(lb_Usuario);
            panel1.Controls.Add(Label_Acesso);
            panel1.Controls.Add(lb_Acesso);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 408);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 0;
            // 
            // lb_Usuario
            // 
            lb_Usuario.AutoSize = true;
            lb_Usuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Usuario.Location = new Point(140, 15);
            lb_Usuario.Name = "lb_Usuario";
            lb_Usuario.Size = new Size(70, 15);
            lb_Usuario.TabIndex = 3;
            lb_Usuario.Text = "Usuário: ---";
            // 
            // Label_Acesso
            // 
            Label_Acesso.AutoSize = true;
            Label_Acesso.Location = new Point(108, 15);
            Label_Acesso.Name = "Label_Acesso";
            Label_Acesso.Size = new Size(13, 15);
            Label_Acesso.TabIndex = 2;
            Label_Acesso.Text = "0";
            // 
            // lb_Acesso
            // 
            lb_Acesso.AutoSize = true;
            lb_Acesso.BackColor = Color.Transparent;
            lb_Acesso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Acesso.Location = new Point(64, 15);
            lb_Acesso.Name = "lb_Acesso";
            lb_Acesso.Size = new Size(48, 15);
            lb_Acesso.TabIndex = 1;
            lb_Acesso.Text = "Acesso:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ledvermelho;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { manutençãoToolStripMenuItem, alunosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // manutençãoToolStripMenuItem
            // 
            manutençãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ms_Login, ms_Logoff });
            manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            manutençãoToolStripMenuItem.Size = new Size(54, 20);
            manutençãoToolStripMenuItem.Text = "LOGIN";
            // 
            // ms_Login
            // 
            ms_Login.Name = "ms_Login";
            ms_Login.Size = new Size(118, 22);
            ms_Login.Text = "LOGON";
            ms_Login.Click += ms_Login_Click;
            // 
            // ms_Logoff
            // 
            ms_Logoff.Name = "ms_Logoff";
            ms_Logoff.Size = new Size(118, 22);
            ms_Logoff.Text = "LOGOFF";
            ms_Logoff.Click += ms_Logoff_Click;
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ambienteDoAlunoToolStripMenuItem, cadastrarUsuárioToolStripMenuItem, gestãoUsuáriosToolStripMenuItem });
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(51, 20);
            alunosToolStripMenuItem.Text = "Aluno";
            // 
            // ambienteDoAlunoToolStripMenuItem
            // 
            ambienteDoAlunoToolStripMenuItem.Name = "ambienteDoAlunoToolStripMenuItem";
            ambienteDoAlunoToolStripMenuItem.Size = new Size(180, 22);
            ambienteDoAlunoToolStripMenuItem.Text = "Ambiente Do Aluno";
            ambienteDoAlunoToolStripMenuItem.Click += ambienteDoAlunoToolStripMenuItem_Click;
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            cadastrarUsuárioToolStripMenuItem.Size = new Size(180, 22);
            cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            // 
            // gestãoUsuáriosToolStripMenuItem
            // 
            gestãoUsuáriosToolStripMenuItem.Name = "gestãoUsuáriosToolStripMenuItem";
            gestãoUsuáriosToolStripMenuItem.Size = new Size(180, 22);
            gestãoUsuáriosToolStripMenuItem.Text = "Gestão Usuários";
            gestãoUsuáriosToolStripMenuItem.Click += gestãoUsuáriosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Bueno APP - v1.0";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lb_Acesso;
        public PictureBox pictureBox1;
        public Label Label_Acesso;
        public Label lb_Usuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem ms_Login;
        private ToolStripMenuItem ms_Logoff;
        private ToolStripMenuItem ambienteDoAlunoToolStripMenuItem;
        private ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private ToolStripMenuItem gestãoUsuáriosToolStripMenuItem;
    }
}