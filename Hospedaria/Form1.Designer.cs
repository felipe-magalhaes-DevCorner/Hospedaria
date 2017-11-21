namespace Hospedaria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtClientes = new System.Windows.Forms.Button();
            this.btMove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioMensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suitePresidenciaslToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiteMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiteJaguaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoBobDylanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoJanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btVenda = new System.Windows.Forms.Button();
            this.pbFloyd = new System.Windows.Forms.PictureBox();
            this.pbStones = new System.Windows.Forms.PictureBox();
            this.pbDave = new System.Windows.Forms.PictureBox();
            this.pbDylan = new System.Windows.Forms.PictureBox();
            this.pbJanes = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbLogged = new System.Windows.Forms.Label();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloyd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDylan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJanes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtClientes
            // 
            this.BtClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClientes.Location = new System.Drawing.Point(42, 49);
            this.BtClientes.Name = "BtClientes";
            this.BtClientes.Size = new System.Drawing.Size(150, 150);
            this.BtClientes.TabIndex = 0;
            this.BtClientes.Text = "Hóspedes";
            this.BtClientes.UseVisualStyleBackColor = true;
            this.BtClientes.Click += new System.EventHandler(this.BtClientes_Click);
            // 
            // btMove
            // 
            this.btMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMove.Location = new System.Drawing.Point(42, 223);
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(150, 150);
            this.btMove.TabIndex = 2;
            this.btMove.Text = "Movimentação";
            this.btMove.UseVisualStyleBackColor = true;
            this.btMove.Click += new System.EventHandler(this.btMove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.financeiroToolStripMenuItem1,
            this.estoqueToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.financeiroToolStripMenuItem.Text = "Gerencia";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuarioToolStripMenuItem,
            this.alterarUsuarioToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // cadastrarUsuarioToolStripMenuItem
            // 
            this.cadastrarUsuarioToolStripMenuItem.Name = "cadastrarUsuarioToolStripMenuItem";
            this.cadastrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cadastrarUsuarioToolStripMenuItem.Text = "Cadastrar Usuario";
            this.cadastrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuarioToolStripMenuItem_Click);
            // 
            // alterarUsuarioToolStripMenuItem
            // 
            this.alterarUsuarioToolStripMenuItem.Name = "alterarUsuarioToolStripMenuItem";
            this.alterarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.alterarUsuarioToolStripMenuItem.Text = "Alterar Usuario";
            this.alterarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.alterarUsuarioToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem1
            // 
            this.financeiroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioDiarioToolStripMenuItem,
            this.relatorioMensalToolStripMenuItem});
            this.financeiroToolStripMenuItem1.Name = "financeiroToolStripMenuItem1";
            this.financeiroToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.financeiroToolStripMenuItem1.Text = "Financeiro";
            // 
            // relatorioDiarioToolStripMenuItem
            // 
            this.relatorioDiarioToolStripMenuItem.Name = "relatorioDiarioToolStripMenuItem";
            this.relatorioDiarioToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.relatorioDiarioToolStripMenuItem.Text = "Relatorio Diario";
            // 
            // relatorioMensalToolStripMenuItem
            // 
            this.relatorioMensalToolStripMenuItem.Name = "relatorioMensalToolStripMenuItem";
            this.relatorioMensalToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.relatorioMensalToolStripMenuItem.Text = "Relatorio Mensal";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suitePresidenciaslToolStripMenuItem,
            this.suiteMasterToolStripMenuItem,
            this.suiteJaguaçãoToolStripMenuItem,
            this.quartoBobDylanToolStripMenuItem,
            this.quartoJanesToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // suitePresidenciaslToolStripMenuItem
            // 
            this.suitePresidenciaslToolStripMenuItem.CheckOnClick = true;
            this.suitePresidenciaslToolStripMenuItem.Name = "suitePresidenciaslToolStripMenuItem";
            this.suitePresidenciaslToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.suitePresidenciaslToolStripMenuItem.Text = "Suite Pink Floyd";
            this.suitePresidenciaslToolStripMenuItem.CheckedChanged += new System.EventHandler(this.suitePresidenciaslToolStripMenuItem_CheckedChanged);
            // 
            // suiteMasterToolStripMenuItem
            // 
            this.suiteMasterToolStripMenuItem.CheckOnClick = true;
            this.suiteMasterToolStripMenuItem.Name = "suiteMasterToolStripMenuItem";
            this.suiteMasterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.suiteMasterToolStripMenuItem.Text = "Suite Rolling Stones";
            this.suiteMasterToolStripMenuItem.CheckedChanged += new System.EventHandler(this.suiteMasterToolStripMenuItem_CheckedChanged);
            // 
            // suiteJaguaçãoToolStripMenuItem
            // 
            this.suiteJaguaçãoToolStripMenuItem.CheckOnClick = true;
            this.suiteJaguaçãoToolStripMenuItem.Name = "suiteJaguaçãoToolStripMenuItem";
            this.suiteJaguaçãoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.suiteJaguaçãoToolStripMenuItem.Text = "Suite Dave Grohl";
            this.suiteJaguaçãoToolStripMenuItem.CheckedChanged += new System.EventHandler(this.suiteJaguaçãoToolStripMenuItem_CheckedChanged);
            // 
            // quartoBobDylanToolStripMenuItem
            // 
            this.quartoBobDylanToolStripMenuItem.CheckOnClick = true;
            this.quartoBobDylanToolStripMenuItem.Name = "quartoBobDylanToolStripMenuItem";
            this.quartoBobDylanToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.quartoBobDylanToolStripMenuItem.Text = "Quarto Bob Dylan";
            this.quartoBobDylanToolStripMenuItem.CheckedChanged += new System.EventHandler(this.quartoBobDylanToolStripMenuItem_CheckedChanged);
            // 
            // quartoJanesToolStripMenuItem
            // 
            this.quartoJanesToolStripMenuItem.CheckOnClick = true;
            this.quartoJanesToolStripMenuItem.Name = "quartoJanesToolStripMenuItem";
            this.quartoJanesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.quartoJanesToolStripMenuItem.Text = "Quarto Janes";
            this.quartoJanesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.quartoJanesToolStripMenuItem_CheckedChanged);
            // 
            // btVenda
            // 
            this.btVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenda.Location = new System.Drawing.Point(230, 223);
            this.btVenda.Name = "btVenda";
            this.btVenda.Size = new System.Drawing.Size(150, 150);
            this.btVenda.TabIndex = 5;
            this.btVenda.Text = "Venda";
            this.btVenda.UseVisualStyleBackColor = true;
            this.btVenda.Click += new System.EventHandler(this.btVenda_Click);
            // 
            // pbFloyd
            // 
            this.pbFloyd.Location = new System.Drawing.Point(230, 49);
            this.pbFloyd.Name = "pbFloyd";
            this.pbFloyd.Size = new System.Drawing.Size(25, 25);
            this.pbFloyd.TabIndex = 6;
            this.pbFloyd.TabStop = false;
            // 
            // pbStones
            // 
            this.pbStones.Location = new System.Drawing.Point(230, 70);
            this.pbStones.Name = "pbStones";
            this.pbStones.Size = new System.Drawing.Size(25, 25);
            this.pbStones.TabIndex = 7;
            this.pbStones.TabStop = false;
            // 
            // pbDave
            // 
            this.pbDave.Location = new System.Drawing.Point(230, 91);
            this.pbDave.Name = "pbDave";
            this.pbDave.Size = new System.Drawing.Size(25, 25);
            this.pbDave.TabIndex = 8;
            this.pbDave.TabStop = false;
            // 
            // pbDylan
            // 
            this.pbDylan.Location = new System.Drawing.Point(230, 112);
            this.pbDylan.Name = "pbDylan";
            this.pbDylan.Size = new System.Drawing.Size(25, 25);
            this.pbDylan.TabIndex = 9;
            this.pbDylan.TabStop = false;
            // 
            // pbJanes
            // 
            this.pbJanes.Location = new System.Drawing.Point(230, 133);
            this.pbJanes.Name = "pbJanes";
            this.pbJanes.Size = new System.Drawing.Size(25, 25);
            this.pbJanes.TabIndex = 10;
            this.pbJanes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Suite Pink Floyd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Suite Rolling Stones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Suite Dave Grohl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quarto Bob Dylan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quarto Janes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "label10";
            // 
            // lbLogged
            // 
            this.lbLogged.AutoSize = true;
            this.lbLogged.Location = new System.Drawing.Point(452, 359);
            this.lbLogged.Name = "lbLogged";
            this.lbLogged.Size = new System.Drawing.Size(0, 13);
            this.lbLogged.TabIndex = 21;
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 404);
            this.Controls.Add(this.lbLogged);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbJanes);
            this.Controls.Add(this.pbDylan);
            this.Controls.Add(this.pbDave);
            this.Controls.Add(this.pbStones);
            this.Controls.Add(this.pbFloyd);
            this.Controls.Add(this.btVenda);
            this.Controls.Add(this.btMove);
            this.Controls.Add(this.BtClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloyd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDylan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtClientes;
        private System.Windows.Forms.Button btMove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.Button btVenda;
        private System.Windows.Forms.ToolStripMenuItem relatorioDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioMensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suitePresidenciaslToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suiteMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suiteJaguaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartoBobDylanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartoJanesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.Label lbLogged;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarUsuarioToolStripMenuItem;
        public System.Windows.Forms.PictureBox pbFloyd;
        public System.Windows.Forms.PictureBox pbStones;
        public System.Windows.Forms.PictureBox pbDave;
        public System.Windows.Forms.PictureBox pbDylan;
        public System.Windows.Forms.PictureBox pbJanes;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}

