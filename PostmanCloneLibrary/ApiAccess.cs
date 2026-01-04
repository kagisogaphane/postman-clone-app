using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PostmanCloneLibrary
{
    public class ApiAccess
    {
        //Initialize an httpclient object
        private readonly HttpClient client = new();

        //Create a method to call an API and Return Json as a string
        public async Task<string> CallApiAsync (string url)
        {
            var response = await client.GetAsync(url); // Call the api and asign to response var

            //Check if the call was successful or not,If not return statuscode
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return json;
            }
            else
            {
                return $"Error {response.StatusCode}";
            }
        }

    }
}
