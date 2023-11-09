namespace Vista
{
    partial class FormAsiento
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
            btnAgregar = new Button();
            lbl = new Label();
            btnCancelar = new Button();
            comboConceptos = new ComboBox();
            btnEliminar = new Button();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numMonto = new NumericUpDown();
            label3 = new Label();
            dgvAsientos = new DataGridView();
            label1 = new Label();
            numCodigo = new NumericUpDown();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            comboLibros = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCodigo).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(12, 439);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(79, 27);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(22, 75);
            lbl.Name = "lbl";
            lbl.Size = new Size(44, 17);
            lbl.TabIndex = 6;
            lbl.Text = "Fecha:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(530, 439);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 27);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // comboConceptos
            // 
            comboConceptos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboConceptos.FormattingEnabled = true;
            comboConceptos.Location = new Point(85, 117);
            comboConceptos.Name = "comboConceptos";
            comboConceptos.Size = new Size(187, 23);
            comboConceptos.TabIndex = 10;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(530, 232);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 27);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 245);
            label5.Name = "label5";
            label5.Size = new Size(120, 17);
            label5.TabIndex = 18;
            label5.Text = "Todos los asientos:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(72, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // numMonto
            // 
            numMonto.Location = new Point(85, 157);
            numMonto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numMonto.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(170, 23);
            numMonto.TabIndex = 21;
            numMonto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 163);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 20;
            label3.Text = "Monto:";
            // 
            // dgvAsientos
            // 
            dgvAsientos.AllowUserToAddRows = false;
            dgvAsientos.AllowUserToDeleteRows = false;
            dgvAsientos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAsientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsientos.Location = new Point(12, 265);
            dgvAsientos.MultiSelect = false;
            dgvAsientos.Name = "dgvAsientos";
            dgvAsientos.ReadOnly = true;
            dgvAsientos.RowHeadersVisible = false;
            dgvAsientos.RowTemplate.Height = 25;
            dgvAsientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsientos.Size = new Size(626, 168);
            dgvAsientos.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 24;
            label1.Text = "Codigo:";
            // 
            // numCodigo
            // 
            numCodigo.Location = new Point(72, 33);
            numCodigo.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCodigo.Name = "numCodigo";
            numCodigo.Size = new Size(170, 23);
            numCodigo.TabIndex = 25;
            numCodigo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 26;
            label2.Text = "Concepto:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Debe", "Haber" });
            comboBox1.Location = new Point(85, 198);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 204);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 28;
            label4.Text = "Tipo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(329, 33);
            label6.Name = "label6";
            label6.Size = new Size(41, 17);
            label6.TabIndex = 30;
            label6.Text = "Libro:";
            // 
            // comboLibros
            // 
            comboLibros.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboLibros.FormattingEnabled = true;
            comboLibros.Location = new Point(376, 32);
            comboLibros.Name = "comboLibros";
            comboLibros.Size = new Size(187, 23);
            comboLibros.TabIndex = 29;
            // 
            // FormAsiento
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 469);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(comboLibros);
            Controls.Add(label4);
            Controls.Add(btnEliminar);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(numCodigo);
            Controls.Add(label1);
            Controls.Add(dgvAsientos);
            Controls.Add(numMonto);
            Controls.Add(comboConceptos);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(lbl);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormAsiento";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormAsiento_Load;
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCodigo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox chkHabilitado;
        private Label lbl;
        private Button btnCancelar;
        private TextBox txtClave;
        private ComboBox comboConceptos;
        private Button btnAgregar;
        private Button btnEliminar;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numMonto;
        private Label label3;
        private DataGridView dgvAsientos;
        private Label label1;
        private NumericUpDown numCodigo;
        private Label label2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label6;
        private ComboBox comboLibros;
    }
}