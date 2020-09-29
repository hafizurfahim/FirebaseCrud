using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text;

namespace WindowsFormsApp1
{
    public static class InternetCheck
    {
        public static bool isInternet()
        {

            
           
            try
            {
                using(var client=new WebClient())
                {
                    using (client.OpenRead("https://www.google.com"))
                    {
                        return true;

                    }
                }
               
            }
            catch(Exception e)
            {
                return false;
            }
        }

    }
}
