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
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(84, 92);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 35;
            label1.Text = "Nova senha:";
            // 
            // bAlterar
            // 
            this.bAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlterar.Location = new System.Drawing.Point(238, 13);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(104, 38);
            this.bAlterar.TabIndex = 34;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(238, 81);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 38);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtRecu
            // 
            this.txtRecu.Location = new System.Drawing.Point(84, 58);
            this.txtRecu.Name = "txtRecu";
            this.txtRecu.Size = new System.Drawing.Size(100, 20);
            this.txtRecu.TabIndex = 32;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(84, 22);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 31;
            // 
            // idrecuperaLabel
            // 
            idrecuperaLabel.AutoSize = true;
            idrecuperaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idrecuperaLabel.Location = new System.Drawing.Point(9, 63);
            idrecuperaLabel.Name = "idrecuperaLabel";
            idrecuperaLabel.Size = new System.Drawing.Size(65, 15);
            idrecuperaLabel.TabIndex = 28;
            idrecuperaLabel.Text = "Nº Secreto";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(12, 27);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(68, 15);
            usernameLabel.TabIndex = 27;
            usernameLabel.Text = "Username:";
            // 
            // lbrecu
            // 
            this.lbrecu.AutoSize = true;
            this.lbrecu.Location = new System.Drawing.Point(276, 34);
            this.lbrecu.Name = "lbrecu";
            this.lbrecu.Size = new System.Drawing.Size(22, 13);
            this.lbrecu.TabIndex = 30;
            this.lbrecu.Text = "rec";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(250, 34);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(27, 13);
            this.lbUser.TabIndex = 29;
            this.lbUser.Text = "user";
            // 
            // frmRecuperaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 139);
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