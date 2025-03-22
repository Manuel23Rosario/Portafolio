namespace Practica_P2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Edicion = new System.Windows.Forms.ToolStripMenuItem();
            this.Atras = new System.Windows.Forms.ToolStripMenuItem();
            this.Adelante = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.Pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.Color = new System.Windows.Forms.ToolStripMenuItem();
            this.Formato = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_coiar = new System.Windows.Forms.ToolStripButton();
            this.btn_cortar = new System.Windows.Forms.ToolStripButton();
            this.btn_pegar = new System.Windows.Forms.ToolStripButton();
            this.Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(766, 367);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Edicion,
            this.Color,
            this.Formato});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abrir,
            this.Guardar,
            this.Cerrar});
            this.Archivo.Name = "Archivo";
            this.Archivo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Archivo.Size = new System.Drawing.Size(73, 24);
            this.Archivo.Text = "Archivo";
            // 
            // Edicion
            // 
            this.Edicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atras,
            this.Adelante,
            this.toolStripSeparator1,
            this.Copiar,
            this.Cortar,
            this.Pegar,
            this.toolStripSeparator2,
            this.SeleccionarTodo,
            this.EliminarTodo});
            this.Edicion.Name = "Edicion";
            this.Edicion.Size = new System.Drawing.Size(72, 24);
            this.Edicion.Text = "Edicion";
            // 
            // Atras
            // 
            this.Atras.Image = global::Practica_P2.Properties.Resources.Atras___copia;
            this.Atras.Name = "Atras";
            this.Atras.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Atras.Size = new System.Drawing.Size(264, 26);
            this.Atras.Text = "Atras";
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Adelante
            // 
            this.Adelante.Image = global::Practica_P2.Properties.Resources.Adelante;
            this.Adelante.Name = "Adelante";
            this.Adelante.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Adelante.Size = new System.Drawing.Size(264, 26);
            this.Adelante.Text = "Adelante";
            this.Adelante.Click += new System.EventHandler(this.Adelante_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // Copiar
            // 
            this.Copiar.Image = global::Practica_P2.Properties.Resources.Copiar;
            this.Copiar.Name = "Copiar";
            this.Copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copiar.Size = new System.Drawing.Size(264, 26);
            this.Copiar.Text = "Copiar";
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // Cortar
            // 
            this.Cortar.Image = global::Practica_P2.Properties.Resources.Cortar;
            this.Cortar.Name = "Cortar";
            this.Cortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cortar.Size = new System.Drawing.Size(264, 26);
            this.Cortar.Text = "Cortar";
            this.Cortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // Pegar
            // 
            this.Pegar.Image = global::Practica_P2.Properties.Resources.Pegar;
            this.Pegar.Name = "Pegar";
            this.Pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Pegar.Size = new System.Drawing.Size(264, 26);
            this.Pegar.Text = "Pegar";
            this.Pegar.Click += new System.EventHandler(this.Pegar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(261, 6);
            // 
            // SeleccionarTodo
            // 
            this.SeleccionarTodo.Image = global::Practica_P2.Properties.Resources.Seleccionar_Todo;
            this.SeleccionarTodo.Name = "SeleccionarTodo";
            this.SeleccionarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.SeleccionarTodo.Size = new System.Drawing.Size(264, 26);
            this.SeleccionarTodo.Text = "Seleccionar Todo";
            this.SeleccionarTodo.Click += new System.EventHandler(this.SeleccionarTodo_Click);
            // 
            // EliminarTodo
            // 
            this.EliminarTodo.Image = global::Practica_P2.Properties.Resources.Eliminar_Todo;
            this.EliminarTodo.Name = "EliminarTodo";
            this.EliminarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.EliminarTodo.Size = new System.Drawing.Size(264, 26);
            this.EliminarTodo.Text = "Eliminar Todo";
            this.EliminarTodo.Click += new System.EventHandler(this.EliminarTodo_Click);
            // 
            // Color
            // 
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(59, 24);
            this.Color.Text = "Color";
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Formato
            // 
            this.Formato.Name = "Formato";
            this.Formato.Size = new System.Drawing.Size(79, 24);
            this.Formato.Text = "Formato";
            this.Formato.Click += new System.EventHandler(this.Formato_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_coiar,
            this.btn_cortar,
            this.btn_pegar,
            this.ComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ComboBox1
            // 
            this.ComboBox1.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "18",
            "20",
            "24",
            "28",
            "29",
            "36",
            "42"});
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 28);
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.seleccionar_tamaño);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_coiar
            // 
            this.btn_coiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_coiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_coiar.Image")));
            this.btn_coiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_coiar.Name = "btn_coiar";
            this.btn_coiar.Size = new System.Drawing.Size(29, 25);
            this.btn_coiar.Text = "Copiar";
            this.btn_coiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // btn_cortar
            // 
            this.btn_cortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cortar.Image = global::Practica_P2.Properties.Resources.Cortar;
            this.btn_cortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cortar.Name = "btn_cortar";
            this.btn_cortar.Size = new System.Drawing.Size(29, 25);
            this.btn_cortar.Text = "Cortar";
            this.btn_cortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // btn_pegar
            // 
            this.btn_pegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_pegar.Image = global::Practica_P2.Properties.Resources.Pegar;
            this.btn_pegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pegar.Name = "btn_pegar";
            this.btn_pegar.Size = new System.Drawing.Size(29, 25);
            this.btn_pegar.Text = "Pegar";
            this.btn_pegar.Click += new System.EventHandler(this.Pegar_Click);
            // 
            // Abrir
            // 
            this.Abrir.Image = global::Practica_P2.Properties.Resources.Abrir;
            this.Abrir.Name = "Abrir";
            this.Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Abrir.Size = new System.Drawing.Size(224, 26);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Guardar
            // 
            this.Guardar.Image = global::Practica_P2.Properties.Resources.Guardar;
            this.Guardar.Name = "Guardar";
            this.Guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Guardar.Size = new System.Drawing.Size(224, 26);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Image = global::Practica_P2.Properties.Resources.Cerrar1;
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Cerrar.Size = new System.Drawing.Size(224, 26);
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Editor de Texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem Cerrar;
        private System.Windows.Forms.ToolStripMenuItem Edicion;
        private System.Windows.Forms.ToolStripMenuItem Atras;
        private System.Windows.Forms.ToolStripMenuItem Adelante;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Copiar;
        private System.Windows.Forms.ToolStripMenuItem Cortar;
        private System.Windows.Forms.ToolStripMenuItem Pegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SeleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem EliminarTodo;
        private System.Windows.Forms.ToolStripMenuItem Color;
        private System.Windows.Forms.ToolStripMenuItem Formato;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_coiar;
        private System.Windows.Forms.ToolStripButton btn_cortar;
        private System.Windows.Forms.ToolStripButton btn_pegar;
        private System.Windows.Forms.ToolStripComboBox ComboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}