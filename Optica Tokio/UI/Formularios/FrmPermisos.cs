using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optica_Tokio.UI.Formularios
{
    public partial class FrmPermisos : Form
    {
        public FrmPermisos()
        {
            InitializeComponent();
        }

        private void btnActualizarPermisos_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarPermisos_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Retorna Cancel si se cancela
            this.Close();
        }

        private void chkChangedCh(object sender,EventArgs e)
        {
            CheckBox chk=sender as CheckBox;
            if(chk.Checked)
            {
                chk.Image=Properties.Resources.Checked;
            }
            else
            {
                chk.Image=Properties.Resources.Unchecked;
            }
        }
    }
}
