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
            this.ptb_Pokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Pokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Pokemon
            // 
            this.dgv_Pokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pokemon.Location = new System.Drawing.Point(22, 98);
            this.dgv_Pokemon.Name = "dgv_Pokemon";
            this.dgv_Pokemon.RowHeadersWidth = 62;
            this.dgv_Pokemon.RowTemplate.Height = 28;
            this.dgv_Pokemon.Size = new System.Drawing.Size(682, 405);
            this.dgv_Pokemon.TabIndex = 0;
            this.dgv_Pokemon.SelectionChanged += new System.EventHandler(this.dgv_Pokemon_SelectionChanged);
            // 
            // ptb_Pokemon
            // 
            this.ptb_Pokemon.Location = new System.Drawing.Point(744, 77);
            this.ptb_Pokemon.Name = "ptb_Pokemon";
            this.ptb_Pokemon.Size = new System.Drawing.Size(423, 463);
            this.ptb_Pokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Pokemon.TabIndex = 1;
            this.ptb_Pokemon.TabStop = false;
            // 
            // frm_Pokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 688);
            this.Controls.Add(this.ptb_Pokemon);
            this.Controls.Add(this.dgv_Pokemon);
            this.Name = "frm_Pokemons";
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.frm_Pokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Pokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Pokemon;
        private System.Windows.Forms.PictureBox ptb_Pokemon;
    }
}

