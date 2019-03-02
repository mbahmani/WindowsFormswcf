using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormswcf
{
    public partial class Registeration : Form
    {
        ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();//add service reference
        public Registeration()
        {
            InitializeComponent();
            showdata();
        }
        private void showdata()
        {
            DataSet ds = new DataSet();
            ds = obj.SelectUserDetials();
            dataGridView1.DataSource = ds.Tables[0];
             

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            ServiceReference1.UserDetials objuserdetail = new ServiceReference1.UserDetials();//add type reference
            objuserdetail.UserID =  Convert.ToInt32(textBox5.Text);
            objuserdetail.UserName = textBox1.Text;
            objuserdetail.Password = textBox2.Text;
            objuserdetail.Country = textBox3.Text;
            objuserdetail.Email = textBox4.Text;
            obj.InsertUserDetails(objuserdetail);
            showdata();

        }

        private void Registeration_Load(object sender, EventArgs e)
        {

        }
    }
}
