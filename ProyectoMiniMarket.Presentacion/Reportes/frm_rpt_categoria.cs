using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMiniMarket.Presentacion.Reportes
{
    public partial class frm_rpt_categoria : Form
    {
        public frm_rpt_categoria()
        {
            InitializeComponent();
        }

        private void frm_rpt_categoria_Load(object sender, EventArgs e)
        {
           
            
            try
            {
                this.dataTable1TableAdapter.Fill(this.dataSet_MiniMarket.DataTable1);
                this.reportViewer1.RefreshReport();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
