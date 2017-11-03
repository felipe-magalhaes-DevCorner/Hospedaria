namespace Hospedaria.fdrQuartos
{
    partial class frmReservas
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
            this.cbNomeRes = new System.Windows.Forms.ComboBox();
            this.datepicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbQuarto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.datepicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbNomeRes
            // 
            this.cbNomeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomeRes.FormattingEnabled = true;
            this.cbNomeRes.Location = new System.Drawing.Point(111, 26);
            this.cbNomeRes.Name = "cbNomeRes";
            this.cbNomeRes.Size = new System.Drawing.Size(370, 28);
            this.cbNomeRes.TabIndex = 1;
            this.cbNomeRes.SelectedIndexChanged += new System.EventHandler(this.cbNomeRes_SelectedIndexChanged);
            // 
            // datepicker1
            // 
            this.datepicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.datepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker1.Location = new System.Drawing.Point(111, 107);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(196, 26);
            this.datepicker1.TabIndex = 3;
            // 
            // cbQuarto
            // 
            this.cbQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuarto.FormattingEnabled = true;
            this.cbQuarto.Location = new System.Drawing.Point(111, 63);
            this.cbQuarto.Name = "cbQuarto";
            this.cbQuarto.Size = new System.Drawing.Size(242, 28);
            this.cbQuarto.TabIndex = 4;
            this.cbQuarto.SelectedIndexChanged += new System.EventHandler(this.cbQuarto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hospede:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quarto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Prevista:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(331, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 150);
            this.button2.TabIndex = 10;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data Saida:";
            // 
            // datepicker2
            // 
            this.datepicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.datepicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker2.Location = new System.Drawing.Point(111, 143);
            this.datepicker2.Name = "datepicker2";
            this.datepicker2.Size = new System.Drawing.Size(196, 26);
            this.datepicker2.TabIndex = 11;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datepicker2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQuarto);
            this.Controls.Add(this.datepicker1);
            this.Controls.Add(this.cbNomeRes);
            this.Name = "frmReservas";
            this.Text = "frmReservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbNomeRes;
        private System.Windows.Forms.DateTimePicker datepicker1;
        private System.Windows.Forms.ComboBox cbQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datepicker2;
    }
}