using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Conexion_1
{
    public partial class frm_Pokemons : Form
    {
        public frm_Pokemons()
        {
            InitializeComponent();
        }

        private void frm_Pokemons_Load(object sender, EventArgs e)
        {
            Pokemons_Datos datos = new Pokemons_Datos();
            dgv_Pokemon.DataSource = datos.listare();
        }
    }
}
