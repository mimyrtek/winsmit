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
            ADOX.CatalogClass cat = new ADOX.CatalogClass();

            string str_create;

            str_create = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
            str_FilePath + str_mdbfilename + ";Jet OLEDB:Engine Type=5";

            Console.WriteLine(str_create);

            cat.Create(str_create);

            cat = null;
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
           
            
            DataSet smitDataSet = new DataSet();
            smitDataAdapter.Fill(smitDataSet);
            
            
        }
        /// <summary>
        /// Create Table
        /// </summary>
        /// <param name="str_mdbfilename"></param>
        /// <param name="str_filepath"></param>
        /// <param name="str_tablename"></param>
        public static void createNewTableInDataBaseFile(string str_mdbfilename,string str_filepath, string str_tablename)
        {
            string str_connection = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + str_filepath + str_mdbfilename + ";";

            OleDbConnection obj_Connection = new OleDbConnection(str_connection);

            string str_sql;

            str_sql = "CREATE TABLE " + str_tablename + " ( " +
                    "_stanza CHAR(35)," +	    
                    "_id CHAR(20)," +	
                    "_id_seq_num CHAR(25)," +	
                    "_next_id CHAR(25)," +	
                    "_text TEXT," +	
                    "_text_msg_file CHAR(5)," +	
                    "_text_msg_set CHAR(25)," +	
                    "_text_msg_id CHAR(25)," +	
                    "_next_type CHAR(25)," +	
                    "_alias CHAR(25)," +	
                    "_help_msg_id CHAR(25)," +	
                    "_help_msg_loc CHAR(25)," +	
                    "_help_msg_base CHAR(25)," +	 
                    "_help_msg_book CHAR(25)," +	 
                    "_option_id  CHAR(25)," +	
                    "_has_name_select  CHAR(25)," +	
                    "_name  CHAR(25)," +	
                    "_name_msg_file  CHAR(25)," +	
                    "_name_msg_set  CHAR(25)," +	
                    "_name_msg_id  CHAR(25)," +	
                    "_cmd_to_exec  CHAR(25)," +	
                    "_ask  CHAR(2)," +	
                    "_exec_mode CHAR(25)," +	
                    "_ghost  CHAR(2)," +	
                    "_cmd_to_discover  TEXT," +	
                    "_cmd_to_discover_postfix  CHAR(25)," +	
                    "_name_size  CHAR(25)," +	
                    "_value_size  CHAR(25)," +	
                    "_disc_field_name  CHAR(25)," +	
                    "_op_type  CHAR(25)," +	
                    "_entry_type  CHAR(25)," +	
                    "_entry_size  CHAR(25)," +	
                    "_required  CHAR(25)," +	
                    "_prefix  CHAR(25)," +	
                    "_cmd_to_list_mode TEXT," +	
                    "_cmd_to_list  TEXT," +	
                    "_cmd_to_list_postfix  CHAR(25)," +	
                    "_multi_select  CHAR(25)," +	
                    "_value_index  CHAR(25)," +	
                    "_disp_values  CHAR(25)," +	
                    "_values_msg_file  TEXT," +	
                    "_values_msg_set  CHAR(25)," +	
                    "_values_msg_id  CHAR(25)," +	
                    "_aix_values  TEXT," +	
                    "_type  CHAR(25)," +	
                    "_cmd_to_classify  CHAR(25)," +	
                    "_cmd_to_classify_postfix  CHAR(25)," +	
                    "_raw_field_name  CHAR(25)," +	
                    "_cooked_field_name  CHAR(25)" +
                    ")";

                       
            obj_Connection.Open();

            OleDbCommand cmd = new OleDbCommand(str_sql, obj_Connection);

            cmd.ExecuteNonQuery();

            obj_Connection.Close();

            cmd = null;

        }
    }
}
