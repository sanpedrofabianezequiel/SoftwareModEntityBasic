using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontOfModelOfLogic
{
    public partial class FrmAutores : Form
    {
        public FrmAutores()
        {
            InitializeComponent();

            traerAutores();

            //Suscribimos el EVENTO
            txtFiltro.TextChanged += txtFiltro_Evento;//Generamos el metodo por cada tecla presionada
        }

        private void txtFiltro_Evento(object sender, EventArgs e)
        {
            //Generamos el metodo por cada tecla presionada


            traerAutores(txtFiltro.Text);


            //  throw new NotImplementedException();
        }

        public void traerAutores()
        {
            Logica.Autor objLogica = new Logica.Autor();//LLamamos a la grilla para usar sus metos
            dgvAutores.DataSource = objLogica.TraerTodos();

        }
        public void traerAutores(string filtro)
        {
            Logica.Autor objLogica = new Logica.Autor();//LLamamos a la grilla para usar sus metos
            dgvAutores.DataSource = objLogica.TraerTodos(filtro);


           
        }

      
    }
}
