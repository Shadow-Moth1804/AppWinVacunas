using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacunas.DataAccess;
using Vacunas.Entity;
using System.Windows.Forms;
using System.IO;

namespace Vacunas.Domain
{
    public class VacHistoryCRUD
    {
        ConexionDataContext conexion = new ConexionDataContext();
        public List<VacHistory> VaccineH()
        {
            var list = from E in conexion.sp_ListHis()
                       select new VacHistory
                       {
                           Id = E.Id,
                           PetName=E.PetName,
                           PetWeight=(decimal)E.PetWeight,
                           PetStage =E.PetStage,
                           VacName = E.VacName,
                           VacDate = E.VacDate,
                           EmpName= E.EmpName,
                           Observations=E.Observations
                       };
            return list.ToList();
        }

        public void LoadProfile(string name, TextBox Id, TextBox Name, TextBox Weight, TextBox Stage,TextBox VacName, TextBox Date, TextBox EmpName, TextBox Observations)
        {
            try
            {
                foreach (var list in VaccineH())
                {
                    if (list.PetName.Equals(name))
                    {
                        Id.Text=list.Id.ToString();
                        Name.Text=list.EmpName;
                        Weight.Text=list.PetWeight.ToString();
                        Stage.Text=list.PetStage;
                        VacName.Text=list.VacName;
                        Date.Text=list.VacDate.ToShortDateString(); ;
                        EmpName.Text=list.EmpName;
                        Observations.Text=list.Observations;
                    }
                }
            }
            catch
            {
            }
        }

        public void Registrar(string nombre, double peso, string etapa,string vacname ,DateTime date, string empleado, string ob )
        {
            conexion.sp_NewHist(nombre, peso, etapa, vacname, date, empleado,ob);
            conexion.SubmitChanges();
        }

        public void FLlenaGrid(string name,DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (var list in VaccineH())
            {
                if (list.PetName.Equals(name))
                {
                    dgv.Rows.Add(list.VacName);
                }
            }
        }
        public void print(DataGridView list)
        {
            list.Rows.Add(VaccineH());
            if (list.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                sfd.InitialDirectory = @"C:\Users\jesus\OneDrive\Documentos";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = list.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[list.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += list.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < list.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += list.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                            list.Rows.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
