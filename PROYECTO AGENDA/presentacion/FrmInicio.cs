using PROYECTO_AGENDA.clases;
using PROYECTO_AGENDA.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_AGENDA.presentacion
{
    public partial class FrmInicio : Form
    {
        contactoController cotactoController = new contactoController();
        FrmCu frmCu = new FrmCu("create");

        public FrmInicio()
        {
            InitializeComponent();
        }

        public FrmInicio(List<contacto> ListContacto)
        {
            InitializeComponent();
            this.ListContacto = ListContacto;    
        }
        public List<contacto> ListContacto { get; set; }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             button2.Enabled = true;
             frmCu.limpiar();
             frmCu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled= false;
            var contacto=frmCu.contacto();
            ListContacto= cotactoController.Addcontacto(contacto);
            DgvContacto.DataSource = null;
            DgvContacto.DataSource = this.ListContacto;
        }
    }
}
