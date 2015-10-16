namespace _04.DistanceCalculatorRESTClient
{
    using System;
    using RestSharp;

    class DistanceCalculatorRESTClient
    {
        static void Main()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://localhost:10920");

            var request = new RestRequest();
            request.Resource = "api/Points?startX=4&startY=3&endX=10&endY=8";

            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
        }
    }
}
