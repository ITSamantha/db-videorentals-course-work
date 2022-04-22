using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BD_course_work
{
    class ControllerForDB
    {
        public static string connectionString;

        public static readonly string[] tables ={ "cassette_photo", "cassette_quality", "cassettes",
                                           "countries", "deals", "district", "films", "owners",
                                          "producers", "property_type", "services", "services_prices",
                                          "studios", "videorental" };




        public static bool Connection(string connect)
        {
            try
            {
                connectionString = connect;

                NpgsqlConnection connection = new NpgsqlConnection();
                
                connection.Open();

                connection.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Connection error: \n {e} ");

                return false;
            }
        }

        public static DataTable selectAllFromTablesDirectories(string table_name)//Выбока всего из таблиц-справочников
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                string command =$"select * from {table_name}";

                var command_sql = new NpgsqlCommand(command, n);

                NpgsqlDataReader reader = command_sql.ExecuteReader();

                DataTable dt = new DataTable();

                if (reader.HasRows)
                {
                    
                    dt.Load(reader);
                    
                }

                command_sql.Dispose();

                reader.Close();

                n.Close();

                return dt;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error of select all: \n" + e);

                return null;
            }
           
    
        }

        public static DataTable selectAllFromMainTables(string table_name)//Выбока всего из главных таблиц
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                string command = "";

                switch (table_name)
                {
                    case "studios"://Студии
                        {
                            command = $"select a.pk_studio_id,a.studio_name,b.country_name from {table_name} a " +
                                $"left join {tables[3]} b on a.fk_studio_country=b.pk_country_id";
                            break;
                        }
                    case "films":
                        {
                            command = $"select a.pk_film_id,a.film_name,b.producer_last_name,b.producer_first_name,b.producer_patronymic,c.studio_name,a.film_year,a.film_duration,a.film_info from {table_name} a " +
                                $"left join {tables[8]} b on a.fk_producer_id=b.pk_producer_id " +
                                $"left join {tables[12]} c on a.fk_studio_id=c.pk_studio_id";
                            break;
                        }
                    case "cassettes":
                        { 
                        command = $"select a.pk_cassette_id,b.quality_name,c.photo,a.cassette_price,a.cassette_demand,d.film_name from {table_name} a " +
                                $"left join {tables[1]} b on a.fk_cassette_quality=b.pk_quality_id " +
                                $"left join {tables[0]} c on a.fk_cassette_photo= c.pk_photo_id " +
                                $"left join {tables[6]} d on a.fk_film_id=d.pk_film_id";
                            break;
                        }
                    case "video_rental":
                        {
                            command = $"select a.pk_video_rental_id,a.video_caption,b.district_name,a.video_adress," +
                                $"c.property_type_name,a.video_phone,a.license_number,a.time_start,a.time_end," +
                                $"a.amount_of_employees,d.owner_last_name,d.owner_first_name,d.owner_patronymic from {table_name} a " +
                                $"left join {tables[5]} b on a.fk_video_district=b.pk_district_id " +
                                $"left join {tables[9]} c on a.fk_property_type=c.pk_property_type_id " +
                                $"left join {tables[7]} d on a.fk_owner_id=d.pk_owner_id";
                            break;
                        }
                  

                }

                var command_sql = new NpgsqlCommand(command, n);

                NpgsqlDataReader reader = command_sql.ExecuteReader();

                DataTable dt = new DataTable();

                if (reader.HasRows)
                {

                    dt.Load(reader);

                }

                command_sql.Dispose();

                reader.Close();

                n.Close();

                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error of select all: \n" + e);

                return null;
            }
        }

        public static void insertIntoDirectTable(string table,string vary)//Вставка в справочники
        {
            NpgsqlConnection c = new NpgsqlConnection(connectionString);

            c.Open();

            string command = $"insert into {table}  values (default,'{vary}');";
           
            var command_s = new NpgsqlCommand(command, c);
            
            var cq=command_s.ExecuteNonQuery();

            command_s.Dispose();
            
            c.Close();

        }

        public static void insertIntoPeopleTable(string table,string last,string first,string patron)
        {
            NpgsqlConnection c = new NpgsqlConnection(connectionString);

            c.Open();

            string command = $"insert into {table}  values (default,'{first}','{last}','{patron}');";//Проверка на допустимый null?

            var command_s = new NpgsqlCommand(command, c);

            var cq = command_s.ExecuteNonQuery();

            command_s.Dispose();

            c.Close();
        }

    }

}
