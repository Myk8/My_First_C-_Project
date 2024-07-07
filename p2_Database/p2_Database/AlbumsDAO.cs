using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace p2_Database
{
    internal class AlbumsDAO
    {
        
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music;";//Connect to the database

        //PART1 
        public List<Album> getAllAbums() {
        //start with an empty list
        List<Album> returnThese = new List<Album>();

            //connect to the mysql server
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

            //define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("SELECT ID, ALBUM_TITLE,ARTIST, YEAR, IMAGE_NAME,DESCRIPTION from albums", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
             while (reader.Read())
                {
                    Album a = new Album 
                    {
                    ID = reader.GetInt32(0),
                    AlbumName = reader.GetString(1),
                    ArtistName = reader.GetString(2),
                    Year= reader.GetInt32(3),
                    ImageURL = reader.GetString(4),
                    Description = reader.GetString(5)
                    };

                    a.Tracks = getTracksForAlbum(a.ID);

                    returnThese.Add(a);
                }
             
            }
            connection.Close();
            return returnThese;
        }



        //PART 2
        public List<Album> searchTitles(String searchterm)
        {
            //start with an empty list
            List<Album> returnThese = new List<Album>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String searchWildPhrase = "%" + searchterm + "%";

            //define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, ALBUM_TITLE,ARTIST, YEAR, IMAGE_NAME,DESCRIPTION from albums WHERE ALBUM_TITLE LIKE @search";
            
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();
            return returnThese;
        }

        internal int addOneAlbum(Album album)
        {
            //connect to the mysql server
           MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open(); 

            //define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumtitle,@artist,@year,@imageURL,@description)", connection);
            
            command.Parameters.AddWithValue("@albumtitle", album.AlbumName);

            command.Parameters.AddWithValue("@artist", album.ArtistName);

            command.Parameters.AddWithValue("@year", album.Year);

            command.Parameters.AddWithValue("@imageURL", album.ImageURL);

            command.Parameters.AddWithValue("@description", album.Description);
           int newRows= command.ExecuteNonQuery();
            connection.Close() ;

            
            return newRows;
        }
      
        

      

        public List<Track> getTracksForAlbum(int albumID)
        {
            //start with an empty list
            List<Track> returnThese = new List<Track>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM TRACKS WHERE ALBUMS_ID = @albumid";

            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        videoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                        album_ID = albumID  // Set the AlbumID property for each track
                    };
                    returnThese.Add(t);
                }
            }
            connection.Close();
            return returnThese;
        }



        //no need just good to know
        /*     public List<JObject> getTracksUsingJoin(int albumID)
             {
                 //start with an empty list
                 List<JObject> returnThese = new List<JObject>();

                 //connect to the mysql server
                 MySqlConnection connection = new MySqlConnection(connectionString);
                 connection.Open();



                 //define the sql statement to fetch all albums
                 MySqlCommand command = new MySqlCommand();
                 command.CommandText = "SELECT tracks.ID as trackID, albums.ALBUM_TITLE, `track_title`, `video_url`, `lyrics` " +
                                       "FROM `tracks` " +
                                       "JOIN albums ON tracks.albums_ID = albums.ID " +
                                       "WHERE albums.ID = @albumid";

                 command.Parameters.AddWithValue("@albumid", albumID);
                 command.Connection = connection;

                 using (MySqlDataReader reader = command.ExecuteReader())
                 {

                     while (reader.Read())
                     {
                         JObject newTrack = new JObject();
                         for (int i = 0; i < reader.FieldCount; i++)
                         {
                             newTrack.Add(reader.GetName(i).ToString(),
                                 reader.GetValue(i).ToString());
                         }

                         returnThese.Add(newTrack);
                     }
                 }
                 connection.Close();
                 return returnThese;
             }*/

        internal int deleteTrack(int trackID)
        {

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("DELETE FROM `tracks` " +
                "WHERE `ID`=@trackID;", connection);

            command.Parameters.AddWithValue("@trackID", trackID);
          
            int result = command.ExecuteNonQuery();
            connection.Close();


            return result;
        }

        internal int updateAlbum(Album album, int AlbumID)
        {
            MySqlConnection connection = new MySqlConnection( connectionString);
            connection.Open();
            
    MySqlCommand command = new MySqlCommand("UPDATE `albums` SET " +
    "`ALBUM_TITLE`= @albumtitle, `ARTIST`= @artist, `YEAR`= @year," +
    " `IMAGE_NAME`=@imageURL, `DESCRIPTION`= @description " +
    "WHERE `albums`.`ID` = @albumID;", connection);

            command.Parameters.AddWithValue("@albumtitle", album.AlbumName);

            command.Parameters.AddWithValue("@artist", album.ArtistName);

            command.Parameters.AddWithValue("@year", album.Year);

            command.Parameters.AddWithValue("@imageURL", album.ImageURL);

            command.Parameters.AddWithValue("@description", album.Description);

            command.Parameters.AddWithValue("@albumID", AlbumID);

            int updateRows = command.ExecuteNonQuery();
            connection.Close();


            return updateRows;
        }

        //something odd in here
        internal int UpdateTrack(Track newTrack, int updateTrackID)
        {
            int updatedRows = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("UPDATE `tracks` SET " +
                        "`track_title` = @trackTitle, `number` = @trackNumber, " +
                        "`video_url` = @videoURL, `lyrics` = @lyrics, " +
                        "`albums_ID` = @albumID WHERE `ID` = @trackID;", connection);

                    command.Parameters.AddWithValue("@trackTitle", newTrack.Name);
                    command.Parameters.AddWithValue("@trackNumber", newTrack.Number);
                    command.Parameters.AddWithValue("@videoURL", newTrack.videoURL);
                    command.Parameters.AddWithValue("@lyrics", newTrack.Lyrics);
                    command.Parameters.AddWithValue("@albumID", newTrack.album_ID);
                    command.Parameters.AddWithValue("@trackID", updateTrackID);

                    updatedRows = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle the exception (log it, display an error message, etc.)
                    Console.WriteLine("Error updating track: " + ex.Message);
                }
            }

            return updatedRows;
        }

        internal int AddTrack(Track newTrack, int albumID)
        {
            int newRows = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `tracks` " +
                        "(`track_title`, `number`, `video_url`, `lyrics`, `albums_ID`) " +
                        "VALUES (@trackTitle, @trackNumber, @videoURL, @lyrics, @albumID);", connection);

                    command.Parameters.AddWithValue("@trackTitle", newTrack.Name);
                    command.Parameters.AddWithValue("@trackNumber", newTrack.Number);
                    command.Parameters.AddWithValue("@videoURL", newTrack.videoURL);
                    command.Parameters.AddWithValue("@lyrics", newTrack.Lyrics);
                    command.Parameters.AddWithValue("@albumID", albumID);

                    newRows = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle the exception (log it, display an error message, etc.)
                    Console.WriteLine("Error adding track: " + ex.Message);
                }
            }

            return newRows;
        }


    }
}
