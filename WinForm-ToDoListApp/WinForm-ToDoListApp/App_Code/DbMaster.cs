using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Text;
using System.Security.Cryptography;

public class DBMaster
{
    private static string main_connection()
    {
        return "Data Source=DESKTOP-QMJ2GCG\\AHMAD;Initial Catalog=DB_TODOApp;Integrated Security=True;";
    }
    public static int Commd_func(string my_qry)
    {
        int status = 0;
        SqlConnection con = new SqlConnection(main_connection());
        try
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(my_qry, con);
            cmd.CommandType = CommandType.Text;
            status = cmd.ExecuteNonQuery();
            return status;
        }
        catch (Exception ex)
        {
            return status;
        }
        finally
        {
            con.Close();
            con.Dispose();
        }
    }
    public static DataTable Get_DT(string qry)
    {
        SqlConnection my_conn = new SqlConnection(main_connection());
        if (qry == null)
        {
            throw (new ArgumentNullException("text"));
        }
        try
        {
            if (my_conn.State == ConnectionState.Open)
            {
                my_conn.Close();
            }
            SqlCommand my_cmd = new SqlCommand(qry, my_conn);
            SqlDataAdapter my_da = new SqlDataAdapter(my_cmd);
            DataTable dt = new DataTable();
            my_da.Fill(dt);
            return dt;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

}