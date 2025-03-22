namespace Calculadora_IMC
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_altura = new TextBox();
            txt_peso = new TextBox();
            btn_calcular = new Button();
            label4 = new Label();
            btn_peso_altura = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(243, 34);
            label1.TabIndex = 0;
            label1.Text = "Calculadora IMC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 194);
            label2.Name = "label2";
            label2.Size = new Size(161, 24);
            label2.TabIndex = 1;
            label2.Text = "Peso(Kilogramos):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 128);
            label3.Name = "label3";
            label3.Size = new Size(140, 24);
            label3.TabIndex = 2;
            label3.Text = "Altura(Metros):";
            // 
            // txt_altura
            // 
            txt_altura.Location = new Point(275, 128);
            txt_altura.Name = "txt_altura";
            txt_altura.Size = new Size(125, 27);
            txt_altura.TabIndex = 3;
            // 
            // txt_peso
            // 
            txt_peso.Location = new Point(295, 194);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(125, 27);
            txt_peso.TabIndex = 4;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(335, 293);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(124, 58);
            btn_calcular.TabIndex = 5;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(102, 224);
            label4.Name = "label4";
            label4.Size = new Size(415, 34);
            label4.TabIndex = 6;
            label4.Text = "(Si necesitas calcular tu peso de libas a kg o tu atura de centimetro a \r\nM usa el boton que dice peso y altura)";
            // 
            // btn_peso_altura
            // 
            btn_peso_altura.Location = new Point(140, 293);
            btn_peso_altura.Name = "btn_peso_altura";
            btn_peso_altura.Size = new Size(124, 58);
            btn_peso_altura.TabIndex = 7;
            btn_peso_altura.Text = "Peso y Altura";
            btn_peso_altura.UseVisualStyleBackColor = true;
            btn_peso_altura.Click += btn_peso_altura_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 450);
            Controls.Add(btn_peso_altura);
            Controls.Add(label4);
            Controls.Add(btn_calcular);
            Controls.Add(txt_peso);
            Controls.Add(txt_altura);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_altura;
        private TextBox txt_peso;
        private Button btn_calcular;
        private Label label4;
        private Button btn_peso_altura;
    }
}
