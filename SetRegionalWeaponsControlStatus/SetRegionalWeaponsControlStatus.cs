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
    public partial class SetRegionalWeaponsControlStatus : Form
    {
        static SqlConnection sqlCon = new SqlConnection(ConnectionString.GetConnectionString());
        public SetRegionalWeaponsControlStatus()
        {
            InitializeComponent();
        }





        private void SetRegionalWeaponsControlStatus_Load(object sender, EventArgs e)
        {
            siteIDCombobox.Items.Add("AADOC");
            siteIDCombobox.Items.Add("All Army Site");
            siteIDCombobox.SelectedIndex = 0;
            batteryIdCombobox.Items.Add("All Lives Batteries");
            batteryIdCombobox.Items.Add("All Simulated Batteries");
            batteryIdCombobox.SelectedIndex = 0;
            unspecifiedRadio.Checked = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            FinalProcess();
        }


        void ProcessSiteID()
        {
            if (siteIDCombobox.SelectedIndex == 0)
            {
                Data.SiteId = siteIDCombobox.SelectedItem.ToString();
            }
            else
            {
                Data.SiteId = siteIDCombobox.SelectedItem.ToString();
            }
        }

        void ProcessBatteryID()
        {
            Data.BatteryId = batteryIdCombobox.SelectedItem.ToString();
        }

        void ProcessStatus()
        {
            if(unspecifiedRadio.Checked == true)
            {
                Data.Status = unspecifiedRadio.Text;
            }
            else if (holdRadio.Checked == true)
            {
                Data.Status = holdRadio.Text;
            }
            else if (tightRadio.Checked == true)
            {
                Data.Status = tightRadio.Text;
            }
            else if (freeRadio.Checked == true)
            {
                Data.Status = freeRadio.Text;
            }
        }

        void FinalProcess()
        {
            ProcessSiteID();
            ProcessBatteryID();
            ProcessStatus();

            Data.RegionalWeaponControlStatus = Data.BatteryId; 

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            int isNull = sqlCon.ExecuteScalar<int>("select count (BatteryId) from Regional_Weapon_Control_Status");
            Data.isNull = isNull;
            if (isNull == 0)
            {
                try 
                {
                    AddToMain();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Added Successfully");
                }
                
            }
            else
            {
                try
                {
                    SelectThenAdd();
                    AddThenDelete();
                    DeleteData();
                    AddToMain();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Added Successfully");
                }
            }

        }



        void SelectThenAdd()
        {
            var siteIdTemp = sqlCon.ExecuteScalar("select SiteId from Regional_Weapon_Control_Status");
            Data.SiteIdTemp = Convert.ToString(siteIdTemp);
            var batteryIdTemp = sqlCon.ExecuteScalar("select BatteryId from Regional_Weapon_Control_Status");
            Data.BatteryIdTemp = Convert.ToString(batteryIdTemp);
            var statusTemp = sqlCon.ExecuteScalar("select Sta_tus from Regional_Weapon_Control_Status");
            Data.StatusTemp = Convert.ToString(statusTemp);
            var timeDateTemp = sqlCon.ExecuteScalar("select TimeDate from Regional_Weapon_Control_Status");
            Data.TimeDateTemp = Convert.ToString(timeDateTemp);
        }

        void AddThenDelete()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SiteId", Data.SiteIdTemp);
            param.Add("@BatteryId", Data.BatteryIdTemp);
            param.Add("@Sta_tus", Data.StatusTemp);
            param.Add("@TimeDate", Data.TimeDateTemp);
            sqlCon.Execute("Proc_Regional_Add_Data_To_History", param, commandType: CommandType.StoredProcedure);
        }

        void DeleteData()
        {
            try
            {
                sqlCon.Execute("delete from Regional_Weapon_Control_Status");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void AddToMain()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SiteId", Data.SiteId);
            param.Add("@BatteryId", Data.BatteryId);
            param.Add("@Sta_tus", Data.Status);
            param.Add("@TimeDate", DateTime.Now);
            sqlCon.Execute("Proc_Regional_Add_Data", param, commandType: CommandType.StoredProcedure);
        }




    }
}
