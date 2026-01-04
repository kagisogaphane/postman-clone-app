using PostmanCloneLibrary;
namespace PostmanCloneUI
{

    public partial class Dashboard : Form
    {
        //Create an ApiAccess Object
        private readonly ApiAccess api = new();
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

                resultsTextbox.Text = await api.CallApiAsync(apiTextbox.Text);

                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsLabel.Text = "Error: " + ex.Message;
                systemStatus.Text = "Error";

            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
