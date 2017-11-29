namespace Hospedaria.fdrFinanceiro
{
    partial class frmFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanceiro));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.datepicker1 = new System.Windows.Forms.DateTimePicker();
            this.datepicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dia = new System.Windows.Forms.RadioButton();
            this.periodo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-2, 78);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1130, 348);
            this.dataGridView2.TabIndex = 1;
            // 
            // datepicker1
            // 
            this.datepicker1.CustomFormat = "dd/MM/yyyy";
            this.datepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker1.Location = new System.Drawing.Point(687, 18);
            this.datepicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(151, 35);
            this.datepicker1.TabIndex = 15;
            this.datepicker1.ValueChanged += new System.EventHandler(this.datepicker1_ValueChanged);
            // 
            // datepicker2
            // 
            this.datepicker2.CustomFormat = "dd/MM/yyyy";
            this.datepicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker2.Location = new System.Drawing.Point(930, 18);
            this.datepicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datepicker2.Name = "datepicker2";
            this.datepicker2.Size = new System.Drawing.Size(180, 35);
            this.datepicker2.TabIndex = 16;
            this.datepicker2.ValueChanged += new System.EventHandler(this.datepicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(843, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Inicial";
            // 
            // dia
            // 
            this.dia.AutoSize = true;
            this.dia.Location = new System.Drawing.Point(538, 9);
            this.dia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dia.Name = "dia";
            this.dia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dia.Size = new System.Drawing.Size(58, 24);
            this.dia.TabIndex = 19;
            this.dia.TabStop = true;
            this.dia.Text = "Dia";
            this.dia.UseVisualStyleBackColor = true;
            this.dia.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // periodo
            // 
            this.periodo.AutoSize = true;
            this.periodo.Location = new System.Drawing.Point(508, 44);
            this.periodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.periodo.Name = "periodo";
            this.periodo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.periodo.Size = new System.Drawing.Size(88, 24);
            this.periodo.TabIndex = 20;
            this.periodo.TabStop = true;
            this.periodo.Text = "Periodo";
            this.periodo.UseVisualStyleBackColor = true;
            this.periodo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // frmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 431);
            this.Controls.Add(this.periodo);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datepicker2);
            this.Controls.Add(this.datepicker1);
            this.Controls.Add(this.dataGridView2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFinanceiro";
            this.Text = "frmFinanceiro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFinanceiro_FormClosing);
            this.Load += new System.EventHandler(this.frmFinanceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker datepicker1;
        private System.Windows.Forms.DateTimePicker datepicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton dia;
        private System.Windows.Forms.RadioButton periodo;
    }
}