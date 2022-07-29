namespace BancoVelhaCredi.formularios
{
    partial class Chaveacesso
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
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxSenhaLoginCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContaLoginCliente = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(12, 122);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(82, 23);
            this.buttonLimpar.TabIndex = 11;
            this.buttonLimpar.Text = "Sair";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click_1);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 93);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(82, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click_1);
            this.buttonOk.MouseLeave += new System.EventHandler(this.buttonOk_MouseLeave);
            this.buttonOk.MouseHover += new System.EventHandler(this.buttonOk_MouseHover);
            // 
            // textBoxSenhaLoginCliente
            // 
            this.textBoxSenhaLoginCliente.Location = new System.Drawing.Point(12, 67);
            this.textBoxSenhaLoginCliente.MaxLength = 6;
            this.textBoxSenhaLoginCliente.Name = "textBoxSenhaLoginCliente";
            this.textBoxSenhaLoginCliente.PasswordChar = '*';
            this.textBoxSenhaLoginCliente.Size = new System.Drawing.Size(82, 20);
            this.textBoxSenhaLoginCliente.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha";
            // 
            // textBoxContaLoginCliente
            // 
            this.textBoxContaLoginCliente.Location = new System.Drawing.Point(12, 25);
            this.textBoxContaLoginCliente.Name = "textBoxContaLoginCliente";
            this.textBoxContaLoginCliente.Size = new System.Drawing.Size(82, 20);
            this.textBoxContaLoginCliente.TabIndex = 7;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(12, 9);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(71, 13);
            this.labelid.TabIndex = 6;
            this.labelid.Text = "Intentificação";
            // 
            // Chaveacesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(114, 160);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxSenhaLoginCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxContaLoginCliente);
            this.Controls.Add(this.labelid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Chaveacesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chave de Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonLimpar;
        public System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.TextBox textBoxSenhaLoginCliente;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxContaLoginCliente;
        public System.Windows.Forms.Label labelid;
    }
}