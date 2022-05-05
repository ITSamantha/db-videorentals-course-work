using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace BD_course_work
{
    class ControllerForDB
    {
        public static string connectionString;

        public static bool isCanceledDelete=true;

        //Данные для генерации
        public static readonly string[] tables ={ "cassette_photo", "cassette_quality", "cassettes",
                                           "countries", "deals", "district", "films", "owners",
                                          "producers", "property_type", "services", "services_prices",
                                          "studios", "video_rental" };

        public static string[] cassette_quality = { "Превосходное", "Хорошее", "Нормальное", "Плохое", "Ужасное" };

        public static string[] countries = { "Россия", "Норвегия", "США", "Таджикистан", "Румыния", "Япония", "Китай", "Англия", "Греция", "Польша", "Италия", "Франция" };

        public static string[] districts = { "Киевский", "Пролетарский", "Ленинский", "Петровский", "Куйбышевский", "Ворошиловский", "Буденновский", "Калининский", "Кировский" };

        public static string[] prop_type = { "Государственная", "Частная(физ.лицо)", "Частная(юр.лицо)", "Коллективная" };

        public static string[] services = { "Прокат", "Запись", "Продажа кассеты", "Обмен кассеты", "Перезапись фильма" };

        public static string[] studios = { "PrismaStudio" , "WowStudio" , "Paramount Pictures" , "20th Century Fox" ,
                                "Columbia Pictures" , "BestFilms" , "Warner Bros." , "Bad Robot Productions" , "Constantin Film" ,
                                "Lucasfilm" , "Original Film" , "Netflix" , "Millennium Films" , "Walt Disney Pictures" , "Pathé" ,
                                "Nobis assumenda quis" , "Est sunt" };

        public static string[] films = { "Достучаться до небес", "Зелёная миля", "Сила воли", "Никогда не сдавайся", "Прислуга", "Форрест Гамп", "Человек паук",
                                  "Великий Гэтсби", "Мемуары Гейши", "Жизнь Пи", "Цветок пустыни", "Три метра над уровнем моря", "Четыре метра над уровнем моря",
                                  "Жизнь Пи=3.14", "Криминальное некриминальное", "Куда приводит ПИ", "Жизнь математика в 3D", "Век Адалин", "Амели" };

        public static string[] video_rentals = { "Перемотка", "Architecto", "БестФилм", "КассетА", "НаНочь!", "Explicabo", "ЕслиСкучно!", "ЗайдиСюда", "Nostrum", "TimeToWatchFilm", "Watch?", "what about film?", "Films!", "WatchMe", "LostFilm" };

        public static string[] female_names = { "Анна", "Дарья", "Амели", "Диана", "Ольга", "Саманта", "Зоя", "Патиция", "Эмма", "Ника", "Жанна", "Владислава", "Дафна" };

        public static string[] female_last_names = { "Савельева", "Барашкина", "Лисицына", "Шубина", "Яковлева", "Елисеева", "Блохина", "Мартова", "Бурова", "Емельянова", "Пушкина", "Баранова", "Вишнякова", "Чернель", "Дубова" };

        public static string[] female_patron = { "Александровна", "Романовна", "Аркадьевна", "Владимировна" };

        public static string[] male_names = { "Боб", "Лаврентий", "Ростислав", "Алекс", "Марат", "Олег", "Валентин", "Владислав", "Петр", "Макар", "Марк", "Дмитрий" };

        public static string[] male_last_names = { "Савельев", "Барашкин", "Лисицын", "Шубин", "Яковлев", "Елисеев", "Блохин", "Мартов", "Буров", "Емельянов", "Пушкин", "Баранов", "Вишняков", "Чернель", "Дубов" };

        public static string[] male_patron = { "Александрович", "Романович", "Аркадьевич", "Владимирович" };

        public static long amount;

        public static byte[][] pics={Instruments.convertImageIntoB(Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\cas1.jpg")),
                                     Instruments.convertImageIntoB(Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\cas2.jpg")),
                                     Instruments.convertImageIntoB(Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\cas3.jpg")),
                                     Instruments.convertImageIntoB(Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\cas4.jpeg")),
                                     Instruments.convertImageIntoB(Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\cas5.jpg")),
                                     Instruments.convertImageIntoB(Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\cas6.jpeg")),
                                     Instruments.convertImageIntoB(Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\cas7.jpg")),
                                     Instruments.convertImageIntoB(Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\cas8.jpeg")),
                                     Instruments.convertImageIntoB(Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\cas9.jpg")),
                                     Instruments.convertImageIntoB(Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\cas10.jpg")),
        };

        //Тестовое соединение
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

        //Генерация данных
        public static void generatePics(int num)
        {
            Random r = new Random();
            
            for(int i = 1; i < num + 1; i++)
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                NpgsqlCommand com = new NpgsqlCommand("Insert into cassette_photo (pk_photo_id,photo) values (default, @Image );", n);
                
                NpgsqlParameter parameter = com.CreateParameter();

                parameter.ParameterName = "@Image";

                parameter.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;

                parameter.Value = pics[r.Next(0, 10)];

                com.Parameters.Add(parameter);

                com.ExecuteNonQuery();

                com.Dispose();

                n.Close();
            }
        }
        
        public static void generateServicesPrices()//Генерация services_prices
        {
            if (getAmountOfRows("services_prices") == 0)
            {
                string command = "Insert into services_prices values";

                long counter = 1;
                
                List<int> services = getSmthForList("services", "pk_service_id");

                List<int> video_rentals = getSmthForList("video_rental", "pk_video_rental_id");

                double n1 = 0.01f;

                Random r = new Random();

                for (int i = 0; i < services.Count; i++)
                {
                    for (int j = 0; j < video_rentals.Count; j++)
                    {
                        if (i == (services.Count - 1) && j == (video_rentals.Count - 1))
                        {
                            command += $"(null, {services[i]}, {video_rentals[j]} ,'{(Math.Round(r.Next(10, 300) + n1, 2)).ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}' );";
                            break;
                        }
                        command += $"( null, {services[i]}, {video_rentals[j]}  ,'{(Math.Round(r.Next(10, 300) + n1, 2)).ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}' ),";
                        n1 += 0.03f;
                        counter++;
                    }
                }
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                var command_sql = new NpgsqlCommand(command, n);

                command_sql.ExecuteNonQuery();

                command_sql.Dispose();

                n.Close();
               
            }
            else
            {
                MessageBox.Show("Невозможно сгенерировать.", "Error");
            }
        }

        public static void generateOrders(int N)//ПОЧЕМУ-ТО ДОБАВЛЯЕТСЯ ВРЕМЯ
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                StringBuilder command = new StringBuilder("Insert into deals values");

                Random r = new Random();

                List<int> cassettes = getSmthForList("cassettes", "pk_cassette_id");

                List<int> services_prices = getSmthForList("services_prices", "pk_service_price_id");

                int deals_count=1;

                if (getAmountOfRows("deals") != 0)
                {
                    NpgsqlCommand c = new NpgsqlCommand("select max(deals.pk_deal_id) from deals;", n);

                    deals_count = (int)c.ExecuteScalar() + 1;
                }

                for (int i = 1; i < N; i++)
                {
                    var cassette_id = cassettes[r.Next(0, (cassettes.Count-1))];

                    var service_id = services_prices[r.Next(0, (services_prices.Count-1))];
                    
                    var price = (double)selectSmthById(service_id, "services_prices", "service_price", "pk_service_price_id") + (double)selectSmthById(cassette_id, "cassettes", "cassette_price", "pk_cassette_id");

                    DateTime date = new DateTime(r.Next(2000, 2021), r.Next(1, 12),r.Next(1, 28));

                    var d = $"{date.Year}-";

                    if (date.Month < 10){ d += $"0{date.Month}-";}
                    else{d += $"{date.Month}-";}
                    if (date.Day < 10) { d += $"0{date.Day}"; }
                    else { d += $"{date.Day}"; }

                    if (services_prices.Count != 0 && cassettes.Count != 0)
                    {
                        if (i == ( N-1))
                        {
                            command.Append($"( {deals_count}, {cassette_id} , ");

                            command.Append($"'Квитанция выдана {date}. . Цена: {price}.Спасибо за посещение! '" + $",  '{d}'::date " + $", '{service_id}', {price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))} ); ");

                            deals_count++;

                            break;
                        }
                        command.Append($"( {deals_count}, {cassette_id} , ");

                        command.Append($"'Квитанция выдана {date}. . Цена: {price}.Спасибо за посещение! '" + $",  '{d}'::date " + $", '{service_id}', {price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))} ), ");

                        deals_count++;
                    }

                }

                var command_sql = new NpgsqlCommand(command.ToString(), n);

                NpgsqlDataReader reader = command_sql.ExecuteReader();

                reader.Close();

                command_sql.Dispose();

                n.Close();

                MessageBox.Show("Успешно сгенерировано.","Оповещение");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);

                return;
            }
        }

        public static void generatePropType()
        {
            if (getAmountOfRows("property_type") == 0)
            {
                NpgsqlConnection c = new NpgsqlConnection(connectionString);

                c.Open();

                var command = $"insert into property_type values ";

                for(int i = 0; i < prop_type.Length; i++)
                {
                    if(i== prop_type.Length - 1)
                    {
                        command += $"({i + 1}, '{prop_type[i]}'); ";break;
                    }
                    command+=$"({i+1}, '{prop_type[i]}'), ";
                }

                NpgsqlCommand com = new NpgsqlCommand(command, c);

                com.ExecuteNonQuery();

                c.Close();
            }
            else
            {
                MessageBox.Show("Невозможно сгенерировать.","Error");
            }
        }

        public static void generateCountries()
        {
            if (getAmountOfRows("countries") == 0)
            {
                NpgsqlConnection c = new NpgsqlConnection(connectionString);

                c.Open();

                var command = $"insert into countries values ";

                for (int i = 0; i < countries.Length; i++)
                {
                    if (i == countries.Length - 1)
                    {
                        command += $"({i + 1}, '{countries[i]}'); "; break;
                    }
                    command += $"({i + 1}, '{countries[i]}'), ";
                }

                NpgsqlCommand com = new NpgsqlCommand(command, c);

                com.ExecuteNonQuery();

                c.Close();
            }
            else
            {
                MessageBox.Show("Невозможно сгенерировать.", "Error");
            }
        }

        public static void generateDistricts()
        {
            if (getAmountOfRows("district") == 0)
            {
                NpgsqlConnection c = new NpgsqlConnection(connectionString);

                c.Open();

                var command = $"insert into district values ";

                for (int i = 0; i < districts.Length; i++)
                {
                    if (i == districts.Length - 1)
                    {
                        command += $"({i + 1}, '{districts[i]}'); "; break;
                    }
                    command += $"({i + 1}, '{districts[i]}'), ";
                }

                NpgsqlCommand com = new NpgsqlCommand(command, c);

                com.ExecuteNonQuery();

                c.Close();
            }
            else
            {
                MessageBox.Show("Невозможно сгенерировать.", "Error");
            }
        }

        public static void generateServices()
        {
            if (getAmountOfRows("services") == 0)
            {
                NpgsqlConnection c = new NpgsqlConnection(connectionString);

                c.Open();

                var command = $"insert into services_view values ";

                for (int i = 0; i < services.Length; i++)
                {
                    if (i == services.Length - 1)
                    {
                        command += $"({i + 1}, '{services[i]}'); "; break;
                    }
                    command += $"({i + 1}, '{services[i]}'), ";
                }

                NpgsqlCommand com = new NpgsqlCommand(command, c);

                com.ExecuteNonQuery();

                c.Close();
            }
            else
            {
                MessageBox.Show("Невозможно сгенерировать.", "Error");
            }
        }

        public static void generateQuality()
        {
            if (getAmountOfRows("cassette_quality") == 0)
            {
                NpgsqlConnection c = new NpgsqlConnection(connectionString);

                c.Open();

                var command = $"insert into cassette_quality values ";

                for (int i = 0; i < cassette_quality.Length; i++)
                {
                    if (i == cassette_quality.Length - 1)
                    {
                        command += $"({i + 1}, '{cassette_quality[i]}'); "; break;
                    }
                    command += $"({i + 1}, '{cassette_quality[i]}'), ";
                }

                NpgsqlCommand com = new NpgsqlCommand(command, c);

                com.ExecuteNonQuery();

                c.Close();
            }
            else
            {
                MessageBox.Show("Невозможно сгенерировать.", "Error");
            }
        }

        public static List<int> getSmthForList(string table,string id_type)
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            var list = new List<int>();

            var command = new NpgsqlCommand($"Select {id_type} from {table};", n);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetInt32(0));
            }

            reader.Close();

            n.Close();

            return list;
        }

        //SELECT-методы

        public static object selectSmthById(int id,string table,string param,string idd)
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            var s = $"Select {param} from {table} where {idd}={id};";

            NpgsqlCommand com = new NpgsqlCommand(s, n);

            var am = com.ExecuteScalar();

            com.Dispose();

            n.Close();

            return am;
        }
        
        public static SortedDictionary<string, int> selectForComboBox(string table, string whatChoose = "", string id_type = "")
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            SortedDictionary<string, int> list = new SortedDictionary<string, int>();

            string textCommand = "";

            if (table.Equals("owners") || table.Equals("producers")||(table.Equals("!services_prices")))
            {
                if (table.Equals("owners"))
                {
                    textCommand = $"Select pk_owner_id,owner_first_name, owner_last_name, owner_patronymic from {table} ;";
                }
                if (table.Equals("producers"))
                {
                    textCommand = $"Select pk_producer_id,producer_first_name, producer_last_name, producer_patronymic from {table} ;";
                }
            }
            else
            {
                if (table.Equals("films"))
                {
                    textCommand = $"Select pk_film_id, film_name, film_year from {table} ;";
                }
                else
                {
                    textCommand = $"Select {id_type}, {whatChoose} from {table} ;";
                }
            }

            var command = new NpgsqlCommand(textCommand, n);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (table.Equals("owners") || table.Equals("producers"))
                {
                    list.Add(reader.GetString(2) + " " + reader.GetString(1) + " " + reader.GetString(3), reader.GetInt32(0));

                    continue;
                }
                if (table.Equals("films"))
                {
                    list.Add(reader.GetString(1)+" "+reader.GetInt32(2), reader.GetInt32(0));

                    continue;
                }
                if (table.Equals("cassettes"))
                {
                    list.Add(reader.GetInt32(1).ToString(), reader.GetInt32(0));

                    continue;
                }
                list.Add(reader.GetString(1), reader.GetInt32(0));
            }

            reader.Close();

            n.Close();

            return list;
        }

        public static SortedDictionary<string, int> selectForComboBoxDeals(int id2)
        {
            SortedDictionary<string, int> list =new SortedDictionary<string, int>();

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            var command = new NpgsqlCommand($"select pk_service_id, service_name from services_view a inner join services_prices b on b.fk_service_id=a.pk_service_id where b.fk_video_rental={id2};" , n);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetString(1), reader.GetInt32(0));
            }

            reader.Close();

            n.Close();

            return list;
        }

        public static long getAmountOfRows(string table_name)//Количество строк в таблице
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            string command = $"Select count(*) from {table_name} ";

            var command_sql = new NpgsqlCommand(command, n);
            
            long amount = (long)command_sql.ExecuteScalar();

            command_sql.Dispose();
            
            n.Close();

            return amount;

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
                            command = "select * from studios_view;";
                            /*$"select a.pk_studio_id,a.studio_name,b.country_name from {table_name} a " +
                            $"inner join {tables[3]} b on a.fk_studio_country=b.pk_country_id";*/
                            break;
                        }
                    case "films":
                        {
                            command = "select * from films_view;";
                                /*$"select a.pk_film_id,a.film_name,b.producer_last_name,b.producer_first_name,b.producer_patronymic,c.studio_name,a.film_year,a.film_duration,a.film_info from {table_name} a " +
                                $"inner join {tables[8]} b on a.fk_producer_id=b.pk_producer_id " +
                                $"inner join {tables[12]} c on a.fk_studio_id=c.pk_studio_id";*/
                            break;
                        }
                    case "cassettes":
                        {
                            command = "select * from cassettes_view;";
                                /*$"select a.pk_cassette_id,b.quality_name,c.photo,a.cassette_price,a.cassette_demand,d.film_name from {table_name} a " +
                                $"inner join {tables[1]} b on a.fk_cassette_quality=b.pk_quality_id " +
                                $"inner join {tables[0]} c on a.fk_cassette_photo= c.pk_photo_id " +
                                $"inner join {tables[6]} d on a.fk_film_id=d.pk_film_id";*/
                            break;
                        }
                    case "video_rental":
                        {
                            command = "select * from rental_view;";
                            /*$"select a.pk_video_rental_id,a.video_caption,b.district_name,a.video_adress," +
                            $"c.property_type_name,a.video_phone,a.license_number,a.time_start,a.time_end," +
                            $"a.amount_of_employees,d.owner_last_name,d.owner_first_name,d.owner_patronymic from {table_name} a " +
                            $"left join {tables[5]} b on a.fk_video_district=b.pk_district_id " +//left join
                            $"left join {tables[9]} c on a.fk_property_type=c.pk_property_type_id " +
                            $"left join {tables[7]} d on a.fk_owner_id=d.pk_owner_id";*/
                            break;
                        }

                    case "services_prices":
                        {
                            command = "select * from service_price_view;";
                            /*$"select a.pk_service_price_id,c.video_caption, b.service_name,a.service_price from {table_name}" +
                            $"  a left join {tables[10]} b on a.fk_service_id=b.pk_service_id left join {tables[13]}" +
                            $" c on a.fk_video_rental=c.pk_video_rental_id";*/
                            break;
                        }

                    case"deals":
                        {
                            command = "select * from deals_view;";
                            /*$"select a.pk_deal_id,f.video_caption,a.fk_cassete_id,d.film_name,a.recipe_deal,a.deal_date,e.service_name,a.general_price from " +
                            $"{table_name} a inner join services_prices b on a.fk_service_price=b.pk_service_price_id inner join cassettes c on a.fk_cassete_id=c.pk_cassette_id " +
                            $"inner join films d on c.fk_film_id=d.pk_film_id inner join services e on b.fk_service_id=e.pk_service_id inner join video_rental f on b.fk_video_rental = f.pk_video_rental_id;"; 
                           //+ $"a inner join cassettes on a.fk_cassette_id=b.*/
                            break;
                        }
                    case "cassette_photo":
                        {
                            command = "select * from images_view;";
                            break;
                        }
                    case "cassette_quality":
                        {
                            command = "select * from quality_view;";
                            break;
                        }
                    case "countries":
                        {
                            command = "select * from countries_view;";
                            break;
                        }
                    case "district":
                        {
                            command = "select * from district_view;";
                            break;
                        }
                    case "owners":
                        {
                            command = "select * from owners_view;";
                            break;
                        }
                    case "producers":
                        {
                            command = "select * from producers_view;";
                            break;
                        }
                    case "property_type":
                        {
                            command = "select * from property_view;";
                            break;
                        }
                    case "services":
                        {
                            command = "select * from services_view;";
                            break;
                        }

                }
                
                amount = getAmountOfRows(table_name);

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
        
        //INSERT-методы

        public static bool insertOrUpdateIntoDeals(int val,int cassette_id, string date,int service_price,double price,int id=0)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                string command = "";

                if (val == 0)
                {
                    command = $"insert into deals values (default,{cassette_id}, '{"Квитанция выдана: "+date+". К оплате: "+price+". Спасибо, что выбрали нас!"}', '{date}', {service_price},'{price});";//СДЕЛАТЬ ТРИГГЕР НА НАПИСАНИЕ КВИТАНЦИИ
                }
                else
                {
                    command = $"update deals set fk_cassete_id = {cassette_id}, recipe_deal = '{"Квитанция выдана: "+date+".К оплате: "+price+".Спасибо, что выбрали нас!"}', deal_date = '{date}', fk_service_price = {service_price},general_price = '{price}' where pk_deal_id={id};";//СДЕЛАТЬ ТРИГГЕР НА НАПИСАНИЕ КВИТАНЦИИ
                }

                var com = new NpgsqlCommand(command, n);

                com.ExecuteNonQuery();

                com.Dispose();

                n.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static int insertOrUpdatePhoto(string path, int val, int id = 0)
        {
            int id1 = 0;

            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                NpgsqlCommand com = new NpgsqlCommand();

                if (path == "")
                {
                    string command = val == 0 ? "Insert into cassette_photo (pk_photo_id,photo) values (default, null ) returning pk_photo_id;" : $"Update cassette_photo set photo=null where pk_photo_id={id} returning pk_photo_id;";

                    com = new NpgsqlCommand(command, n);

                    id1 = (int)com.ExecuteScalar();
                }
                else
                {
                    string command = val == 0 ? "Insert into cassette_photo (pk_photo_id,photo) values (default, @Image ) returning pk_photo_id;" : $"Update cassette_photo set photo=@Image where pk_photo_id={id} returning pk_photo_id;";

                    com = new NpgsqlCommand(command, n);

                    NpgsqlParameter parameter = com.CreateParameter();

                    parameter.ParameterName = "@Image";

                    parameter.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;

                    parameter.Value = Instruments.convertImageIntoB(Image.FromFile(path));

                    com.Parameters.Add(parameter);

                    id1 = (int)com.ExecuteScalar();
                }

                com.Dispose();

                n.Close();

                return id1;
            }
            catch (Exception e)
            {
                Console.Write(e);

                return 0;//Тут еще подумать!!!
            }

        }

        public static bool insertIntoDirectTable(string table,string vary)//Вставка в справочники
        {
            try
            {
                NpgsqlConnection c = new NpgsqlConnection(connectionString);

                c.Open();

                string command = $"insert into {table}  values (null,'{vary}');";

                var command_s = new NpgsqlCommand(command, c);

                var cq = command_s.ExecuteNonQuery();

                command_s.Dispose();

                c.Close();

                return true;
            }
            catch(Npgsql.PostgresException e)
            {
                return false;
            }
        }

        public static bool insertIntoStudios(string name,int id_country)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                NpgsqlCommand com = new NpgsqlCommand($"insert into studios values (default, '{name}', {id_country});", n);

                com.ExecuteNonQuery();

                n.Close();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);

                return false;
            }
        }

        public static int selectByVideoAndService(int video,int service)
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            NpgsqlCommand com = new NpgsqlCommand($"select pk_service_price_id from services_prices where fk_service_id={service} and fk_video_rental = {video};", n);

            int r = (int)com.ExecuteScalar();

            n.Close();

            return r;

        }

        public static bool insertIntoFilms(string film_name, int producer_id,int studio_id,int year,int duration,string info)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                NpgsqlCommand com = new NpgsqlCommand($"insert into films values (default, '{film_name}', {producer_id}, {studio_id}, {year}, {duration}, '{info}');", n);

                com.ExecuteNonQuery();

                n.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return false;
            }
        }

        public static bool insertIntoCassette(int cassette_quality,int cassette_photo,double price,bool demand,int film_id)
        {
            NpgsqlCommand com= new NpgsqlCommand();
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                if (cassette_photo == 0)
                {
                    int id= insertOrUpdatePhoto("", 0);

                    com = new NpgsqlCommand($"insert into cassettes values (default, '{cassette_quality}', {id}, '{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}', '{demand}', {film_id});", n);
                }
                else
                {
                    com = new NpgsqlCommand($"insert into cassettes values (default, '{cassette_quality}', {cassette_photo}, '{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}', '{demand}', {film_id});", n);
                }
                
                com.ExecuteNonQuery();

                n.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return false;
            }
        }

        public static bool updateCassette(int id,int cassette_quality, int cassette_photo, double price, bool demand, int film_id)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                NpgsqlCommand com = new NpgsqlCommand($"update cassettes set fk_cassette_quality = '{cassette_quality}',fk_cassette_photo = {cassette_photo},cassette_price =  '{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}', cassette_demand = '{demand}',fk_film_id =  {film_id} where pk_cassette_id={id};", n);

                com.ExecuteNonQuery();

                n.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool insertIntoServicesPrices(int service_id, int video_rental_id, double price)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                var command = $"insert into services_prices values (default, {service_id}, {video_rental_id}, '{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}');";

                NpgsqlCommand com = new NpgsqlCommand(command, n);

                com.ExecuteNonQuery();

                com.Dispose();

                n.Close();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);

                return false;
            }
        }

        public static bool insertOrUpdateIntoPeopleTable(string table,string last,string first,string patron,int val,int id=0)
        {
            try
            {
                NpgsqlConnection c = new NpgsqlConnection(connectionString);

                c.Open();

                string command = val == 0 ? $"insert into {table}  values (default,'{first}','{last}','{patron}');" :
                    (table.Equals("owners") ? $"update {table}  set owner_first_name = '{first}', owner_last_name = '{last}', owner_patronymic = '{patron}' where pk_owner_id={id};" :
                    $"update {table}  set producer_first_name = '{first}', producer_last_name = '{last}', producer_patronymic = '{patron}' where pk_producer_id={id};");

                var command_s = new NpgsqlCommand(command, c);

                var cq = command_s.ExecuteNonQuery();

                command_s.Dispose();

                c.Close();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public static bool insertIntoVideoRental(string video_name,int video_id,string adress,int prop,string phone,string number,string time_s,string time_e,int amount,int owner_id)//Добавление в Video_Rental
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();
                
                var command = $"insert into video_rental values (default,'{video_name}','{video_id}','{adress}','{prop}','{phone}','{number}','{time_s}','{time_e}','{amount}','{owner_id}' );";
               
                NpgsqlCommand com = new NpgsqlCommand(command, n);

                com.ExecuteNonQuery();

                return true;

            }
            catch(Exception e)
            {
                Console.WriteLine(e);

                MessageBox.Show("Строка не добавлена. Возможно, лицензия или номер телефона не уникальны.");

                return false;
            }
        }

        //UPDATE-методы
        public static bool updateStudios(string name, int id_country,int studio_id)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                NpgsqlCommand com = new NpgsqlCommand($"update studios set studio_name= '{name}', fk_studio_country= {id_country} where pk_studio_id ={ studio_id};", n);

                com.ExecuteNonQuery();

                n.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return false;
            }
        }

        public static bool updateServicesPrices(int id,int service_id, int video_rental_id, double price)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                var command = $"update services_prices set fk_service_id = {service_id}, fk_video_rental = {video_rental_id}, service_price = '{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}' where pk_service_price_id = {id};";

                NpgsqlCommand com = new NpgsqlCommand(command, n);

                com.ExecuteNonQuery();

                com.Dispose();

                n.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return false;
            }
        }

        public static bool updateFilms(int id,string film_name, int producer_id, int studio_id, int year, int duration, string info)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                NpgsqlCommand com = new NpgsqlCommand($"update films set film_name= '{film_name}',fk_producer_id= {producer_id}, fk_studio_id = {studio_id}, film_year = {year}, film_duration = {duration}, film_info =  '{info}' where pk_film_id ={id};", n);

                com.ExecuteNonQuery();

                n.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return false;
            }
        }
        
        public static bool updateIntoVideoRental(int id,string video_name, int video_id, string adress, int prop, string phone, string number, string time_s, string time_e, int amount, int owner_id)//Редактирование в Video_Rental
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                var command = $"update video_rental set  video_caption ='{video_name}', " +
                    $"fk_video_district = '{video_id}', video_adress = '{adress}'," +
                    $"fk_property_type ='{prop}', video_phone = '{phone}'," +
                    $"license_number = '{number}',time_start = '{time_s}'," +
                    $"time_end = '{time_e}',amount_of_employees = '{amount}'," +
                    $"fk_owner_id = '{owner_id}' where pk_video_rental_id = {id};";

                NpgsqlCommand com = new NpgsqlCommand(command, n);

                com.ExecuteNonQuery();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return false;
            }
        }
        
        public static bool updateDirectTables(string table,int id,string value)//ФОТО СДЕЛАТЬ ОТДЕЛЬНО!
        {
            NpgsqlConnection c = new NpgsqlConnection(connectionString);

            c.Open();

            string command="";

            switch (table)
            {
                case "cassette_quality":
                    {
                        command = $"update {table} set quality_name = '{value}' where pk_quality_id={id};";

                        break;
                    }
                
                case "district":
                    {
                        command = $"update {table} set district_name = '{value}' where pk_district_id={id};";

                        break;
                    }
                case "countries":
                    {
                        command = $"update {table} set country_name = '{value}' where pk_country_id={id};";

                        break;
                    }
                case "property_type":
                    {
                        command = $"update {table} set property_type_name = '{value}' where pk_property_type_id={id};";

                        break;
                    }
                case "services":
                    {
                        command = $"update {table} set service_name = '{value}' where pk_service_id={id};";

                        break;
                    }
            }
            try
            {
                NpgsqlCommand com = new NpgsqlCommand(command, c);

                com.ExecuteNonQuery();

                com.Dispose();

                c.Close();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        
        //DELETE-методы
        public static bool deleteById(int id,string table,string id_title,bool isMessage)
        {
            DialogResult dialogResult= new DialogResult();
            
            if (isMessage)
            {
                switch (table)
                {
                    case "cassette_photo":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "cassette_quality":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблице \"Кассеты\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "cassettes":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблице \"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "countries":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Студии\", \"Фильмы\",\"Кассеты\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "deals":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "district":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Видеопрокаты\",\"Услуги и цены\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "films":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Кассеты\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "owners":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Видеопрокат\",\"Сделки\",\"Услуги и цены\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "producers":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Фильмы\",\"Кассеты\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "property_type":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Видеопрокат\",\"Сделки\",\"Услуги и цены\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "services":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Услуги и цены\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "services_prices":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "studios":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Фильмы\",\"Кассеты\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                    case "video_rental":
                        {
                            dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Услуги и цены\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            break;
                        }
                }
            }
            else
            {
                if (isCanceledDelete == false){dialogResult = DialogResult.Yes;}
                else { dialogResult = DialogResult.No; }
            }

            if (dialogResult == DialogResult.No)
            {
                isCanceledDelete = true;
            }

            if (dialogResult == DialogResult.Yes)
            {
                isCanceledDelete = false;

                try
                {
                    NpgsqlConnection c = new NpgsqlConnection(connectionString);

                    c.Open();

                    string command = $"delete from {table} where {id_title} = {id};";//Подумать над каскадным удалением, не удаляет, когда используется во внешнем ключе

                    var command_s = new NpgsqlCommand(command, c);


                    command_s.ExecuteNonQuery();

                    command_s.Dispose();

                    c.Close();

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return false;
                }
            }

            return false;
        }

        public static bool deletePhoto(int id)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                var command = new NpgsqlCommand($"update cassette_photo set photo = null where pk_photo_id={id}", n);

                command.ExecuteNonQuery();

                n.Close();

                command.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool deleteByValue(string value, string table, string string_title)//Не дописан
        {
            DialogResult dialogResult = new DialogResult();

            switch (table)
            {
                case "cassette_photo":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "cassette_quality":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблице \"Кассеты\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "cassettes":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблице \"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "countries":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Студии\", \"Фильмы\",\"Кассеты\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "deals":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "district":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Видеопрокаты\",\"Услуги и цены\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "films":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Кассеты\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "owners":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Видеопрокат\",\"Сделки\",\"Услуги и цены\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "producers":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Фильмы\",\"Кассеты\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "property_type":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Видеопрокат\",\"Сделки\",\"Услуги и цены\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "services":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Услуги и цены\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "services_prices":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "studios":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Фильмы\",\"Кассеты\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
                case "video_rental":
                    {
                        dialogResult = MessageBox.Show("Вы уверены? В таблицах \"Услуги и цены\",\"Сделки\" будут удалены записи, связанные с данной строкой. Это действие нельзя будет отменить.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        break;
                    }
            }

            isCanceledDelete = false;

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    NpgsqlConnection c = new NpgsqlConnection(connectionString);

                    c.Open();

                    string command = $"delete from {table} where {string_title} = '{value}';";

                    var command_s = new NpgsqlCommand(command, c);
                    
                    var count = command_s.ExecuteNonQuery();

                    command_s.Dispose();

                    c.Close();

                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Строка с таким значением не была найдена и удалена.");

                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    return false;
                }
            }
            isCanceledDelete = true;

            return false;
        }

        //Методы поиска SEARCH
        public static DataTable searchStudio(string search,string filter)
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            string com = $"select * from studios_view ";

            if (filter != "")
            {
                if (search != "")
                {

                    com += $" where studio_name='{search}' and country_name='{filter}'";
                }
                else
                {
                    com += $" where country_name='{filter}'";
                }
            }
            else
            {
                if (search != "")
                {
                    com += $" where studio_name='{search}';";
                }
            }

            var command_sql = new NpgsqlCommand(com, n);

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

        public static DataTable searchServicesPrices(string video,string service,string more,string less)
        {
            DataTable dt = new DataTable();

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            string com = $"select * from service_price_view ";

            if (video != "")
            {
                com += $" where video_caption ='{video}' ";
            }
            if (service != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and service_name ='{service}' ";
                }
                else
                {
                    com += $" where service_name ='{service}' ";
                }
            }
            if (more != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and service_price >='{double.Parse(more).ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}' ";
                }
                else
                {
                    com += $" where service_price >='{double.Parse(more).ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}' ";
                }
            }
            if (less != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and service_price <='{double.Parse(less).ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}' ";
                }
                else
                {
                    com += $" where service_price <='{double.Parse(less).ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}' ";
                }
            }

            com += " order by service_price ASC;";

            var command_sql = new NpgsqlCommand(com, n);

            NpgsqlDataReader reader = command_sql.ExecuteReader();
            
            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            command_sql.Dispose();

            reader.Close();
            
            n.Close();

            return dt;

        }

        public static DataTable searchDictionary(string whatFind,string table,string key)//Поиск в словарях
        {
            DataTable dt = new DataTable();

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            string com = $"select * from {table} ";

            if (whatFind != String.Empty)
            {
                com += $" where {key} ='{whatFind}'";
            }
            
            var command_sql = new NpgsqlCommand(com, n);

            NpgsqlDataReader reader = command_sql.ExecuteReader();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            command_sql.Dispose();

            reader.Close();

            n.Close();

            return dt;
        }

        public static DataTable searchPeopleTable(string table,string last,string first,string patron)
        {
            DataTable dt = new DataTable();

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            string com = "";

            if (table == "producers")
            {
                com = $"select * from producers_view ";

                if (last != "")
                {
                    com += $" where producer_last_name ='{last}' ";
                }
                if (first != "")
                {
                    if (com.Contains("where"))
                    {
                        com += $" and producer_first_name ='{first}' ";
                    }
                    else
                    {
                        com += $" where producer_first_name ='{first}' ";
                    }
                }
                if (patron != "")
                {
                    if (com.Contains("where"))
                    {
                        com += $" and producer_patronymic ='{patron}' ";
                    }
                    else
                    {
                        com += $" where producer_patronymic ='{patron}' ";
                    }
                }
            }
            else
            {
                com = $"select * from owners_view ";

                if (last != "")
                {
                    com += $" where owner_last_name ='{last}' ";
                }
                if (first != "")
                {
                    if (com.Contains("where"))
                    {
                        com += $" and owner_first_name ='{first}' ";
                    }
                    else
                    {
                        com += $" where owner_first_name ='{first}' ";
                    }
                }
                if (patron != "")
                {
                    if (com.Contains("where"))
                    {
                        com += $" and owner_patronymic ='{patron}' ";
                    }
                    else
                    {
                        com += $" where owner_patronymic ='{patron}' ";
                    }
                }
            }
            
            var command_sql = new NpgsqlCommand(com, n);

            NpgsqlDataReader reader = command_sql.ExecuteReader();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            command_sql.Dispose();

            reader.Close();

            n.Close();

            return dt;
        }

        public static DataTable searchFilms(string film_name,string studio,string last,string first,string patron,string year1,string year2,string info,string dur1,string dur2)
        {
            DataTable dt = new DataTable();

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            string com = "select * from films_view ";

            if (film_name != String.Empty)
            {
                com += $" where film_name='{film_name}' ";
            }
            if(studio != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and studio_name ='{studio}' ";
                }
                else
                {
                    com += $" where studio_name ='{studio}' ";
                }
            }
            if (info != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and film_info ='{info}' ";
                }
                else
                {
                    com += $" where film_info ='{info}' ";
                }
            }
            if (last != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and producer_last_name ='{last}' ";
                }
                else
                {
                    com += $" where producer_last_name ='{last}' ";
                }
            }
            if (first != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and producer_first_name ='{first}' ";
                }
                else
                {
                    com += $" where producer_first_name ='{first}' ";
                }
            }
            if (patron != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and producer_patronymic ='{patron}' ";
                }
                else
                {
                    com += $" where producer_patronymic ='{patron}' ";
                }
            }
            if (year1 != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and film_year >='{year1}' ";
                }
                else
                {
                    com += $" where film_year >='{year1}' ";
                }
            }
            if (year2 != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and film_year <='{year2}' ";
                }
                else
                {
                    com += $" where film_year <='{year2}' ";
                }
            }
            if (dur1 != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and film_duration >='{dur1}' ";
                }
                else
                {
                    com += $" where film_duration >='{dur1}' ";
                }
            }
            if (dur2 != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and film_duration <='{dur2}' ";
                }
                else
                {
                    com += $" where film_duration <='{dur2}' ";
                }
            }
            var command_sql = new NpgsqlCommand(com, n);

            NpgsqlDataReader reader = command_sql.ExecuteReader();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            command_sql.Dispose();

            reader.Close();

            n.Close();

            return dt;
        }

        
        /*public static bool deleteAllFromtable(string table)
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

        }*/

    }

}
