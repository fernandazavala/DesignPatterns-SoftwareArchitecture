using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSegundoParcial
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            Singleton instance = Singleton.GetInstance();
            Adaptee instance_adaptee = new Adaptee();
            List<string> user_type_r = new List<string>();
            var email = emailBox.Text;
            user_type_r = instance_adaptee.Get_access_data(email);
            var correct_password = passwordBox.Text;
            if(user_type_r[0] == correct_password)
            {
                MessageBox.Show("Presione aceptar para continuar");
                if(user_type_r[1] == "students")
                {
                    AlumnosForm estudiante = new AlumnosForm();
                    estudiante.return_student_information(user_type_r);
                    estudiante.ShowDialog();
                }
                else if(user_type_r[1] == "teachers")
                {
                    MaestrosForm maestro = new MaestrosForm();
                    maestro.return_teacher_information(user_type_r);
                    maestro.ShowDialog();
                }
                else if(user_type_r[1] == "admin")
                {
                    AdministradorForm administrador = new AdministradorForm();
                    administrador.return_admin_information(user_type_r);
                    administrador.ShowDialog();
                }
            }

        }
    }
}
