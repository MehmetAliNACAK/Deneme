using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    internal class sqlbaglantisi
    {
        
        public SqlConnection baglati()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0Q9U4V1\\SQLEXPRESS;Initial Catalog=\"RESİDANS PROJE\";Integrated Security=True");

            baglan.Open();
            return baglan;  

        
        }

    }
}