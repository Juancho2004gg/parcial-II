namespace WinFormsApp1
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
            num1TextBox = new TextBox();
            num2TextBox = new TextBox();
            cuadradoRadioButton = new RadioButton();
            resultadoLabel = new Label();
            mcmRadioButton = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            calcularButton = new Button();
            SuspendLayout();
            // 
            // num1TextBox
            // 
            num1TextBox.Location = new Point(158, 103);
            num1TextBox.Name = "num1TextBox";
            num1TextBox.Size = new Size(125, 27);
            num1TextBox.TabIndex = 0;
            // 
            // num2TextBox
            // 
            num2TextBox.Location = new Point(366, 103);
            num2TextBox.Name = "num2TextBox";
            num2TextBox.Size = new Size(125, 27);
            num2TextBox.TabIndex = 1;
            // 
            // cuadradoRadioButton
            // 
            cuadradoRadioButton.AutoSize = true;
            cuadradoRadioButton.Location = new Point(158, 156);
            cuadradoRadioButton.Name = "cuadradoRadioButton";
            cuadradoRadioButton.Size = new Size(95, 24);
            cuadradoRadioButton.TabIndex = 2;
            cuadradoRadioButton.TabStop = true;
            cuadradoRadioButton.Text = "Cuadrado";
            cuadradoRadioButton.UseVisualStyleBackColor = true;
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Location = new Point(339, 160);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(78, 20);
            resultadoLabel.TabIndex = 3;
            resultadoLabel.Text = "Resultado:";
            // 
            // mcmRadioButton
            // 
            mcmRadioButton.AutoSize = true;
            mcmRadioButton.Location = new Point(158, 186);
            mcmRadioButton.Name = "mcmRadioButton";
            mcmRadioButton.Size = new Size(65, 24);
            mcmRadioButton.TabIndex = 4;
            mcmRadioButton.TabStop = true;
            mcmRadioButton.Text = "MCM";
            mcmRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 64);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 5;
            label1.Text = "Ingresar primer numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 72);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 64);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 7;
            label3.Text = "Ingresar segundo numero";
            label3.Click += label3_Click;
            // 
            // calcularButton
            // 
            calcularButton.Location = new Point(158, 228);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(94, 29);
            calcularButton.TabIndex = 8;
            calcularButton.Text = "Calcular";
            calcularButton.UseVisualStyleBackColor = true;
            calcularButton.Click += calcularButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calcularButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mcmRadioButton);
            Controls.Add(resultadoLabel);
            Controls.Add(cuadradoRadioButton);
            Controls.Add(num2TextBox);
            Controls.Add(num1TextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1TextBox;
        private TextBox num2TextBox;
        private RadioButton cuadradoRadioButton;
        private Label resultadoLabel;
        private RadioButton mcmRadioButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button calcularButton;
    }
}
