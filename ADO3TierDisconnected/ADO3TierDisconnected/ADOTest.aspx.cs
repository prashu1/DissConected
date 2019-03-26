using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace ADO3TierDisconnected
{
    public partial class ADOTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void insert_Click(object sender, EventArgs e)
        {
            Class2 b = new Class2();
            property p = new property();
          
            p.FirstName = FName.Text;
            p.LastName = LName.Text;
            p.Email = EMAIL.Text;
            b.InsertTest(p);
        }

        protected void update_Click(object sender, EventArgs e)
        {
            Class2 b = new Class2();
            property p = new property();
            p.FirstName = FName.Text;
            p.LastName = LName.Text;
            p.AddressID = Convert.ToByte(TexADD.Text);
            b.UpdateTest(p);

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            Class2 b = new Class2();
            property p = new property();
            p.AddressID = Convert.ToInt32(TexADD.Text);
            b.DeleteTest(p);

        }
    }

    
}