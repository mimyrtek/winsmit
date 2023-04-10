using System;
using System.Collections.Generic;
using System.Text;
using ADOX;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;

namespace WinSmit
{
    static class DBUtil
    {
        /// <summary>
        /// create New database
        /// </summary>
        /// <param name="str_mdbfilename"></param>
        /// <param name="str_FilePath"></param>
        public static void createNewDataBaseFile(string str_mdbfilename, string str_FilePath)
        {
            try
            {
                ADOX.CatalogClass cat = new ADOX.CatalogClass();
                string str_create;

                str_create = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                str_FilePath + str_mdbfilename + ";Jet OLEDB:Engine Type=5";

                Console.WriteLine(str_create);

                cat.Create(str_create);

                cat = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }
        /// <summary>
        /// fillDataset
        /// </summary>
        /// <param name="str_mdbfilename"></param>
        /// <param name="str_filepath"></param>
        /// <param name="str_tablename"></param>
        public static void fillDataset(string str_mdbfilename,string str_filepath, string str_tablename)
        {
            string str_connection = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + str_filepath + str_mdbfilename + ";";
            OleDbConnection connection = new OleDbConnection(str_connection);
            string selectStatement = "SELECT * from smit";

            OleDbCommand selectCommand = new OleDbCommand(selectStatement, connection);
            OleDbDataAdapter smitDataAdapter = new OleDbDataAdapter(selectCommand);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(smitDataAdapter);
            

            DataRow myDataRow;
            DataSet smitDataSet = new DataSet();

            smitDataAdapter.Fill(smitDataSet, "smit");
            myDataRow = smitDataSet.Tables["smit"].NewRow();
            myDataRow["_stanza"] = "sm_menu_opt";
            myDataRow["_id"] = "New Id";

            smitDataSet.Tables["smit"].Rows.Add(myDataRow);

            smitDataAdapter.Update(smitDataSet, "smit");

            connection.Close();

            
        }
        /// <summary>
        /// Create Table
        /// </summary>
        /// <param name="str_mdbfilename"></param>
        /// <param name="str_filepath"></param>
        /// <param name="str_tablename"></param>
        public static void createNewTableInDataBaseFile(string str_mdbfilename,string str_filepath, string str_tablename)
        {
            try
            {
                string str_connection = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                    @"Data Source=" + str_filepath + str_mdbfilename + ";";
                OleDbConnection obj_Connection = new OleDbConnection(str_connection);
                string str_sql;
                str_sql = "CREATE TABLE " + str_tablename + " ( " +
                        "_stanza VARCHAR(64)," +
                        "_id VARCHAR(64)," +
                        "_id_seq_num VARCHAR(64)," +
                        "_next_id VARCHAR(64)," +
                        "_text VARCHAR(250)," +
                        "_text_msg_file TEXT," +
                        "_text_msg_set INT," +
                        "_text_msg_id INT," +
                        "_next_type TEXT," +
                        "_alias TEXT," +
                        "_help_msg_id TEXT," +
                        "_help_msg_loc TEXT," +
                        "_help_msg_base TEXT," +
                        "_help_msg_book TEXT," +
                        "_option_id  TEXT," +
                        "_has_name_select  TEXT," +
                        "_name  TEXT," +
                        "_name_msg_file  TEXT," +
                        "_name_msg_set  TEXT," +
                        "_name_msg_id  TEXT," +
                        "_cmd_to_exec  TEXT," +
                        "_ask  CHAR(64)," +
                        "_exec_mode CHAR(64)," +
                        "_ghost  CHAR(64)," +
                        "_cmd_to_discover  TEXT," +
                        "_cmd_to_discover_postfix  TEXT," +
                        "_name_size  TEXT," +
                        "_value_size  TEXT," +
                        "_disc_field_name  TEXT," +
                        "_op_type  CHAR(64)," +
                        "_entry_type CHAR(64)," +
                        "_entry_size  INT," +
                        "_required  CHAR(64)," +
                        "_prefix  CHAR(64)," +
                        "_cmd_to_list_mode TEXT," +
                        "_cmd_to_list  TEXT," +
                        "_cmd_to_list_postfix  TEXT," +
                        "_multi_select  TEXT," +
                        "_value_index  TEXT," +
                        "_disp_values  TEXT," +
                        "_values_msg_file  TEXT," +
                        "_values_msg_set  TEXT," +
                        "_values_msg_id  TEXT," +
                        "_aix_values  TEXT," +
                        "_type  CHAR(64)," +
                        "_cmd_to_classify  TEXT," +
                        "_cmd_to_classify_postfix  TEXT," +
                        "_raw_field_name  TEXT," +
                        "_cooked_field_name  TEXT" +
                        ")";
                obj_Connection.Open();
                OleDbCommand cmd = new OleDbCommand(str_sql, obj_Connection);
                cmd.ExecuteNonQuery();
                obj_Connection.Close();
                cmd = null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
