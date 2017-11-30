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
            this.dataGridView2.Location = new System.Drawing.Point(-1, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(753, 226);
            this.dataGridView2.TabIndex = 1;
            // 
            // datepicker1
            // 
            this.datepicker1.CustomFormat = "dd/MM/yyyy";
            this.datepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker1.Location = new System.Drawing.Point(458, 12);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(102, 26);
            this.datepicker1.TabIndex = 15;
            this.datepicker1.ValueChanged += new System.EventHandler(this.datepicker1_ValueChanged);
            // 
            // datepicker2
            // 
            this.datepicker2.CustomFormat = "dd/MM/yyyy";
            this.datepicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker2.Location = new System.Drawing.Point(620, 12);
            this.datepicker2.Name = "datepicker2";
            this.datepicker2.Size = new System.Drawing.Size(121, 26);
            this.datepicker2.TabIndex = 16;
            this.datepicker2.ValueChanged += new System.EventHandler(this.datepicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Inicial";
            // 
            // dia
            // 
            this.dia.AutoSize = true;
            this.dia.Location = new System.Drawing.Point(359, 6);
            this.dia.Name = "dia";
            this.dia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dia.Size = new System.Drawing.Size(41, 17);
            this.dia.TabIndex = 19;
            this.dia.TabStop = true;
            this.dia.Text = "Dia";
            this.dia.UseVisualStyleBackColor = true;
            this.dia.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // periodo
            // 
            this.periodo.AutoSize = true;
            this.periodo.Location = new System.Drawing.Point(339, 29);
            this.periodo.Name = "periodo";
            this.periodo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.periodo.Size = new System.Drawing.Size(61, 17);
            this.periodo.TabIndex = 20;
            this.periodo.TabStop = true;
            this.periodo.Text = "Periodo";
            this.periodo.UseVisualStyleBackColor = true;
            this.periodo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // frmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 280);
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
            this.Name = "frmFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financeiro";
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