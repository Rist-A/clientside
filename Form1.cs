namespace clientside
{
    public partial class getstart : Form
    {
        public getstart()
        {
            InitializeComponent();
        }

        private void getbtn_Click(object sender, EventArgs e)
        {
            loginsignup nextform =new loginsignup();
            nextform.ShowDialog();
        }
    }
}
