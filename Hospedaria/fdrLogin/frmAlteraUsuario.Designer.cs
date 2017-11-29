namespace Hospedaria.fdrLogin
{
    partial class frmAlteraUsuario
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chekBan = new System.Windows.Forms.CheckBox();
            this.txtnovasenha = new System.Windows.Forms.TextBox();
            this.txtconfsenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btGravar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // chekBan
            // 
            this.chekBan.AutoSize = true;
            this.chekBan.BackColor = System.Drawing.Color.Transparent;
            this.chekBan.Location = new System.Drawing.Point(85, 182);
            this.chekBan.Name = "chekBan";
            this.chekBan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chekBan.Size = new System.Drawing.Size(116, 24);
            this.chekBan.TabIndex = 2;
            this.chekBan.Text = ":Bloqueado";
            this.chekBan.UseVisualStyleBackColor = false;
            // 
            // txtnovasenha
            // 
            this.txtnovasenha.Location = new System.Drawing.Point(181, 78);
            this.txtnovasenha.Name = "txtnovasenha";
            this.txtnovasenha.Size = new System.Drawing.Size(262, 26);
            this.txtnovasenha.TabIndex = 3;
            // 
            // txtconfsenha
            // 
            this.txtconfsenha.Location = new System.Drawing.Point(181, 112);
            this.txtconfsenha.Name = "txtconfsenha";
            this.txtconfsenha.Size = new System.Drawing.Size(262, 26);
            this.txtconfsenha.TabIndex = 4;
            this.txtconfsenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(78, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nova senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar nova senha:";
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravar.Location = new System.Drawing.Point(320, 215);
            this.btGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(120, 123);
            this.btGravar.TabIndex = 9;
            this.btGravar.Text = "Alterar";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(192, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 123);
            this.button1.TabIndex = 10;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(123, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Login:";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(181, 45);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.ReadOnly = true;
            this.txtlogin.Size = new System.Drawing.Size(262, 26);
            this.txtlogin.TabIndex = 11;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(181, 146);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(133, 28);
            this.cbCargo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(107, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cargo:";
            // 
            // frmAlteraUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(452, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtconfsenha);
            this.Controls.Add(this.txtnovasenha);
            this.Controls.Add(this.chekBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmAlteraUsuario";
            this.Text = "frmAlteraUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlteraUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmAlteraUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chekBan;
        private System.Windows.Forms.TextBox txtnovasenha;
        private System.Windows.Forms.TextBox txtconfsenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label5;
    }
}