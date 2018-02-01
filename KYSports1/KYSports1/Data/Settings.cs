using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace KYSports1.Data
{
    public class Settings
    {
        private static string _connectionString;
        public static string GetConnectionString()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                _connectionString = ConfigurationManager.ConnectionStrings["KYSports1"].ConnectionString;
            }
            return _connectionString;
        }
    }
}