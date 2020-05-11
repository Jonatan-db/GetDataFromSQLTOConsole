using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Collections.Generic;
using ConsoleTables;

namespace RetrieveDataFromSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting to SQL Server!");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            Console.WriteLine("Cadena de conexión detectada en el archivo app.config:");
            Console.WriteLine("------------------------------------------------------");
            ShowConnectionStrings();
            Console.WriteLine();

            Console.WriteLine("Datos de la tabla Clientes:");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            ShowData("SELECT * FROM Clientes");
            Console.ReadKey();
        }

        static void ShowConnectionStrings()
        {
            var settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    Console.WriteLine("Name:              " + cs.Name);
                    Console.WriteLine("Provider:          " + cs.ProviderName);
                    Console.WriteLine("Connection String: " + cs.ConnectionString);
                }
            }
        }

        private static void ShowData(string query)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQL_Testing_Server"].ConnectionString;
            DataSet datosEnMemoria = new DataSet();
            datosEnMemoria = SelectRows(datosEnMemoria, connectionString, query);

            // Usando ConsoleTables:
            ConsoleTable table = new ConsoleTable(datosEnMemoria.Tables[0].Columns.ToString());
            for (int i = 0; i< datosEnMemoria.Tables[0].Rows.Count; i++)
            {
                table.Rows.Add(datosEnMemoria.Tables[0].Rows[i].ItemArray);
            }
            table.Write();

            // Usando ExtensionMethods:
            Console.WriteLine(datosEnMemoria.ToPrettyString());
        }

        private static DataSet SelectRows(DataSet dataset, string connectionString, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(queryString, connection);
                adapter.Fill(dataset);
                return dataset;
            }
        }

    } 
    static class ExtensionMethods
        {
            public static string ToPrettyString(this DataSet ds)
            {
                var sb = new StringBuilder();
                foreach (var table in ds.Tables.ToList())
                {
                    sb.AppendLine("--" + table.TableName + "--");
                    sb.AppendLine(String.Join(" | ", table.Columns.ToList()));
                    foreach (DataRow row in table.Rows)
                    {
                        sb.AppendLine(String.Join(" | ", row.ItemArray));
                    }
                    sb.AppendLine();
                }
                return sb.ToString();
            }

            public static void AddRange(this DataColumnCollection collection, params string[] columns)
            {
                foreach (var column in columns)
                {
                    collection.Add(column);
                }
            }

            public static List<DataTable> ToList(this DataTableCollection collection)
            {
                var list = new List<DataTable>();
                foreach (var table in collection)
                {
                    list.Add((DataTable)table);
                }
                return list;
            }

            public static List<DataColumn> ToList(this DataColumnCollection collection)
            {
                var list = new List<DataColumn>();
                foreach (var column in collection)
                {
                    list.Add((DataColumn)column);
                }
                return list;
            }
        }

}
