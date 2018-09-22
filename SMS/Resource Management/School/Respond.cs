using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace School
{
    public partial class Respond : MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQG2200;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=1234");

        public Respond()
        {
            InitializeComponent();
        }

        private void Respond_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if ((string)metroComboBox1.SelectedItem == "Approve")
            { 
            
            }
            else if ((string)metroComboBox1.SelectedItem == "Denie")
            {

            }
            else if ((string)metroComboBox1.SelectedItem == "Ignore")
            {

            }
            else
            { 
                        
            }
        }
    }
}