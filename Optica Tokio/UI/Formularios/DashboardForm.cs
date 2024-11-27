using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Optica_Tokio.Logica_del_Negocio.Servicios;
namespace Optica_Tokio.UI.Formularios
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        public void ActualizarContador(int contador)
        {
            lbProductosTotales.Text = $"Total de filas: {contador}";
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }
        public void cargar_datos()
        {
            lbCategoriastotales.Text =ClasificacionServices.listaClasificaciones.GetTam().ToString();
            lbProductosTotales.Text = Producto_CategoriaServices.productoCategorias.GetTam().ToString();
            lbRolestotales.Text = RolesServices.roles.GetTam().ToString();
            lbUsuarios.Text = UsuarioService.listaUsuarios.GetTam().ToString();
            lbProveedores.Text = ProvedoresServices.arbolProveedores.GetTam().ToString();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            cargar_datos();
        }
    }
}
//ObtenerEstadisticasInventario();
//ObtenerResumenMovimientos(DateTime fechaInicio, DateTime fechaFin);