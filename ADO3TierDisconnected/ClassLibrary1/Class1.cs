using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary1
{
    public class Class1
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter ada;


        public SqlConnection getconnection()
        {
            return (new SqlConnection(@"data source=LAPTOP-UOE8L24G\GRIDINFOCOM;initial catalog= ADOTest; integrated security=true;"));
        }

       

        public DataSet sqlset()
        {
            return (new DataSet());

        }
        public SqlDataAdapter sqlada()
        {
            return (new SqlDataAdapter("select * from Test", con));

        }
        void FillData()
        {
            con = getconnection();
            ds = sqlset();
            ada = sqlada();
            ada.Fill(ds);

        }
        public string InsertTest(string FirstName, string LastName, string Email)
        {
            FillData();
            SqlCommandBuilder cb = new SqlCommandBuilder(ada);

            foreach (DataRow d in ds.Tables[0].Rows)
            {
                if (FirstName == d["FirstName"].ToString())
                {
                    return null;
                }

            }
            DataRow dr = ds.Tables[0].NewRow();
            dr["FirstName"] = FirstName;
            dr["LastName"] = LastName;
            dr["Email"] = Email;
            ds.Tables[0].Rows.Add(dr);
            ada.Update(ds);
            return "1";

        }
        public int DeleteTest(int AddressID)
        {
            FillData();
            SqlCommandBuilder cb = new SqlCommandBuilder(ada);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (Convert.ToInt16(dr["AddressID"]) == AddressID)
                {
                    dr.Delete();
                    ada.Update(ds);
                    return 1;
                }

            }
            return 0;
        }
        public int update( int AddressID,string FirstName, string LastName)
        {
            FillData();
            SqlCommandBuilder cb = new SqlCommandBuilder(ada);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (Convert.ToByte(dr["AddressID"]) ==AddressID)
                {
                    dr["FirstName"] = FirstName;
                    dr["LastName"] = LastName;
                    ada.Update(ds);
                    return 1;
                }
            }
            return 0;

        }
        public DataTable searchdata(int AddressID)
        {
            FillData();
            DataTable d = ds.Tables[0].Clone();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (Convert.ToByte(dr["AddressID"]) == AddressID)
                {
                    d.ImportRow(dr);
                }
            }
            return d;
        }
    }
}
