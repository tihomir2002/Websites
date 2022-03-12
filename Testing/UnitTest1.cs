using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        MySqlConnection con = 
            new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;");

        //[TestMethod]
        public void Connect()
        {
            con.Open();
            Assert.IsTrue(con.Ping());
            con.Close();
        }

        //[TestMethod]
        public void InsertData()
        {
            string value1 = "Ime2";
            int value2 = 14;
            string value3 = "Country2";
            MySqlCommand cmd = new(
                "INSERT INTO city(name,population,country)" +
                " VALUES(@name,@population,@country)", con);

            con.Open();
            cmd.Parameters.AddWithValue("@name", value1);
            cmd.Parameters.AddWithValue("@population", value2);
            cmd.Parameters.AddWithValue("@country", value3);

            int effectedRows = cmd.ExecuteNonQuery();
            con.Close();

            Assert.AreEqual(1, effectedRows);
        }

        //[TestMethod]
        public void GetData()
        {
            con.Open();
            MySqlCommand mySqlCommand = new("SELECT name,population,country FROM city", con);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                System.Console.WriteLine(
                    mySqlDataReader.GetString(0) + mySqlDataReader[1].ToString() + mySqlDataReader[2].ToString());
            }
            
            Assert.AreEqual(3, mySqlDataReader.FieldCount);
            mySqlDataReader.Close();
            con.Close();
        }
    }
}