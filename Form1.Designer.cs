namespace DB_Conexion_1
{
    partial class frm_Pokemons
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
            this.dgv_Pokemon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Pokemon
            // 
            this.dgv_Pokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pokemon.Location = new System.Drawing.Point(57, 12);
            this.dgv_Pokemon.Name = "dgv_Pokemon";
            this.dgv_Pokemon.RowHeadersWidth = 62;
            this.dgv_Pokemon.RowTemplate.Height = 28;
            this.dgv_Pokemon.Size = new System.Drawing.Size(715, 426);
            this.dgv_Pokemon.TabIndex = 0;
            // 
            // frm_Pokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Pokemon);
            this.Name = "frm_Pokemons";
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.frm_Pokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Pokemon;
    }
}

