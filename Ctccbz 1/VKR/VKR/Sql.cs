﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VKR
{

    public class Sql
    {
        static string ConStr = "server=localhost;port=3306;userid=root;password=123456;database=vkr";
        static public MySqlConnection Connection = new MySqlConnection(ConStr);
    }
}
