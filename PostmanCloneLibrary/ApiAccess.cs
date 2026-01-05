using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

namespace PostmanCloneLibrary
{
    public class ApiAccess : IApiAccess
    {
        //Initialize an httpclient object
        private readonly HttpClient client = new();

        //Create a method to call an API and Return Json as a string
        public async Task<string> CallApiAsync(
            string url,
            bool formatOutput = false,
            HttpAction action = HttpAction.GET)
        {
            var response = await client.GetAsync(url); // Call the api and assign to response var

            //Check if the call was successful or not,If not return statuscode
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync(); // Raw Json
                if (formatOutput == false)
                {
                    return json; //Return Raw Json
                }

                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json); //Turn the json string into Json Element Object
                json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true }); //Put spaces

                return json; //Return Formated Json

            }
            else
            {
                return $"Error {response.StatusCode}";
            }
        }

        //Validate URL
        public bool IsValidUrl(String url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return false;
            }

            bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) &&
                (uriOutput.Scheme == Uri.UriSchemeHttps);
            return output;
        }

    }
}
