namespace EJ1
{
    partial class FormVerExpediente
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
            groupBox1 = new GroupBox();
            lsbExpedientes = new ListBox();
            btnCerrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsbExpedientes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 217);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expedientes";
            // 
            // lsbExpedientes
            // 
            lsbExpedientes.FormattingEnabled = true;
            lsbExpedientes.ItemHeight = 15;
            lsbExpedientes.Location = new Point(15, 22);
            lsbExpedientes.Name = "lsbExpedientes";
            lsbExpedientes.Size = new Size(400, 184);
            lsbExpedientes.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.DialogResult = DialogResult.Cancel;
            btnCerrar.Location = new Point(127, 235);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(206, 53);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormVerExpediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 300);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormVerExpediente";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCerrar;
        public ListBox lsbExpedientes;
    }
}