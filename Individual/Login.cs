using MySql.Data.MySqlClient;

namespace Individual
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                using (MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
                {
                    try
                    {
                        bool wrongPassword = false;
                        bool wrongName = false;
                        conn.Open();
                        MySqlCommand mySqlCommand = new("SELECT * from profiles", conn);
                        MySqlDataReader dataReader = mySqlCommand.ExecuteReader();

                        while (dataReader.Read())
                        {
                            if (dataReader.GetString(4) == textBox1.Text)
                            {
                                wrongName = false;

                                if (dataReader.GetString(5) == textBox2.Text)
                                {
                                    Bitmap image = null;// dataReader.GetString(3) load frm link
                                    MyProfile myProfile = new(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), image);
                                    wrongPassword = false;
                                    new Form1(this,myProfile).Show();
                                    textBox1.Text = string.Empty;
                                    textBox2.Text = string.Empty;
                                    Hide();
                                    break;
                                }
                                else wrongPassword = true;
                            }
                            else wrongName = true;
                        }

                        if (wrongPassword) MessageBox.Show("Wrong password");
                        else if(wrongName) MessageBox.Show("Username not found");

                        dataReader.Close();
                    }
                    catch (AggregateException) 
                    {
                        MessageBox.Show("You need a VPN connection to login.");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error checking credentials: " + ex.ToString());
                    }
                }
            }
            else MessageBox.Show("Fill all fields");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
