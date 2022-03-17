using MySql.Data.MySqlClient;

namespace Individual
{
    public class Settings
    {
        private Panel default_panel;
        private Form1 parent;
        private MyProfile profile;

        public Panel DefaultPanel { get => default_panel; }

        public Settings(Form1 form, MyProfile myProfile)
        {
            parent = form;
            profile = myProfile;

            SetDefaultPanel(myProfile.ID);
            LoadDefaultPanel();
        }
        
        private void SetDefaultPanel(int myProfileID)
        {
            string panelName = new Database().GetDefaultPanel(myProfileID);
            foreach (Control control in parent.Controls)
            {
                if (control.Name == panelName && control is Panel)
                {
                    ChangeDefaultPanel(control as Panel);
                    break;
                }
            }
        }

        public void ChangeDefaultPanel(Panel panel)
        {
            default_panel = panel;
        }

        public void LoadDefaultPanel()
        {
            if (default_panel==null)
                return;

            foreach(Control control in parent.Controls)
            {
                if (!control.Name.StartsWith("pn"))//change only pn panels(Library,Store,Profile)
                    continue;

                if (control is Panel && control == default_panel)
                    control.Visible = true;
                else control.Visible = false;
            }
        }

        public void SaveChanges()
        {
            try 
            {
                using (MySqlConnection con = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
                {
                    con.Open();
                    MySqlCommand command = new("UPDATE profiles SET panel=@panel WHERE id=@id", con);
                    command.Parameters.AddWithValue("@panel",default_panel.Name);
                    command.Parameters.AddWithValue("@id",profile.ID);

                    int result = command.ExecuteNonQuery();

                    if (result == 1) MessageBox.Show("Changes saved!");
                    else MessageBox.Show("Changes could not be saved!");
                }
            }
            catch(Exception ex)
            {
                if (ex is AggregateException) MessageBox.Show("No connection to the database");
                else MessageBox.Show("Could not save settings changes." + ex.ToString());
            }
        }
    }
}
