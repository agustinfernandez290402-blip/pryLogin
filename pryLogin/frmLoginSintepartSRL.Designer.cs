namespace pryLogin
{
    partial class frmLoginSintepartSRL
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            TxtUsuario = new TextBox();
            txtContraseña = new TextBox();
            cmbCombo = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblerror = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(65, 56);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += label1_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(65, 87);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(65, 124);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Modulo";
            // 
            // TxtUsuario
            // 
            TxtUsuario.ForeColor = Color.Blue;
            TxtUsuario.Location = new Point(136, 56);
            TxtUsuario.MaxLength = 10;
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(105, 23);
            TxtUsuario.TabIndex = 3;
            TxtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(136, 90);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(105, 23);
            txtContraseña.TabIndex = 4;
            // 
            // cmbCombo
            // 
            cmbCombo.FormattingEnabled = true;
            cmbCombo.Items.AddRange(new object[] { "ADM ", "SIST ", "COM", "VTA" });
            cmbCombo.Location = new Point(136, 124);
            cmbCombo.Name = "cmbCombo";
            cmbCombo.Size = new Size(105, 23);
            cmbCombo.TabIndex = 5;
            cmbCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(301, 56);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(93, 27);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(301, 100);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 27);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.Location = new Point(37, 171);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(38, 15);
            lblerror.TabIndex = 8;
            lblerror.Text = "label1";
            lblerror.Click += label1_Click_1;
            // 
            // frmLoginSintepartSRL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 225);
            Controls.Add(lblerror);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(cmbCombo);
            Controls.Add(txtContraseña);
            Controls.Add(TxtUsuario);
            Name = "frmLoginSintepartSRL";
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox TxtUsuario;
        private TextBox txtContraseña;
        private ComboBox cmbCombo;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblerror;
    }
}