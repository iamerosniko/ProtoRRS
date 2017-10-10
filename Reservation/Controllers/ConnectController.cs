using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Reservation.Controllers
{
    public class ConnectController : ApiController
    {
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        // GET: api/Connect
        public IEnumerable<string> Get()
        {
            List<string> val=new List<string>();
            UserCredential credential;
            try
            {
                using (var stream =
                new FileStream(@"D:\home\site\wwwroot\bin\client_secret.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = @"D:\home\site\wwwroot\bin\";
                    credPath = Path.Combine(credPath, "credentials/sheets.googleapis.com-dotnet-quickstart.json");

                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                    val.Add("Credential file saved to: " + credPath);
                }

                // Create Google Sheets API service.
                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Define request parameters.
                String spreadsheetId = "1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms";
                String range = "Class Data!A2:E";
                SpreadsheetsResource.ValuesResource.GetRequest request =
                        service.Spreadsheets.Values.Get(spreadsheetId, range);

                // Prints the names and majors of students in a sample spreadsheet:
                // https://docs.google.com/spreadsheets/d/1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms/edit
                ValueRange response = request.Execute();
                IList<IList<Object>> values = response.Values;
                if (values != null && values.Count > 0)
                {
                    Console.WriteLine("Name, Major");
                    foreach (var row in values)
                    {
                        // Print columns A and E, which correspond to indices 0 and 4.
                        Console.WriteLine("{0}, {1}", row[0], row[4]);
                        val.Add(row[0].ToString()+" "+ row[4].ToString());
                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                }
                Console.Read();
            }
            catch (Exception ex)
            {
                val.Add(ex.ToString());
                return val;
            }

            return val;
        }

        // GET: api/Connect/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Connect
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Connect/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Connect/5
        public void Delete(int id)
        {
        }
    }
}
