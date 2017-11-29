namespace Hospedaria.fdrLogin
{
    partial class frmRecuperaSenha
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label idrecuperaLabel;
            System.Windows.Forms.Label usernameLabel;
            this.txtPass = new System.Windows.Forms.TextBox();
            this.bAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtRecu = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbrecu = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            idrecuperaLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(4, 149);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 22);
            label1.TabIndex = 35;
            label1.Text = "Nova senha:";
            // 
            // idrecuperaLabel
            // 
            idrecuperaLabel.AutoSize = true;
            idrecuperaLabel.BackColor = System.Drawing.Color.Transparent;
            idrecuperaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idrecuperaLabel.Location = new System.Drawing.Point(14, 97);
            idrecuperaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idrecuperaLabel.Name = "idrecuperaLabel";
            idrecuperaLabel.Size = new System.Drawing.Size(97, 22);
            idrecuperaLabel.TabIndex = 28;
            idrecuperaLabel.Text = "Nº Secreto";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = System.Drawing.Color.Transparent;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(18, 42);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(97, 22);
            usernameLabel.TabIndex = 27;
            usernameLabel.Text = "Username:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(126, 142);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(148, 26);
            this.txtPass.TabIndex = 36;
            // 
            // bAlterar
            // 
            this.bAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlterar.Location = new System.Drawing.Point(357, 20);
            this.bAlterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(156, 58);
            this.bAlterar.TabIndex = 34;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = false;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(357, 125);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(156, 58);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtRecu
            // 
            this.txtRecu.Location = new System.Drawing.Point(126, 89);
            this.txtRecu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRecu.Name = "txtRecu";
            this.txtRecu.Size = new System.Drawing.Size(148, 26);
            this.txtRecu.TabIndex = 32;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(126, 34);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(148, 26);
            this.txtUser.TabIndex = 31;
            // 
            // lbrecu
            // 
            this.lbrecu.AutoSize = true;
            this.lbrecu.Location = new System.Drawing.Point(414, 52);
            this.lbrecu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbrecu.Name = "lbrecu";
            this.lbrecu.Size = new System.Drawing.Size(31, 20);
            this.lbrecu.TabIndex = 30;
            this.lbrecu.Text = "rec";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(375, 52);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(40, 20);
            this.lbUser.TabIndex = 29;
            this.lbUser.Text = "user";
            // 
            // frmRecuperaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(531, 214);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(label1);
            this.Controls.Add(this.bAlterar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtRecu);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(idrecuperaLabel);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.lbrecu);
            this.Controls.Add(this.lbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRecuperaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecuperaSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtRecu;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbrecu;
        private System.Windows.Forms.Label lbUser;
    }
}