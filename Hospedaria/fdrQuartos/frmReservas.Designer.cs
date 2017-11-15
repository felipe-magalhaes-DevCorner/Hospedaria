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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservas));
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
            resources.ApplyResources(this.cbNomeRes, "cbNomeRes");
            this.cbNomeRes.FormattingEnabled = true;
            this.cbNomeRes.Name = "cbNomeRes";
            this.cbNomeRes.SelectedIndexChanged += new System.EventHandler(this.cbNomeRes_SelectedIndexChanged);
            // 
            // datepicker1
            // 
            resources.ApplyResources(this.datepicker1, "datepicker1");
            this.datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker1.Name = "datepicker1";
            // 
            // cbQuarto
            // 
            resources.ApplyResources(this.cbQuarto, "cbQuarto");
            this.cbQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuarto.FormattingEnabled = true;
            this.cbQuarto.Name = "cbQuarto";
            this.cbQuarto.SelectedIndexChanged += new System.EventHandler(this.cbQuarto_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // datepicker2
            // 
            resources.ApplyResources(this.datepicker2, "datepicker2");
            this.datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker2.Name = "datepicker2";
            // 
            // frmReservas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datepicker2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQuarto);
            this.Controls.Add(this.datepicker1);
            this.Controls.Add(this.cbNomeRes);
            this.DoubleBuffered = true;
            this.Name = "frmReservas";
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