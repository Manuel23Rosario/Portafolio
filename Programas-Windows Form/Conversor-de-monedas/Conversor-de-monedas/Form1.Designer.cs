namespace Conversor_de_monedas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cob_convert = new ComboBox();
            label1 = new Label();
            txt_pesos = new TextBox();
            button1 = new Button();
            txt_resultado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lbl_mensaje = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cob_convert
            // 
            cob_convert.FormattingEnabled = true;
            cob_convert.Items.AddRange(new object[] { "Dolar", "Euro", "Yen Japones", "Libra Esterlina" });
            cob_convert.Location = new Point(289, 165);
            cob_convert.Name = "cob_convert";
            cob_convert.Size = new Size(151, 28);
            cob_convert.TabIndex = 0;
            cob_convert.SelectedIndexChanged += cob_convert_SelectedIndexChanged;
            cob_convert.Click += cob_convert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 96);
            label1.Name = "label1";
            label1.Size = new Size(183, 23);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la cantidad:";
            // 
            // txt_pesos
            // 
            txt_pesos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pesos.Location = new Point(360, 96);
            txt_pesos.Name = "txt_pesos";
            txt_pesos.Size = new Size(82, 38);
            txt_pesos.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(289, 320);
            button1.Name = "button1";
            button1.Size = new Size(144, 70);
            button1.TabIndex = 5;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_resultado
            // 
            txt_resultado.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_resultado.Location = new Point(289, 240);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(136, 38);
            txt_resultado.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 165);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 8;
            label2.Text = "Convertir a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 244);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 9;
            label3.Text = "Equivale a:";
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.AutoSize = true;
            lbl_mensaje.Location = new Point(431, 252);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(50, 20);
            lbl_mensaje.TabIndex = 10;
            lbl_mensaje.Text = "label4";
            lbl_mensaje.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(118, 28);
            label5.Name = "label5";
            label5.Size = new Size(379, 45);
            label5.TabIndex = 11;
            label5.Text = "Conversor De Monedas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Conversor_de_monedas_Photoroom;
            pictureBox1.Location = new Point(503, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 418);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(lbl_mensaje);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_resultado);
            Controls.Add(button1);
            Controls.Add(txt_pesos);
            Controls.Add(label1);
            Controls.Add(cob_convert);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Conversor De Monedas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cob_convert;
        private Label label1;
        private TextBox txt_pesos;
        private Button button1;
        private TextBox txt_resultado;
        private Label label2;
        private Label label3;
        private Label lbl_mensaje;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
