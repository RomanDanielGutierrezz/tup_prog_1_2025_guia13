namespace EJ1
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
            GroupBox1 = new GroupBox();
            btnMonto = new Button();
            btnVerT = new Button();
            btnRegistrarN = new Button();
            GroupBox2 = new GroupBox();
            btnVerDNI = new Button();
            tbDNI = new TextBox();
            lbDni = new Label();
            GroupBox3 = new GroupBox();
            btnCausa = new Button();
            tbCausa = new TextBox();
            lbCausa = new Label();
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            GroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = SystemColors.ButtonHighlight;
            GroupBox1.Controls.Add(btnMonto);
            GroupBox1.Controls.Add(btnVerT);
            GroupBox1.Controls.Add(btnRegistrarN);
            GroupBox1.Location = new Point(20, 26);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(591, 166);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Expediente";
            // 
            // btnMonto
            // 
            btnMonto.Location = new Point(407, 43);
            btnMonto.Name = "btnMonto";
            btnMonto.Size = new Size(158, 90);
            btnMonto.TabIndex = 2;
            btnMonto.Text = "Ver mayores en monto";
            btnMonto.UseVisualStyleBackColor = true;
            btnMonto.Click += btnMonto_Click;
            // 
            // btnVerT
            // 
            btnVerT.Location = new Point(217, 43);
            btnVerT.Name = "btnVerT";
            btnVerT.Size = new Size(158, 90);
            btnVerT.TabIndex = 1;
            btnVerT.Text = "Ver Todos";
            btnVerT.UseVisualStyleBackColor = true;
            btnVerT.Click += btnVerT_Click;
            // 
            // btnRegistrarN
            // 
            btnRegistrarN.Location = new Point(27, 43);
            btnRegistrarN.Name = "btnRegistrarN";
            btnRegistrarN.Size = new Size(158, 90);
            btnRegistrarN.TabIndex = 0;
            btnRegistrarN.Text = "Registrar Nuevo";
            btnRegistrarN.UseVisualStyleBackColor = true;
            btnRegistrarN.Click += btnRegistrarN_Click;
            // 
            // GroupBox2
            // 
            GroupBox2.BackColor = SystemColors.ButtonHighlight;
            GroupBox2.Controls.Add(btnVerDNI);
            GroupBox2.Controls.Add(tbDNI);
            GroupBox2.Controls.Add(lbDni);
            GroupBox2.Location = new Point(20, 245);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(591, 166);
            GroupBox2.TabIndex = 1;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Ver Expediente de una Persona";
            // 
            // btnVerDNI
            // 
            btnVerDNI.Location = new Point(362, 47);
            btnVerDNI.Name = "btnVerDNI";
            btnVerDNI.Size = new Size(158, 90);
            btnVerDNI.TabIndex = 3;
            btnVerDNI.Text = "Ver Expedientes";
            btnVerDNI.UseVisualStyleBackColor = true;
            btnVerDNI.Click += btnVerDNI_Click;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(94, 82);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(233, 23);
            tbDNI.TabIndex = 1;
            // 
            // lbDni
            // 
            lbDni.AutoSize = true;
            lbDni.Location = new Point(61, 85);
            lbDni.Name = "lbDni";
            lbDni.Size = new Size(27, 15);
            lbDni.TabIndex = 0;
            lbDni.Text = "DNI";
            // 
            // GroupBox3
            // 
            GroupBox3.BackColor = SystemColors.ButtonHighlight;
            GroupBox3.Controls.Add(btnCausa);
            GroupBox3.Controls.Add(tbCausa);
            GroupBox3.Controls.Add(lbCausa);
            GroupBox3.Location = new Point(20, 461);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(591, 166);
            GroupBox3.TabIndex = 1;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Ver expediente";
            // 
            // btnCausa
            // 
            btnCausa.Location = new Point(362, 49);
            btnCausa.Name = "btnCausa";
            btnCausa.Size = new Size(158, 90);
            btnCausa.TabIndex = 4;
            btnCausa.Text = "Ver Causa";
            btnCausa.UseVisualStyleBackColor = true;
            btnCausa.Click += btnCausa_Click;
            // 
            // tbCausa
            // 
            tbCausa.Location = new Point(94, 84);
            tbCausa.Name = "tbCausa";
            tbCausa.Size = new Size(233, 23);
            tbCausa.TabIndex = 3;
            // 
            // lbCausa
            // 
            lbCausa.AutoSize = true;
            lbCausa.Location = new Point(94, 57);
            lbCausa.Name = "lbCausa";
            lbCausa.Size = new Size(102, 15);
            lbCausa.TabIndex = 2;
            lbCausa.Text = "Numero de Causa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(633, 639);
            Controls.Add(GroupBox3);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parcial 2";
            GroupBox1.ResumeLayout(false);
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox1;
        private GroupBox GroupBox2;
        private GroupBox GroupBox3;
        private Button btnMonto;
        private Button btnVerT;
        private Button btnRegistrarN;
        private Button btnVerDNI;
        private TextBox tbDNI;
        private Label lbDni;
        private TextBox tbCausa;
        private Label lbCausa;
        private Button btnCausa;
    }
}
