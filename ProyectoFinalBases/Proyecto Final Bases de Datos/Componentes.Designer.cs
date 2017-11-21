namespace Proyecto_Final_Bases_de_Datos
{
    partial class Componentes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialDispBOX = new System.Windows.Forms.ListBox();
            this.materialSelectBOX = new System.Windows.Forms.ListBox();
            this.addMaterialBTN = new System.Windows.Forms.Button();
            this.retrieveMaterialBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idProductoTxtBOXX = new System.Windows.Forms.TextBox();
            this.aceptarCompBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disponibles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionadas";
            // 
            // materialDispBOX
            // 
            this.materialDispBOX.FormattingEnabled = true;
            this.materialDispBOX.Location = new System.Drawing.Point(13, 117);
            this.materialDispBOX.Name = "materialDispBOX";
            this.materialDispBOX.Size = new System.Drawing.Size(120, 173);
            this.materialDispBOX.TabIndex = 2;
            // 
            // materialSelectBOX
            // 
            this.materialSelectBOX.FormattingEnabled = true;
            this.materialSelectBOX.Location = new System.Drawing.Point(224, 117);
            this.materialSelectBOX.Name = "materialSelectBOX";
            this.materialSelectBOX.Size = new System.Drawing.Size(120, 173);
            this.materialSelectBOX.TabIndex = 3;
            // 
            // addMaterialBTN
            // 
            this.addMaterialBTN.Location = new System.Drawing.Point(154, 151);
            this.addMaterialBTN.Name = "addMaterialBTN";
            this.addMaterialBTN.Size = new System.Drawing.Size(52, 38);
            this.addMaterialBTN.TabIndex = 4;
            this.addMaterialBTN.Text = ">";
            this.addMaterialBTN.UseVisualStyleBackColor = true;
            this.addMaterialBTN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addMaterialBTN_MouseClick);
            // 
            // retrieveMaterialBTN
            // 
            this.retrieveMaterialBTN.Location = new System.Drawing.Point(154, 195);
            this.retrieveMaterialBTN.Name = "retrieveMaterialBTN";
            this.retrieveMaterialBTN.Size = new System.Drawing.Size(52, 38);
            this.retrieveMaterialBTN.TabIndex = 5;
            this.retrieveMaterialBTN.Text = "<";
            this.retrieveMaterialBTN.UseVisualStyleBackColor = true;
            this.retrieveMaterialBTN.Click += new System.EventHandler(this.retrieveMaterialBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "COMPONENTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id producto:";
            // 
            // idProductoTxtBOXX
            // 
            this.idProductoTxtBOXX.Location = new System.Drawing.Point(103, 38);
            this.idProductoTxtBOXX.Name = "idProductoTxtBOXX";
            this.idProductoTxtBOXX.Size = new System.Drawing.Size(30, 20);
            this.idProductoTxtBOXX.TabIndex = 8;
            this.idProductoTxtBOXX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aceptarCompBTN
            // 
            this.aceptarCompBTN.Location = new System.Drawing.Point(246, 310);
            this.aceptarCompBTN.Name = "aceptarCompBTN";
            this.aceptarCompBTN.Size = new System.Drawing.Size(75, 23);
            this.aceptarCompBTN.TabIndex = 9;
            this.aceptarCompBTN.Text = "Aceptar";
            this.aceptarCompBTN.UseVisualStyleBackColor = true;
            this.aceptarCompBTN.Click += new System.EventHandler(this.aceptarCompBTN_Click);
            // 
            // Componentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 345);
            this.Controls.Add(this.aceptarCompBTN);
            this.Controls.Add(this.idProductoTxtBOXX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.retrieveMaterialBTN);
            this.Controls.Add(this.addMaterialBTN);
            this.Controls.Add(this.materialSelectBOX);
            this.Controls.Add(this.materialDispBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Componentes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox materialDispBOX;
        private System.Windows.Forms.ListBox materialSelectBOX;
        private System.Windows.Forms.Button addMaterialBTN;
        private System.Windows.Forms.Button retrieveMaterialBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idProductoTxtBOXX;
        private System.Windows.Forms.Button aceptarCompBTN;
    }
}
