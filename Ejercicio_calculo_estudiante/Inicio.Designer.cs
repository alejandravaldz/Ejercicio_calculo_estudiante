namespace Ejercicio_calculo_estudiante
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            btn_Motrar = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_Nombre = new TextBox();
            txt_Carrera = new TextBox();
            txt_Matricula = new TextBox();
            txt_Edad = new TextBox();
            txt_Apellido = new TextBox();
            txt_Datos = new TextBox();
            SuspendLayout();
            // 
            // btn_Motrar
            // 
            btn_Motrar.BackColor = SystemColors.GradientActiveCaption;
            btn_Motrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Motrar.Location = new Point(740, 112);
            btn_Motrar.Name = "btn_Motrar";
            btn_Motrar.Size = new Size(110, 42);
            btn_Motrar.TabIndex = 0;
            btn_Motrar.Text = "Mostrar";
            btn_Motrar.UseVisualStyleBackColor = false;
            btn_Motrar.Click += btn_Motrar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = SystemColors.GradientActiveCaption;
            btn_Limpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Limpiar.Location = new Point(741, 212);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(109, 45);
            btn_Limpiar.TabIndex = 1;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = SystemColors.GradientActiveCaption;
            btn_Salir.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Salir.Location = new Point(740, 295);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(110, 42);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Lucida Calligraphy", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 48);
            label1.TabIndex = 8;
            label1.Text = "Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 344);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 124);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 15;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 185);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 16;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 248);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 17;
            label5.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 321);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 18;
            label6.Text = "Matricula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(398, 225);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 19;
            label7.Text = "Carrera";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(342, 404);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 20;
            label8.Text = "Datos";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(184, 117);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(125, 27);
            txt_Nombre.TabIndex = 21;
            // 
            // txt_Carrera
            // 
            txt_Carrera.Location = new Point(474, 222);
            txt_Carrera.Name = "txt_Carrera";
            txt_Carrera.Size = new Size(125, 27);
            txt_Carrera.TabIndex = 23;
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(184, 314);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(125, 27);
            txt_Matricula.TabIndex = 24;
            // 
            // txt_Edad
            // 
            txt_Edad.Location = new Point(184, 245);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(125, 27);
            txt_Edad.TabIndex = 25;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(184, 178);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(125, 27);
            txt_Apellido.TabIndex = 26;
            // 
            // txt_Datos
            // 
            txt_Datos.Location = new Point(419, 381);
            txt_Datos.Multiline = true;
            txt_Datos.Name = "txt_Datos";
            txt_Datos.Size = new Size(321, 66);
            txt_Datos.TabIndex = 27;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2024_01_19_a_las_18_35_05_2c1bd4bb;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 562);
            Controls.Add(txt_Datos);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Edad);
            Controls.Add(txt_Matricula);
            Controls.Add(txt_Carrera);
            Controls.Add(txt_Nombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Motrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            Text = "Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Motrar;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_Nombre;
        private TextBox txt_Carrera;
        private TextBox txt_Matricula;
        private TextBox txt_Edad;
        private TextBox txt_Apellido;
        private TextBox txt_Datos;
    }
}