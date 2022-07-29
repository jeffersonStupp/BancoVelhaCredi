namespace BancoVelhaCredi.formularios
{
    partial class Login_cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSenhaLoginCliente = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxContaLoginCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // textBoxSenhaLoginCliente
            // 
            this.textBoxSenhaLoginCliente.Location = new System.Drawing.Point(16, 64);
            this.textBoxSenhaLoginCliente.MaxLength = 6;
            this.textBoxSenhaLoginCliente.Name = "textBoxSenhaLoginCliente";
            this.textBoxSenhaLoginCliente.PasswordChar = '*';
            this.textBoxSenhaLoginCliente.Size = new System.Drawing.Size(82, 20);
            this.textBoxSenhaLoginCliente.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(16, 90);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(82, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(16, 119);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(82, 23);
            this.buttonLimpar.TabIndex = 5;
            this.buttonLimpar.Text = "Sair";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 151);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueci minha conta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxContaLoginCliente
            // 
            this.textBoxContaLoginCliente.Location = new System.Drawing.Point(16, 25);
            this.textBoxContaLoginCliente.Name = "textBoxContaLoginCliente";
            this.textBoxContaLoginCliente.Size = new System.Drawing.Size(82, 20);
            this.textBoxContaLoginCliente.TabIndex = 1;
            // 
            // Login_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(103, 174);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxSenhaLoginCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxContaLoginCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login_cliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxSenhaLoginCliente;
        public System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox textBoxContaLoginCliente;
    }
}