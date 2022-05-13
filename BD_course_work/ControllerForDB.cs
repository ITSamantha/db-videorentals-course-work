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
        public static string connectionString= "Server = localhost; Port = 5432;UserId = postgres; Password =01dr10kv; Database = Video_Rentals; ";

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
                                "Nobis assumenda quis" , "Est sunt","Филььмец!", "Фильм?!", "ЛюблюКино!" };

        public static string[] films = { "Достучаться до небес", "Зелёная миля", "Сила воли", "Никогда не сдавайся", "Прислуга", "Форрест Гамп", "Человек паук",
                                  "Великий Гэтсби", "Мемуары Гейши", "Жизнь Пи", "Цветок пустыни", "Три метра над уровнем моря", "Четыре метра над уровнем моря",
                                  "Жизнь Пи=3.14", "Криминальное некриминальное", "Куда приводит ПИ", "Жизнь математика в 3D", "Век Адалин", "Амели" };

        public static string[] film_info = {"Это самый крутой фильм!", "Этот фильм стоит посмотреть каждому!", "Ты должен посмотреть этот фильм!" };

        public static string[] video_rentals = { "Перемотка", "Architecto", "БестФилм", "КассетА", "НаНочь!", "Explicabo", "ЕслиСкучно!", "ЗайдиСюда",
            "Nostrum", "TimeToWatchFilm", "Watch?", "what about film?", "Films!", "WatchMe", "LostFilm","ПосмотриФильм", "ПоттерДом", "ПодПопкорн","Бублик", "Integer",
            "Видеопросмотр","ПоПкОрН", "Перемотка+", "Перемотка++", "СуперВидеопрокат", "ЛюбителиКино", "Видеопрокат для ребят","Леонтьев", "NoExit","MyFilm",
            "Filmец","Dandelions", "EatAndWatch","ПО", "Фильмы Средневековья", "Психология фильма", "ДляЛюбителя!"};


        public static string[] female_names = { "Анна", "Дарья", "Амели", "Диана", "Ольга", "Саманта", "Зоя", "Патриция", "Эмма", "Ника", "Жанна", "Владислава", "Дафна" };

        public static string[] female_last_names = { "Савельева", "Барашкина", "Лисицына", "Шубина", "Яковлева", "Елисеева", "Блохина", "Мартова", "Бурова", "Емельянова", "Пушкина", "Баранова", "Вишнякова", "Чернель", "Дубова" };

        public static string[] female_patron = { "Александровна", "Романовна", "Аркадьевна", "Владимировна" };

        public static string[] male_names = { "Боб", "Лаврентий", "Ростислав", "Алекс", "Марат", "Олег", "Валентин", "Владислав", "Петр", "Макар", "Марк", "Дмитрий" };

        public static string[] male_last_names = { "Савельев", "Барашкин", "Лисицын", "Шубин", "Яковлев", "Елисеев", "Блохин", "Мартов", "Буров", "Емельянов", "Пушкин", "Баранов", "Вишняков", "Чернель", "Дубов" };

        public static string[] male_patron = { "Александрович", "Романович", "Аркадьевич", "Владимирович" };

        public static string[] streets = { "Пушкина", "Колотушкина", "Матвеева", "Лаптева", "Дурова", "Макарова", "Бабкина", "Барашкина" };

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
        /*public static bool Connection(string connect)
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
        }*/

        //Генерация данных
        public static void generatePics(int num)
        {
            Random r = new Random();
            
            for(int i = 1; i < num + 1; i++)
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                NpgsqlCommand com = new NpgsqlCommand("Insert into cassette_photo (pk_photo_id,photo) values (null, @Image );", n);
                
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

        public static void generatePeople(int value,int num)
        {
                if (value==0&&getAmountOfRows("producers") != 0)
                {
                    MessageBox.Show("Невозможно сгенерировать.", "Error");

                    return;
                }
                if (value==1&&getAmountOfRows("owners") != 0)
                {
                        MessageBox.Show("Невозможно сгенерировать.", "Error");

                        return;
                }
            
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                Random r = new Random();

                StringBuilder s = new StringBuilder($"insert into { (value == 0 ? "producers" : "owners") } values ");

                for (int i = 0; i < num; i++)
                {
                    if (r.Next(0, 2) == 0)
                    {
                        if (i == (num - 1))
                        {
                            s.Append($" (null,'{male_names[r.Next(0, male_names.Length)]}','{male_last_names[r.Next(0, male_last_names.Length)]}','{male_patron[r.Next(0, male_patron.Length)]}' ); ");
                        }
                        else { s.Append($" (null,'{male_names[r.Next(0, male_names.Length)]}','{male_last_names[r.Next(0, male_last_names.Length)]}','{male_patron[r.Next(0, male_patron.Length)]}' ), "); }
                    }
                    else
                    {
                        if (i == (num - 1))
                        {
                            s.Append($" (null,'{female_names[r.Next(0, female_names.Length)]}','{female_last_names[r.Next(0, female_last_names.Length)]}','{female_patron[r.Next(0, female_patron.Length)]}' ); ");
                        }
                        else
                        {
                            s.Append($" (null,'{female_names[r.Next(0, female_names.Length)]}','{female_last_names[r.Next(0, female_last_names.Length)]}','{female_patron[r.Next(0, female_patron.Length)]}' ), ");
                        }
                    }
                }

                NpgsqlCommand com = new NpgsqlCommand(s.ToString(), n);
            
                com.ExecuteNonQuery();

                com.Dispose();

                n.Close();
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
            if (getAmountOfRows("deals") == 0)
            {
                if (getAmountOfRows("services_prices") == 0)
                {
                    MessageBox.Show("Невозможно сгенерировать, таблица \"Услуги и цены\" пуста.", "Error");

                    return;
                }
                if (getAmountOfRows("cassettes") == 0)
                {
                    MessageBox.Show("Невозможно сгенерировать, таблица \"Кассеты\" пуста.", "Error");

                    return;
                }
                try
                {
                    NpgsqlConnection n = new NpgsqlConnection(connectionString);

                    n.Open();

                    StringBuilder command = new StringBuilder("Insert into deals values");

                    Random r = new Random();

                    List<int> cassettes = getSmthForList("cassettes", "pk_cassette_id");

                    List<int> services_prices = getSmthForList("services_prices", "pk_service_price_id");

                    for (int i = 1; i < N; i++)
                    {
                        var cassette_id = cassettes[r.Next(0, (cassettes.Count - 1))];

                        var service_id = services_prices[r.Next(0, (services_prices.Count - 1))];

                        var price = (double)selectSmthById(service_id, "services_prices", "service_price", "pk_service_price_id") + (double)selectSmthById(cassette_id, "cassettes", "cassette_price", "pk_cassette_id");

                        DateTime date = new DateTime(r.Next(2000, 2021), r.Next(1, 12), r.Next(1, 28));

                        if (services_prices.Count != 0 && cassettes.Count != 0)
                        {
                            if (i == (N - 1))
                            {
                                command.Append($"( null, {cassette_id} , ");

                                command.Append($"'Квитанция выдана {date.ToShortDateString()}.\n Цена: {price}.\nСпасибо за посещение видеопроката!',  '{date.ToShortDateString()}'::date " + $", '{service_id}', {price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))} ); ");

                                break;
                            }
                            command.Append($"( null, {cassette_id} , ");

                            command.Append($"'Квитанция выдана {date.ToShortDateString()}.\n Цена: {price}.\nСпасибо за посещение видеопроката!',  '{date.ToShortDateString()}'::date " + $", '{service_id}', {price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))} ), ");
                        }

                    }

                    var command_sql = new NpgsqlCommand(command.ToString(), n);

                    NpgsqlDataReader reader = command_sql.ExecuteReader();

                    reader.Close();

                    command_sql.Dispose();

                    n.Close();

                    MessageBox.Show("Успешно сгенерировано.", "Оповещение");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    return;
                }
            }
            else
            {
                MessageBox.Show("Невозможно сгенерировать.", "Error");
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
                        command += $"(null, '{prop_type[i]}'); ";break;
                    }
                    command+=$"(null, '{prop_type[i]}'), ";
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
                        command += $"(null, '{countries[i]}'); "; break;
                    }
                    command += $"(null, '{countries[i]}'), ";
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
                        command += $"(null, '{districts[i]}'); "; break;
                    }
                    command += $"(null, '{districts[i]}'), ";
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
                        command += $"(null, '{services[i]}'); "; break;
                    }
                    command += $"(null, '{services[i]}'), ";
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
                        command += $" (null, '{cassette_quality[i]}'); "; break;
                    }
                    command += $" (null, '{cassette_quality[i]}'), ";
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

        public static void generateStudios()
        {
            if (getAmountOfRows("studios") == 0)
            {
                NpgsqlConnection c = new NpgsqlConnection(connectionString);

                List<int> ids = new List<int>();

                c.Open();

                var command = $"insert into studios values ";

                if (getAmountOfRows("countries")==0)
                {
                    MessageBox.Show("Невозможно сгенерировать, таблица \"Страны\" пуста.", "Error");

                    return;
                }
                else
                {
                    ids = getSmthForList("countries", "pk_country_id");
                }

                Random r = new Random();

                for (int i = 0; i < studios.Length; i++)
                {
                    if (i == studios.Length - 1)
                    {
                        command += $" (null, '{studios[i]}','{ids[r.Next(0,ids.Count)]}' ) ; "; break;
                    }
                    command += $" (null, '{studios[i]}','{ids[r.Next(0, ids.Count)]}' ), ";
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

        public static void filmGeneration(int num)
        {
            if (getAmountOfRows("films") == 0)
            {
                List<int> ids1 = new List<int>();

                List<int> ids2 = new List<int>();

                if (getAmountOfRows("studios") == 0)
                {
                    MessageBox.Show("Невозможно сгенерировать.Таблица \"Студии\" пуста.", "Error");
                    return;
                }
                else
                {
                    ids1 = getSmthForList("studios", "pk_studio_id");
                }
                if (getAmountOfRows("producers") == 0)
                {
                    MessageBox.Show("Невозможно сгенерировать.Таблица \"Режиссеры\" пуста.", "Error");
                    return;
                }
                else
                {
                    ids2 = getSmthForList("producers", "pk_producer_id");
                }

                NpgsqlConnection c = new NpgsqlConnection(connectionString);
                
                c.Open();

                var command = $"insert into films values ";
                
                Random r = new Random();

                for (int i = 0; i < num; i++)
                {
                    if (i == (num - 1))
                    {
                        command += $" (null,'{films[r.Next(0,films.Length)]}','{ids2[r.Next(0, ids2.Count)]}','{ids1[r.Next(0, ids1.Count)]}','{r.Next(1888,2023)}','{r.Next(30, 401)}','{film_info[r.Next(0,3)]}' ) ; "; break;
                    }
                    command += $" (null,'{films[r.Next(0, films.Length)]}','{ids2[r.Next(0, ids2.Count)]}','{ids1[r.Next(0, ids1.Count)]}','{r.Next(1888, 2023)}','{r.Next(30, 401)}','{film_info[r.Next(0, 3)]}' ), ";
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

        public static void generateCassettes(int num)
        {
            if (getAmountOfRows("cassettes") == 0)
            {
                List<int> ids1 = new List<int>();//Качество

                List<int> ids2 = new List<int>();//Фильмы

                List<int> photos = new List<int>();//Фото

                if (getAmountOfRows("cassette_quality") == 0)
                {
                    MessageBox.Show("Невозможно сгенерировать.Таблица \"Качество кассеты\" пуста.", "Error");
                    return;
                }
                else
                {
                    ids1 = getSmthForList("cassette_quality", "pk_quality_id");
                }
                if (getAmountOfRows("films") == 0)
                {
                    MessageBox.Show("Невозможно сгенерировать.Таблица \"Фильмы\" пуста.", "Error");
                    return;
                }
                else
                {
                    ids2 = getSmthForList("films", "pk_film_id");
                }
                if (getAmountOfRows("cassette_photo") == 0)
                {
                    MessageBox.Show("Таблица \"Фото кассеты\" пуста.Запущена генерация фото.", "Error");

                    generatePics(num);

                    photos = getSmthForList("cassette_photo", "pk_photo_id");

                }
                else
                {
                    if(getAmountOfRows("cassette_photo") >= num)
                    {
                        photos = getSmthForList("cassette_photo", "pk_photo_id");
                    }
                    else
                    {
                        MessageBox.Show("В таблице \"Фото\" не достаточно фото для генерации.", "Error");
                        return;
                    }
                }

                NpgsqlConnection c = new NpgsqlConnection(connectionString);

                c.Open();

                var command = $"insert into cassettes values ";

                Random r = new Random();

                double f = 0.9f;
                
                for (int i = 0; i < num; i++)
                {
                    if (i == (num - 1))
                    {
                        command += $" (null,'{ids1[r.Next(0,ids1.Count)]}',{photos[i]},'{Math.Round((double)(r.Next(100,2000)+f),2).ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}','{(r.Next(0,2)==0? "false":"true")}','{ids2[r.Next(0,ids2.Count)]}' ) ; "; break;
                    }
                    command += $" (null,'{ids1[r.Next(0, ids1.Count)]}',{photos[i]},'{Math.Round((double)(r.Next(100, 2000) + (double)Math.Round(r.NextDouble(),2)),2).ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}','{(r.Next(0, 2) == 0 ? "false" : "true")}','{ids2[r.Next(0, ids2.Count)]}' ),  ";
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

        public static void generateVideoRental()
        {
            if (getAmountOfRows("video_rental") == 0)
            {
                NpgsqlConnection c = new NpgsqlConnection(connectionString);

                List<int> ids = new List<int>();//Районы

                List<int> ids1 = new List<int>();//Тип собственности

                List<int> ids2 = new List<int>();//Тип собственности

                c.Open();

                var command = $"insert into video_rental values ";

                if (getAmountOfRows("district") == 0)
                {
                    MessageBox.Show("Невозможно сгенерировать, таблица \"Районы\" пуста.", "Error");

                    return;
                }
                else
                {
                    ids = getSmthForList("district", "pk_district_id");
                }
                if (getAmountOfRows("property_type") == 0)
                {
                    MessageBox.Show("Невозможно сгенерировать, таблица \"Тип собственности\" пуста.", "Error");

                    return;
                }
                else
                {
                    ids1 = getSmthForList("property_type", "pk_property_type_id");
                }
                if (getAmountOfRows("owners") == 0)
                {
                    MessageBox.Show("Невозможно сгенерировать, таблица \"Хозяева\" пуста.", "Error");

                    return;
                }
                else
                {
                    ids2 = getSmthForList("owners", "pk_owner_id");
                }
                
                Random r = new Random();

                for (int i = 0; i < video_rentals.Length; i++)
                {
                    if (i == video_rentals.Length - 1)
                    {
                        command += $" (null, '{video_rentals[i]}','{ids[r.Next(0,ids.Count)]}','{"Ул."+streets[r.Next(0,streets.Length)]+",д."+r.Next(1,100)}'," +
                            $" '{ids1[r.Next(0,ids1.Count)]}','(071) {r.Next(100,1000)}-{r.Next(1000,10000)}', '{r.Next(1000000,10000000)}', '{r.Next(6,13)}', '{r.Next(13,23)}'," +
                            $" '{r.Next(1,100)}', '{ids2[r.Next(0,ids2.Count)]}' ) ; "; break;
                    }
                    command += $" (null, '{video_rentals[i]}','{ids[r.Next(0, ids.Count)]}','{"Ул." + streets[r.Next(0, streets.Length)] + ",д." + r.Next(1, 100)}'," +
                            $" '{ids1[r.Next(0, ids1.Count)]}','(071) {r.Next(100, 1000)}-{r.Next(1000, 10000)}', '{r.Next(1000000, 10000000)}', '{r.Next(6, 13)}', '{r.Next(13, 23)}'," +
                            $" '{r.Next(1, 100)}', '{ids2[r.Next(0, ids2.Count)]}' ) , "; ;
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

            if (table.Equals("owners") || table.Equals("producers"))
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
                if (table.Equals("films")||table.Equals("studios"))
                {
                    if(table.Equals("studios"))
                    {
                        textCommand = $"Select pk_studio_id, studio_name, a.country_name from {table} inner join countries a on studios.fk_studio_country=a.pk_country_id ;";
                    }
                    else
                    {
                        textCommand = $"Select pk_film_id, film_name, film_year from {table} ;";
                    }  
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
                    list.Add(reader.GetString(1)+","+reader.GetInt32(2), reader.GetInt32(0));

                    continue;
                }
                if (table.Equals("cassettes"))
                {
                    list.Add(reader.GetDouble(1).ToString(), reader.GetInt32(0));

                    continue;
                }
                if (table.Equals("studios"))
                {
                    list.Add(reader.GetString(1)+","+reader.GetString(2), reader.GetInt32(0));
                    continue;
                }
                list.Add(reader.GetString(1), reader.GetInt32(0));
            }

            reader.Close();

            n.Close();

            return list;
        }

        public static int getServicePriceID(int video, int service)
        {

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            NpgsqlCommand com = new NpgsqlCommand($"select pk_service_price_id from services_prices where fk_service_id={service} and fk_video_rental={video} ;", n);

            var count = (int)com.ExecuteScalar();

            com.Dispose();

            n.Close();
            
            return count;
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
                            /*command=$"select a.pk_film_id,a.film_name,b.producer_last_name,b.producer_first_name,b.producer_patronymic," +
                            "c.studio_name, d.country_name,a.film_year,a.film_duration,a.film_info from films a " +
                            $"inner join producers b on a.fk_producer_id=b.pk_producer_id " +
                            $"inner join studios c on a.fk_studio_id=c.pk_studio_id " +
                            $"inner join countries d ON c.fk_studio_country = d.pk_country_id;";*/
                            break;
                        }
                    case "cassettes":
                        {
                            command = $"select a.pk_cassette_id,b.quality_name,c.photo,a.cassette_price,a.cassette_demand,d.film_name,d.film_year from cassettes a " +
                                $"inner join {tables[1]} b on a.fk_cassette_quality=b.pk_quality_id " +
                                $"inner join {tables[0]} c on a.fk_cassette_photo= c.pk_photo_id " +
                                $"inner join {tables[6]} d on a.fk_film_id=d.pk_film_id";
                            //command = "select * from cassettes_view;";
                               
                            break;
                        }
                    case "video_rental":
                        {
                            command = "select * from rental_view;";
                            /*command=$"select a.pk_video_rental_id,a.video_caption,b.district_name,a.video_adress," +
                            $"c.property_type_name,a.video_phone,a.license_number,a.time_start,a.time_end," +
                            $"a.amount_of_employees,d.owner_last_name,d.owner_first_name,d.owner_patronymic from video_rental a " +
                            $"inner join district b on a.fk_video_district=b.pk_district_id " +
                            $"inner join property_type c on a.fk_property_type=c.pk_property_type_id " +
                            $"inner join owners d on a.fk_owner_id=d.pk_owner_id ORDER BY pk_video_rental_id ASC;";*/
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
                            //command = "select * from deals_view;";
                            command = $" SELECT a.pk_deal_id,f.video_caption,a.fk_cassete_id,d.film_name,d.film_year,a.recipe_deal," +
                                $"a.deal_date,e.service_name,a.general_price FROM deals a INNER JOIN services_prices b " +
                                $"ON a.fk_service_price = b.pk_service_price_id INNER JOIN cassettes c ON a.fk_cassete_id " +
                                $"= c.pk_cassette_id INNER JOIN films d ON c.fk_film_id = d.pk_film_id " +
                                $"INNER JOIN services e ON b.fk_service_id = e.pk_service_id INNER JOIN video_rental f " +
                                $"ON b.fk_video_rental = f.pk_video_rental_id; ";
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

        public static bool insertOrUpdateIntoDeals(int val,int cassette_id,string recipe, string date,int service_price,double price,int id=0)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                string command = "";

                if (val == 0)
                {
                    command = $"insert into deals values (null,{cassette_id}, '{recipe}', '{date}'::date, {service_price},'{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}');";//СДЕЛАТЬ ТРИГГЕР НА НАПИСАНИЕ КВИТАНЦИИ
                }
                else
                {
                    command = $"update deals set fk_cassete_id = {cassette_id}, recipe_deal = '{recipe}', deal_date = '{date}'::date, fk_service_price = {service_price},general_price = '{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}' where pk_deal_id={id};";//СДЕЛАТЬ ТРИГГЕР НА НАПИСАНИЕ КВИТАНЦИИ
                }

                var com = new NpgsqlCommand(command, n);

                com.ExecuteNonQuery();

                com.Dispose();

                n.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);

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
                    string command = val == 0 ? "Insert into cassette_photo (pk_photo_id,photo) values (null, null ) returning pk_photo_id;" : $"Update cassette_photo set photo=null where pk_photo_id={id} returning pk_photo_id;";

                    com = new NpgsqlCommand(command, n);

                    id1 = (int)com.ExecuteScalar();
                }
                else
                {
                    string command = val == 0 ? "Insert into cassette_photo (pk_photo_id,photo) values (null, @Image ) returning pk_photo_id;" : $"Update cassette_photo set photo=@Image where pk_photo_id={id} returning pk_photo_id;";

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

                NpgsqlCommand com = new NpgsqlCommand($"insert into studios values (null, '{name}', {id_country});", n);

                com.ExecuteNonQuery();

                n.Close();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);

                isCanceledDelete = false;

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

                NpgsqlCommand com = new NpgsqlCommand($"insert into films values (null, '{film_name}', {producer_id}, {studio_id}, {year}, {duration}, '{info}');", n);

                com.ExecuteNonQuery();

                n.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                isCanceledDelete = false;

                return false;
            }
        }

        public static bool insertIntoCassette(int cassette_quality,int? cassette_photo,double price,bool demand,int film_id)
        {
            NpgsqlCommand com= new NpgsqlCommand();
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                if (cassette_photo == 0)
                {
                    int id= insertOrUpdatePhoto("", 0);

                    com = new NpgsqlCommand($"insert into cassettes values (null, '{cassette_quality}', {id}, '{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}', '{demand}', {film_id});", n);
                }
                else
                {
                    com = new NpgsqlCommand($"insert into cassettes values (null, '{cassette_quality}', {cassette_photo}, '{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}', '{demand}', {film_id});", n);
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

        public static bool updateCassette(int id,int cassette_quality, int? cassette_photo, double price, bool demand, int film_id)//ДОДЕЛАТЬ
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                NpgsqlCommand com= new NpgsqlCommand();

                n.Open();

                com = new NpgsqlCommand($"update cassettes set fk_cassette_quality = '{cassette_quality}',cassette_price =  '{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}', cassette_demand = '{demand}',fk_film_id =  {film_id} where pk_cassette_id={id};", n);
                //fk_cassette_photo = {cassette_photo},
                com.ExecuteNonQuery();

                n.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);

                return false;
            }
        }

        public static bool insertIntoServicesPrices(int service_id, int video_rental_id, double price)
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();

                var command = $"insert into services_prices values (null, {service_id}, {video_rental_id}, '{price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}');";

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

                string command = val == 0 ? $"insert into {table}  values (null,'{first}','{last}','{patron}');" :
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

                isCanceledDelete = false;

                return false;
            }
        }

        public static bool insertIntoVideoRental(string video_name,int video_id,string adress,int prop,string phone,string number,string time_s,string time_e,int amount,int owner_id)//Добавление в Video_Rental
        {
            try
            {
                NpgsqlConnection n = new NpgsqlConnection(connectionString);

                n.Open();
                
                var command = $"insert into video_rental values (null,'{video_name}','{video_id}','{adress}','{prop}','{phone}','{number}','{time_s}','{time_e}','{amount}','{owner_id}' );";
               
                NpgsqlCommand com = new NpgsqlCommand(command, n);

                com.ExecuteNonQuery();

                return true;

            }
            catch(Exception e)
            {
                Console.WriteLine(e);

                //MessageBox.Show("Строка не добавлена. Возможно, лицензия или номер телефона не уникальны.");

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
                isCanceledDelete = false;
                return false;
            }
        }

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
                    case "services_view":
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

                    if (table == "cassette_photo")
                    {
                        deletePhoto(id);

                        return true;
                    }

                    return false;
                }
            }

            return false;
        }

        public static bool deletePhoto(int? id)
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

        public static bool deleteByValue(string value, string table, string string_title,string last="",string patron="")//Не дописан
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

                    string command= "";

                    if(table.Equals("producers")|| table.Equals("owners"))
                    {
                        if (table.Equals("producers"))
                        {
                            command = $"delete from {table} where producer_first_name='{value}' and producer_last_name='{last}' and producer_patronymic ='{patron}' ";
                        }
                        if (table.Equals("owners"))
                        {
                            command = $"delete from {table} where owner_first_name='{value}' and owner_last_name='{last}' and owner_patronymic ='{patron}' ";
                        }
                    }
                    else
                    {
                        command = $"delete from {table} where {string_title} = '{value}';";
                    }

                    var command_s = new NpgsqlCommand(command, c);
                    
                    var count = command_s.ExecuteNonQuery();

                    command_s.Dispose();

                    c.Close();

                    if (count >= 1)
                    {
                        MessageBox.Show($"Удалено {count} строк.", "Оповещение");
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

        public static void deleteAllFromTable(string table)
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            var command = new NpgsqlCommand($"delete from {table}", n);

            command.ExecuteNonQuery();

            command.Dispose();

            n.Close();
        }

        //Методы поиска SEARCH

        public static DataTable searchCassettes(string quality,string pr1,string pr2,string demand,string film_name)
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            DataTable dt = new DataTable();

            string com = $"select a.pk_cassette_id,b.quality_name,c.photo,a.cassette_price,a.cassette_demand,d.film_name,d.film_year from cassettes a " +
                                $"inner join {tables[1]} b on a.fk_cassette_quality=b.pk_quality_id " +
                                $"inner join {tables[0]} c on a.fk_cassette_photo= c.pk_photo_id " +
                                $"inner join {tables[6]} d on a.fk_film_id=d.pk_film_id ";

            if (quality != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and b.quality_name ='{quality}' ";
                }
                else
                {
                    com += $" where b.quality_name ='{quality}' ";
                }
            }
            if (pr1 != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and a.cassette_price >='{pr1}' ";
                }
                else
                {
                    com += $" where a.cassette_price >='{pr1}'";
                }
            }
            if (pr2 != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and a.cassette_price <='{pr2}' ";
                }
                else
                {
                    com += $" where a.cassette_price <='{pr2}'";
                }
            }
            if (demand != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and a.cassette_demand ={demand} ";
                }
                else
                {
                    com += $" where a.cassette_demand ={demand} ";
                }
            }
            if (film_name != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and d.pk_film_id ='{film_name}' ";
                }
                else
                {
                    com += $" where d.pk_film_id ='{film_name}' ";
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

        public static DataTable searchDeals(string id_casset,string film,string video,string service,string pr1,string pr2,string date1,string date2,bool one,bool two)
        {
            
            string com = $"SELECT a.pk_deal_id,f.video_caption,a.fk_cassete_id,d.film_name,d.film_year,a.recipe_deal," +
                                $"a.deal_date,e.service_name,a.general_price FROM deals a INNER JOIN services_prices b " +
                                $"ON a.fk_service_price = b.pk_service_price_id INNER JOIN cassettes c ON a.fk_cassete_id " +
                                $"= c.pk_cassette_id INNER JOIN films d ON c.fk_film_id = d.pk_film_id " +
                                $"INNER JOIN services e ON b.fk_service_id = e.pk_service_id INNER JOIN video_rental f " +
                                $"ON b.fk_video_rental = f.pk_video_rental_id ";

            if (id_casset != "")
            {
                com += $" where a.fk_cassete_id ='{id_casset}' ";
            }
            if (film != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and d.pk_film_id ='{film}' ";
                }
                else
                {
                    com += $" where d.pk_film_id ='{film}' ";
                }
            }
            if (video != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and f.video_caption ='{video}' ";
                }
                else
                {
                    com += $" where f.video_caption ='{video}' ";
                }
            }
            if (service != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and e.service_name ='{service}' ";
                }
                else
                {
                    com += $" where e.service_name ='{service}' ";
                }
            }
            if (pr1 != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and a.general_price >='{pr1}' ";
                }
                else
                {
                    com += $" where a.general_price >='{pr1}' ";
                }
            }
            if (pr2 != "")
            {
                if (com.Contains("where"))
                {
                    com += $" and a.general_price <='{pr2}' ";
                }
                else
                {
                    com += $" where a.general_price <='{pr2}' ";
                }
            }

            if (one)
            {
                if (date1 != "")
                {
                    if (com.Contains("where"))
                    {
                        com += $" and a.deal_date >='{date1}'::date ";
                    }
                    else
                    {
                        com += $" where a.deal_date >='{date1}'::date ";
                    }
                }
            }

            if (two)
            {
                if (date2 != "")
                {
                    if (com.Contains("where"))
                    {
                        com += $" and a.deal_date <='{date2}'::date ";
                    }
                    else
                    {
                        com += $" where a.deal_date <='{date2}'::date ";
                    }
                }
            }

            //Запрос симметричное внутреннее соединение с условием по дате
            //Вывести сделки, совершенные после 15.12.2018
            /*com = $"SELECT a.pk_deal_id,f.video_caption,a.fk_cassete_id,d.film_name,d.film_year,a.recipe_deal," +
                                $"a.deal_date,e.service_name,a.general_price FROM deals a INNER JOIN services_prices b " +
                                $"ON a.fk_service_price = b.pk_service_price_id INNER JOIN cassettes c ON a.fk_cassete_id " +
                                $"= c.pk_cassette_id INNER JOIN films d ON c.fk_film_id = d.pk_film_id " +
                                $"INNER JOIN services e ON b.fk_service_id = e.pk_service_id INNER JOIN video_rental f " +
                                $"ON b.fk_video_rental = f.pk_video_rental_id " +
                                $"WHERE a.deal_date >='15.12.2018'::date";*/

            //Запрос симметричное внутреннее соединение с условием по дате
            //Вывести сделки, совершенные после 15.12.2018 и до 01.11.2020
            /*com = $"SELECT a.pk_deal_id,f.video_caption,a.fk_cassete_id,d.film_name,d.film_year,a.recipe_deal," +
                                $"a.deal_date,e.service_name,a.general_price FROM deals a INNER JOIN services_prices b " +
                                $"ON a.fk_service_price = b.pk_service_price_id INNER JOIN cassettes c ON a.fk_cassete_id " +
                                $"= c.pk_cassette_id INNER JOIN films d ON c.fk_film_id = d.pk_film_id " +
                                $"INNER JOIN services e ON b.fk_service_id = e.pk_service_id INNER JOIN video_rental f " +
                                $"ON b.fk_video_rental = f.pk_video_rental_id " +
                                $"WHERE a.deal_date >='15.12.2018'::date and  a.deal_date <='01.11.2020'::date";*/

            //Запрос на запросе по принципу левого соединения
            //Вывод сделок, совершенных видеопрокатом «LostFilm».
            /*com = $"SELECT a.pk_deal_id,f.video_caption,a.fk_cassete_id,d.film_name,d.film_year,a.recipe_deal," +
                                $"a.deal_date,e.service_name,a.general_price FROM deals a " +
                                $"LEFT JOIN services_prices b ON a.fk_service_price = b.pk_service_price_id " +
                                $"LEFT JOIN cassettes c ON a.fk_cassete_id = c.pk_cassette_id " +
                                $"LEFT JOIN films d ON c.fk_film_id = d.pk_film_id " +
                                $"LEFT JOIN services e ON b.fk_service_id = e.pk_service_id " +
                                $"LEFT JOIN video_rental f ON b.fk_video_rental = f.pk_video_rental_id " +
                                $"WHERE f.video_caption = 'LostFilm'";*/

            NpgsqlConnection n = new NpgsqlConnection("Server = localhost; Port = 5432;UserId = postgres; Password =01dr10kv; Database = Video_Rentals; ");

            n.Open();

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

            string com = "select a.pk_film_id,a.film_name,b.producer_last_name,b.producer_first_name,b.producer_patronymic,c.studio_name, d.country_name,a.film_year,a.film_duration,a.film_info from films a " +
                                $"inner join {tables[8]} b on a.fk_producer_id=b.pk_producer_id " +
                                $"inner join {tables[12]} c on a.fk_studio_id=c.pk_studio_id " +
                                $"inner join countries d ON c.fk_studio_country = d.pk_country_id ";
            
            if (film_name != String.Empty)
            {
                com += $" where film_name='{film_name}' ";
            }
            if(studio != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and fk_studio_id ='{studio}' ";
                }
                else
                {
                    com += $" where fk_studio_id ='{studio}' ";
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

            try
            {
                NpgsqlDataReader reader = command_sql.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                command_sql.Dispose();

                reader.Close();

                n.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            

            return dt;
        }

        public static DataTable searchVideoRental(string name,string time_s1, string time_s2, string time_e1, string time_e2,string first,string last,
            string patron,string district,string type_prop,string number,string license,string amount_empl1,string amount_empl2)
        {
            DataTable dt = new DataTable();

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            string com = "select * from rental_view ";

            if (name != String.Empty)
            {
                com += $" where video_caption = '{name}' ";
            }
            /*if (adress != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and video_adress = '{adress}' ";
                }
                else
                {
                    com += $" where video_adress = '{adress}' ";
                }
            }*/
            if (time_s1 != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and time_start >= '{time_s1}' ";
                }
                else
                {
                    com += $" where time_start >= '{time_s1}' ";
                }
            }
            if (time_s2 != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and time_start <= '{time_s2}' ";
                }
                else
                {
                    com += $" where time_start <= '{time_s2}' ";
                }
            }
            if (time_e1 != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and time_end >= '{time_e1}' ";
                }
                else
                {
                    com += $" where time_end >= '{time_e1}' ";
                }
            }
            if (time_e2 != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and time_end <= '{time_e2}' ";
                }
                else
                {
                    com += $" where time_end <= '{time_e2}' ";
                }
            }
            if (first != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and owner_first_name = '{first}' ";
                }
                else
                {
                    com += $" where owner_first_name = '{first}' ";
                }
            }
            if (last != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and owner_last_name = '{last}' ";
                }
                else
                {
                    com += $" where owner_last_name = '{last}' ";
                }
            }
            if (patron != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and owner_patronymic = '{patron}' ";
                }
                else
                {
                    com += $" where owner_patronymic = '{patron}' ";
                }
            }
            
            if (district != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and district_name = '{district}' ";
                }
                else
                {
                    com += $" where district_name = '{district}' ";
                }
            }

            if (type_prop != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and property_type_name = '{type_prop}' ";
                }
                else
                {
                    com += $" where property_type_name = '{type_prop}' ";
                }
            }
            if (number != "(   )    -")
            {
                if (com.Contains("where"))
                {
                    com += $" and video_phone = '{number}' ";
                }
                else
                {
                    com += $" where video_phone = '{number}' ";
                }
            }
            if (license != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and license_number = '{license}' ";
                }
                else
                {
                    com += $" where license_number = '{license}' ";
                }
            }

            if (amount_empl1 != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and amount_of_employees >= '{amount_empl1}' ";
                }
                else
                {
                    com += $" where amount_of_employees >= '{amount_empl1}' ";
                }
            }

            if (amount_empl2 != String.Empty)
            {
                if (com.Contains("where"))
                {
                    com += $" and amount_of_employees <= '{amount_empl2}' ";
                }
                else
                {
                    com += $" where amount_of_employees <= '{amount_empl2}' ";
                }
            }

            //Запрос с отбором по внешнему ключу – вывод видеопрокатов определенного района

            /*com = $" SELECT a.pk_video_rental_id, a.video_caption,b.district_name,a.video_adress," +
                $"c.property_type_name,a.video_phone,a.license_number," +
                $"a.time_start,a.time_end,a.amount_of_employees,d.owner_last_name,d.owner_first_name," +
                $"d.owner_patronymic FROM video_rental a " +
                $"INNER JOIN district b ON a.fk_video_district = b.pk_district_id " +
                $"INNER JOIN property_type c ON a.fk_property_type = c.pk_property_type_id" +
                $"INNER JOIN owners d ON a.fk_owner_id = d.pk_owner_id where fk_video_district ={district};"*/

            //Запрос с отбором по внешнему ключу – вывод видеопрокатов определенного типа собственности

            /*com = $" SELECT a.pk_video_rental_id, a.video_caption,b.district_name,a.video_adress," +
                $"c.property_type_name,a.video_phone,a.license_number," +
                $"a.time_start,a.time_end,a.amount_of_employees,d.owner_last_name,d.owner_first_name," +
                $"d.owner_patronymic FROM video_rental a " +
                $"INNER JOIN district b ON a.fk_video_district = b.pk_district_id " +
                $"INNER JOIN property_type c ON a.fk_property_type = c.pk_property_type_id" +
                $"INNER JOIN owners d ON a.fk_owner_id = d.pk_owner_id where fk_property_type ={type_prop};";*/

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

        public static List<string> district = new List<string>();

        public static List<string> video_rental = new List<string>();

        public static DataTable startQuery(int num)
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            DataTable dt = new DataTable();

            string com = "";

            switch (num)
            {
                case 0:
                    {
                        //Левое внешнее соединение. Вывод фильмов, у которых отсутствует кассета.
                        com = $"select distinct a.pk_film_id,a.film_name,a.film_year,a.film_duration,a.film_info,e.producer_last_name,c.studio_name from films a " +
                              $"inner join producers e on a.fk_producer_id=e.pk_producer_id " +
                              $"inner join studios c on a.fk_studio_id=c.pk_studio_id "+
                              $"LEFT JOIN cassettes b on b.fk_film_id=a.pk_film_id where b.pk_cassette_id IS NULL;";

                        break;
                    }
                case 1:
                    {
                        //Правое внешнее соединение. Вывод фильмов, у которых есть кассета.
                        com = $"select distinct b.pk_film_id,b.film_name,b.film_year,b.film_duration,b.film_info,e.producer_last_name,c.studio_name from cassettes a " +
                              $"RIGHT JOIN films b on a.fk_film_id=b.pk_film_id " +
                              $"inner join producers e on b.fk_producer_id=e.pk_producer_id " +
                              $"inner join studios c on b.fk_studio_id=c.pk_studio_id " +
                              $"where a.pk_cassette_id IS NOT NULL";

                        break;
                    }
                case 2:
                    {
                        //Итоговый запрос без условия. Количество сделок каждого видеопроката
                        com = $"select c.pk_video_rental_id, c.video_caption,count(a.pk_deal_id) from deals a " +
                            $"INNER JOIN services_prices b on a.fk_service_price = b.pk_service_price_id " +
                            $"INNER JOIN video_rental c on b.fk_video_rental = c.pk_video_rental_id group by c.pk_video_rental_id,c.video_caption " +
                            $"ORDER BY count ASC; ";

                        break;
                    }
                case 3:
                    {
                        //Итоговый запрос без условия с итоговыми данными вида: «всего», «в том числе». 
                        //Количество кассет, в том числе кассет превосходного, хорошего, нормального, плохого, ужасного качества.
                        com = $"select count(pk_cassette_id),count(CASE WHEN b.quality_name = 'Превосходное' THEN b.pk_quality_id END), " +
                              $" count(CASE WHEN b.quality_name = 'Хорошее' THEN b.pk_quality_id END) ," +
                              $" count(CASE WHEN b.quality_name = 'Нормальное' THEN b.pk_quality_id END), " +
                              $" count(CASE WHEN b.quality_name = 'Плохое' THEN b.pk_quality_id END), " +
                              $" count(CASE WHEN b.quality_name = 'Ужасное' THEN b.pk_quality_id END) " +
                              $" from cassettes a INNER JOIN cassette_quality b on a.fk_cassette_quality = b.pk_quality_id";
                        break;
                    }
                case 4:
                    {   //Итоговый запрос с условием на группы
                        //Вывод видеопрокатов, среднее всех цен сделок которых превышает 1200
                        com = $"select c.pk_video_rental_id,c.video_caption,d.district_name,c.video_adress,e.property_type_name,avg(a.general_price) from deals a " +
                            $"INNER JOIN services_prices b on a.fk_service_price = b.pk_service_price_id " +
                            $"INNER JOIN video_rental c on b.fk_video_rental = c.pk_video_rental_id " +
                            $"INNER JOIN district d on c.fk_video_district = d.pk_district_id " +
                            $"INNER JOIN property_type e on c.fk_property_type = e.pk_property_type_id " +
                            $"GROUP BY c.pk_video_rental_id,c.video_caption,d.district_name,e.property_type_name " +
                            $"HAVING avg(a.general_price) > 1200";
                        break;
                    }
                case 5:
                    {
                        //Запрос на запросе по принципу итогового запроса
                        //Вывод информации о видеопрокате, который совершил сделку с максимальной ценой.
                        com = $"select c.pk_video_rental_id,c.video_caption,d.district_name,c.video_adress,e.property_type_name, " +
                            $"c.video_phone, c.license_number,a.general_price from deals a " +
                            $"INNER JOIN services_prices b on a.fk_service_price = b.pk_service_price_id " +
                            $"INNER JOIN video_rental c on b.fk_video_rental = c.pk_video_rental_id " +
                            $"INNER JOIN district d on c.fk_video_district = d.pk_district_id " +
                            $"INNER JOIN property_type e on c.fk_property_type = e.pk_property_type_id " +
                            $"WHERE a.general_price = (select max(general_price) from deals) " +
                            $"GROUP BY c.pk_video_rental_id,c.video_caption,d.district_name,e.property_type_name,a.general_price";
                        break;
                    }
                case 6:
                    {
                        //Запрос с использованием объединения
                        //Вывод выручки видеопрокатов со сделок и суммарная выручка видеопрокатов
                        com = $"(select c.pk_video_rental_id,c.video_caption,avg(a.general_price) from deals a " +
                            $"INNER JOIN services_prices b on a.fk_service_price = b.pk_service_price_id " +
                            $"INNER JOIN video_rental c on b.fk_video_rental = c.pk_video_rental_id " +
                            $"GROUP BY c.pk_video_rental_id,c.video_caption " +
                            $"ORDER BY avg(a.general_price) ASC ) " +
                            $"UNION " +
                            $"(SELECT CAST(null AS int) AS pk_video_rental_id, " +
                            $"'Общий заработок' AS video_caption, SUM(general_price) AS avg " +
                            $"from deals GROUP BY pk_video_rental_id, video_caption)";
                        break;
                    }
                case 7:
                    {
                        //Запрос с подзапросом IN
                        //Вывод сделок, кассеты которых не пользовались спросом
                        com = $" SELECT pk_deal_id,cassettes.pk_cassette_id,films.film_name,films.film_year,cassettes.cassette_demand, " +
                            $"deals.recipe_deal,deals.deal_date,deals.general_price from deals " +
                            $"inner join cassettes on cassettes.pk_cassette_id = deals.fk_cassete_id " +
                            $"inner join films on films.pk_film_id = cassettes.fk_film_id " +
                            $"where deals.fk_cassete_id IN(SELECT cassettes.pk_cassette_id from " +
                            $"cassettes where cassettes.cassette_demand = false)";

                        break;
                    }
                case 8:
                    {
                        //Запрос с подзапросом NOT IN
                        //Вывод сделок, кассеты которых пользовались спросом
                        com = $" SELECT pk_deal_id,cassettes.pk_cassette_id,films.film_name,films.film_year,cassettes.cassette_demand, " +
                            $"deals.recipe_deal,deals.deal_date,deals.general_price from deals " +
                            $"inner join cassettes on cassettes.pk_cassette_id = deals.fk_cassete_id " +
                            $"inner join films on films.pk_film_id = cassettes.fk_film_id " +
                            $"where deals.fk_cassete_id NOT IN(SELECT cassettes.pk_cassette_id from " +
                            $"cassettes where cassettes.cassette_demand = false)";

                        break;
                    }
                case 9:
                    {
                        //Запрос с подзапросом CASE
                        //Вывести фильмы кассет, стоимость которых менее 500, иначе в поле «Фильм» вывести «Слишком дорого…!».
                        com = $"SELECT pk_cassette_id, cassette_demand, cassette_quality.quality_name,cassette_photo.photo,cassette_price, " +
                            $"CASE WHEN cassette_price <= 500 then(select film_name from films where pk_film_id = cassettes.fk_film_id ) " +
                            $"else 'Слишком дорого...!' end as film_name " +
                            $"from cassettes " +
                            $"inner join cassette_quality on cassettes.fk_cassette_quality = cassette_quality.pk_quality_id " +
                            $"inner join cassette_photo on cassettes.fk_cassette_photo = cassette_photo.pk_photo_id";
                        break;
                    }
                case 10:
                    {
                        //Запрос с подзапросом с операцией над итоговыми данными
                        //Вывести информацию о кассетах, чьи стоимости ниже средней цены кассеты.
                        com = $"SELECT pk_cassette_id,films.film_name,films.film_year,cassette_demand,cassette_quality.quality_name," +
                              $"cassette_photo.photo,cassettes.cassette_price from cassettes " +
                              $"inner join cassette_quality on cassettes.fk_cassette_quality = cassette_quality.pk_quality_id " +
                              $"inner join cassette_photo on cassettes.fk_cassette_photo = cassette_photo.pk_photo_id " +
                              $"inner join films on films.pk_film_id = fk_film_id " +
                              $"where cassette_price <= (select avg(cassette_price) from cassettes)";
                        break;
                    }
                case 11:
                    {
                        //Спец. запрос 1
                        //Определить процент видеотек, работающих в ночное время по каждому району города и по городу в целом.

                        com = "select district_name from district;";

                        district = new List<string>();

                        var command1 = new NpgsqlCommand(com, n);

                        var reader1 = command1.ExecuteReader();

                        while (reader1.Read())
                        {
                            district.Add(reader1.GetString(0));
                        }
                        reader1.Close();

                        com = "select (count(CASE WHEN a.time_end >= 20 THEN a.time_end END) * 100) / greatest( count(a.pk_video_rental_id),1) ";

                        for(int i = 0; i < district.Count; i++)
                        {
                            com += $",(count(CASE WHEN a.time_end >= 20 and b.district_name = '{district[i]}' THEN a.time_end END) * 100)/ greatest(count(CASE WHEN b.district_name = '{district[i]}' THEN b.pk_district_id END),1) ";
                        }

                        com += "from video_rental a inner join district b on a.fk_video_district = b.pk_district_id";

                        /*com += "select (count(CASE WHEN a.time_end >= 20 THEN a.time_end END) * 100) / " +
                            "greatest( count(a.pk_video_rental_id),1) ,(count(CASE WHEN a.time_end >= 20 and b.district_name = 'Киевский' " +
                            "THEN a.time_end END) * 100)/ greatest(count(CASE WHEN b.district_name = 'Киевский' THEN b.pk_district_id END),1) " +
                            ",(count(CASE WHEN a.time_end >= 20 and b.district_name = 'Пролетарский' THEN a.time_end END) * 100)/ " +
                            "greatest(count(CASE WHEN b.district_name = 'Пролетарский' THEN b.pk_district_id END),1) ," +
                            "(count(CASE WHEN a.time_end >= 20 and b.district_name = 'Ленинский' THEN a.time_end END) * 100)/ " +
                            "greatest(count(CASE WHEN b.district_name = 'Ленинский' THEN b.pk_district_id END),1) ," +
                            "(count(CASE WHEN a.time_end >= 20 and b.district_name = 'Петровский' THEN a.time_end END) * 100)/ " +
                            "greatest(count(CASE WHEN b.district_name = 'Петровский' THEN b.pk_district_id END),1) ," +
                            "(count(CASE WHEN a.time_end >= 20 and b.district_name = 'Куйбышевский' THEN a.time_end END) * 100)/ " +
                            "greatest(count(CASE WHEN b.district_name = 'Куйбышевский' THEN b.pk_district_id END),1) ," +
                            "(count(CASE WHEN a.time_end >= 20 and b.district_name = 'Ворошиловский' THEN a.time_end END) * 100)/ " +
                            "greatest(count(CASE WHEN b.district_name = 'Ворошиловский' THEN b.pk_district_id END),1) ," +
                            "(count(CASE WHEN a.time_end >= 20 and b.district_name = 'Буденновский' THEN a.time_end END) * 100)/ " +
                            "greatest(count(CASE WHEN b.district_name = 'Буденновский' THEN b.pk_district_id END),1) ," +
                            "(count(CASE WHEN a.time_end >= 20 and b.district_name = 'Калининский' THEN a.time_end END) * 100)/ " +
                            "greatest(count(CASE WHEN b.district_name = 'Калининский' THEN b.pk_district_id END),1) ," +
                            "(count(CASE WHEN a.time_end >= 20 and b.district_name = 'Кировский' THEN a.time_end END) * 100)/ " +
                            "greatest(count(CASE WHEN b.district_name = 'Кировский' THEN b.pk_district_id END),1) " +
                            "from video_rental a inner join district b on a.fk_video_district = b.pk_district_id";*/
                        break;
                    }
                case 12:
                    {
                        //Итоговый запрос на данные  группы
                        //Вывод количества сделок видеопрокатов за период 12.10.2016 по 10.12.2020, которые превысили 70
                        com = $"SELECT f.pk_video_rental_id,f.video_caption,count(pk_deal_id)" +
                                $" FROM deals a INNER JOIN services_prices b " +
                                $"ON a.fk_service_price = b.pk_service_price_id " +
                                $"INNER JOIN video_rental f " +
                                $"ON b.fk_video_rental = f.pk_video_rental_id " +
                                $"WHERE a.deal_date >='12.10.2016'::date and  a.deal_date <='10.12.2020'::date  " +
                                $"GROUP BY f.pk_video_rental_id,f.video_caption " +
                                $"HAVING count(pk_deal_id)>= 70";

                        break;
                    }
                case 13:
                    {
                        //Итоговый запрос с условием на данные по значению
                        //Вывод видеопрокатов, у которых количество сделок за все время превышает 400
                        com = $"select c.pk_video_rental_id,c.video_caption,d.district_name,c.video_adress,e.property_type_name,count(pk_video_rental_id) from deals a " +
                            $"INNER JOIN services_prices b on a.fk_service_price = b.pk_service_price_id " +
                            $"INNER JOIN video_rental c on b.fk_video_rental = c.pk_video_rental_id " +
                            $"INNER JOIN district d on c.fk_video_district = d.pk_district_id " +
                            $"INNER JOIN property_type e on c.fk_property_type = e.pk_property_type_id " +
                            $"GROUP BY c.pk_video_rental_id,c.video_caption,d.district_name,e.property_type_name " +
                            $"HAVING count(c.pk_video_rental_id) > 400";

                        break;
                    }
                case 14:
                    {   //Итоговый запрос с условием на данные по маске
                        //Вывод количества сделок видеопрокатов, у которых название начинается с буквы «П»
                        com = "select c.pk_video_rental_id,c.video_caption,d.district_name,c.video_adress,e.property_type_name,count(pk_video_rental_id) " +
                            "from deals a INNER JOIN services_prices b on a.fk_service_price = b.pk_service_price_id " +
                            "INNER JOIN video_rental c on b.fk_video_rental = c.pk_video_rental_id " +
                            "INNER JOIN district d on c.fk_video_district = d.pk_district_id " +
                            "INNER JOIN property_type e on c.fk_property_type = e.pk_property_type_id " +
                            "GROUP BY c.pk_video_rental_id,c.video_caption,d.district_name,e.property_type_name " +
                            "HAVING c.video_caption LIKE 'П%'";
                        break;
                    }
                case 15:
                    {
                        //Итоговый запрос с условием на данные без использования индекса
                        //Вывод видеопрокатов, у которых количество сделок за все время менее 400
                        com = $"select c.pk_video_rental_id,c.video_caption,d.district_name,c.video_adress,e.property_type_name,count(pk_video_rental_id) from deals a " +
                            $"INNER JOIN services_prices b on a.fk_service_price = b.pk_service_price_id " +
                            $"INNER JOIN video_rental c on b.fk_video_rental = c.pk_video_rental_id " +
                            $"INNER JOIN district d on c.fk_video_district = d.pk_district_id " +
                            $"INNER JOIN property_type e on c.fk_property_type = e.pk_property_type_id " +
                            $"GROUP BY c.pk_video_rental_id,c.video_caption,d.district_name,e.property_type_name " +
                            $"HAVING count(c.pk_video_rental_id) < 400";

                        break;
                    }
                case 16:
                    {
                        //Итоговый запрос с условием на данные по маске
                        //Вывод количества сделок видеопрокатов, у которых название начинается не с буквы "П"
                        com = "select c.pk_video_rental_id,c.video_caption,d.district_name,c.video_adress,e.property_type_name,count(pk_video_rental_id) " +
                            "from deals a INNER JOIN services_prices b on a.fk_service_price = b.pk_service_price_id " +
                            "INNER JOIN video_rental c on b.fk_video_rental = c.pk_video_rental_id " +
                            "INNER JOIN district d on c.fk_video_district = d.pk_district_id " +
                            "INNER JOIN property_type e on c.fk_property_type = e.pk_property_type_id " +
                            "GROUP BY c.pk_video_rental_id,c.video_caption,d.district_name,e.property_type_name " +
                            "HAVING c.video_caption NOT LIKE 'П%'";

                        break;
                    }
                case 17:
                    {
                        //Спец.запрос 2
                        twoforms add = new twoforms();
                        
                        add.ShowDialog();
                        com = $"select c.service_name,count(a.pk_deal_id),sum(a.general_price) from deals a " +
                            $"inner join services_prices b on a.fk_service_price = b.pk_service_price_id " +
                            $"inner join services c on b.fk_service_id = c.pk_service_id " +
                            $"where c.service_name = '{add.title.Text}' and a.deal_date BETWEEN '01.01.{add.year.Text}' AND '31.12.{add.year.Text}' " +
                            $"group by service_name ";
                        break;
                    }
                case 18:
                    {
                        //Спец. запрос 2
                        //Определить среднее количество клиентов по заданному району и по городу в целом.
                        AddOrEditOneColumn add = new AddOrEditOneColumn();

                        add.mainL1.Text = "Введите район";

                        add.button1.Text = "Запуск";

                        add.groupBox1.Text = "Район";

                        add.ShowDialog();

                        district1 = add.countryTB.Text;

                        //Ср. кол-во по району это все сделки/кол-во видеопрокатов района
                        com = "select count(a.pk_deal_id) / greatest( (select count(*) from video_rental),1) " +
                            $",count(CASE WHEN  district.district_name='{add.countryTB.Text}'  " +
                            $"THEN a.pk_deal_id END)/ greatest((select count(*) from video_rental " +
                            $"inner join district on district.pk_district_id=video_rental.fk_video_district " +
                            $"where district.district_name='{add.countryTB.Text}'  ),1) " +
                            "from deals a inner join services_prices b on a.fk_service_price=b.pk_service_price_id " +
                            "inner join video_rental c on b.fk_video_rental=c.pk_video_rental_id " +
                            "inner join district on c.fk_video_district=district.pk_district_id";
                        break;
                    }


                
            }


            try
            {
                NpgsqlCommand command = new NpgsqlCommand(com, n);

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
            catch(Exception e)
            { return null; }
            



        }

        public static string district1;

        public static object selectForVideoRental(string whatChoose,string name)
        {

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            NpgsqlCommand com = new NpgsqlCommand($"select {whatChoose} from video_rental where video_caption = '{name}'", n);

            var obj = com.ExecuteScalar();

            com.Dispose();

            n.Close();

            return obj;
        }

        public static object selectDistrictForVideoRental(string name)
        {

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            NpgsqlCommand com = new NpgsqlCommand($"select district.district_name from video_rental  inner join district on video_rental.fk_video_district=district.pk_district_id where video_caption = '{name}'", n);

            var obj = com.ExecuteScalar();

            com.Dispose();

            n.Close();

            return obj;

        }

        public static object selectPropForVideoRental(string name)
        {

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            NpgsqlCommand com = new NpgsqlCommand($"select property_type.property_type_name from video_rental  inner join property_type on video_rental.fk_property_type=property_type.pk_property_type_id where video_caption = '{name}'", n);

            var obj = com.ExecuteScalar();

            com.Dispose();

            n.Close();

            return obj;

        }

        public static object selectOwnerForVideoRental(string name)
        {

            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

            object obj="";

            NpgsqlCommand com = new NpgsqlCommand($"select b.owner_last_name,b.owner_first_name,b.owner_patronymic from video_rental a inner join owners b on a.fk_owner_id=b.pk_owner_id where video_caption = '{name}'", n);

            var reader = com.ExecuteReader();

            while (reader.Read())
            {
                obj = reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2);
            }

            reader.Close();

            com.Dispose();

            n.Close();

            return obj;

        }


        /*public static bool deleteAllFromtable(string table)
        {
            NpgsqlConnection n = new NpgsqlConnection(connectionString);

            n.Open();

        }*/

    }

}
