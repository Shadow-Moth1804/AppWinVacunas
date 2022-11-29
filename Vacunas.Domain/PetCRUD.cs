using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vacunas.DataAccess;
using Vacunas.Entity;

namespace Vacunas.Domain
{
    public class PetCRUD
    {
        ConexionDataContext conexion = new ConexionDataContext();

        public List<Pet> Mascotas()
        {
            var list = from E in conexion.sp_ListPet()
                       select new Pet
                       {
                           Id = E.Id,
                           PetName = E.PetName,
                           Breed = E.Breed,
                           Gender = E.Gender,
                           DateBirth = E.DateBirth,
                           AdData = E.AdData,
                           OwnerName = E.OwnerName,
                           Condition=(bool)E.Condition
                       };
            return list.ToList();
        }

        public void NuevaMascota(string name, string breed, string gender, DateTime date, string Observation, string OwnerName)
        {
            conexion.sp_NewPet(name, breed, gender, date, Observation, OwnerName);
            conexion.SubmitChanges();
        }
        public void LlenaGrid(DataGridView grid)
        {
            foreach (var list in Mascotas())
            {
                grid.Rows.Add(list.PetName);
            }
        }
        public void LoadProfile(string name, TextBox Id, TextBox Name, TextBox Breed, TextBox Gender, TextBox DateBirth, TextBox AdData, TextBox OwnerMame )
        {
            try
            {
                foreach (var list in Mascotas())
                {
                    if (list.PetName.Equals(name))
                    {
                        Id.Text=list.Id.ToString();
                        Name.Text=list.PetName;
                        Breed.Text=list.Breed;
                        Gender.Text=list.Gender;
                        DateBirth.Text=list.DateBirth.ToShortDateString();
                        AdData.Text=list.AdData;
                        OwnerMame.Text=list.OwnerName;
                    }
                }
            }
            catch
            {
            }
        }

        public void EliminarMascota(int Id)
        {
            conexion.sp_DelPet(Id);
            conexion.SubmitChanges();
        }

        public void LlenaCombo(ComboBox cbo)
        {
            cbo.DataSource= Mascotas();
            cbo.ValueMember="Id";
            cbo.DisplayMember = "PetName";

        }
    }
}
