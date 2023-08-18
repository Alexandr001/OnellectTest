using System.Net.Http.Json;

namespace TestOnellect.Services.Implementation;

public class HttpService : IHttpService
{
	public async Task<int> SendPost<T>(string url, T model)
	{
		HttpClient client = new();
		HttpResponseMessage response = await client.PostAsJsonAsync(url, model);
		return (int) response.StatusCode;
	}
}