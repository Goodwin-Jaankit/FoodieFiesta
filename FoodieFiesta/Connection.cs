﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Web;

namespace FoodieFiesta
{
    public class Connection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString; 
        }
    }

    public class Utils
    {
        public static bool IsValidExtension(string fileName)
        {

            bool isValid = false;

            string[] fileExtension = { ".jpg", ".png", ".jpeg" };

            for (int i = 0; i <= fileExtension.Length - 1; i++)

            {

                if (fileName.Contains(fileExtension[i]))

                {

                    isValid = true;

                 break;

                }  

            }
            return isValid;
        }



        // Setting default image if their is no image for any job.



        public static string GetImageUrl(Object url)

        {

            string url1 = "";

            if (string.IsNullOrEmpty(url.ToString()) || url == DBNull.Value)
            {

                url1 = "../Images/No_image.png";

            }
            else
            {

                url1 = string.Format("../{0}", url);

            }

            //return ResolveUrl(url1);

            return url1;
        }


    }

} 