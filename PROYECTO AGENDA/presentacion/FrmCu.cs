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
    public partial class FrmCu : Form
    {
     
        contactoController contactoController=new contactoController();
        
        public FrmCu(string opcion)
        {
            InitializeComponent();

            if (opcion=="create")
            {
                label1.Text = "Crear contacto";
            }else if (opcion == "update")
            {
                label1.Text="Actualizar contacto";
            }

        }
      
        private void FrmCu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        public contacto contacto()
        {
            contacto contacto = new contacto();
            contacto.id = Convert.ToInt32(txtID.Value);
            contacto.nom = txtNombre.Text;
            contacto.apellido = txtApellido.Text;
            contacto.tel = txtTelefono.Text;
            contacto.direccion = txtDireccion.Text;
            contacto.correo = txtCorreo.Text;
            contacto.fechaNac = dtpFechaNac.Value;
            contacto.tipo = cmbTipo.Text;
            contacto.relacion = cmbRelacion.Text;

            FrmInicio inicio = new FrmInicio();
            inicio.Visible = false;
            return contacto;

            
        }
        public void limpiar()
        {
            txtID.Value=0;
            txtNombre.Text=string.Empty;
            txtApellido.Text=string.Empty;
            txtTelefono.Text=string.Empty;
            txtDireccion.Text=string.Empty;
            txtCorreo.Text=string.Empty;
            dtpFechaNac.Value = DateTime.Now;
            cmbRelacion.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
        }
    }
}
