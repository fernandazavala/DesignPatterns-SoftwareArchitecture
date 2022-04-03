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
    public partial class MaestrosForm : Form
    {
        public MaestrosForm()
        {
            InitializeComponent();
        }

        public void return_teacher_information(List<string> datos_maestro)
        {
            InformacionMaestrosRespuestaLabel.Text = "Nombre del profesor: " + datos_maestro[3] + "\nID del profesor: " + datos_maestro[2] + "\nPassword: " + datos_maestro[0]  + "\nAño de nacimiento: " + datos_maestro[4] + "\nEstado de nacimiento: " + datos_maestro[5] + "\nCorreo electrónico: " + datos_maestro[6];
            CalificacionesMestrosRespuestaLabel.Text = "Nombre de la asignatura impartida: " + datos_maestro[7] + "\nNombre del alumno: " + datos_maestro[8] + "\nCalificaciones: " + datos_maestro[9] + "\nPromedio del alumno: " + datos_maestro[10];
        }
    }
}
