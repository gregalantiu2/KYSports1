using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KYSports1.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using KYSports1.Data;
using KYSports1.Models.ViewModels;

namespace KYSports1
{
    public class Repo
    {
        public GameDetails GetNextGame()
        {
            GameDetails NextGame = new GameDetails();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["KYSports1"].ToString();

                SqlCommand cmd = new SqlCommand("Games.GetNextGame");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader DataReader = cmd.ExecuteReader())
                {
                    while (DataReader.Read())
                    {
                        NextGame.Opponent = DataReader["Opponent"].ToString();
                        NextGame.DayOfWeek = DataReader["DayOfWeek"].ToString();
                        NextGame.GameDate = DateTime.Parse(DataReader["GameDate"].ToString());
                        NextGame.Network = DataReader["Network"].ToString();
                        NextGame.GameLocation = DataReader["GameLocation"].ToString();
                    }
                }
            }
            return NextGame;
        }
        public PlayerQueryString GetPlayerQueryString()
        {
            PlayerNames PlayerName = new PlayerNames();
            PlayerQueryString QueryString = new PlayerQueryString();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["KYSports1"].ToString();

                SqlCommand cmd = new SqlCommand("[Admin].[PlayerQueryStringGet]");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader DataReader = cmd.ExecuteReader())
                {
                    while (DataReader.Read())
                    {
                        PlayerName.FirstName = DataReader["FirstName"].ToString();
                        PlayerName.LastName = DataReader["LastName"].ToString();

                        QueryString.QueryString += PlayerName.FirstName + '-' + PlayerName.LastName + ',';
                    }
                }

                
            }
            return QueryString;
        }
        public void AddPlayertoPage(string firstname,string lastname)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("Admin.AddPlayer", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", firstname);
                command.Parameters.AddWithValue("@LastName", lastname);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public List<PlayerNames> GetAllPlayers()
        {
            List<PlayerNames> players = new List<PlayerNames>();
            

            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("Admin.GetAllPlayers", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using (SqlDataReader datareader = command.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        PlayerNames names = new PlayerNames();
                        names.FirstName = datareader["FirstName"].ToString();
                        names.LastName = datareader["LastName"].ToString();
                        names.Wholename = datareader["FirstName"].ToString() + ' ' + datareader["LastName"].ToString();
                        players.Add(names);
                    }
                    
                }

            }
            return players;
        }
        public List<BingoText> GetBingoText()
        {
            List<BingoText> text = new List<BingoText>();


            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("MiniGames.GetBingoText", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using (SqlDataReader datareader = command.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        BingoText bingo = new BingoText();
                        bingo.CardID = int.Parse(datareader["BingoBoxID"].ToString());
                        bingo.Text = datareader["BingoBoxText"].ToString();
                        text.Add(bingo);
                    }

                }

            }
            return text;
        }
        public void CreateNewArticle(string Author,string ArticleBody,string Title,bool? CarFlg,int CategoryID,string ImageURL)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("Admin.NewArticle", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Author", Author);
                command.Parameters.AddWithValue("@Title", Title);
                command.Parameters.AddWithValue("@ArticleBody", ArticleBody);
                command.Parameters.AddWithValue("@CategoryID", CategoryID);
                command.Parameters.AddWithValue("@ImageURL", ImageURL);
                command.Parameters.AddWithValue("@CarFlg", CarFlg);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public void DeleteArticle(int ArticleID)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("Admin.DeleteArticle", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ArticleID", ArticleID);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public void UpdateArticle(Articles article)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("Admin.UpdateArticle", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ArticleID", article.ArticleID);
                command.Parameters.AddWithValue("@Author", article.Author);
                command.Parameters.AddWithValue("@Title", article.Title);
                command.Parameters.AddWithValue("@ArticleBody", article.ArticleBody);
                command.Parameters.AddWithValue("@CategoryID", article.CategoryID);
                command.Parameters.AddWithValue("@ImageURL", article.ImageURL);
                command.Parameters.AddWithValue("@CarFlg", article.CarFlg);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public Articles GetArticles()
        {
            Articles article = new Articles();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["KYSports1"].ToString();

                SqlCommand cmd = new SqlCommand("Admin.GetArticle");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader DataReader = cmd.ExecuteReader())
                {
                    while (DataReader.Read())
                    {
                        article.ArticleID = int.Parse(DataReader["ArticleID"].ToString());
                        article.Title = DataReader["Title"].ToString();
                        article.Author = DataReader["Author"].ToString();
                        article.Published = DateTime.Parse(DataReader["PublishedDate"].ToString());
                        article.ArticleBody = DataReader["ArticleBody"].ToString();
                        article.CategoryID = int.Parse(DataReader["CategoryID"].ToString());
                        article.ImageURL = DataReader["ImageURL"].ToString();
                        article.CarFlg = bool.Parse(DataReader["CarFlg"].ToString());
                    }
                }
            }
            return article;
        }
        public Articles GetArticlesByID(int id)
        {
            Articles article = new Articles();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["KYSports1"].ToString();

                SqlCommand cmd = new SqlCommand("admin.GetArticleByID");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                using (SqlDataReader DataReader = cmd.ExecuteReader())
                {
                    while (DataReader.Read())
                    {
                        article.ArticleID = int.Parse(DataReader["ArticleID"].ToString());
                        article.Title = DataReader["Title"].ToString();
                        article.Author = DataReader["Author"].ToString();
                        article.Published = DateTime.Parse(DataReader["PublishedDate"].ToString());
                        article.ArticleBody = DataReader["ArticleBody"].ToString();
                        article.CategoryID = int.Parse(DataReader["CategoryID"].ToString());
                        article.ImageURL = DataReader["ImageURL"].ToString();
                        article.CarFlg = bool.Parse(DataReader["CarFlg"].ToString());
                    }
                }
            }
            return article;
        }
        public List<Articles> GetAllArticles()
        {
            List<Articles> articles = new List<Articles>();

            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("Admin.GetAllArticles", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using (SqlDataReader datareader = command.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        Articles single = new Articles();
                        single.ArticleID = int.Parse(datareader["ArticleID"].ToString());
                        single.Author = datareader["Author"].ToString();
                        single.Published = DateTime.Parse(datareader["PublishedDate"].ToString());
                        single.Title = datareader["Title"].ToString();
                        single.CarFlg = bool.Parse(datareader["CarFlg"].ToString());
                        single.ArticleBody = datareader["ArticleBody"].ToString();
                        single.CategoryID = int.Parse(datareader["CategoryID"].ToString());
                        single.ImageURL = datareader["ImageURL"].ToString();
                        single.Category = datareader["Category"].ToString();
                        articles.Add(single);
                    }

                }

            }
            return articles;
        }
        public List<Articles> GetCarouselArticles()
        {
            List<Articles> articles = new List<Articles>();

            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand("Homepage.GetCarouselArticles", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using (SqlDataReader datareader = command.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        Articles single = new Articles();
                        single.ArticleID = int.Parse(datareader["ArticleID"].ToString());
                        single.Author = datareader["Author"].ToString();
                        single.Published = DateTime.Parse(datareader["PublishedDate"].ToString());
                        single.Title = datareader["Title"].ToString();
                        single.CarFlg = bool.Parse(datareader["CarFlg"].ToString());
                        single.ArticleBody = datareader["ArticleBody"].ToString();
                        single.CategoryID = int.Parse(datareader["CategoryID"].ToString());
                        single.ImageURL = datareader["ImageURL"].ToString();
                        single.Category = datareader["Category"].ToString();
                        articles.Add(single);
                    }

                }

            }
            return articles;
        }
    }
}