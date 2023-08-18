namespace TestOnellect.Services;

public interface IHttpService
{
	public Task<int> SendPost<T>(string url, T model);
}