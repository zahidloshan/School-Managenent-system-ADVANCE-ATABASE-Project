using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;
using System.Data;

namespace SchoolManagementSystem
{
    static class DataAccess
    {
        private static OracleConnection oracon;
        public static OracleConnection Oracon
        {
            get { return oracon; }
            set { oracon = value; }
        }

        private static OracleCommand sqlcom;
        public static OracleCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private static OracleDataAdapter sda;
        public static OracleDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private static DataSet ds;
        public static DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        static DataAccess()
        {
            Oracon = new OracleConnection("User Id =scott;Password=tiger;Data Source =DESKTOP-LEQ6NJC");
            Oracon.Open();
        }
        private static void QueryText(string query)
        {
            Sqlcom = new OracleCommand(query, Oracon);
        }

        public static DataSet ExecuteQuery(string sql)
        {
            try
            {
                QueryText(sql);
                Sda = new OracleDataAdapter(Sqlcom);
                Ds = new DataSet();
                Sda.Fill(Ds);
                return Ds;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public static DataTable ExecuteQueryTable(string sql)
        {
            try
            {
                QueryText(sql);
                Sda = new OracleDataAdapter(Sqlcom);
                Ds = new DataSet();
                Sda.Fill(Ds);
                return Ds.Tables[0];
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public static int ExecuteUpdateQuery(string sql)
        {
            QueryText(sql);
            int u = Sqlcom.ExecuteNonQuery();
            return u;

        }
    }
}
