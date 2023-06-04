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
        
        public static List<int> userAccountsIDs { get; set; }
        public static int currentAccountID { get; set; }
    }
}