using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EasyAMP.Utils
{
    public enum DbType
    {
        mysql,
        sqlite
    }

    public class SqlDb
    {
        public static string SetSql(string account, string pwd, string db_name)
        {
            string connString = string.Format("server=localhost;port=3306;user id={0};password={1};database=mysql;charset=utf8;", account, pwd);

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                DataTable dbs = conn.GetSchema("databases");

                bool is_exist = false;
                for (int i = 0; i < dbs.Rows.Count; i++)
                {
                    var row = dbs.Rows[i];

                    string dbn = (string)row[1];
                    if (dbn.Equals(db_name, StringComparison.OrdinalIgnoreCase))
                    {
                        is_exist = true;
                    }
                }

                string ret_str = "";
                if (!is_exist)
                {
                    string create_sql_cmd = string.Format("CREATE DATABASE {0} CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;", db_name);
                    var cmd = new MySqlCommand(create_sql_cmd, conn);
                    cmd.ExecuteNonQuery();

                    ret_str = string.Format("資料庫【{0}】建立完成。設定完成", db_name);
                }
                else
                {                    
                    ret_str = string.Format("資料庫【{0}】已存在。設定完成", db_name);
                }

                conn.Close();

                return ret_str;
            }
        }

        public static void UpdateEnvFileDb(ConfigObject conf, DbType db_type, string db_name)
        {
            string env_file_path = string.Format("{0}\\htdocs\\{1}\\.env", conf.xamppPath, db_name);
            System.IO.StreamReader file = new System.IO.StreamReader(env_file_path);

            string all_str = "";
            string line;
            while ((line = file.ReadLine()) != null)
            {
                if (line.StartsWith("DB_CONNECTION"))
                {
                    switch (db_type)
                    {
                        case DbType.mysql:
                            line = "DB_CONNECTION=mysql";
                            break;
                        case DbType.sqlite:
                            line = "DB_CONNECTION=sqlite";
                            break;
                    }
                }
                else if (line.StartsWith("DB_HOST"))
                {
                    switch (db_type)
                    {
                        case DbType.mysql:
                            line = "DB_HOST=127.0.0.1";
                            break;
                        case DbType.sqlite:
                            line = "";
                            break;
                    }
                }
                else if (line.StartsWith("DB_DATABASE"))
                {
                    switch (db_type)
                    {
                        case DbType.mysql:
                            line = "DB_DATABASE=" + db_name;
                            break;
                        case DbType.sqlite:
                            line = string.Format("DB_DATABASE={0}\\htdocs\\{1}\\database\\{2}", conf.xamppPath, db_name, db_name);
                            break;
                    }
                }


                all_str += line + "\n";

            }
            file.Close();

            // 寫入
            System.IO.File.WriteAllText(env_file_path, all_str);
        }

        public static void ExecuteSqlFile(string account, string pwd, string db_name, string sql_file_path)
        {
            string connString = string.Format("server=localhost;port=3306;user id={0};password={1};database=mysql;charset=utf8;", account, pwd);

            string script = "use " + db_name + ";" + File.ReadAllText(sql_file_path);

            using (MySqlConnection conn = new MySqlConnection(connString)) 
            {
                try
                {
                    conn.Open();
                    var cmd = new MySqlCommand(script, conn);
                    int ret = cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
