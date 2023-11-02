﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SydneyFrippiri
{
    internal class AuxFunctions
    {

        public enum DB_CRUD_TYPE
        {
            INSERT = 0,
            DELETE = 1,
            UPDATE = 2,
            INSERT_NO_AUTO = 3,

        }

        public static bool IsNumberOrDecimal(string input)
        {
            // Regular expression pattern to match a strictly numeric string
            string numericPattern  = @"^[0-9]+(\.[0-9]+)?$";

            // Check if the input string matches the numeric pattern
            return Regex.IsMatch(input, numericPattern);
        }


        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return false;
            string pattern = @"^(\(\d{3}\)|\d{3})\d{3}-?\d{4}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        public static void showDatabaseErrorDialog(string text)
        {
            
            MessageBox.Show(text, "Database Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void showGeneralErrorDialog(string text)
        {
            MessageBox.Show(text, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void showSuccessDialog(string text)
        {
            MessageBox.Show(text, "Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool executeMultipleSQLStatements(List<string> stmts)
        {

            Microsoft.Data.SqlClient.SqlConnection? conn = DBConnection.getConnection();
            SqlCommand cmd = new();
            SqlTransaction? transaction = null;

            try
            {
                transaction = conn?.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                foreach (string sql in stmts)
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                transaction?.Commit();




                return true;
            }
            catch (Exception)
            {
                transaction?.Rollback();
                throw;
            }

        }
        // write a C# function that checks for valid emails 

        public static DataTable executeSingleParametrizedQuery (string sql, object[,] p)
        {
            SqlConnection? conn = DBConnection.getConnection();
            SqlCommand cmd = new();
            
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                for (int i = 0; i < p.Length / 2; i++)
                {
                    cmd.Parameters.AddWithValue(p[i, 0].ToString(), p[i, 1]);
                }
                SqlDataAdapter da = new(cmd);
                DataTable dt = new();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int executeSingleNonQuery(string sql, DB_CRUD_TYPE TYPE)
        {

            SqlConnection? conn = DBConnection.getConnection();
            SqlCommand cmd = new();
            SqlTransaction? transaction = null;

            try
            {
                transaction = conn?.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                int x = cmd.ExecuteNonQuery();
                transaction?.Commit();
                if (TYPE == DB_CRUD_TYPE.INSERT)
                {
                    cmd.CommandText = "SELECT SCOPE_IDENTITY()";
                    int ret = Convert.ToInt32(cmd.ExecuteScalar());
                    return ret;

                }
                else if (TYPE == DB_CRUD_TYPE.DELETE || TYPE == DB_CRUD_TYPE.UPDATE)
                {
                    return x;
                }
                else if (TYPE != DB_CRUD_TYPE.INSERT_NO_AUTO) {
                    return x;
                }

            }
            catch (SqlException)
            {
                transaction?.Rollback();
                throw;
            }
            catch (Exception)
            {
                transaction?.Rollback();


                throw;
            }         
            return -1;
        }

        public static int executeSingleParametrizedNonQuery (string sql, object[,] p, DB_CRUD_TYPE TYPE)

        {
            SqlConnection? conn = DBConnection.getConnection();
            SqlCommand cmd = new();
            SqlTransaction? transaction = null;

            try
            {
                transaction = conn?.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandText = sql;
                if (p != null)
                {
                    for (int i = 0; i <= p.GetLength(0) - 1; i++)
                    {
                        string pName = (string)p[i, 0];
                        object value = p[i, 1];
                        cmd.Parameters.AddWithValue(pName, value);
                    }
                }
                int x = cmd.ExecuteNonQuery();
                transaction?.Commit();
                if (TYPE == DB_CRUD_TYPE.INSERT)
                {
                    cmd.CommandText = "SELECT SCOPE_IDENTITY()";
                    int ret = Convert.ToInt32(cmd.ExecuteScalar());
                    return ret;

                }
                else if (TYPE == DB_CRUD_TYPE.DELETE || TYPE == DB_CRUD_TYPE.UPDATE)
                {
                    return x;
                }
                else if (TYPE != DB_CRUD_TYPE.INSERT_NO_AUTO)
                {
                    return x;
                }
                else { 
                    return -1;
                }

            }
            catch (SqlException )
            {
                transaction?.Rollback();
                throw;
            }
            catch (Exception)
            {
                transaction?.Rollback();    
                throw;
            }
        }

        public static DataTable? executeSQLQuery(string sql)
        {
            SqlConnection? conn = DBConnection.getConnection();
            SqlCommand cmd = new(sql, conn)
            {
                CommandType = CommandType.Text                
            };
            SqlDataAdapter adapter = new(cmd);
            DataTable dataTable = new();



            try
            {
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        public static int executeNonQueryStoredProcedure(string spName, object[,] p, DB_CRUD_TYPE TYPE)
        {
            SqlConnection? conn = DBConnection.getConnection();

            SqlCommand cmd = new(spName, conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            if (p != null)
            {
                for (int i = 0; i <= p.GetLength(0) - 1; i++)
                {
                    string pName = (string)p[i, 0];
                    object value = p[i, 1];
                    cmd.Parameters.AddWithValue(pName, value);
                } // end for
            } // end if

            int x;
            try
            {
                x = cmd.ExecuteNonQuery();
                if (TYPE == DB_CRUD_TYPE.INSERT)
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                else if (TYPE == DB_CRUD_TYPE.DELETE || TYPE == DB_CRUD_TYPE.UPDATE)
                {
                    return x;
                }
                else
                {
                    return -1;
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        } // end if

        public static DataTable? executeQueryStoredProcedure(string spName, object[,] p)
        {

            SqlConnection? conn = DBConnection.getConnection();
            SqlCommand cmd = new(spName, conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            if (p != null)
            {
                for (int i = 0; i <= p.GetLength(0) - 1; i++)
                {
                    string pName = (string)p[i, 0];
                    object value = p[i, 1];
                    cmd.Parameters.AddWithValue(pName, value);
                }
            }

            SqlDataAdapter adapter = new(cmd);
            DataTable dataTable = new();
            try
            {
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
