
namespace BasicCSharpM3
{
    partial class FrmProducto
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
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCaducidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtCodigoBuscar = new System.Windows.Forms.TextBox();
            this.lblIngresarCodigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDatoBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.lblCriterioBusq = new System.Windows.Forms.Label();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.cmbUnidadM = new System.Windows.Forms.ComboBox();
            this.lblUnidadM = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtMensajeJson = new System.Windows.Forms.RichTextBox();
            this.btnMostrarJson = new System.Windows.Forms.Button();
            this.btnOrdenarByPrecio = new System.Windows.Forms.Button();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.lblPrecioMenor = new System.Windows.Forms.Label();
            this.lblPrecioMayor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(23, 253);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(119, 23);
            this.btnAñadir.TabIndex = 0;
            this.btnAñadir.Text = "Añadir producto";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(33, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(33, 121);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.AutoSize = true;
            this.lblCaducidad.Location = new System.Drawing.Point(33, 180);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(75, 17);
            this.lblCaducidad.TabIndex = 4;
            this.lblCaducidad.Text = "Caducidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(33, 153);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(33, 88);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(111, 23);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtCaducidad
            // 
            this.txtCaducidad.Location = new System.Drawing.Point(116, 180);
            this.txtCaducidad.Name = "txtCaducidad";
            this.txtCaducidad.Size = new System.Drawing.Size(111, 23);
            this.txtCaducidad.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(116, 153);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(111, 23);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(116, 118);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(111, 23);
            this.txtCantidad.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(116, 88);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(244, 23);
            this.txtDescripcion.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 23);
            this.txtNombre.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(188, 56);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(155, 253);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(163, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar producto";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtCodigoBuscar
            // 
            this.txtCodigoBuscar.Location = new System.Drawing.Point(64, 56);
            this.txtCodigoBuscar.Name = "txtCodigoBuscar";
            this.txtCodigoBuscar.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoBuscar.TabIndex = 16;
            // 
            // lblIngresarCodigo
            // 
            this.lblIngresarCodigo.AutoSize = true;
            this.lblIngresarCodigo.Location = new System.Drawing.Point(46, 40);
            this.lblIngresarCodigo.Name = "lblIngresarCodigo";
            this.lblIngresarCodigo.Size = new System.Drawing.Size(150, 13);
            this.lblIngresarCodigo.TabIndex = 17;
            this.lblIngresarCodigo.Text = "Ingrese el codigo del producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUnidadM);
            this.groupBox1.Controls.Add(this.btnMostrarJson);
            this.groupBox1.Controls.Add(this.btnOrdenarByPrecio);
            this.groupBox1.Controls.Add(this.lblUnidadM);
            this.groupBox1.Controls.Add(this.btnAñadir);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.lblCaducidad);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtCaducidad);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(21, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 367);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir y actualizar productos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPrecioMayor);
            this.groupBox3.Controls.Add(this.lblPrecioMenor);
            this.groupBox3.Controls.Add(this.txtPrecio1);
            this.groupBox3.Controls.Add(this.txtDatoBusqueda);
            this.groupBox3.Controls.Add(this.btnBuscar2);
            this.groupBox3.Controls.Add(this.lblCriterioBusq);
            this.groupBox3.Controls.Add(this.cmbBusqueda);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 102);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Productos";
            // 
            // txtDatoBusqueda
            // 
            this.txtDatoBusqueda.AutoCompleteCustomSource.AddRange(new string[] {
            "Unidad",
            "Litros",
            "Mililitros",
            "Libra",
            "Gramo",
            "Kilogramo"});
            this.txtDatoBusqueda.Location = new System.Drawing.Point(116, 55);
            this.txtDatoBusqueda.Name = "txtDatoBusqueda";
            this.txtDatoBusqueda.Size = new System.Drawing.Size(121, 23);
            this.txtDatoBusqueda.TabIndex = 21;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBuscar2.Location = new System.Drawing.Point(252, 56);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar2.TabIndex = 20;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // lblCriterioBusq
            // 
            this.lblCriterioBusq.AutoSize = true;
            this.lblCriterioBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCriterioBusq.Location = new System.Drawing.Point(6, 24);
            this.lblCriterioBusq.Name = "lblCriterioBusq";
            this.lblCriterioBusq.Size = new System.Drawing.Size(104, 13);
            this.lblCriterioBusq.TabIndex = 19;
            this.lblCriterioBusq.Text = "Criterio de busqueda";
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Unidad de medida",
            "Caducidad",
            "Rango de precio",
            "Codigo"});
            this.cmbBusqueda.Location = new System.Drawing.Point(116, 24);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(121, 25);
            this.cmbBusqueda.TabIndex = 18;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbBusqueda_SelectedIndexChanged);
            // 
            // cmbUnidadM
            // 
            this.cmbUnidadM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadM.FormattingEnabled = true;
            this.cmbUnidadM.Items.AddRange(new object[] {
            "Unidad",
            "Litros",
            "Mililitros",
            "Libras",
            "Gramos",
            "Kilogramos"});
            this.cmbUnidadM.Location = new System.Drawing.Point(165, 212);
            this.cmbUnidadM.Name = "cmbUnidadM";
            this.cmbUnidadM.Size = new System.Drawing.Size(121, 25);
            this.cmbUnidadM.TabIndex = 17;
            // 
            // lblUnidadM
            // 
            this.lblUnidadM.AutoSize = true;
            this.lblUnidadM.Location = new System.Drawing.Point(36, 215);
            this.lblUnidadM.Name = "lblUnidadM";
            this.lblUnidadM.Size = new System.Drawing.Size(123, 17);
            this.lblUnidadM.TabIndex = 16;
            this.lblUnidadM.Text = "Unidad de medida";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodigoBuscar);
            this.groupBox2.Controls.Add(this.lblIngresarCodigo);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(404, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 90);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar producto";
            // 
            // rtxtMensajeJson
            // 
            this.rtxtMensajeJson.Location = new System.Drawing.Point(426, 24);
            this.rtxtMensajeJson.Name = "rtxtMensajeJson";
            this.rtxtMensajeJson.ReadOnly = true;
            this.rtxtMensajeJson.Size = new System.Drawing.Size(354, 372);
            this.rtxtMensajeJson.TabIndex = 20;
            this.rtxtMensajeJson.Text = "";
            // 
            // btnMostrarJson
            // 
            this.btnMostrarJson.Location = new System.Drawing.Point(23, 311);
            this.btnMostrarJson.Name = "btnMostrarJson";
            this.btnMostrarJson.Size = new System.Drawing.Size(250, 32);
            this.btnMostrarJson.TabIndex = 21;
            this.btnMostrarJson.Text = "Mostrar todos los productos en Json";
            this.btnMostrarJson.UseVisualStyleBackColor = true;
            this.btnMostrarJson.Click += new System.EventHandler(this.btnMostrarJson_Click);
            // 
            // btnOrdenarByPrecio
            // 
            this.btnOrdenarByPrecio.Location = new System.Drawing.Point(23, 282);
            this.btnOrdenarByPrecio.Name = "btnOrdenarByPrecio";
            this.btnOrdenarByPrecio.Size = new System.Drawing.Size(164, 23);
            this.btnOrdenarByPrecio.TabIndex = 22;
            this.btnOrdenarByPrecio.Text = "Ordenar por precio";
            this.btnOrdenarByPrecio.UseVisualStyleBackColor = true;
            this.btnOrdenarByPrecio.Click += new System.EventHandler(this.btnOrdenarByPrecio_Click);
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(6, 55);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio1.TabIndex = 22;
            this.txtPrecio1.Visible = false;
            // 
            // lblPrecioMenor
            // 
            this.lblPrecioMenor.AutoSize = true;
            this.lblPrecioMenor.Location = new System.Drawing.Point(6, 85);
            this.lblPrecioMenor.Name = "lblPrecioMenor";
            this.lblPrecioMenor.Size = new System.Drawing.Size(92, 17);
            this.lblPrecioMenor.TabIndex = 23;
            this.lblPrecioMenor.Text = "Precio Menor";
            this.lblPrecioMenor.Visible = false;
            // 
            // lblPrecioMayor
            // 
            this.lblPrecioMayor.AutoSize = true;
            this.lblPrecioMayor.Location = new System.Drawing.Point(129, 85);
            this.lblPrecioMayor.Name = "lblPrecioMayor";
            this.lblPrecioMayor.Size = new System.Drawing.Size(91, 17);
            this.lblPrecioMayor.TabIndex = 24;
            this.lblPrecioMayor.Text = "Precio Mayor";
            this.lblPrecioMayor.Visible = false;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 513);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rtxtMensajeJson);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCaducidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtCodigoBuscar;
        private System.Windows.Forms.Label lblIngresarCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCriterioBusq;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.ComboBox cmbUnidadM;
        private System.Windows.Forms.Label lblUnidadM;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.RichTextBox rtxtMensajeJson;
        private System.Windows.Forms.TextBox txtDatoBusqueda;
        private System.Windows.Forms.Button btnMostrarJson;
        private System.Windows.Forms.Button btnOrdenarByPrecio;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.Label lblPrecioMayor;
        private System.Windows.Forms.Label lblPrecioMenor;
    }
}