
namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, bool formatOutput = false, HttpAction action = HttpAction.GET);
        bool IsValidUrl(string url);
    }
}