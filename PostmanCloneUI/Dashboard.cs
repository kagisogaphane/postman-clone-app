using PostmanCloneLibrary;
namespace PostmanCloneUI
{

    public partial class Dashboard : Form
    {
        private readonly IApiAccess api = new ApiAccess();
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void callApiButton_Click(object sender, EventArgs e)
        {
            systemStatus.Text = "Calling API.......";
            resultsTextbox.Text = string.Empty;

            //Validate the API URL
            if (api.IsValidUrl(apiTextbox.Text) == false)
            {
                systemStatus.Text = "Invalid URL";
                return;
            }
            try
            {
               

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

        // Call Formated Json
        private async void btnFormatJson_Click(object sender, EventArgs e)
        {
            resultsTextbox.Text = await api.CallApiAsync(apiTextbox.Text, true);
        }
    }
}
