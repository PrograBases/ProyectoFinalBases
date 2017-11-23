namespace Proyecto_Final_Bases_de_Datos
{
    partial class Productos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.crearProducto = new System.Windows.Forms.Button();
            this.infoProducto = new System.Windows.Forms.Button();
            this.actualizarProducto = new System.Windows.Forms.Button();
            this.eliminarProducto = new System.Windows.Forms.Button();
            this.idFlujoLabel = new System.Windows.Forms.Label();
            this.TipoLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.idFlujoProducto = new System.Windows.Forms.TextBox();
            this.tipoProducto = new System.Windows.Forms.TextBox();
            this.descripcionProducto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idProducto = new System.Windows.Forms.TextBox();
            this.idProductoLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarIdProducto = new System.Windows.Forms.TextBox();
            this.verProducto = new System.Windows.Forms.Button();
            this.pRODUCTOSMASTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSMASTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crearProducto
            // 
            this.crearProducto.Location = new System.Drawing.Point(45, 288);
            this.crearProducto.Name = "crearProducto";
            this.crearProducto.Size = new System.Drawing.Size(104, 23);
            this.crearProducto.TabIndex = 0;
            this.crearProducto.Text = "Crear Producto";
            this.crearProducto.UseVisualStyleBackColor = true;
            this.crearProducto.Click += new System.EventHandler(this.crearProducto_Click);
            // 
            // infoProducto
            // 
            this.infoProducto.Location = new System.Drawing.Point(216, 288);
            this.infoProducto.Name = "infoProducto";
            this.infoProducto.Size = new System.Drawing.Size(104, 23);
            this.infoProducto.TabIndex = 1;
            this.infoProducto.Text = "Info Producto";
            this.infoProducto.UseVisualStyleBackColor = true;
            this.infoProducto.Click += new System.EventHandler(this.infoProducto_Click);
            // 
            // actualizarProducto
            // 
            this.actualizarProducto.Location = new System.Drawing.Point(378, 288);
            this.actualizarProducto.Name = "actualizarProducto";
            this.actualizarProducto.Size = new System.Drawing.Size(111, 23);
            this.actualizarProducto.TabIndex = 2;
            this.actualizarProducto.Text = "Actualizar Producto";
            this.actualizarProducto.UseVisualStyleBackColor = true;
            this.actualizarProducto.Click += new System.EventHandler(this.actualizarProducto_Click);
            // 
            // eliminarProducto
            // 
            this.eliminarProducto.Location = new System.Drawing.Point(562, 288);
            this.eliminarProducto.Name = "eliminarProducto";
            this.eliminarProducto.Size = new System.Drawing.Size(111, 23);
            this.eliminarProducto.TabIndex = 3;
            this.eliminarProducto.Text = "Eliminar Producto";
            this.eliminarProducto.UseVisualStyleBackColor = true;
            this.eliminarProducto.Click += new System.EventHandler(this.eliminarProducto_Click);
            // 
            // idFlujoLabel
            // 
            this.idFlujoLabel.AutoSize = true;
            this.idFlujoLabel.Location = new System.Drawing.Point(3, 78);
            this.idFlujoLabel.Name = "idFlujoLabel";
            this.idFlujoLabel.Size = new System.Drawing.Size(58, 13);
            this.idFlujoLabel.TabIndex = 5;
            this.idFlujoLabel.Text = "Id del Flujo";
            // 
            // TipoLabel
            // 
            this.TipoLabel.AutoSize = true;
            this.TipoLabel.Location = new System.Drawing.Point(363, 17);
            this.TipoLabel.Name = "TipoLabel";
            this.TipoLabel.Size = new System.Drawing.Size(89, 13);
            this.TipoLabel.TabIndex = 6;
            this.TipoLabel.Text = "Tipo de Producto";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(363, 85);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(126, 13);
            this.DescripcionLabel.TabIndex = 7;
            this.DescripcionLabel.Text = "Descripcion del Producto";
            // 
            // idFlujoProducto
            // 
            this.idFlujoProducto.Location = new System.Drawing.Point(122, 75);
            this.idFlujoProducto.Name = "idFlujoProducto";
            this.idFlujoProducto.Size = new System.Drawing.Size(127, 20);
            this.idFlujoProducto.TabIndex = 9;
            // 
            // tipoProducto
            // 
            this.tipoProducto.Location = new System.Drawing.Point(497, 14);
            this.tipoProducto.Name = "tipoProducto";
            this.tipoProducto.Size = new System.Drawing.Size(127, 20);
            this.tipoProducto.TabIndex = 10;
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.Location = new System.Drawing.Point(497, 78);
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.Size = new System.Drawing.Size(127, 20);
            this.descripcionProducto.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idProducto);
            this.panel1.Controls.Add(this.idProductoLabel);
            this.panel1.Controls.Add(this.DescripcionLabel);
            this.panel1.Controls.Add(this.descripcionProducto);
            this.panel1.Controls.Add(this.tipoProducto);
            this.panel1.Controls.Add(this.idFlujoLabel);
            this.panel1.Controls.Add(this.idFlujoProducto);
            this.panel1.Controls.Add(this.TipoLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 128);
            this.panel1.TabIndex = 12;
            // 
            // idProducto
            // 
            this.idProducto.Location = new System.Drawing.Point(122, 18);
            this.idProducto.Name = "idProducto";
            this.idProducto.Size = new System.Drawing.Size(127, 20);
            this.idProducto.TabIndex = 13;
            // 
            // idProductoLabel
            // 
            this.idProductoLabel.AutoSize = true;
            this.idProductoLabel.Location = new System.Drawing.Point(3, 21);
            this.idProductoLabel.Name = "idProductoLabel";
            this.idProductoLabel.Size = new System.Drawing.Size(79, 13);
            this.idProductoLabel.TabIndex = 12;
            this.idProductoLabel.Text = "Id del Producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(477, 89);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar por Tipo de Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buscarIdProducto
            // 
            this.buscarIdProducto.Location = new System.Drawing.Point(304, 150);
            this.buscarIdProducto.Name = "buscarIdProducto";
            this.buscarIdProducto.Size = new System.Drawing.Size(280, 20);
            this.buscarIdProducto.TabIndex = 15;
            this.buscarIdProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buscarIdProducto_KeyUp);
            // 
            // verProducto
            // 
            this.verProducto.Location = new System.Drawing.Point(598, 242);
            this.verProducto.Name = "verProducto";
            this.verProducto.Size = new System.Drawing.Size(93, 23);
            this.verProducto.TabIndex = 16;
            this.verProducto.Text = "ver Producto";
            this.verProducto.UseVisualStyleBackColor = true;
            this.verProducto.Click += new System.EventHandler(this.verProducto_Click);
            // 
            // pRODUCTOSMASTERBindingSource
            // 
            this.pRODUCTOSMASTERBindingSource.DataSource = typeof(Proyecto_Final_Bases_de_Datos.PRODUCTOS_MASTER);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(Proyecto_Final_Bases_de_Datos.Productos);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 377);
            this.Controls.Add(this.verProducto);
            this.Controls.Add(this.buscarIdProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eliminarProducto);
            this.Controls.Add(this.actualizarProducto);
            this.Controls.Add(this.infoProducto);
            this.Controls.Add(this.crearProducto);
            this.Name = "Productos";
            this.Text = "Mantenimiento de Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSMASTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crearProducto;
        private System.Windows.Forms.Button infoProducto;
        private System.Windows.Forms.Button actualizarProducto;
        private System.Windows.Forms.Button eliminarProducto;
        private System.Windows.Forms.Label idFlujoLabel;
        private System.Windows.Forms.Label TipoLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.TextBox idFlujoProducto;
        private System.Windows.Forms.TextBox tipoProducto;
        private System.Windows.Forms.TextBox descripcionProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscarIdProducto;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.BindingSource pRODUCTOSMASTERBindingSource;
        private System.Windows.Forms.Label idProductoLabel;
        private System.Windows.Forms.TextBox idProducto;
        private System.Windows.Forms.Button verProducto;
    }
}

