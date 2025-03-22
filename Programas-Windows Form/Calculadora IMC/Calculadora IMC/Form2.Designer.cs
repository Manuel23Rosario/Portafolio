namespace Calculadora_IMC
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPies = new TextBox();
            txtPeso = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_resultado_altura = new TextBox();
            txt_resultado_peso = new TextBox();
            lbl_altura = new Label();
            lbl_peso = new Label();
            btn_calcular = new Button();
            label8 = new Label();
            txtPulgadas = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 34);
            label1.Name = "label1";
            label1.Size = new Size(323, 41);
            label1.TabIndex = 0;
            label1.Text = "Calcular Altura y Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 114);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Altura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(178, 176);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "Peso:";
            // 
            // txtPies
            // 
            txtPies.Location = new Point(177, 114);
            txtPies.Name = "txtPies";
            txtPies.Size = new Size(125, 27);
            txtPies.TabIndex = 3;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(237, 175);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 27);
            txtPeso.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 180);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Libra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(308, 117);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 6;
            label5.Text = "Pies";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(579, 109);
            label6.Name = "label6";
            label6.Size = new Size(26, 28);
            label6.TabIndex = 7;
            label6.Text = "=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(406, 175);
            label7.Name = "label7";
            label7.Size = new Size(26, 28);
            label7.TabIndex = 8;
            label7.Text = "=";
            // 
            // txt_resultado_altura
            // 
            txt_resultado_altura.Location = new Point(611, 109);
            txt_resultado_altura.Name = "txt_resultado_altura";
            txt_resultado_altura.ReadOnly = true;
            txt_resultado_altura.Size = new Size(125, 27);
            txt_resultado_altura.TabIndex = 9;
            // 
            // txt_resultado_peso
            // 
            txt_resultado_peso.Location = new Point(438, 177);
            txt_resultado_peso.Name = "txt_resultado_peso";
            txt_resultado_peso.ReadOnly = true;
            txt_resultado_peso.Size = new Size(125, 27);
            txt_resultado_peso.TabIndex = 10;
            // 
            // lbl_altura
            // 
            lbl_altura.AutoSize = true;
            lbl_altura.Location = new Point(742, 113);
            lbl_altura.Name = "lbl_altura";
            lbl_altura.Size = new Size(42, 20);
            lbl_altura.TabIndex = 11;
            lbl_altura.Text = "label";
            lbl_altura.Visible = false;
            // 
            // lbl_peso
            // 
            lbl_peso.AutoSize = true;
            lbl_peso.Location = new Point(569, 183);
            lbl_peso.Name = "lbl_peso";
            lbl_peso.Size = new Size(50, 20);
            lbl_peso.TabIndex = 12;
            lbl_peso.Text = "label9";
            lbl_peso.Visible = false;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(348, 234);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(134, 50);
            btn_calcular.TabIndex = 13;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(349, 115);
            label8.Name = "label8";
            label8.Size = new Size(18, 23);
            label8.TabIndex = 14;
            label8.Text = "y";
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(373, 113);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.Size = new Size(125, 27);
            txtPulgadas.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(504, 116);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 16;
            label9.Text = "Pulgadas";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 311);
            Controls.Add(label9);
            Controls.Add(txtPulgadas);
            Controls.Add(label8);
            Controls.Add(btn_calcular);
            Controls.Add(lbl_peso);
            Controls.Add(lbl_altura);
            Controls.Add(txt_resultado_peso);
            Controls.Add(txt_resultado_altura);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPeso);
            Controls.Add(txtPies);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Calculadora de peso y altura";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPies;
        private TextBox txtPeso;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_resultado_altura;
        private TextBox txt_resultado_peso;
        private Label lbl_altura;
        private Label lbl_peso;
        private Button btn_calcular;
        private Label label8;
        private TextBox txtPulgadas;
        private Label label9;
    }
}