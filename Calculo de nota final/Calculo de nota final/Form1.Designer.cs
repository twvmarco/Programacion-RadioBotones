namespace Calculo_de_nota_final
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtAcumulativo = new TextBox();
            txtExamen = new TextBox();
            groupBox1 = new GroupBox();
            rbDistancia = new RadioButton();
            rbPresencial = new RadioButton();
            btnCalcular = new Button();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(359, 47);
            label1.TabIndex = 0;
            label1.Text = "Calculo de nota final";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(186, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre del estudiante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(150, 133);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 2;
            label3.Text = "Nota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(127, 176);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 3;
            label4.Text = "Examen";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(204, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(262, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtAcumulativo
            // 
            txtAcumulativo.Location = new Point(204, 135);
            txtAcumulativo.Name = "txtAcumulativo";
            txtAcumulativo.Size = new Size(262, 23);
            txtAcumulativo.TabIndex = 5;
            // 
            // txtExamen
            // 
            txtExamen.Location = new Point(204, 178);
            txtExamen.Name = "txtExamen";
            txtExamen.Size = new Size(262, 23);
            txtExamen.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDistancia);
            groupBox1.Controls.Add(rbPresencial);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 101);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jornada";
            // 
            // rbDistancia
            // 
            rbDistancia.AutoSize = true;
            rbDistancia.Location = new Point(233, 46);
            rbDistancia.Name = "rbDistancia";
            rbDistancia.Size = new Size(99, 25);
            rbDistancia.TabIndex = 9;
            rbDistancia.TabStop = true;
            rbDistancia.Text = "Distancia";
            rbDistancia.UseVisualStyleBackColor = true;
            // 
            // rbPresencial
            // 
            rbPresencial.AutoSize = true;
            rbPresencial.Location = new Point(24, 46);
            rbPresencial.Name = "rbPresencial";
            rbPresencial.Size = new Size(106, 25);
            rbPresencial.TabIndex = 8;
            rbPresencial.TabStop = true;
            rbPresencial.Text = "Presencial";
            rbPresencial.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(24, 382);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(127, 33);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Cambiar Resultado";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(367, 382);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(99, 33);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(478, 438);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox1);
            Controls.Add(txtExamen);
            Controls.Add(txtAcumulativo);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtAcumulativo;
        private TextBox txtExamen;
        private GroupBox groupBox1;
        private RadioButton rbDistancia;
        private RadioButton rbPresencial;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
