using MetaData;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnCreateInstance.Enabled = false;
        }

        private void btnLoadAssembly_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Assembly ...";
            openFileDialog.Filter = ".Net Assemblies (*.exe, *.dll)|*.exe;*.dll";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Assembly assembly = Assembly.LoadFile(openFileDialog.FileName);
                txtAssemblyName.Text = assembly.ToString();
                Type[] types = assembly.GetTypes();
                foreach (var item in types)
                {
                    listAssemblyDataTypes.Items.Add(item);
                }
                if(types.Length > 0)
                    btnCreateInstance.Enabled = true;
            }
        }

        private void listAssemblyDataTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listAssemblyDataTypes.SelectedItem;
            LoadMetaData metaData = new LoadMetaData((Type)selectedItem);
            txtMetaData.Text = metaData.LoadGeneralTypeInfo();
            txtMetaData.Text += metaData.LoadProperties();
            txtMetaData.Text += metaData.LoadMethods();
        }

        private void btnCreateInstance_Click(object sender, EventArgs e)
        {
            if(listAssemblyDataTypes.SelectedIndex < 0) return;
            var selectedDataType = (Type)listAssemblyDataTypes.SelectedItem;

            var dataTypeInstance = Activator.CreateInstance(selectedDataType);
                selectedDataType.GetProperty("Fname").SetValue(dataTypeInstance, "Payam");
                selectedDataType.GetProperty("Lname").SetValue(dataTypeInstance, "Boroumand");

            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Selected Data Type Name : {selectedDataType.Name}");
            builder.AppendLine($"Data Type Properties List : ");
            PropertyInfo[] properties = selectedDataType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in properties)
            {
                builder.AppendLine($"public {prop.PropertyType.Name} {prop.Name} : {prop.GetValue(dataTypeInstance)}");
            }
            txtMetaData.Text = builder.ToString();

            var repositoryType = listAssemblyDataTypes.Items.OfType<Type>().First(type => type.Name.Equals("GenericRepository`1"));
            var genericRepositoryType = repositoryType.MakeGenericType(selectedDataType);
            var repositoryInstance = Activator.CreateInstance(genericRepositoryType);
            var repositoryAddMethod = genericRepositoryType.GetMethod("Add");
            repositoryAddMethod.Invoke(repositoryInstance, new[] { dataTypeInstance });
        }
    }
}
