using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication4;

namespace ITPPro
{
    public partial class summary : MetroFramework.Forms.MetroForm
    {
        string eid;
        public summary()
        {
            InitializeComponent();
           
        }

        SqlConnection con = DBAccess.GetConnection();
       
        private void summary_Load(object sender, EventArgs e)
        {
          
        }

        void nett()
        {


            realnet.Text = (Convert.ToDouble(actincome.Text) - Convert.ToDouble(expro.Text)).ToString();
        }

        void netplan()
        {

            pronet.Text = (Convert.ToDouble(proincome.Text) - Convert.ToDouble(plpro.Text)).ToString();
        }
       
        public void rsummCost()
        {
            con.Open();

            String vi = "select sum(total) as tot from RCost where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(vi, con);

            cmd.ExecuteNonQuery();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            SqlDataReader d;
            d = cmd.ExecuteReader();
            if(d.Read())
            {
                string tot = d["tot"].ToString();
                expro.Text = tot;
    
            }            
            con.Close();

        }

        public void sumCost()
        {
            con.Open();

            String vi = "select sum(tot) as tot from Cost where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(vi, con);

            cmd.ExecuteNonQuery();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            SqlDataReader d;
            d = cmd.ExecuteReader();
            if (d.Read())
            {
                string tot = d["tot"].ToString();
                plpro.Text = tot;

            }
            con.Close();
        }

        public void sumProfit()
        {
            con.Open();

            String vi = "select sum(tot) as tot from Profit where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(vi, con);

            cmd.ExecuteNonQuery();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            SqlDataReader d;
            d = cmd.ExecuteReader();
            if (d.Read())
            {
                string tot = d["tot"].ToString();
                proincome.Text = tot;

            }
            con.Close();
        }



        public void rsummProfit()
        {

            con.Open();

            String vi = "select sum(total) as tot from RProfit where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(vi, con);

            cmd.ExecuteNonQuery();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            SqlDataReader d;
            d = cmd.ExecuteReader();
            if (d.Read())
            {
                string tot = d["tot"].ToString();
                actincome.Text = tot;

            }

            con.Close();

        }

        public void sendid(string id)
        {
            sumlbl.Text = id;
            eid = id;// Convert.ToInt32(id);
            rsummCost();
            sumCost();
            rsummProfit();
            sumProfit();
            nett();
            netplan();
        }
       
        
        private void expro_Click(object sender, EventArgs e)
        {
         
        }

        private void expro_Click_1(object sender, EventArgs e)
        {

        }
       
       
     
    }
}
