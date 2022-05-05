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
    public partial class AssiStudentForm : Form
    {
        FileStream fs;
        
        public AssiStudentForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {

            try
            {
                int RollNo = Convert.ToInt32(txtRollNo.Text);
                string Name = txtName.Text;
                double Percentage = Convert.ToDouble(txtPercentage.Text);
                string Stream = txtStream.Text;
                string City = txtCity.Text;
                fs = new FileStream(@"D:\TestFolder\StudentFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(RollNo);
                bw.Write(Name);
                bw.Write(Percentage);
                bw.Write(Stream);
                bw.Write(City);
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
                fs = new FileStream(@"D:\TestFolder\StudentFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtRollNo.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtPercentage.Text = br.ReadDouble().ToString();
                txtStream.Text = br.ReadString();
                txtCity.Text = br.ReadString();
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
