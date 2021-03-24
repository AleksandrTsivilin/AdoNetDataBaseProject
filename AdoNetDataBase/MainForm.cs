using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDataBase
{
    public partial class MainForm : Form
    {
        
        private Manager _manager;

        public MainForm()
        {
            InitializeComponent();

            _manager = new Manager();
        }

        private void DBConnectBtn_Click(object sender, EventArgs e)
        {           
            if (_manager.Connect())
            {
                SetInfoUser("Successfully",Color.Green);
                TablesCbx.Enabled = true;
                var tableNames = _manager.GetTableNames();
                TablesCbx.Items.AddRange(tableNames.ToArray());
            }
            else
            {
                SetInfoUser("Failure try again late", Color.Red);                
            }
        }

        private void SetInfoUser(string message,Color color)
        {
            ResultConnectTxt.Text = message;
            ResultConnectTxt.BackColor = color;
        }

        private void TablesCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index= TablesCbx.SelectedIndex;
            var infoTable=_manager.GetCurrentTable(index);           
           
        }
    }
}
