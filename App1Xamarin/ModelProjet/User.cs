using System;
using System.Collections.Generic;
using System.Text;

namespace App1Xamarin.ModelProjet
{
   public class User
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int ID { get; set; }
        public string nom { get; set; }
        public string email { get; set; }
        public string mdp { get; set; }
        
    }
}


