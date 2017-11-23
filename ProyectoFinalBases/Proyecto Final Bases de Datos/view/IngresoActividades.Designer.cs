namespace Proyecto_Final_Bases_de_Datos.view
{
    partial class IngresoActividades
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_PRODDataSet2 = new Proyecto_Final_Bases_de_Datos.DB_PRODDataSet2();
            this.aCTIVIDADMASTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCTIVIDAD_MASTERTableAdapter = new Proyecto_Final_Bases_de_Datos.DB_PRODDataSet2TableAdapters.ACTIVIDAD_MASTERTableAdapter();
            this.dB_PRODDataSet3 = new Proyecto_Final_Bases_de_Datos.DB_PRODDataSet3();
            this.aCTIVIDADMASTERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aCTIVIDAD_MASTERTableAdapter1 = new Proyecto_Final_Bases_de_Datos.DB_PRODDataSet3TableAdapters.ACTIVIDAD_MASTERTableAdapter();
            this.idActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pantallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipofirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolseguridadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requeridaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periódicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambiaestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.tipoFirma = new System.Windows.Forms.TextBox();
            this.rolSeguridad = new System.Windows.Forms.TextBox();
            this.requerida = new System.Windows.Forms.TextBox();
            this.periodica = new System.Windows.Forms.TextBox();
            this.tiempo = new System.Windows.Forms.TextBox();
            this.cambiaEstado = new System.Windows.Forms.TextBox();
            this.adHoc = new System.Windows.Forms.TextBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.insertar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PRODDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADMASTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PRODDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADMASTERBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActividadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripciónDataGridViewTextBoxColumn,
            this.pantallaDataGridViewTextBoxColumn,
            this.tipofirmaDataGridViewTextBoxColumn,
            this.rolseguridadDataGridViewTextBoxColumn,
            this.requeridaDataGridViewTextBoxColumn,
            this.periódicaDataGridViewTextBoxColumn,
            this.tiempoDataGridViewTextBoxColumn,
            this.cambiaestadoDataGridViewTextBoxColumn,
            this.adHocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCTIVIDADMASTERBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 179);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dB_PRODDataSet2
            // 
            this.dB_PRODDataSet2.DataSetName = "DB_PRODDataSet2";
            this.dB_PRODDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCTIVIDADMASTERBindingSource
            // 
            this.aCTIVIDADMASTERBindingSource.DataMember = "ACTIVIDAD_MASTER";
            this.aCTIVIDADMASTERBindingSource.DataSource = this.dB_PRODDataSet2;
            // 
            // aCTIVIDAD_MASTERTableAdapter
            // 
            this.aCTIVIDAD_MASTERTableAdapter.ClearBeforeFill = true;
            // 
            // dB_PRODDataSet3
            // 
            this.dB_PRODDataSet3.DataSetName = "DB_PRODDataSet3";
            this.dB_PRODDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCTIVIDADMASTERBindingSource1
            // 
            this.aCTIVIDADMASTERBindingSource1.DataMember = "ACTIVIDAD_MASTER";
            this.aCTIVIDADMASTERBindingSource1.DataSource = this.dB_PRODDataSet3;
            // 
            // aCTIVIDAD_MASTERTableAdapter1
            // 
            this.aCTIVIDAD_MASTERTableAdapter1.ClearBeforeFill = true;
            // 
            // idActividadDataGridViewTextBoxColumn
            // 
            this.idActividadDataGridViewTextBoxColumn.DataPropertyName = "IdActividad";
            this.idActividadDataGridViewTextBoxColumn.HeaderText = "IdActividad";
            this.idActividadDataGridViewTextBoxColumn.Name = "idActividadDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripciónDataGridViewTextBoxColumn
            // 
            this.descripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción";
            this.descripciónDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripciónDataGridViewTextBoxColumn.Name = "descripciónDataGridViewTextBoxColumn";
            // 
            // pantallaDataGridViewTextBoxColumn
            // 
            this.pantallaDataGridViewTextBoxColumn.DataPropertyName = "Pantalla";
            this.pantallaDataGridViewTextBoxColumn.HeaderText = "Pantalla";
            this.pantallaDataGridViewTextBoxColumn.Name = "pantallaDataGridViewTextBoxColumn";
            // 
            // tipofirmaDataGridViewTextBoxColumn
            // 
            this.tipofirmaDataGridViewTextBoxColumn.DataPropertyName = "Tipo_firma";
            this.tipofirmaDataGridViewTextBoxColumn.HeaderText = "Tipo_firma";
            this.tipofirmaDataGridViewTextBoxColumn.Name = "tipofirmaDataGridViewTextBoxColumn";
            // 
            // rolseguridadDataGridViewTextBoxColumn
            // 
            this.rolseguridadDataGridViewTextBoxColumn.DataPropertyName = "Rol_seguridad";
            this.rolseguridadDataGridViewTextBoxColumn.HeaderText = "Rol_seguridad";
            this.rolseguridadDataGridViewTextBoxColumn.Name = "rolseguridadDataGridViewTextBoxColumn";
            // 
            // requeridaDataGridViewTextBoxColumn
            // 
            this.requeridaDataGridViewTextBoxColumn.DataPropertyName = "Requerida";
            this.requeridaDataGridViewTextBoxColumn.HeaderText = "Requerida";
            this.requeridaDataGridViewTextBoxColumn.Name = "requeridaDataGridViewTextBoxColumn";
            // 
            // periódicaDataGridViewTextBoxColumn
            // 
            this.periódicaDataGridViewTextBoxColumn.DataPropertyName = "Periódica";
            this.periódicaDataGridViewTextBoxColumn.HeaderText = "Periódica";
            this.periódicaDataGridViewTextBoxColumn.Name = "periódicaDataGridViewTextBoxColumn";
            // 
            // tiempoDataGridViewTextBoxColumn
            // 
            this.tiempoDataGridViewTextBoxColumn.DataPropertyName = "Tiempo";
            this.tiempoDataGridViewTextBoxColumn.HeaderText = "Tiempo";
            this.tiempoDataGridViewTextBoxColumn.Name = "tiempoDataGridViewTextBoxColumn";
            // 
            // cambiaestadoDataGridViewTextBoxColumn
            // 
            this.cambiaestadoDataGridViewTextBoxColumn.DataPropertyName = "Cambia_estado";
            this.cambiaestadoDataGridViewTextBoxColumn.HeaderText = "Cambia_estado";
            this.cambiaestadoDataGridViewTextBoxColumn.Name = "cambiaestadoDataGridViewTextBoxColumn";
            // 
            // adHocDataGridViewTextBoxColumn
            // 
            this.adHocDataGridViewTextBoxColumn.DataPropertyName = "AdHoc";
            this.adHocDataGridViewTextBoxColumn.HeaderText = "AdHoc";
            this.adHocDataGridViewTextBoxColumn.Name = "adHocDataGridViewTextBoxColumn";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(68, 55);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(68, 100);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 3;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(68, 148);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 20);
            this.descripcion.TabIndex = 4;
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(277, 55);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(100, 20);
            this.pantalla.TabIndex = 5;
            // 
            // tipoFirma
            // 
            this.tipoFirma.Location = new System.Drawing.Point(277, 100);
            this.tipoFirma.Name = "tipoFirma";
            this.tipoFirma.Size = new System.Drawing.Size(100, 20);
            this.tipoFirma.TabIndex = 6;
            // 
            // rolSeguridad
            // 
            this.rolSeguridad.Location = new System.Drawing.Point(277, 148);
            this.rolSeguridad.Name = "rolSeguridad";
            this.rolSeguridad.Size = new System.Drawing.Size(100, 20);
            this.rolSeguridad.TabIndex = 7;
            // 
            // requerida
            // 
            this.requerida.Location = new System.Drawing.Point(472, 54);
            this.requerida.Name = "requerida";
            this.requerida.Size = new System.Drawing.Size(100, 20);
            this.requerida.TabIndex = 8;
            // 
            // periodica
            // 
            this.periodica.Location = new System.Drawing.Point(472, 100);
            this.periodica.Name = "periodica";
            this.periodica.Size = new System.Drawing.Size(100, 20);
            this.periodica.TabIndex = 9;
            // 
            // tiempo
            // 
            this.tiempo.Location = new System.Drawing.Point(472, 148);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(100, 20);
            this.tiempo.TabIndex = 10;
            // 
            // cambiaEstado
            // 
            this.cambiaEstado.Location = new System.Drawing.Point(660, 54);
            this.cambiaEstado.Name = "cambiaEstado";
            this.cambiaEstado.Size = new System.Drawing.Size(100, 20);
            this.cambiaEstado.TabIndex = 11;
            // 
            // adHoc
            // 
            this.adHoc.Location = new System.Drawing.Point(660, 100);
            this.adHoc.Name = "adHoc";
            this.adHoc.Size = new System.Drawing.Size(100, 20);
            this.adHoc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Decripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pantalla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo de firma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rol de seguridad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Requerida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Periódica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tiempo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(660, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cambia de estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(663, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ad Hoc";
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(68, 424);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(75, 23);
            this.insertar.TabIndex = 24;
            this.insertar.Text = "Insertar";
            this.insertar.UseVisualStyleBackColor = true;
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(277, 424);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 25;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(472, 423);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 26;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // IngresoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 519);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adHoc);
            this.Controls.Add(this.cambiaEstado);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.periodica);
            this.Controls.Add(this.requerida);
            this.Controls.Add(this.rolSeguridad);
            this.Controls.Add(this.tipoFirma);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IngresoActividades";
            this.Text = "IngresoActividades";
            this.Load += new System.EventHandler(this.IngresoActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PRODDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADMASTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PRODDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADMASTERBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_PRODDataSet2 dB_PRODDataSet2;
        private System.Windows.Forms.BindingSource aCTIVIDADMASTERBindingSource;
        private DB_PRODDataSet2TableAdapters.ACTIVIDAD_MASTERTableAdapter aCTIVIDAD_MASTERTableAdapter;
        private DB_PRODDataSet3 dB_PRODDataSet3;
        private System.Windows.Forms.BindingSource aCTIVIDADMASTERBindingSource1;
        private DB_PRODDataSet3TableAdapters.ACTIVIDAD_MASTERTableAdapter aCTIVIDAD_MASTERTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pantallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipofirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolseguridadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requeridaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periódicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cambiaestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.TextBox tipoFirma;
        private System.Windows.Forms.TextBox rolSeguridad;
        private System.Windows.Forms.TextBox requerida;
        private System.Windows.Forms.TextBox periodica;
        private System.Windows.Forms.TextBox tiempo;
        private System.Windows.Forms.TextBox cambiaEstado;
        private System.Windows.Forms.TextBox adHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button eliminar;
    }
}