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
    public partial class AlumnosForm : Form
    {
        public AlumnosForm()
        {
            InitializeComponent();
        }
        public void return_student_information(List<string> datos_estudiante)
        {
            InformacionAlumnosRespuestaLabel.Text = "Nombre del alumno: " + datos_estudiante[3] + "\nID del alumno: " + datos_estudiante[2] + "\nPassword: " + datos_estudiante[0] + "\nCarrera: " + datos_estudiante[4] + "\nAño de nacimiento: " + datos_estudiante[5] + "\nEstado de nacimiento: " + datos_estudiante[6] + "\nCorreo electrónico: " + datos_estudiante[7];
            CalificacionesAlumnosRespuestaLabel.Text = "ID de la materia: " + datos_estudiante[8] + "\nNombre de la materia: " + datos_estudiante[9] + "\nCalificaciones: " + datos_estudiante[10] + "\nPromedio: " + datos_estudiante[11];
        }

        private void DescargarButton_Click(object sender, EventArgs e)
        {
            string path = "";
            SaveFileDialog folderBrowser = new SaveFileDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                path =  folderBrowser.FileName.ToString();

            }

            var FileType = ConfigurationSettings.AppSettings.Get("Change_FileType");
            if(FileType == "txt")
            {
                TXTFile txt = new TXTFile();
                txt.createTXT(CalificacionesAlumnosRespuestaLabel.Text, path+".txt");
            }
            else if(FileType == "docx")
            {
                DocxFile docx = new DocxFile();
                docx.generateFile(CalificacionesAlumnosRespuestaLabel.Text, path + ".docx");
            }
        }
    }
}
