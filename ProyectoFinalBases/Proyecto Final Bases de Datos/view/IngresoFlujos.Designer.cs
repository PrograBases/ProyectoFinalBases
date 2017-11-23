namespace Proyecto_Final_Bases_de_Datos.view
{
    partial class IngresoFlujos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFlujoMaestroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLUJOMASTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PRODDataSet1 = new Proyecto_Final_Bases_de_Datos.DB_PRODDataSet1();
            this.fLUJO_MASTERTableAdapter = new Proyecto_Final_Bases_de_Datos.DB_PRODDataSet1TableAdapters.FLUJO_MASTERTableAdapter();
            this.codigoFlujoTxt = new System.Windows.Forms.TextBox();
            this.codigoFlujoMasterTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nuevoFlujoMasterTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLUJOMASTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PRODDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de flujos de procesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código del flujo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Flujos maestros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFlujoMaestroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fLUJOMASTERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(381, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(145, 267);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idFlujoMaestroDataGridViewTextBoxColumn
            // 
            this.idFlujoMaestroDataGridViewTextBoxColumn.DataPropertyName = "IdFlujoMaestro";
            this.idFlujoMaestroDataGridViewTextBoxColumn.HeaderText = "IdFlujoMaestro";
            this.idFlujoMaestroDataGridViewTextBoxColumn.Name = "idFlujoMaestroDataGridViewTextBoxColumn";
            this.idFlujoMaestroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLUJOMASTERBindingSource
            // 
            this.fLUJOMASTERBindingSource.DataMember = "FLUJO_MASTER";
            this.fLUJOMASTERBindingSource.DataSource = this.dB_PRODDataSet1;
            // 
            // dB_PRODDataSet1
            // 
            this.dB_PRODDataSet1.DataSetName = "DB_PRODDataSet1";
            this.dB_PRODDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fLUJO_MASTERTableAdapter
            // 
            this.fLUJO_MASTERTableAdapter.ClearBeforeFill = true;
            // 
            // codigoFlujoTxt
            // 
            this.codigoFlujoTxt.Location = new System.Drawing.Point(54, 107);
            this.codigoFlujoTxt.Name = "codigoFlujoTxt";
            this.codigoFlujoTxt.Size = new System.Drawing.Size(100, 20);
            this.codigoFlujoTxt.TabIndex = 4;
            // 
            // codigoFlujoMasterTxt
            // 
            this.codigoFlujoMasterTxt.Location = new System.Drawing.Point(54, 181);
            this.codigoFlujoMasterTxt.Name = "codigoFlujoMasterTxt";
            this.codigoFlujoMasterTxt.Size = new System.Drawing.Size(100, 20);
            this.codigoFlujoMasterTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código flujo master";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nuevo flujo maestro";
            // 
            // nuevoFlujoMasterTxt
            // 
            this.nuevoFlujoMasterTxt.Location = new System.Drawing.Point(567, 107);
            this.nuevoFlujoMasterTxt.Name = "nuevoFlujoMasterTxt";
            this.nuevoFlujoMasterTxt.Size = new System.Drawing.Size(100, 20);
            this.nuevoFlujoMasterTxt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Nuevo flujo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IngresoFlujos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nuevoFlujoMasterTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codigoFlujoMasterTxt);
            this.Controls.Add(this.codigoFlujoTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IngresoFlujos";
            this.Text = "IngresoFlujos";
            this.Load += new System.EventHandler(this.IngresoFlujos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLUJOMASTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PRODDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_PRODDataSet1 dB_PRODDataSet1;
        private System.Windows.Forms.BindingSource fLUJOMASTERBindingSource;
        private DB_PRODDataSet1TableAdapters.FLUJO_MASTERTableAdapter fLUJO_MASTERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFlujoMaestroDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox codigoFlujoTxt;
        private System.Windows.Forms.TextBox codigoFlujoMasterTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nuevoFlujoMasterTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}