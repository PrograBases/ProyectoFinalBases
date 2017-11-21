namespace Proyecto_Final_Bases_de_Datos
{
    partial class MainScreen
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
            this.mantProdBTN = new System.Windows.Forms.Button();
            this.crearOrdBTN = new System.Windows.Forms.Button();
            this.compBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mantProdBTN
            // 
            this.mantProdBTN.Location = new System.Drawing.Point(69, 68);
            this.mantProdBTN.Name = "mantProdBTN";
            this.mantProdBTN.Size = new System.Drawing.Size(150, 23);
            this.mantProdBTN.TabIndex = 0;
            this.mantProdBTN.Text = "Mantenimiento de productos";
            this.mantProdBTN.UseVisualStyleBackColor = true;
            this.mantProdBTN.Click += new System.EventHandler(this.mantProdBTN_Click);
            // 
            // crearOrdBTN
            // 
            this.crearOrdBTN.Location = new System.Drawing.Point(69, 120);
            this.crearOrdBTN.Name = "crearOrdBTN";
            this.crearOrdBTN.Size = new System.Drawing.Size(150, 23);
            this.crearOrdBTN.TabIndex = 1;
            this.crearOrdBTN.Text = "Crear orden de producción";
            this.crearOrdBTN.UseVisualStyleBackColor = true;
            this.crearOrdBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // compBTN
            // 
            this.compBTN.Location = new System.Drawing.Point(69, 177);
            this.compBTN.Name = "compBTN";
            this.compBTN.Size = new System.Drawing.Size(150, 23);
            this.compBTN.TabIndex = 2;
            this.compBTN.Text = "Componentes";
            this.compBTN.UseVisualStyleBackColor = true;
            this.compBTN.Click += new System.EventHandler(this.compBTN_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.compBTN);
            this.Controls.Add(this.crearOrdBTN);
            this.Controls.Add(this.mantProdBTN);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mantProdBTN;
        private System.Windows.Forms.Button crearOrdBTN;
        private System.Windows.Forms.Button compBTN;
    }
}