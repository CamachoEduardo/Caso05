
namespace Caso05
{
    partial class frmPlanilla
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHijos = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtFechaIng = new System.Windows.Forms.DateTimePicker();
            this.cboCondicion = new System.Windows.Forms.ComboBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvEmpleados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.btnConsulta3 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Pagos de Empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHijos);
            this.groupBox1.Controls.Add(this.txtEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num. Hijos";
            // 
            // txtHijos
            // 
            this.txtHijos.Location = new System.Drawing.Point(230, 32);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(100, 20);
            this.txtHijos.TabIndex = 4;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(6, 32);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(218, 20);
            this.txtEmpleado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleado";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnRegistrar);
            this.GroupBox2.Controls.Add(this.dtFechaIng);
            this.GroupBox2.Controls.Add(this.cboCondicion);
            this.GroupBox2.Controls.Add(this.cboArea);
            this.GroupBox2.Controls.Add(this.label6);
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Controls.Add(this.label4);
            this.GroupBox2.Location = new System.Drawing.Point(371, 60);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(473, 83);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Datos de Planilla";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(383, 34);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtFechaIng
            // 
            this.dtFechaIng.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIng.Location = new System.Drawing.Point(262, 33);
            this.dtFechaIng.Name = "dtFechaIng";
            this.dtFechaIng.Size = new System.Drawing.Size(91, 20);
            this.dtFechaIng.TabIndex = 5;
            // 
            // cboCondicion
            // 
            this.cboCondicion.FormattingEnabled = true;
            this.cboCondicion.Items.AddRange(new object[] {
            "Personal",
            "Comision"});
            this.cboCondicion.Location = new System.Drawing.Point(133, 32);
            this.cboCondicion.Name = "cboCondicion";
            this.cboCondicion.Size = new System.Drawing.Size(121, 21);
            this.cboCondicion.TabIndex = 4;
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Items.AddRange(new object[] {
            "Ventas",
            "Marketing",
            "Logistica",
            "Prestamo"});
            this.cboArea.Location = new System.Drawing.Point(6, 32);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(121, 21);
            this.cboArea.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha de Ing.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(130, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Condicion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Area";
            // 
            // lvEmpleados
            // 
            this.lvEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvEmpleados.GridLines = true;
            this.lvEmpleados.HideSelection = false;
            this.lvEmpleados.Location = new System.Drawing.Point(12, 166);
            this.lvEmpleados.Name = "lvEmpleados";
            this.lvEmpleados.Size = new System.Drawing.Size(832, 153);
            this.lvEmpleados.TabIndex = 3;
            this.lvEmpleados.UseCompatibleStateImageBehavior = false;
            this.lvEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EMPLEADO";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "HIJOS";
            this.columnHeader2.Width = 53;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "AREA";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CONDICION";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TIEMPO DE SERVICIO";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SUELDO BASE";
            this.columnHeader6.Width = 96;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "MOVILIDAD";
            this.columnHeader7.Width = 73;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ASIGNACION";
            this.columnHeader8.Width = 81;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "DESCUENTO";
            this.columnHeader9.Width = 82;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "NETO SUELDO";
            this.columnHeader10.Width = 93;
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.HideSelection = false;
            this.lvEstadisticas.Location = new System.Drawing.Point(12, 325);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(615, 166);
            this.lvEstadisticas.TabIndex = 4;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "CONDICION";
            this.columnHeader11.Width = 418;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "VALOR";
            this.columnHeader12.Width = 193;
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.Location = new System.Drawing.Point(633, 381);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(90, 23);
            this.btnConsulta1.TabIndex = 5;
            this.btnConsulta1.Text = "CONSULTA 1";
            this.btnConsulta1.UseVisualStyleBackColor = true;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.Location = new System.Drawing.Point(633, 410);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(90, 23);
            this.btnConsulta2.TabIndex = 6;
            this.btnConsulta2.Text = "CONSULTA 2";
            this.btnConsulta2.UseVisualStyleBackColor = true;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // btnConsulta3
            // 
            this.btnConsulta3.Location = new System.Drawing.Point(633, 439);
            this.btnConsulta3.Name = "btnConsulta3";
            this.btnConsulta3.Size = new System.Drawing.Size(90, 23);
            this.btnConsulta3.TabIndex = 7;
            this.btnConsulta3.Text = "CONSULTA 3";
            this.btnConsulta3.UseVisualStyleBackColor = true;
            this.btnConsulta3.Click += new System.EventHandler(this.btnConsulta3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(633, 468);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 507);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsulta3);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.btnConsulta1);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.lvEmpleados);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmPlanilla";
            this.Text = "Control de Pago de Empleados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.ComboBox cboCondicion;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtFechaIng;
        private System.Windows.Forms.ListView lvEmpleados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView lvEstadisticas;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.Button btnConsulta3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtHijos;
        private System.Windows.Forms.Label label3;
    }
}

