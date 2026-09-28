namespace SP1
{
    partial class frmInicio
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
            lblBienvenidoalSistema = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblBienvenidoalSistema
            // 
            lblBienvenidoalSistema.AutoSize = true;
            lblBienvenidoalSistema.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenidoalSistema.Font = new Font("Segoe UI", 24F);
            lblBienvenidoalSistema.Location = new Point(94, 84);
            lblBienvenidoalSistema.Margin = new Padding(4, 0, 4, 0);
            lblBienvenidoalSistema.Name = "lblBienvenidoalSistema";
            lblBienvenidoalSistema.Size = new Size(332, 47);
            lblBienvenidoalSistema.TabIndex = 0;
            lblBienvenidoalSistema.Text = "Bienvenido al Sistema";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(182, 216);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(145, 56);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button1_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 331);
            Controls.Add(btnAceptar);
            Controls.Add(lblBienvenidoalSistema);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenidoalSistema;
        private Button btnAceptar;
    }
}