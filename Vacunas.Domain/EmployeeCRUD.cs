using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vacunas.DataAccess;
using Vacunas.Entity;

namespace Vacunas.Domain
{
    public class EmployeeCRUD
    {
        ConexionDataContext conexion = new ConexionDataContext();

        public List<Employee> Employee()
        {
            var list = from E in conexion.sp_ListEmpl()
                       select new Employee
                       {
                           Id = E.Id,
                           EmpName=E.EmpName,
                           EmpRange=E.EmpRange,
                           Email=E.Email,
                           Condition=(bool)E.Condition
                       };
            return list.ToList();
        }

        public void NuevoEmpleado(string name, string range, string email)
        {
            conexion.sp_NewEmployee(name, range, email);
            conexion.SubmitChanges();
        }

        public void LLenaCombo(ComboBox comboBox)
        {
            comboBox.DataSource=Employee();
            comboBox.ValueMember="Id";
            comboBox.DisplayMember="EmpName";
        }

        public void Info(TextBox range, string name)
        {
            foreach (var list in Employee())
            {
                if (list.EmpName.Equals(name))
                {
                    range.Text=list.EmpRange;
                }
            }
        }

        public void LlenaGrid(DataGridView grid)
        {
            foreach(var list in Employee())
            {
                grid.Rows.Add(list.EmpName);
            }
        }

        public void LoadProfile(string name, TextBox Id, TextBox Name, TextBox Email, TextBox Range)
        {
            try
            {
                foreach(var list in Employee())
                {
                    if (list.EmpName.Equals(name))
                    {
                        Id.Text=list.Id.ToString();
                        Name.Text=list.EmpName;
                        Email.Text=list.Email;
                        Range.Text=list.EmpRange;
                    }
                }
            }
            catch   
            {
            }
        }

        public void EliminarEmpleado(int Id)
        {
            conexion.sp_DelEmployee(Id);
        }
    }
}
