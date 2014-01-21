namespace frmBaseConsulta
{
    partial class frmBase
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
            this.gbxResultados = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customTextbox1 = new CustomControlsPack_1.Textbox.CustomTextbox();
            this.customTextbox2 = new CustomControlsPack_1.Textbox.CustomTextbox();
            this.customTextbox3 = new CustomControlsPack_1.Textbox.CustomTextbox();
            this.customTextbox4 = new CustomControlsPack_1.Textbox.CustomTextbox();
            this.customTextbox5 = new CustomControlsPack_1.Textbox.CustomTextbox();
            this.gbxResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxResultados
            // 
            this.gbxResultados.Controls.Add(this.dataGridView1);
            this.gbxResultados.Location = new System.Drawing.Point(12, 197);
            this.gbxResultados.Name = "gbxResultados";
            this.gbxResultados.Size = new System.Drawing.Size(602, 175);
            this.gbxResultados.TabIndex = 0;
            this.gbxResultados.TabStop = false;
            this.gbxResultados.Text = "Resultado";
            this.gbxResultados.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // customTextbox1
            // 
            this.customTextbox1.caracter_permitido = CustomControlsPack_1.Textbox.CustomTextbox.tipo_caracteres.Entero;
            this.customTextbox1.db_columna = null;
            this.customTextbox1.db_tabla = null;
            this.customTextbox1.Location = new System.Drawing.Point(253, 64);
            this.customTextbox1.longitud_maxima = 255;
            this.customTextbox1.mod_color_focus = true;
            this.customTextbox1.Name = "customTextbox1";
            this.customTextbox1.sel_color_focus = CustomControlsPack_1.Textbox.CustomTextbox.colores.Morado;
            this.customTextbox1.Size = new System.Drawing.Size(100, 20);
            this.customTextbox1.TabIndex = 1;
            // 
            // customTextbox2
            // 
            this.customTextbox2.caracter_permitido = CustomControlsPack_1.Textbox.CustomTextbox.tipo_caracteres.Entero;
            this.customTextbox2.db_columna = null;
            this.customTextbox2.db_tabla = null;
            this.customTextbox2.Location = new System.Drawing.Point(71, 21);
            this.customTextbox2.longitud_maxima = 255;
            this.customTextbox2.mod_color_focus = false;
            this.customTextbox2.Name = "customTextbox2";
            this.customTextbox2.sel_color_focus = CustomControlsPack_1.Textbox.CustomTextbox.colores.Amarillo;
            this.customTextbox2.Size = new System.Drawing.Size(100, 20);
            this.customTextbox2.TabIndex = 1;
            // 
            // customTextbox3
            // 
            this.customTextbox3.caracter_permitido = CustomControlsPack_1.Textbox.CustomTextbox.tipo_caracteres.Decimal;
            this.customTextbox3.db_columna = null;
            this.customTextbox3.db_tabla = null;
            this.customTextbox3.Location = new System.Drawing.Point(71, 47);
            this.customTextbox3.longitud_maxima = 255;
            this.customTextbox3.mod_color_focus = false;
            this.customTextbox3.Name = "customTextbox3";
            this.customTextbox3.sel_color_focus = CustomControlsPack_1.Textbox.CustomTextbox.colores.Amarillo;
            this.customTextbox3.Size = new System.Drawing.Size(100, 20);
            this.customTextbox3.TabIndex = 1;
            // 
            // customTextbox4
            // 
            this.customTextbox4.caracter_permitido = CustomControlsPack_1.Textbox.CustomTextbox.tipo_caracteres.Texto;
            this.customTextbox4.db_columna = null;
            this.customTextbox4.db_tabla = null;
            this.customTextbox4.Location = new System.Drawing.Point(71, 73);
            this.customTextbox4.longitud_maxima = 255;
            this.customTextbox4.mod_color_focus = false;
            this.customTextbox4.Name = "customTextbox4";
            this.customTextbox4.sel_color_focus = CustomControlsPack_1.Textbox.CustomTextbox.colores.Amarillo;
            this.customTextbox4.Size = new System.Drawing.Size(100, 20);
            this.customTextbox4.TabIndex = 1;
            // 
            // customTextbox5
            // 
            this.customTextbox5.caracter_permitido = CustomControlsPack_1.Textbox.CustomTextbox.tipo_caracteres.Fecha;
            this.customTextbox5.db_columna = null;
            this.customTextbox5.db_tabla = null;
            this.customTextbox5.Location = new System.Drawing.Point(71, 99);
            this.customTextbox5.longitud_maxima = 255;
            this.customTextbox5.mod_color_focus = false;
            this.customTextbox5.Name = "customTextbox5";
            this.customTextbox5.sel_color_focus = CustomControlsPack_1.Textbox.CustomTextbox.colores.Amarillo;
            this.customTextbox5.Size = new System.Drawing.Size(100, 20);
            this.customTextbox5.TabIndex = 1;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 384);
            this.Controls.Add(this.customTextbox5);
            this.Controls.Add(this.customTextbox4);
            this.Controls.Add(this.customTextbox3);
            this.Controls.Add(this.customTextbox2);
            this.Controls.Add(this.gbxResultados);
            this.Name = "frmBase";
            this.Text = "frmBase";
            this.gbxResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxResultados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControlsPack_1.Textbox.CustomTextbox customTextbox1;
        private CustomControlsPack_1.Textbox.CustomTextbox customTextbox2;
        private CustomControlsPack_1.Textbox.CustomTextbox customTextbox3;
        private CustomControlsPack_1.Textbox.CustomTextbox customTextbox4;
        private CustomControlsPack_1.Textbox.CustomTextbox customTextbox5;
    }
}