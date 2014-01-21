namespace frmLogin
{
    partial class frmLogin
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
            this.customTextbox1 = new CustomControlsPack_1.Textbox.CustomTextbox();
            this.customTextbox2 = new CustomControlsPack_1.Textbox.CustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customTextbox1
            // 
            this.customTextbox1.caracter_permitido = CustomControlsPack_1.Textbox.CustomTextbox.tipo_caracteres.Texto;
            this.customTextbox1.db_columna = null;
            this.customTextbox1.db_tabla = null;
            this.customTextbox1.Location = new System.Drawing.Point(82, 12);
            this.customTextbox1.longitud_maxima = 255;
            this.customTextbox1.mod_color_focus = false;
            this.customTextbox1.Name = "customTextbox1";
            this.customTextbox1.sel_color_focus = CustomControlsPack_1.Textbox.CustomTextbox.colores.Amarillo;
            this.customTextbox1.Size = new System.Drawing.Size(100, 20);
            this.customTextbox1.TabIndex = 0;
            // 
            // customTextbox2
            // 
            this.customTextbox2.caracter_permitido = CustomControlsPack_1.Textbox.CustomTextbox.tipo_caracteres.Texto;
            this.customTextbox2.db_columna = null;
            this.customTextbox2.db_tabla = null;
            this.customTextbox2.Location = new System.Drawing.Point(82, 38);
            this.customTextbox2.longitud_maxima = 255;
            this.customTextbox2.mod_color_focus = false;
            this.customTextbox2.Name = "customTextbox2";
            this.customTextbox2.PasswordChar = '*';
            this.customTextbox2.sel_color_focus = CustomControlsPack_1.Textbox.CustomTextbox.colores.Amarillo;
            this.customTextbox2.Size = new System.Drawing.Size(100, 20);
            this.customTextbox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 127);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customTextbox2);
            this.Controls.Add(this.customTextbox1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControlsPack_1.Textbox.CustomTextbox customTextbox1;
        private CustomControlsPack_1.Textbox.CustomTextbox customTextbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}