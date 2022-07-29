namespace BancoVelhaCredi.formularios
{
    partial class buscaconta
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
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.textBoxconta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(5, 32);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(160, 20);
            this.textBoxnome.TabIndex = 9;
            // 
            // textBoxconta
            // 
            this.textBoxconta.Location = new System.Drawing.Point(5, 71);
            this.textBoxconta.Name = "textBoxconta";
            this.textBoxconta.Size = new System.Drawing.Size(160, 20);
            this.textBoxconta.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Conta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedTextBoxCpf);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe o CPF";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(6, 29);
            this.maskedTextBoxCpf.Mask = "000000000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(158, 20);
            this.maskedTextBoxCpf.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxnome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxconta);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado da Busca";
            this.groupBox2.Visible = false;
            // 
            // buscaconta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 151);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "buscaconta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Conta";
            this.Load += new System.EventHandler(this.buscaconta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.TextBox textBoxconta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}