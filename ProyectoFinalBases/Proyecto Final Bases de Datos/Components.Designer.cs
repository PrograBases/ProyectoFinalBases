namespace Proyecto_Final_Bases_de_Datos
{
    partial class Components
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Components));
            this.listBox1 = new System.Windows.Forms.ListBox();
         
           
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
           
            this.SuspendLayout();
            // 
            // listBox1
            // 
          
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(86, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 121);
            this.listBox1.TabIndex = 0;
            // 
            // dB_PRODDataSet1
            // 
           
            // 
            // mATERIALBindingSource
            // 
           
            // 
            // mATERIALTableAdapter
            // 
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Componentes Disponibles";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(265, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(265, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 30);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Componentes Seleccionados";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(377, 85);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(144, 121);
            this.listBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Enviar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de Firma";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sin Firma",
            "Firma Simple",
            "Doble Firma"});
            this.comboBox1.Location = new System.Drawing.Point(437, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 261);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Components";
            this.Text = "Componentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
      
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}