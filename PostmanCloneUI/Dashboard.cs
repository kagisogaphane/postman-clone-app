namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void callApiButton_Click(object sender, EventArgs e)
        {
            //Validate the API URL
            try
            {
                systemStatus.Text = "Calling API.......";

                await Task.Delay(3000); // Delay the task by 2s

                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsLabel.Text = "Error: " + ex.Message;
                systemStatus.Text = "Error";
                
            }

        }
    }
}
