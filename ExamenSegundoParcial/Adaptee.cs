using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSegundoParcial
{
    class Adaptee : Adapter
    {
		Singleton instance = Singleton.GetInstance();
		public override List<string> Get_students(int id)
		{
			var x = instance.DB.users[0].students[id];
			List<string> listdata = new List<string>();
			listdata.Add(Convert.ToString(x.student_id));
			listdata.Add(Convert.ToString(x.name));
			listdata.Add(Convert.ToString(x.career));
			listdata.Add(Convert.ToString(x.birth_year));
			listdata.Add(Convert.ToString(x.hometown));
			listdata.Add(Convert.ToString(x.email));
			listdata.Add(Convert.ToString(x.password));
			// lo hacemos con todas las variables
			return listdata;
		}

		public override List<string> Get_teachers(int id)
		{
			var x = instance.DB.users[1].teachers[id];
			List<string> listdata = new List<string>();
			listdata.Add(Convert.ToString(x.teacher_id));
			listdata.Add(Convert.ToString(x.name));
			listdata.Add(Convert.ToString(x.birth_year));
			listdata.Add(Convert.ToString(x.hometown));
			listdata.Add(Convert.ToString(x.email));
			listdata.Add(Convert.ToString(x.password));
			// lo hacemos con todas las variables
			return listdata;
		}

		public override List<string> Get_admin(int id)
		{
			var x = instance.DB.users[2].admin[id];
			List<string> listdata = new List<string>();
			listdata.Add(Convert.ToString(x.admin_id));
			listdata.Add(Convert.ToString(x.name));
			listdata.Add(Convert.ToString(x.birth_year));
			listdata.Add(Convert.ToString(x.hometown));
			listdata.Add(Convert.ToString(x.email));
			listdata.Add(Convert.ToString(x.password));
			// lo hacemos con todas las variables
			return listdata;
		}



		public override List<string> Get_access_data(string email)
		{
			List<string> user_type = new List<string>();
			var data = instance.DB.users[0].students;
			foreach (var i in data)
			{
				if (i.email == email)
				{
					user_type.Add(Convert.ToString(i.password));
					user_type.Add(Convert.ToString("students"));
					user_type.Add(Convert.ToString(i.student_id));
					user_type.Add(Convert.ToString(i.name));
					user_type.Add(Convert.ToString(i.career));
					user_type.Add(Convert.ToString(i.birth_year));
					user_type.Add(Convert.ToString(i.hometown));
					user_type.Add(Convert.ToString(i.email));
					user_type.Add(Convert.ToString(i.subjects[0].subject_id));
					user_type.Add(Convert.ToString(i.subjects[0].subject_name));
					string grades_student = "";
					foreach (var x in i.subjects[0].grades)
					{
						grades_student += Convert.ToString(x) + " ";
					}
					user_type.Add(Convert.ToString(grades_student));
					user_type.Add(Convert.ToString(i.subjects[0].average));
					return user_type;
				}
			}

			var data2 = instance.DB.users[1].teachers;
			var datam = instance.DB.users[1].students;
			foreach (var i in data2)
			{
				if (i.email == email)
				{
					user_type.Add(Convert.ToString(i.password));
					user_type.Add(Convert.ToString("teachers"));
					user_type.Add(Convert.ToString(i.teacher_id));
					user_type.Add(Convert.ToString(i.name));
					user_type.Add(Convert.ToString(i.birth_year));
					user_type.Add(Convert.ToString(i.hometown));
					user_type.Add(Convert.ToString(i.email));
					user_type.Add(Convert.ToString(i.subject_name));
					foreach (var j in data)
                    {
						
						if (i.subject_name == j.subjects[0].subject_name)
                        {
							string grades_student = "";
							foreach (var x in j.subjects[0].grades)
							{
								grades_student += Convert.ToString(x) + " ";
							}
							user_type.Add(Convert.ToString(j.name));
							user_type.Add(Convert.ToString(grades_student));
							user_type.Add(Convert.ToString(j.subjects[0].average));
						}
                    }
					return user_type;
				}
			}

			var data3 = instance.DB.users[2].admin;
			foreach (var i in data3)
			{
				if (i.email == email)
				{
					user_type.Add(Convert.ToString(i.password));
					user_type.Add(Convert.ToString("admin"));
					user_type.Add(Convert.ToString(i.admin_id));
					user_type.Add(Convert.ToString(i.name));
					user_type.Add(Convert.ToString(i.birth_year));
					user_type.Add(Convert.ToString(i.hometown));
					user_type.Add(Convert.ToString(i.email));
					return user_type;
				}
			}
			return null;
		}

		public override List<string> Get_subjects(int id)
		{
			var x = instance.DB.subjects[id];
			List<string> listdata = new List<string>();
			listdata.Add(Convert.ToString(x.subject_id));
			listdata.Add(Convert.ToString(x.name));
			listdata.Add(Convert.ToString(x.teacher_id));
			listdata.Add(Convert.ToString(x.student_id));
			// lo hacemos con todas las variables
			return listdata;
		}
	}
}
