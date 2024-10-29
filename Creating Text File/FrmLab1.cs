using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();
            string getInput = txtInput.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentRecord reg = new FrmStudentRecord();
            reg.ShowDialog();
        }
    }
}
