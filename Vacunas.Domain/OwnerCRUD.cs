using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vacunas.DataAccess;
using Vacunas.Entity;

namespace Vacunas.Domain
{
    public class OwnerCRUD
    {

        ConexionDataContext conexion = new ConexionDataContext();

        public List<Owner> Owner()
        {
            var list = from E in conexion.sp_ListOwner()
                       select new Owner
                       {
                           Id = E.Id,
                           OwnerName = E.OwnerName,
                           PhoneNumber = E.PhoneNumber,
                           Email = E.Email,
                           AdData = E.AdData,
                           Condition = (bool)E.Condition
                       };
            return list.ToList();
        }

        public void NuevoDueño(string name, string Phone, string Email,string AdData)
        {
            conexion.sp_NewOwner(name, Phone, Email, AdData);
            conexion.SubmitChanges();
        }

        public void LlenaGrid(DataGridView dgv)
        {
            foreach (var list in Owner())
            {
                dgv.Rows.Add(list.OwnerName);
            }
        }

        public void Load(string name, TextBox Id, TextBox Name, TextBox Phone, TextBox Email,TextBox AdData)
        {
            try
            {
                foreach (var list in Owner())
                {
                    if (list.OwnerName.Equals(name))
                    {
                        Id.Text=list.Id.ToString();
                        Name.Text=list.OwnerName;
                        Phone.Text=list.PhoneNumber;
                        Email.Text=list.Email;
                        AdData.Text=list.AdData;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Eliminardueño(int Id)
        {
            conexion.sp_DelOwner(Id);
        }

        public void LlenaCombo(ComboBox cbo)
        {
            cbo.DataSource=Owner();
            cbo.ValueMember="Id";
            cbo.DisplayMember="OwnerName";
        }
    }
}
