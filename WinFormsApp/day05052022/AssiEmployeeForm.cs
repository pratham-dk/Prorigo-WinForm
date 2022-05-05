using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp.day05052022
{
    public partial class AssiEmployeeForm : Form
    {
        FileStream fs;
        public AssiEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                int empid = Convert.ToInt32(txtEmpId.Text);
                string empname = txtEmpName.Text;
                string designation = txtDesignation.Text;
                double salary = Convert.ToDouble(txtSalary.Text);
                string department = txtDepartment.Text;
                fs = new FileStream(@"D:\TestFolder\EmployeeFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(empid);
                bw.Write(empname);
                bw.Write(designation);
                bw.Write(salary);
                bw.Write(department);
                bw.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                fs.Close(); // free the resouce 
            }

        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\EmployeeFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtEmpId.Text = br.ReadInt32().ToString();
                txtEmpName.Text = br.ReadString();
                txtDesignation.Text = br.ReadString();
                txtSalary.Text = br.ReadDouble().ToString();
                txtDepartment.Text = br.ReadString();

                br.Close();  // close the opeation reader
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close(); // free the resouce 
            }

        }
    }
}
