namespace CapaPresentacion
{
    partial class WF_Posiciones
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
            dataGridView1 = new DataGridView();
            maskedTextBox1 = new MaskedTextBox();
            txtNombre = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(814, 551);
            dataGridView1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(1070, 237);
            maskedTextBox1.Mask = "99999999.99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(224, 23);
            maskedTextBox1.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1069, 170);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 23);
            txtNombre.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1069, 317);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 3;
            // 
            // WF_Posiciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 717);
            Controls.Add(comboBox1);
            Controls.Add(txtNombre);
            Controls.Add(maskedTextBox1);
            Controls.Add(dataGridView1);
            Name = "WF_Posiciones";
            Text = "WF_Posiciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtNombre;
        private ComboBox comboBox1;
    }
}