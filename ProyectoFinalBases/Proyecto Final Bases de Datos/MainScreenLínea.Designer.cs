namespace Proyecto_Final_Bases_de_Datos
{
    partial class MainScreenLínea
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
            this.codLBL = new System.Windows.Forms.Label();
            this.codProdLBL = new System.Windows.Forms.Label();
            this.nomProdLBL = new System.Windows.Forms.Label();
            this.ToDoBOX = new System.Windows.Forms.ListBox();
            this.IncomingBOX = new System.Windows.Forms.ListBox();
            this.PeriodicsBOX = new System.Windows.Forms.ListBox();
            this.AdHocBOX = new System.Windows.Forms.ListBox();
            this.hacerActBTN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codLBL
            // 
            this.codLBL.AutoSize = true;
            this.codLBL.Location = new System.Drawing.Point(47, 50);
            this.codLBL.Name = "codLBL";
            this.codLBL.Size = new System.Drawing.Size(58, 13);
            this.codLBL.TabIndex = 0;
            this.codLBL.Text = "laHOLAAA";
            // 
            // codProdLBL
            // 
            this.codProdLBL.AutoSize = true;
            this.codProdLBL.Location = new System.Drawing.Point(47, 79);
            this.codProdLBL.Name = "codProdLBL";
            this.codProdLBL.Size = new System.Drawing.Size(35, 13);
            this.codProdLBL.TabIndex = 1;
            this.codProdLBL.Text = "label2";
            // 
            // nomProdLBL
            // 
            this.nomProdLBL.AutoSize = true;
            this.nomProdLBL.Location = new System.Drawing.Point(291, 79);
            this.nomProdLBL.Name = "nomProdLBL";
            this.nomProdLBL.Size = new System.Drawing.Size(35, 13);
            this.nomProdLBL.TabIndex = 2;
            this.nomProdLBL.Text = "label3";
            // 
            // ToDoBOX
            // 
            this.ToDoBOX.FormattingEnabled = true;
            this.ToDoBOX.Location = new System.Drawing.Point(45, 117);
            this.ToDoBOX.Name = "ToDoBOX";
            this.ToDoBOX.Size = new System.Drawing.Size(157, 121);
            this.ToDoBOX.TabIndex = 3;
            // 
            // IncomingBOX
            // 
            this.IncomingBOX.FormattingEnabled = true;
            this.IncomingBOX.Location = new System.Drawing.Point(267, 117);
            this.IncomingBOX.Name = "IncomingBOX";
            this.IncomingBOX.Size = new System.Drawing.Size(151, 121);
            this.IncomingBOX.TabIndex = 4;
            // 
            // PeriodicsBOX
            // 
            this.PeriodicsBOX.FormattingEnabled = true;
            this.PeriodicsBOX.Location = new System.Drawing.Point(45, 302);
            this.PeriodicsBOX.Name = "PeriodicsBOX";
            this.PeriodicsBOX.Size = new System.Drawing.Size(157, 108);
            this.PeriodicsBOX.TabIndex = 5;
            // 
            // AdHocBOX
            // 
            this.AdHocBOX.FormattingEnabled = true;
            this.AdHocBOX.Location = new System.Drawing.Point(267, 302);
            this.AdHocBOX.Name = "AdHocBOX";
            this.AdHocBOX.Size = new System.Drawing.Size(151, 108);
            this.AdHocBOX.TabIndex = 6;
            // 
            // hacerActBTN
            // 
            this.hacerActBTN.Location = new System.Drawing.Point(267, 456);
            this.hacerActBTN.Name = "hacerActBTN";
            this.hacerActBTN.Size = new System.Drawing.Size(151, 23);
            this.hacerActBTN.TabIndex = 7;
            this.hacerActBTN.Text = "Marcar como realizada";
            this.hacerActBTN.UseVisualStyleBackColor = true;
            this.hacerActBTN.Click += new System.EventHandler(this.hacerActBTN_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menú";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(229, 22);
            this.toolStripMenuItem2.Text = "Crear orden de producción";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(229, 22);
            this.toolStripMenuItem3.Text = "Mantenimiento de productos";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(229, 22);
            this.toolStripMenuItem4.Text = "Componentes";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Test (nada más para que prueben)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreenLínea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hacerActBTN);
            this.Controls.Add(this.AdHocBOX);
            this.Controls.Add(this.PeriodicsBOX);
            this.Controls.Add(this.IncomingBOX);
            this.Controls.Add(this.ToDoBOX);
            this.Controls.Add(this.nomProdLBL);
            this.Controls.Add(this.codProdLBL);
            this.Controls.Add(this.codLBL);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainScreenLínea";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codLBL;
        private System.Windows.Forms.Label codProdLBL;
        private System.Windows.Forms.Label nomProdLBL;
        private System.Windows.Forms.ListBox ToDoBOX;
        private System.Windows.Forms.ListBox IncomingBOX;
        private System.Windows.Forms.ListBox PeriodicsBOX;
        private System.Windows.Forms.ListBox AdHocBOX;
        private System.Windows.Forms.Button hacerActBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button button1;
    }
}