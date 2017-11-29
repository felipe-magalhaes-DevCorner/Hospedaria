namespace Hospedaria.Clientes
{
    partial class frmmainClientes
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
            this.BtClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtClientes
            // 
            this.BtClientes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClientes.Location = new System.Drawing.Point(24, 18);
            this.BtClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtClientes.Name = "BtClientes";
            this.BtClientes.Size = new System.Drawing.Size(225, 231);
            this.BtClientes.TabIndex = 1;
            this.BtClientes.Text = "Cadastrar(F1)";
            this.BtClientes.UseVisualStyleBackColor = false;
            this.BtClientes.Click += new System.EventHandler(this.BtClientes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(282, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 231);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar(F2)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmmainClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(525, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmmainClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmainClientes_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtClientes;
        private System.Windows.Forms.Button button1;
    }
}