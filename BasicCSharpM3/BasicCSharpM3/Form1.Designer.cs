
namespace BasicCSharpM3
{
    partial class Form1
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ldlNombres = new System.Windows.Forms.Label();
            this.ldlApellidos = new System.Windows.Forms.Label();
            this.ldlDni = new System.Windows.Forms.Label();
            this.ldlSalario = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnFragmentar = new System.Windows.Forms.Button();
            this.btnSalarioMaximo = new System.Windows.Forms.Button();
            this.btnSalarioMinimo = new System.Windows.Forms.Button();
            this.btnSalarioPromedio = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalariosArribaPromedio = new System.Windows.Forms.Button();
            this.btnDebajoPromedio = new System.Windows.Forms.Button();
            this.cajaDeTxt = new System.Windows.Forms.GroupBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnNivelMenor = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.cajaDeTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 24);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ldlNombres
            // 
            this.ldlNombres.AutoSize = true;
            this.ldlNombres.Location = new System.Drawing.Point(6, 29);
            this.ldlNombres.Name = "ldlNombres";
            this.ldlNombres.Size = new System.Drawing.Size(49, 13);
            this.ldlNombres.TabIndex = 1;
            this.ldlNombres.Text = "Nombres";
            // 
            // ldlApellidos
            // 
            this.ldlApellidos.AutoSize = true;
            this.ldlApellidos.Location = new System.Drawing.Point(6, 67);
            this.ldlApellidos.Name = "ldlApellidos";
            this.ldlApellidos.Size = new System.Drawing.Size(49, 13);
            this.ldlApellidos.TabIndex = 2;
            this.ldlApellidos.Text = "Apellidos";
            // 
            // ldlDni
            // 
            this.ldlDni.AutoSize = true;
            this.ldlDni.Location = new System.Drawing.Point(6, 111);
            this.ldlDni.Name = "ldlDni";
            this.ldlDni.Size = new System.Drawing.Size(23, 13);
            this.ldlDni.TabIndex = 3;
            this.ldlDni.Text = "Dni";
            // 
            // ldlSalario
            // 
            this.ldlSalario.AutoSize = true;
            this.ldlSalario.Location = new System.Drawing.Point(6, 149);
            this.ldlSalario.Name = "ldlSalario";
            this.ldlSalario.Size = new System.Drawing.Size(39, 13);
            this.ldlSalario.TabIndex = 4;
            this.ldlSalario.Text = "Salario";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(96, 26);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(138, 20);
            this.txtNombres.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(96, 64);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(138, 20);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(96, 101);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(138, 20);
            this.txtDni.TabIndex = 7;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(96, 139);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(138, 20);
            this.txtSalario.TabIndex = 8;
            // 
            // btnFragmentar
            // 
            this.btnFragmentar.Location = new System.Drawing.Point(96, 3);
            this.btnFragmentar.Name = "btnFragmentar";
            this.btnFragmentar.Size = new System.Drawing.Size(94, 24);
            this.btnFragmentar.TabIndex = 9;
            this.btnFragmentar.Text = "Fragmentar";
            this.btnFragmentar.UseVisualStyleBackColor = true;
            this.btnFragmentar.Click += new System.EventHandler(this.btnFragmentar_Click);
            // 
            // btnSalarioMaximo
            // 
            this.btnSalarioMaximo.Location = new System.Drawing.Point(196, 3);
            this.btnSalarioMaximo.Name = "btnSalarioMaximo";
            this.btnSalarioMaximo.Size = new System.Drawing.Size(111, 23);
            this.btnSalarioMaximo.TabIndex = 10;
            this.btnSalarioMaximo.Text = "Ver salario maximo";
            this.btnSalarioMaximo.UseVisualStyleBackColor = true;
            this.btnSalarioMaximo.Click += new System.EventHandler(this.btnSalarioMaximo_Click);
            // 
            // btnSalarioMinimo
            // 
            this.btnSalarioMinimo.Location = new System.Drawing.Point(313, 3);
            this.btnSalarioMinimo.Name = "btnSalarioMinimo";
            this.btnSalarioMinimo.Size = new System.Drawing.Size(120, 23);
            this.btnSalarioMinimo.TabIndex = 11;
            this.btnSalarioMinimo.Text = "Ver salario minimo";
            this.btnSalarioMinimo.UseVisualStyleBackColor = true;
            this.btnSalarioMinimo.Click += new System.EventHandler(this.btnSalarioMinimo_Click);
            // 
            // btnSalarioPromedio
            // 
            this.btnSalarioPromedio.Location = new System.Drawing.Point(439, 3);
            this.btnSalarioPromedio.Name = "btnSalarioPromedio";
            this.btnSalarioPromedio.Size = new System.Drawing.Size(127, 23);
            this.btnSalarioPromedio.TabIndex = 12;
            this.btnSalarioPromedio.Text = "Ver salario promedio";
            this.btnSalarioPromedio.UseVisualStyleBackColor = true;
            this.btnSalarioPromedio.Click += new System.EventHandler(this.btnSalarioPromedio_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAceptar);
            this.flowLayoutPanel1.Controls.Add(this.btnFragmentar);
            this.flowLayoutPanel1.Controls.Add(this.btnSalarioMaximo);
            this.flowLayoutPanel1.Controls.Add(this.btnSalarioMinimo);
            this.flowLayoutPanel1.Controls.Add(this.btnSalarioPromedio);
            this.flowLayoutPanel1.Controls.Add(this.btnSalariosArribaPromedio);
            this.flowLayoutPanel1.Controls.Add(this.btnDebajoPromedio);
            this.flowLayoutPanel1.Controls.Add(this.btnNivelMenor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(49, 274);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(602, 64);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnSalariosArribaPromedio
            // 
            this.btnSalariosArribaPromedio.Location = new System.Drawing.Point(3, 33);
            this.btnSalariosArribaPromedio.Name = "btnSalariosArribaPromedio";
            this.btnSalariosArribaPromedio.Size = new System.Drawing.Size(171, 23);
            this.btnSalariosArribaPromedio.TabIndex = 13;
            this.btnSalariosArribaPromedio.Text = "Salarios arriba de promedio";
            this.btnSalariosArribaPromedio.UseVisualStyleBackColor = true;
            this.btnSalariosArribaPromedio.Click += new System.EventHandler(this.btnSalariosArribaPromedio_Click);
            // 
            // btnDebajoPromedio
            // 
            this.btnDebajoPromedio.Location = new System.Drawing.Point(180, 33);
            this.btnDebajoPromedio.Name = "btnDebajoPromedio";
            this.btnDebajoPromedio.Size = new System.Drawing.Size(155, 23);
            this.btnDebajoPromedio.TabIndex = 14;
            this.btnDebajoPromedio.Text = "Salarios debajo del promedio";
            this.btnDebajoPromedio.UseVisualStyleBackColor = true;
            this.btnDebajoPromedio.Click += new System.EventHandler(this.btnDebajoPromedio_Click);
            // 
            // cajaDeTxt
            // 
            this.cajaDeTxt.Controls.Add(this.lblGenero);
            this.cajaDeTxt.Controls.Add(this.lblNivel);
            this.cajaDeTxt.Controls.Add(this.cmbGenero);
            this.cajaDeTxt.Controls.Add(this.cmbNivel);
            this.cajaDeTxt.Controls.Add(this.ldlNombres);
            this.cajaDeTxt.Controls.Add(this.txtNombres);
            this.cajaDeTxt.Controls.Add(this.ldlSalario);
            this.cajaDeTxt.Controls.Add(this.txtSalario);
            this.cajaDeTxt.Controls.Add(this.ldlApellidos);
            this.cajaDeTxt.Controls.Add(this.txtDni);
            this.cajaDeTxt.Controls.Add(this.ldlDni);
            this.cajaDeTxt.Controls.Add(this.txtApellidos);
            this.cajaDeTxt.Location = new System.Drawing.Point(49, 12);
            this.cajaDeTxt.Name = "cajaDeTxt";
            this.cajaDeTxt.Size = new System.Drawing.Size(295, 256);
            this.cajaDeTxt.TabIndex = 14;
            this.cajaDeTxt.TabStop = false;
            this.cajaDeTxt.Text = "Ingrese los datos";
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria",
            "Universitario",
            "Posgrado",
            "Maestria",
            "Doctorado",
            "PostDoctorado"});
            this.cmbNivel.Location = new System.Drawing.Point(96, 175);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 9;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(96, 211);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 10;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(3, 178);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(87, 13);
            this.lblNivel.TabIndex = 11;
            this.lblNivel.Text = "Nivel Academico";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(6, 214);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "Genero";
            // 
            // btnNivelMenor
            // 
            this.btnNivelMenor.Location = new System.Drawing.Point(341, 33);
            this.btnNivelMenor.Name = "btnNivelMenor";
            this.btnNivelMenor.Size = new System.Drawing.Size(126, 23);
            this.btnNivelMenor.TabIndex = 15;
            this.btnNivelMenor.Text = "Menor nivel Academico";
            this.btnNivelMenor.UseVisualStyleBackColor = true;
            this.btnNivelMenor.Click += new System.EventHandler(this.btnNivelMenor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 477);
            this.Controls.Add(this.cajaDeTxt);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.cajaDeTxt.ResumeLayout(false);
            this.cajaDeTxt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label ldlNombres;
        private System.Windows.Forms.Label ldlApellidos;
        private System.Windows.Forms.Label ldlDni;
        private System.Windows.Forms.Label ldlSalario;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnFragmentar;
        private System.Windows.Forms.Button btnSalarioMaximo;
        private System.Windows.Forms.Button btnSalarioMinimo;
        private System.Windows.Forms.Button btnSalarioPromedio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox cajaDeTxt;
        private System.Windows.Forms.Button btnSalariosArribaPromedio;
        private System.Windows.Forms.Button btnDebajoPromedio;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Button btnNivelMenor;
    }
}

