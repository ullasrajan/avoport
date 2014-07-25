using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;

namespace Avoport.Models
{
    public class ExecutiveLoginModel
    {
        [Required]
        [Display(Name = "UserName")]

        public String Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        public String Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }



        public bool IsValid(String _username, string _pwd)
        {
            string str = "SELECT Employee_ID FROM executivelogin WHERE Employee_ID='" + _username + "' And Password='" + _pwd + "'";
            SqlConnection SqlCon = new SqlConnection();



            SqlCon.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=AKVDatabase;Integrated Security=True";
            SqlCon.Open();
            SqlCommand Sqlcmd = new SqlCommand(str, SqlCon);
            SqlDataReader dr = Sqlcmd.ExecuteReader();
            if (dr.Read())
                return true;
            else
                return false;
        }
    }
}