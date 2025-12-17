namespace ED_data_structure
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.cmbEstructuras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEstructuras
            // 
            this.cmbEstructuras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstructuras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEstructuras.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstructuras.FormattingEnabled = true;
            this.cmbEstructuras.Items.AddRange(new object[] {
            "Árbol Binario",
            "Cola Circular",
            "Cola Doble",
            "Cola Prioridad",
            "Cola Simple",
            "Diccionario",
            "Grafo",
            "Lista Circular",
            "Lista Doble",
            "Lista Doble Circular",
            "Pila (Stack)",
            "Tabla Hash"});
            this.cmbEstructuras.Location = new System.Drawing.Point(18, 37);
            this.cmbEstructuras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEstructuras.Name = "cmbEstructuras";
            this.cmbEstructuras.Size = new System.Drawing.Size(199, 28);
            this.cmbEstructuras.TabIndex = 0;
            this.cmbEstructuras.SelectedIndexChanged += new System.EventHandler(this.cmbEstructuras_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estructura:";
            // 
            // txtDato1
            // 
            this.txtDato1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDato1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato1.Location = new System.Drawing.Point(18, 89);
            this.txtDato1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(114, 26);
            this.txtDato1.TabIndex = 2;
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.BackColor = System.Drawing.Color.Transparent;
            this.lblDato1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato1.Location = new System.Drawing.Point(16, 66);
            this.lblDato1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(40, 20);
            this.lblDato1.TabIndex = 3;
            this.lblDato1.Text = "Dato:";
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.BackColor = System.Drawing.Color.Transparent;
            this.lblDato2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato2.Location = new System.Drawing.Point(144, 68);
            this.lblDato2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(91, 20);
            this.lblDato2.TabIndex = 5;
            this.lblDato2.Text = "Dato 2 / Prior:";
            // 
            // txtDato2
            // 
            this.txtDato2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDato2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.txtDato2.Location = new System.Drawing.Point(146, 89);
            this.txtDato2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(114, 26);
            this.txtDato2.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(16, 26);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.btnEliminar.Location = new System.Drawing.Point(16, 62);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.btnMostrar.Location = new System.Drawing.Point(137, 26);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(90, 28);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar Todo";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.IndianRed;
            this.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstado.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.btnEstado.Location = new System.Drawing.Point(137, 62);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(90, 28);
            this.btnEstado.TabIndex = 9;
            this.btnEstado.Text = "Ver Estado";
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Black;
            this.txtResultado.Location = new System.Drawing.Point(18, 169);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(684, 312);
            this.txtResultado.TabIndex = 10;
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.BackColor = System.Drawing.Color.LavenderBlush;
            this.grpOperaciones.Controls.Add(this.btnPreOrden);
            this.grpOperaciones.Controls.Add(this.btnInOrden);
            this.grpOperaciones.Controls.Add(this.btnPostOrden);
            this.grpOperaciones.Controls.Add(this.btnBuscar);
            this.grpOperaciones.Controls.Add(this.btnClear);
            this.grpOperaciones.Controls.Add(this.btnAgregar);
            this.grpOperaciones.Controls.Add(this.btnEliminar);
            this.grpOperaciones.Controls.Add(this.btnEstado);
            this.grpOperaciones.Controls.Add(this.btnMostrar);
            this.grpOperaciones.Location = new System.Drawing.Point(283, 11);
            this.grpOperaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOperaciones.Size = new System.Drawing.Size(419, 129);
            this.grpOperaciones.TabIndex = 11;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones";
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.BackColor = System.Drawing.Color.Firebrick;
            this.btnPreOrden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreOrden.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.btnPreOrden.ForeColor = System.Drawing.Color.White;
            this.btnPreOrden.Location = new System.Drawing.Point(238, 26);
            this.btnPreOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(69, 28);
            this.btnPreOrden.TabIndex = 12;
            this.btnPreOrden.Text = "PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = false;
            this.btnPreOrden.Visible = false;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // btnInOrden
            // 
            this.btnInOrden.BackColor = System.Drawing.Color.Firebrick;
            this.btnInOrden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInOrden.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.btnInOrden.ForeColor = System.Drawing.Color.White;
            this.btnInOrden.Location = new System.Drawing.Point(238, 62);
            this.btnInOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(69, 28);
            this.btnInOrden.TabIndex = 13;
            this.btnInOrden.Text = "InOrden";
            this.btnInOrden.UseVisualStyleBackColor = false;
            this.btnInOrden.Visible = false;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.BackColor = System.Drawing.Color.Firebrick;
            this.btnPostOrden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPostOrden.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.btnPostOrden.ForeColor = System.Drawing.Color.White;
            this.btnPostOrden.Location = new System.Drawing.Point(238, 94);
            this.btnPostOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(69, 28);
            this.btnPostOrden.TabIndex = 14;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = false;
            this.btnPostOrden.Visible = false;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(16, 94);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(211, 28);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.btnClear.Location = new System.Drawing.Point(311, 26);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 96);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpiar Todo\r\n";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblDato2);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.lblDato1);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEstructuras);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Estructuras de Datos - Proyecto Final";
            this.grpOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstructuras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.Button btnPostOrden;
    }
}