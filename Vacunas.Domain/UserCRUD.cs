using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacunas.DataAccess;
using System.Windows.Forms;
using Vacunas.Entity;

namespace Vacunas.Domain
{
    public class UserCRUD
    {
        ConexionDataContext conexion = new ConexionDataContext();

        public List<User> Users()
        {
            var list = from E in conexion.sp_ListUser()
                       select new User
                       {
                           Id = E.Id,
                           Name=E.UserName,
                           EmpName=E.EmpName,
                           Condition=(bool)E.Condition
                       };
            return list.ToList();
        }

        public void NuevoUsuario(string name, string password, string employee)
        {
            conexion.sp_NewUser(name, password, employee);
            conexion.SubmitChanges();
        }

        public bool Login(string name, string password)
        {
            bool log = false;
            try
            {
                var result = conexion.sp_Login(name,password);
                if (result==1)
                {
                    log = true;
                }
                else
                {
                    log = false;
                }
            }
            catch(Exception ex)
            {
                log = false;
            }
            return log;
        }
    }
}
