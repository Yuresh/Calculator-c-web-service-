using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Test2WebService
{
    /// <summary>
    /// Summary description for Test2WebService
    /// </summary>
    [WebService(Namespace = "http://yuresh.org/webService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Test2WebService : System.Web.Services.WebService
    {

        [WebMethod(Description = "Add two numbers")]
        public int add(int a, int b)
        {
            return a + b; 
        }

        [WebMethod(Description = "Multiply two numbers")]
        public int mul(int a, int b)
        {
            return a * b;
        }

        [WebMethod(Description = "Subtract two numbers")]
        public int sub(int a, int b)
        {
            return a - b;
        }

        [WebMethod(Description = "Division two numbers")]
        public int div(int a, int b)
        {
            return a / b;
        }


    }
}
