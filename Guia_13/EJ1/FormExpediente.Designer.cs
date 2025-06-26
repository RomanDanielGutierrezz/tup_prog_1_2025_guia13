namespace EJ1
{
    partial class FormExpediente
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
            tbImporte = new TextBox();
            lbImporte = new Label();
            tbDNI = new TextBox();
            lbDNIexpediente = new Label();
            tbNumerocausa = new TextBox();
            lbNmrCausa = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbImporte);
            groupBox1.Controls.Add(lbImporte);
            groupBox1.Controls.Add(tbDNI);
            groupBox1.Controls.Add(lbDNIexpediente);
            groupBox1.Controls.Add(tbNumerocausa);
            groupBox1.Controls.Add(lbNmrCausa);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar";
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(200, 104);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(165, 23);
            tbImporte.TabIndex = 5;
            // 
            // lbImporte
            // 
            lbImporte.AutoSize = true;
            lbImporte.Location = new Point(35, 107);
            lbImporte.Name = "lbImporte";
            lbImporte.Size = new Size(159, 15);
            lbImporte.TabIndex = 4;
            lbImporte.Text = "Importe por faltas cometidas";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(200, 75);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(165, 23);
            tbDNI.TabIndex = 3;
            // 
            // lbDNIexpediente
            // 
            lbDNIexpediente.AutoSize = true;
            lbDNIexpediente.Location = new Point(167, 78);
            lbDNIexpediente.Name = "lbDNIexpediente";
            lbDNIexpediente.Size = new Size(27, 15);
            lbDNIexpediente.TabIndex = 2;
            lbDNIexpediente.Text = "DNI";
            // 
            // tbNumerocausa
            // 
            tbNumerocausa.Location = new Point(200, 46);
            tbNumerocausa.Name = "tbNumerocausa";
            tbNumerocausa.Size = new Size(165, 23);
            tbNumerocausa.TabIndex = 1;
            // 
            // lbNmrCausa
            // 
            lbNmrCausa.AutoSize = true;
            lbNmrCausa.Location = new Point(92, 49);
            lbNmrCausa.Name = "lbNmrCausa";
            lbNmrCausa.Size = new Size(102, 15);
            lbNmrCausa.TabIndex = 0;
            lbNmrCausa.Text = "Numero de Causa";
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(32, 176);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(165, 59);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(212, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 59);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormExpediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 243);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormExpediente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Expediente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lbImporte;
        private Label lbDNIexpediente;
        private Label lbNmrCausa;
        public TextBox tbImporte;
        public TextBox tbDNI;
        public TextBox tbNumerocausa;
    }
}