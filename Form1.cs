using MetaData;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadMetaData_Click(object sender, EventArgs e)
        {
            LoadMetaData metaData = new LoadMetaData<Person>();
            txtMetaData.Text = metaData.LoadGeneralTypeInfo();
            txtMetaData.Text += metaData.LoadProperties();
            txtMetaData.Text += metaData.LoadMethods();
        }
    }
}
