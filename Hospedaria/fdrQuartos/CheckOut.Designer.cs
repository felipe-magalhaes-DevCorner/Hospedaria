namespace Hospedaria.fdrQuartos
{
    partial class CheckOut
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
            this.lbQuarto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorPensao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorQuarto = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomePensao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbQuarto
            // 
            this.lbQuarto.AutoSize = true;
            this.lbQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuarto.Location = new System.Drawing.Point(37, 28);
            this.lbQuarto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuarto.Name = "lbQuarto";
            this.lbQuarto.Size = new System.Drawing.Size(92, 29);
            this.lbQuarto.TabIndex = 1;
            this.lbQuarto.Text = "Quarto:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(340, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 106);
            this.button2.TabIndex = 19;
            this.button2.Text = "Check Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorTotal.Location = new System.Drawing.Point(189, 243);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(119, 26);
            this.txtValorTotal.TabIndex = 23;
            // 
            // txtValorPensao
            // 
            this.txtValorPensao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtValorPensao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorPensao.Location = new System.Drawing.Point(189, 157);
            this.txtValorPensao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorPensao.Name = "txtValorPensao";
            this.txtValorPensao.ReadOnly = true;
            this.txtValorPensao.Size = new System.Drawing.Size(119, 26);
            this.txtValorPensao.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Valor Pensão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Valor Quarto";
            // 
            // txtValorQuarto
            // 
            this.txtValorQuarto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtValorQuarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorQuarto.Location = new System.Drawing.Point(189, 203);
            this.txtValorQuarto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorQuarto.Name = "txtValorQuarto";
            this.txtValorQuarto.ReadOnly = true;
            this.txtValorQuarto.Size = new System.Drawing.Size(119, 26);
            this.txtValorQuarto.TabIndex = 27;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.Location = new System.Drawing.Point(136, 71);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(311, 26);
            this.txtNomeCliente.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cliente:";
            // 
            // txtNomePensao
            // 
            this.txtNomePensao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNomePensao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomePensao.Location = new System.Drawing.Point(136, 111);
            this.txtNomePensao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomePensao.Name = "txtNomePensao";
            this.txtNomePensao.ReadOnly = true;
            this.txtNomePensao.Size = new System.Drawing.Size(311, 26);
            this.txtNomePensao.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Pensão:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 291);
            this.Controls.Add(this.txtNomePensao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorQuarto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorPensao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbQuarto);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckOut_FormClosing);
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbQuarto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorPensao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorQuarto;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomePensao;
        private System.Windows.Forms.Label label5;
    }
}