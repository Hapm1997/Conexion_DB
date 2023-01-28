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
        private List<Pokemons_Desc> listaPokemon;
        public frm_Pokemons()
        {
            InitializeComponent();
        }

        private void frm_Pokemons_Load(object sender, EventArgs e)
        {
            Pokemons_Datos datos = new Pokemons_Datos();
            listaPokemon = datos.listare();
            dgv_Pokemon.DataSource = listaPokemon;
            dgv_Pokemon.Columns["UrlImagen"].Visible = false;
            cargar_Imagen(listaPokemon[0].UrlImagen);
        }

        private void dgv_Pokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemons_Desc seleccionado = (Pokemons_Desc)dgv_Pokemon.CurrentRow.DataBoundItem;
            cargar_Imagen(seleccionado.UrlImagen);
        }
        private void cargar_Imagen(string imagen)
        {
            try
            {
                ptb_Pokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                ptb_Pokemon.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

    }
}
