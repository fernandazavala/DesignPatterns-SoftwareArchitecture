using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSegundoParcial
{
    abstract class Adapter
    {
        public abstract List<string> Get_students(int id);
        public abstract List<string> Get_teachers(int id);
        public abstract List<string> Get_admin(int id);
        public abstract List<string> Get_access_data(string email);
        public abstract List<string> Get_subjects(int id);

    }
}
