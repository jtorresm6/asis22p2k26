using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Mantenimiento;
namespace CapaVista_Mantenimiento
{
    public partial class FrmMantenimientoPaciente : Form
    {
        public FrmMantenimientoPaciente()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblbitacora", 4, 5);
            

   
         
        }
        public static void MostrarFormulario()
        {
            FrmMantenimientoPaciente form = new FrmMantenimientoPaciente();

          
            form.ShowDialog();
        }
    }
}


   

