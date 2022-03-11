namespace Individual
{
    public partial class ChangeProfile : Form
    {
        public ChangeProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

            openFileDialog.Title = "Select an image";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                new FileInfo(openFileDialog.FileName).CopyTo(Environment.CurrentDirectory + "\\Profile"+openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf(".")),true);
                pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + "\\Profile" + openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf(".")));
            }
        }
    }
}
