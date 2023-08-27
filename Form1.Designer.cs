namespace problema9enformulario
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
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            lbl1 = new Label();
            boton = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(414, 35);
            label1.TabIndex = 0;
            label1.Text = "Ingrese 1er Número:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 104);
            label2.Name = "label2";
            label2.Size = new Size(414, 35);
            label2.TabIndex = 1;
            label2.Text = "Ingrese 2do Número:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 177);
            label3.Name = "label3";
            label3.Size = new Size(414, 35);
            label3.TabIndex = 2;
            label3.Text = "Ingrese 3er Número:";
            // 
            // txt1
            // 
            txt1.BackColor = SystemColors.ButtonShadow;
            txt1.Font = new Font("OCR A Extended", 22F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(520, 31);
            txt1.Name = "txt1";
            txt1.Size = new Size(89, 45);
            txt1.TabIndex = 3;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txt2
            // 
            txt2.BackColor = SystemColors.ButtonShadow;
            txt2.Font = new Font("OCR A Extended", 22F, FontStyle.Regular, GraphicsUnit.Point);
            txt2.Location = new Point(520, 104);
            txt2.Name = "txt2";
            txt2.Size = new Size(89, 45);
            txt2.TabIndex = 4;
            txt2.TextChanged += txt2_TextChanged;
            // 
            // txt3
            // 
            txt3.BackColor = SystemColors.ButtonShadow;
            txt3.Font = new Font("OCR A Extended", 22F, FontStyle.Regular, GraphicsUnit.Point);
            txt3.Location = new Point(520, 171);
            txt3.Name = "txt3";
            txt3.Size = new Size(89, 45);
            txt3.TabIndex = 5;
            txt3.TextChanged += textBox2_TextChanged;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Silver;
            lbl1.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(35, 350);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(498, 35);
            lbl1.TabIndex = 6;
            lbl1.Text = "El mayor número es.....";
            lbl1.Click += label4_Click_1;
            // 
            // boton
            // 
            boton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            boton.Image = (Image)resources.GetObject("boton.Image");
            boton.Location = new Point(207, 237);
            boton.Name = "boton";
            boton.Size = new Size(195, 64);
            boton.TabIndex = 7;
            boton.UseVisualStyleBackColor = true;
            boton.Click += boton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 281);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(246, 281);
            label6.Name = "label6";
            label6.Size = new Size(128, 37);
            label6.TabIndex = 9;
            label6.Text = "Calcular:";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(646, 415);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(boton);
            Controls.Add(lbl1);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private Label lbl1;
        private Button boton;
        private Label label5;
        private Label label6;
    }
}