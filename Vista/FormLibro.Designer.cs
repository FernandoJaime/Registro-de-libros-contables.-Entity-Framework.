namespace Vista
{
    partial class FormLibro
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            numCapital = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCapital).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(12, 168);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 27);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(198, 168);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 27);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 13;
            label3.Text = "Capital actual:";
            // 
            // numCapital
            // 
            numCapital.Location = new Point(107, 103);
            numCapital.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCapital.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            numCapital.Name = "numCapital";
            numCapital.Size = new Size(170, 23);
            numCapital.TabIndex = 17;
            numCapital.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(62, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 20;
            label1.Text = "Fecha:";
            // 
            // FormLibro
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 202);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(numCapital);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormLibro";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormLibro_Load;
            ((System.ComponentModel.ISupportInitialize)numCapital).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private CheckBox chkHabilitado;
        private Button btnCancelar;
        private TextBox txtClave;
        private Label label3;
        private NumericUpDown numCapital;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}