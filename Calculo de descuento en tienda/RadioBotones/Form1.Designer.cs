namespace RadioBotones
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
            label1 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtMonto = new TextBox();
            groupBox1 = new GroupBox();
            rb20 = new RadioButton();
            rb10 = new RadioButton();
            rbSinDescuento = new RadioButton();
            btnCalcular = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre del cliente:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(204, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 142);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 3;
            label3.Text = "Monto de compra:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(204, 147);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(253, 23);
            txtMonto.TabIndex = 4;
            txtMonto.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb20);
            groupBox1.Controls.Add(rb10);
            groupBox1.Controls.Add(rbSinDescuento);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(20, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 153);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de cliente";
            // 
            // rb20
            // 
            rb20.AutoSize = true;
            rb20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb20.Location = new Point(300, 68);
            rb20.Name = "rb20";
            rb20.Size = new Size(137, 21);
            rb20.TabIndex = 2;
            rb20.TabStop = true;
            rb20.Text = "20% de descuento";
            rb20.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            rb10.AutoSize = true;
            rb10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb10.Location = new Point(139, 68);
            rb10.Name = "rb10";
            rb10.Size = new Size(137, 21);
            rb10.TabIndex = 1;
            rb10.TabStop = true;
            rb10.Text = "10% de descuento";
            rb10.UseVisualStyleBackColor = true;
            // 
            // rbSinDescuento
            // 
            rbSinDescuento.AutoSize = true;
            rbSinDescuento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbSinDescuento.Location = new Point(6, 68);
            rbSinDescuento.Name = "rbSinDescuento";
            rbSinDescuento.Size = new Size(112, 21);
            rbSinDescuento.TabIndex = 0;
            rbSinDescuento.TabStop = true;
            rbSinDescuento.Text = "Sin descuento";
            rbSinDescuento.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(26, 363);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(105, 50);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // button2
            // 
            button2.Location = new Point(191, 363);
            button2.Name = "button2";
            button2.Size = new Size(105, 50);
            button2.TabIndex = 7;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(352, 363);
            button3.Name = "button3";
            button3.Size = new Size(105, 50);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 25);
            label2.Name = "label2";
            label2.Size = new Size(370, 47);
            label2.TabIndex = 9;
            label2.Text = "Cálculo de descuento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 426);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox1);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calc";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtMonto;
        private GroupBox groupBox1;
        private RadioButton rb20;
        private RadioButton rb10;
        private RadioButton rbSinDescuento;
        private Button btnCalcular;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}
