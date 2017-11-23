namespace Hospedaria.fdrQuartos
{
    partial class frmAlteraReserva
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.datepicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.datepicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQuarto = new System.Windows.Forms.ComboBox();
            this.cbNomeCheckIn = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(286, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 69);
            this.button2.TabIndex = 36;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(20, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Data Saida:";
            // 
            // datepicker2
            // 
            this.datepicker2.CustomFormat = "dd/MM/yyyy 11:59";
            this.datepicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker2.Location = new System.Drawing.Point(117, 114);
            this.datepicker2.Name = "datepicker2";
            this.datepicker2.Size = new System.Drawing.Size(163, 26);
            this.datepicker2.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(5, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Data Prevista:";
            // 
            // datepicker1
            // 
            this.datepicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker1.Location = new System.Drawing.Point(117, 78);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(163, 26);
            this.datepicker1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quarto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hospede:";
            // 
            // cbQuarto
            // 
            this.cbQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbQuarto.FormattingEnabled = true;
            this.cbQuarto.Location = new System.Drawing.Point(95, 39);
            this.cbQuarto.Name = "cbQuarto";
            this.cbQuarto.Size = new System.Drawing.Size(185, 28);
            this.cbQuarto.TabIndex = 27;
            // 
            // cbNomeCheckIn
            // 
            this.cbNomeCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbNomeCheckIn.FormattingEnabled = true;
            this.cbNomeCheckIn.Location = new System.Drawing.Point(95, 7);
            this.cbNomeCheckIn.Name = "cbNomeCheckIn";
            this.cbNomeCheckIn.Size = new System.Drawing.Size(316, 28);
            this.cbNomeCheckIn.TabIndex = 26;
            this.cbNomeCheckIn.SelectedIndexChanged += new System.EventHandler(this.cbNomeCheckIn_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(417, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 37;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(372, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 69);
            this.button3.TabIndex = 39;
            this.button3.Text = "Gravar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmAlteraReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 149);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datepicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datepicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQuarto);
            this.Controls.Add(this.cbNomeCheckIn);
            this.Name = "frmAlteraReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAlteraReserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlteraReserva_FormClosing);
            this.Load += new System.EventHandler(this.frmAlteraReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datepicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datepicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQuarto;
        private System.Windows.Forms.ComboBox cbNomeCheckIn;
        private System.Windows.Forms.Button button3;
    }
}