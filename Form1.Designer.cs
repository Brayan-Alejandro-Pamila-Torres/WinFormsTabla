namespace WinFormsTabla
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
            labelNombre = new Label();
            labelEdad = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            BtnGuardar = new Button();
            BtnLimpiar = new Button();
            Grilla = new DataGridView();
            BtnExit = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grilla).BeginInit();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(53, 42);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(57, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre: ";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(63, 82);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(39, 15);
            labelEdad.TabIndex = 1;
            labelEdad.Text = "Edad: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(190, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 22);
            txtNombre.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(190, 79);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 22);
            txtEdad.TabIndex = 3;
            // 
            // BtnGuardar
            // 
            BtnGuardar.ForeColor = SystemColors.Highlight;
            BtnGuardar.Location = new Point(482, 42);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(93, 60);
            BtnGuardar.TabIndex = 4;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += button1_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(600, 42);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(86, 60);
            BtnLimpiar.TabIndex = 5;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // Grilla
            // 
            Grilla.BackgroundColor = SystemColors.Control;
            Grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla.Location = new Point(53, 147);
            Grilla.Name = "Grilla";
            Grilla.Size = new Size(633, 157);
            Grilla.TabIndex = 6;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(702, 42);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(86, 60);
            BtnExit.TabIndex = 7;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 427);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 8;
            label1.Text = "Brayan Alejandro Pamila Torres";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BtnExit);
            Controls.Add(Grilla);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnGuardar);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(labelEdad);
            Controls.Add(labelNombre);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Highlight;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private Label labelEdad;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Button BtnGuardar;
        private Button BtnLimpiar;
        private DataGridView Grilla;
        private Button BtnExit;
        private Label label1;
    }
}
