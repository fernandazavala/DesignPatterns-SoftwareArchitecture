using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ExamenSegundoParcial
{
    public partial class AdministradorForm : Form
    {
        public AdministradorForm()
        {
            InitializeComponent();
        }

        public void return_admin_information(List<string> datos_admin)
        {
            InformacionAdministradorRespuestaLabel.Text = "Nombre del administrador: " + datos_admin[3] + "\nID del administrador: " + datos_admin[2] + "\nPassword: " + datos_admin[0] + "\nAño de nacimiento: " + datos_admin[4] + "\nEstado de nacimiento: " + datos_admin[5] + "\nCorreo electrónico: " + datos_admin[6];
        }
    }
}
