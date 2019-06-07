namespace sistemaRestaurante.vistas
{
    partial class MostrarCliente
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
            this.dgwclientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwclientes
            // 
            this.dgwclientes.BackgroundColor = System.Drawing.Color.White;
            this.dgwclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwclientes.Location = new System.Drawing.Point(49, 60);
            this.dgwclientes.Name = "dgwclientes";
            this.dgwclientes.Size = new System.Drawing.Size(359, 229);
            this.dgwclientes.TabIndex = 4;
            this.dgwclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwclientes_CellContentClick);
            // 
            // MostrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 349);
            this.Controls.Add(this.dgwclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MostrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartera de Clientes";
            this.Load += new System.EventHandler(this.MostrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwclientes;
    }
}