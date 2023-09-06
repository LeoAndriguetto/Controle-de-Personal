namespace Projeto_Academia
{
    partial class F_Login
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
            label1 = new Label();
            txt_user = new TextBox();
            label2 = new Label();
            txt_senha = new TextBox();
            btn_Logar = new Button();
            btn_Cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(12, 27);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(149, 23);
            txt_user.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(12, 71);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(149, 23);
            txt_senha.TabIndex = 3;
            // 
            // btn_Logar
            // 
            btn_Logar.Location = new Point(12, 100);
            btn_Logar.Name = "btn_Logar";
            btn_Logar.Size = new Size(149, 23);
            btn_Logar.TabIndex = 4;
            btn_Logar.Text = "Log in";
            btn_Logar.UseVisualStyleBackColor = true;
            btn_Logar.Click += btn_Logar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(12, 129);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(149, 23);
            btn_Cancelar.TabIndex = 5;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += button2_Click;
            // 
            // F_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(179, 169);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Logar);
            Controls.Add(txt_senha);
            Controls.Add(label2);
            Controls.Add(txt_user);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_Login";
            Load += F_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_user;
        private Label label2;
        private TextBox txt_senha;
        private Button btn_Logar;
        private Button btn_Cancelar;
    }
}