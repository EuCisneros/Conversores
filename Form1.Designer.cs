namespace conversor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.txtsalida = new System.Windows.Forms.TextBox();
            this.cmbentrada = new System.Windows.Forms.ComboBox();
            this.cmbsalida = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtentrada
            // 
            this.txtentrada.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtentrada.Location = new System.Drawing.Point(72, 108);
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(163, 20);
            this.txtentrada.TabIndex = 0;
            this.txtentrada.TextChanged += new System.EventHandler(this.txtentrada_TextChanged);
            // 
            // txtsalida
            // 
            this.txtsalida.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtsalida.Location = new System.Drawing.Point(309, 109);
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(170, 20);
            this.txtsalida.TabIndex = 1;
            // 
            // cmbentrada
            // 
            this.cmbentrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbentrada.FormattingEnabled = true;
            this.cmbentrada.Items.AddRange(new object[] {
            "RUBLO RUSO",
            "PESO FILIPINO",
            "PESO CHILENO",
            "PESO COLOMBIANO",
            "DOLAR ESTADOUNIDENSE",
            "",
            "KILOMETROS",
            "METROS",
            "PIES",
            "PULGADAS",
            "CENTIMETROS",
            "",
            "QUINTAL",
            "TONELADA",
            "LIBRA",
            "ONZA",
            "GRAMO",
            "",
            "KILÓMETRO CÚBICO",
            "DECÁMETRO CÚBICO",
            "METRO CÚBICO",
            "DECÍMETRO CÚBICO",
            "MILÍMETRO CÚBICO"});
            this.cmbentrada.Location = new System.Drawing.Point(72, 166);
            this.cmbentrada.Name = "cmbentrada";
            this.cmbentrada.Size = new System.Drawing.Size(163, 21);
            this.cmbentrada.TabIndex = 2;
            this.cmbentrada.SelectedIndexChanged += new System.EventHandler(this.cmbentrada_SelectedIndexChanged);
            // 
            // cmbsalida
            // 
            this.cmbsalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsalida.FormattingEnabled = true;
            this.cmbsalida.Items.AddRange(new object[] {
            "RUBLO RUSO",
            "PESO FILIPINO",
            "PESO CHILENO",
            "PESO COLOMBIANO",
            "DOLAR ESTADOUNIDENSE",
            "",
            "KILOMETROS",
            "METROS",
            "PIES",
            "PULGADAS",
            "CENTIMETROS",
            "",
            "QUINTAL",
            "TONELADA",
            "LIBRA",
            "ONZA",
            "GRAMO",
            "",
            "KILÓMETRO CÚBICO",
            "DECÁMETRO CÚBICO",
            "METRO CÚBICO",
            "DECÍMETRO CÚBICO",
            "MILÍMETRO CÚBICO"});
            this.cmbsalida.Location = new System.Drawing.Point(309, 167);
            this.cmbsalida.Name = "cmbsalida";
            this.cmbsalida.Size = new System.Drawing.Size(170, 21);
            this.cmbsalida.TabIndex = 3;
            this.cmbsalida.SelectedIndexChanged += new System.EventHandler(this.cmbsalida_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 347);
            this.Controls.Add(this.cmbsalida);
            this.Controls.Add(this.cmbentrada);
            this.Controls.Add(this.txtsalida);
            this.Controls.Add(this.txtentrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtentrada;
        private System.Windows.Forms.TextBox txtsalida;
        private System.Windows.Forms.ComboBox cmbentrada;
        private System.Windows.Forms.ComboBox cmbsalida;
    }
}

