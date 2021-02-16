using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
namespace SetRegionalWeaponsControlStatus
{
    public partial class Dummy : Form
    {
        static SqlConnection sqlCon = new SqlConnection(ConnectionString.GetConnectionString());
        public static string localNameSet;
        public Dummy()
        {
            InitializeComponent();
            SetDefault();
        }


        private void setRegionalWeaponsControlStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRegionalWeaponsControlStatus nav = new SetRegionalWeaponsControlStatus();
            nav.Show();
        }

        void SetDefault()
        {
            int checkCount = sqlCon.ExecuteScalar<int>("select count (BatteryId) from Regional_Weapon_Control_Status");
            if (checkCount == 1)
            {
                var changeName = sqlCon.ExecuteScalar("select Sta_tus from Regional_Weapon_Control_Status");
                localNameSet = Convert.ToString(changeName);
                rgnlToolStripMenuItem.Text = localNameSet;
            }
        }
    }
}
