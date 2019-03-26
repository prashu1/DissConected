using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace BAL
{
    public class Class2
    {
      
            Class1 d = new Class1();
        property p = new property();

          public  string InsertTest(property p)
            {
           // d.InsertTest(p.FirstName, p.LastName, p.Phones, p.Email);
            return (d.InsertTest(p.FirstName, p.LastName,p.Email));
           // return 1;
            }
           public   int DeleteTest(property p)
            {
                return (d.DeleteTest(p.AddressID));
            //return 1;
            }
         /*    DataTable SearchTest(property p)
            {
                return (d.SearchTest(p.AddressID));
            } */
          public   int UpdateTest(property p)
            {
                return (d.update(p.AddressID,p.FirstName,p.LastName));
            }

        }
    }
