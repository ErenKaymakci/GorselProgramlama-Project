using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GelismisATM
{
    public class User
    {
        public static string userID { get; set; }
        public static string userName { get; set; }
        public static string userTC { get; set; }
        
        //public static List<string> userAccountsIDs { get; set; }
        public static string userAccountsIDs { get; set; }
        public static string currentAccountID { get; set; }
        
    }
}