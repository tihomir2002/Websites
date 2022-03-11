namespace Individual
{
    public class Settings
    {
        private Panel default_panel;
        private Form1 parent;

        public Panel DefaultPanel { get => default_panel; }

        public Settings(Form1 form)
        {
            parent = form;
            //default_panel from db
            LoadDefaultPanel();
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
            //send vars to db
        }
    }
}
