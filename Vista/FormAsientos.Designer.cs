namespace Vista
{
    partial class FormAsientos
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
            btnVolver = new Button();
            lbl = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numCapital = new NumericUpDown();
            label3 = new Label();
            dgvAsientoss = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numCapital).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsientoss).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(12, 369);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(79, 27);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(12, 23);
            lbl.Name = "lbl";
            lbl.Size = new Size(41, 17);
            lbl.TabIndex = 6;
            lbl.Text = "Libro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 107);
            label5.Name = "label5";
            label5.Size = new Size(113, 17);
            label5.TabIndex = 18;
            label5.Text = "Asientos del libro:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(59, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // numCapital
            // 
            numCapital.Location = new Point(107, 60);
            numCapital.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCapital.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            numCapital.Name = "numCapital";
            numCapital.Size = new Size(152, 23);
            numCapital.TabIndex = 21;
            numCapital.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 20;
            label3.Text = "Capital actual:";
            // 
            // dgvAsientoss
            // 
            dgvAsientoss.AllowUserToAddRows = false;
            dgvAsientoss.AllowUserToDeleteRows = false;
            dgvAsientoss.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAsientoss.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsientoss.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsientoss.Location = new Point(12, 127);
            dgvAsientoss.MultiSelect = false;
            dgvAsientoss.Name = "dgvAsientoss";
            dgvAsientoss.ReadOnly = true;
            dgvAsientoss.RowHeadersVisible = false;
            dgvAsientoss.RowTemplate.Height = 25;
            dgvAsientoss.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsientoss.Size = new Size(691, 229);
            dgvAsientoss.TabIndex = 22;
            // 
            // FormAsientos
            // 
            AcceptButton = btnVolver;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 399);
            ControlBox = false;
            Controls.Add(dgvAsientoss);
            Controls.Add(numCapital);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(lbl);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormAsientos";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormAsientos_Load;
            ((System.ComponentModel.ISupportInitialize)numCapital).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsientoss).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private CheckBox chkHabilitado;
        private Label lbl;
        private TextBox txtClave;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numCapital;
        private Label label3;
        private DataGridView dgvAsientoss;
    }
}