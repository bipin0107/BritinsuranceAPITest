using RestSharp;
using Newtonsoft.Json;
using BritinsuranceAPI.Models;
using BritinsuranceAPI.Tests;
using System;

using static BritinsuranceAPI.Models.PatchObjectRequest;

namespace BritinsuranceAPI.Utlities
{
    public class ApiClient
    {
        public static void Main(string[] args)
        {
            // Initialize the client

            var objectId = 7;

            // Initialize the client
            var client = ApiTests.GetClient();

            // Create request with dynamic ID
            var request = new RestRequest($"objects/{objectId}", Method.Patch);
            var updateObject = new UpdateObjectRequest { Name = "Apple MacBook Pro 16 (Updated Name)" };
            request.AddJsonBody(updateObject);
            // Execute request
            var response = client.Execute(request);

            // Validate response
            if (response.IsSuccessful)
            {
                Console.WriteLine("PATCH request successful.");
                Console.WriteLine("Response Content: " + response.Content);

                // Deserialize response content
                try
                {
                    // Deserialize response content
                    var updatedObject = JsonConvert.DeserializeObject<UpdateObjectRequest>(response.Content);

                    // Verify updated name
                    if (updatedObject.Name == updateObject.Name)
                    {
                        Console.WriteLine("Update verified.");
                    }
                    else
                    {
                        Console.WriteLine("Update verification failed.");
                    }
                }
                catch (JsonException jsonEx)
                {
                    Console.WriteLine("Error deserializing response content: " + jsonEx.Message);
                }
            }
            else
            {
                Console.WriteLine("PATCH request failed with status: " + response.StatusCode);
                Console.WriteLine("Error Message: " + response.ErrorMessage);
                Console.WriteLine("Response Content: " + response.Content);
            }
        }
    }
}
