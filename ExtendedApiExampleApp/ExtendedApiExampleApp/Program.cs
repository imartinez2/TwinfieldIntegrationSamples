using ExtendedApiExampleApp;

var options = Options.Parse(args);

//if (options == null)
//	ShowUsage();
//else
	RunDemo();

WaitForUser();

static void ShowUsage() => Console.WriteLine("ExtendedApiExampleApp.exe <accessToken> <clusterUrl> <companyCode>");


static void RunDemo()
{
	try
	{
		var demo = new ApiDemo();
		demo.Run("eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6IjctV24wSGVKYWFka3pMTUN2N2lOVnRNblJ2YyIsImtpZCI6IjctV24wSGVKYWFka3pMTUN2N2lOVnRNblJ2YyJ9.eyJpc3MiOiJodHRwczovL2xvZ2luLnR3aW5maWVsZC5jb20vYXV0aC9hdXRoZW50aWNhdGlvbiIsImF1ZCI6Imh0dHBzOi8vbG9naW4udHdpbmZpZWxkLmNvbS9hdXRoL2F1dGhlbnRpY2F0aW9uL3Jlc291cmNlcyIsImV4cCI6MTc2MTkwNjAzNiwibmJmIjoxNzYxODYyODM2LCJjbGllbnRfaWQiOiJ0ZmFza2FhcGkwMSIsInNjb3BlIjpbInR3Zi5vcmdhbmlzYXRpb25Vc2VyIiwidHdmLm9yZ2FuaXNhdGlvbiJdLCJzdWIiOiJleUpOWlcxaVpYSkpaQ0k2SW1ObVpURmhOVFJqTFdSbE5EQXRORFJsT1MwNU0yRXdMV0l5Wm1Fd01HUTBZV0U0WlNJc0lrOXlaMkZ1YVhOaGRHbHZibFZ6WlhJaU9pSk5VRTBpTENKUGNtZGhibWx6WVhScGIyNURiMlJsSWpvaVFWTkxRU0lzSWs5eVoyRnVhWE5oZEdsdmJrbGtJam9pTkdNMVlUWXlZbUl0WTJJM1l5MDBNRGMwTFdJMlpUY3ROMlUzWW1WaE5qSXdNVEZqSW4wPSIsImF1dGhfdGltZSI6MTc2MTg2MjgzNSwiaWRwIjoiQUFBIiwidHdmLm9yZ2FuaXNhdGlvblVzZXJDb2RlIjoiTVBNIiwidHdmLm9yZ2FuaXNhdGlvbklkIjoiNGM1YTYyYmItY2I3Yy00MDc0LWI2ZTctN2U3YmVhNjIwMTFjIiwidHdmLm9yZ2FuaXNhdGlvbkNvZGUiOiJBU0tBIiwidHdmLmNsdXN0ZXJVcmwiOiJodHRwczovL2FwaS5hY2NvdW50aW5nMi50d2luZmllbGQuY29tIiwiYW1yIjpbImV4dGVybmFsIl19.H3NP0o8Kuf67moZMxqwbYwPNomFK6ANwjOfHI1-WZsWsY_sA6XocHaFtmCFbYzkkml_c8IrpX0RzPrDWrFfsUCHNbrEFvH9H4iANpwMhFMgydukpAaSxUGaderpy_b257a9pDAw3zMJ3O64NHtJw-ut_BIAzXYeRqQkv4Iiwg7XohL1JauxubGR3iavYNUykHAAryoSj-Q9zZXSE6RZhmQLZhNIs32GXTyNTAbVuGTx6Tse1cE739IcyXlWMrzkdQo8lKoIb-Io-Pbiep5HYA9FJUUpIKzMJJANblpmk8EW0_CLB1e-lKlJC5dEbK9NuvWBw2cDjs3U1jGs6Zb8rYQ", "https://api.accounting2.twinfield.com", "200MPM");	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
	}
}


static void RunDemo2(Options options)
{
	try
	{
		var demo = new ApiDemo();
		demo.Run(options.AccessToken, options.ClusterUrl, options.CompanyCode);
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
	}
}

static void WaitForUser()
{
	Console.WriteLine("Press any key to continue");
	Console.ReadKey();
}
