using System;
//Name Spaces
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Properties;

namespace HotelBookingSystem.Data
{
    public class DB
    {
        #region Enum
        public enum DBOperation
        {
            Add,
            Edit,
            Delete,
        }

        #endregion

        #region Variable declaration
        //***Once the database is created you can find the correct connection string by using the Settings.Default object to select the correct connection string
        private string strConn = Settings.Default.HotelDBConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
        #endregion

        #region Constructor
        public DB()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
                daMain = new SqlDataAdapter();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        #endregion

        #region Update the DateSet
        public void FillDataSet(string aSQLstring, string aTable)
        {
            //fills dataset fresh from the db for a specific table and with a specific Query
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                //dsMain.Clear();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }

        #endregion

        #region Update the data source 
        public bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success = true;
            try
            {
                // Open the connection
                if (cnMain.State == ConnectionState.Closed)
                    cnMain.Open();

                // Update the database via the DataAdapter
                daMain.Update(dsMain, table);
            }
            catch (Exception errObj)
            {
                System.Windows.Forms.MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
                // Ensure the connection is closed
                if (cnMain.State == ConnectionState.Open)
                    cnMain.Close();
            }

            FillDataSet(sqlLocal, table);
            return success;

            #endregion
        }

    }
}
