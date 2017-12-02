namespace Hospedaria.fdrQuartos
{
    partial class CheckIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQuarto = new System.Windows.Forms.ComboBox();
            this.cbNomeCheckIn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPensao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datepicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.datepicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(45, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quarto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hóspede:";
            // 
            // cbQuarto
            // 
            this.cbQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbQuarto.FormattingEnabled = true;
            this.cbQuarto.Location = new System.Drawing.Point(146, 71);
            this.cbQuarto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbQuarto.Name = "cbQuarto";
            this.cbQuarto.Size = new System.Drawing.Size(361, 37);
            this.cbQuarto.TabIndex = 2;
            this.cbQuarto.SelectedIndexChanged += new System.EventHandler(this.cbQuarto_SelectedIndexChanged);
            this.cbQuarto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cbQuarto_MouseMove);
            // 
            // cbNomeCheckIn
            // 
            this.cbNomeCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbNomeCheckIn.FormattingEnabled = true;
            this.cbNomeCheckIn.Location = new System.Drawing.Point(146, 22);
            this.cbNomeCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNomeCheckIn.Name = "cbNomeCheckIn";
            this.cbNomeCheckIn.Size = new System.Drawing.Size(440, 37);
            this.cbNomeCheckIn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(39, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pensão:";
            // 
            // cbPensao
            // 
            this.cbPensao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPensao.FormattingEnabled = true;
            this.cbPensao.Location = new System.Drawing.Point(146, 126);
            this.cbPensao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPensao.Name = "cbPensao";
            this.cbPensao.Size = new System.Drawing.Size(361, 37);
            this.cbPensao.TabIndex = 3;
            this.cbPensao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cbPensao_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(33, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data Saída:";
            // 
            // datepicker2
            // 
            this.datepicker2.CustomFormat = "dd/MM/yyyy 11:59";
            this.datepicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker2.Location = new System.Drawing.Point(178, 238);
            this.datepicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datepicker2.Name = "datepicker2";
            this.datepicker2.Size = new System.Drawing.Size(242, 35);
            this.datepicker2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(10, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data Prevista:";
            // 
            // datepicker1
            // 
            this.datepicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker1.Location = new System.Drawing.Point(178, 183);
            this.datepicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(242, 35);
            this.datepicker1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(519, 172);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 106);
            this.button2.TabIndex = 6;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(594, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 24;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(16, 251);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(652, 289);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datepicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datepicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPensao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQuarto);
            this.Controls.Add(this.cbNomeCheckIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckIn_FormClosing);
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQuarto;
        private System.Windows.Forms.ComboBox cbNomeCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPensao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datepicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datepicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}