namespace Agenda
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Estado_Civil = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Fecha_Nacimiento = new System.Windows.Forms.Label();
            this.lbl_Movil = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.cbo_Estado_Civil = new System.Windows.Forms.ComboBox();
            this.txt_Movil = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(205, 28);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(78, 22);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(443, 28);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(79, 22);
            this.lbl_Apellido.TabIndex = 1;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_Estado_Civil
            // 
            this.lbl_Estado_Civil.AutoSize = true;
            this.lbl_Estado_Civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado_Civil.Location = new System.Drawing.Point(274, 116);
            this.lbl_Estado_Civil.Name = "lbl_Estado_Civil";
            this.lbl_Estado_Civil.Size = new System.Drawing.Size(110, 22);
            this.lbl_Estado_Civil.TabIndex = 2;
            this.lbl_Estado_Civil.Text = "Estado Civil:";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(36, 116);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(90, 22);
            this.lbl_Direccion.TabIndex = 3;
            this.lbl_Direccion.Text = "Direccion:";
            // 
            // lbl_Fecha_Nacimiento
            // 
            this.lbl_Fecha_Nacimiento.AutoSize = true;
            this.lbl_Fecha_Nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha_Nacimiento.Location = new System.Drawing.Point(663, 28);
            this.lbl_Fecha_Nacimiento.Name = "lbl_Fecha_Nacimiento";
            this.lbl_Fecha_Nacimiento.Size = new System.Drawing.Size(181, 22);
            this.lbl_Fecha_Nacimiento.TabIndex = 4;
            this.lbl_Fecha_Nacimiento.Text = "Fecha de nacimiento:";
            // 
            // lbl_Movil
            // 
            this.lbl_Movil.AutoSize = true;
            this.lbl_Movil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Movil.Location = new System.Drawing.Point(36, 202);
            this.lbl_Movil.Name = "lbl_Movil";
            this.lbl_Movil.Size = new System.Drawing.Size(56, 22);
            this.lbl_Movil.TabIndex = 5;
            this.lbl_Movil.Text = "Movil:";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.Location = new System.Drawing.Point(495, 202);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(164, 22);
            this.lbl_Correo.TabIndex = 7;
            this.lbl_Correo.Text = "Correo Electronico:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(274, 202);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(86, 22);
            this.lbl_Telefono.TabIndex = 8;
            this.lbl_Telefono.Text = "Telefono:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(209, 58);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(205, 28);
            this.txt_Nombre.TabIndex = 9;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido.Location = new System.Drawing.Point(447, 58);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(205, 28);
            this.txt_Apellido.TabIndex = 10;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(40, 141);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(205, 28);
            this.txt_Direccion.TabIndex = 12;
            // 
            // cbo_Estado_Civil
            // 
            this.cbo_Estado_Civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Estado_Civil.FormattingEnabled = true;
            this.cbo_Estado_Civil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Divorciado/a ",
            "Viudo/a"});
            this.cbo_Estado_Civil.Location = new System.Drawing.Point(278, 139);
            this.cbo_Estado_Civil.Name = "cbo_Estado_Civil";
            this.cbo_Estado_Civil.Size = new System.Drawing.Size(148, 30);
            this.cbo_Estado_Civil.TabIndex = 15;
            // 
            // txt_Movil
            // 
            this.txt_Movil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Movil.Location = new System.Drawing.Point(40, 229);
            this.txt_Movil.Name = "txt_Movil";
            this.txt_Movil.Size = new System.Drawing.Size(205, 28);
            this.txt_Movil.TabIndex = 16;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(278, 234);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(205, 28);
            this.txt_Telefono.TabIndex = 17;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.Location = new System.Drawing.Point(498, 234);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(296, 28);
            this.txt_Correo.TabIndex = 18;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insertar.Location = new System.Drawing.Point(104, 298);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(121, 58);
            this.btn_Insertar.TabIndex = 19;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(245, 298);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(126, 58);
            this.btn_Modificar.TabIndex = 20;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Genero:";
            // 
            // cboGenero
            // 
            this.cboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cboGenero.Location = new System.Drawing.Point(498, 139);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(148, 30);
            this.cboGenero.TabIndex = 22;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(12, 362);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.RowHeadersWidth = 51;
            this.dgvAgenda.RowTemplate.Height = 24;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(852, 297);
            this.dgvAgenda.TabIndex = 23;
            this.dgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellClick);
            this.dgvAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellContentClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(558, 301);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(95, 41);
            this.btn_buscar.TabIndex = 24;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(396, 298);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(126, 58);
            this.btn_eliminar.TabIndex = 25;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha.Location = new System.Drawing.Point(668, 58);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(148, 28);
            this.txt_Fecha.TabIndex = 26;
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(22, 58);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Id.Size = new System.Drawing.Size(84, 28);
            this.txt_Id.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(659, 308);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(205, 28);
            this.txt_buscar.TabIndex = 29;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 671);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Movil);
            this.Controls.Add(this.cbo_Estado_Civil);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl_Movil);
            this.Controls.Add(this.lbl_Fecha_Nacimiento);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Estado_Civil);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "Form1";
            this.Text = "git ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Estado_Civil;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Fecha_Nacimiento;
        private System.Windows.Forms.Label lbl_Movil;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.ComboBox cbo_Estado_Civil;
        private System.Windows.Forms.TextBox txt_Movil;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}

