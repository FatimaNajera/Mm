using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace Mm
{
    internal class AccionesComunes
    {
        public static void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void LlenarCombo(String consulta, ComboBox combo, string id, string campo)
        {
            combo.ValueMember = id;
            combo.DisplayMember= campo;
            DataTable dt;
            dt = Conexion.EjecutaSeleccion(consulta);

            DataRow r = dt.NewRow();
            r[0] = 0;
            r[1] = "Todos Los Datos";
            dt.Rows.InsertAt(r, 0);

            if (dt== null)
            {
                return;
            }
            combo.Items.Clear();
            combo.DataSource = dt;
        }
    }
}