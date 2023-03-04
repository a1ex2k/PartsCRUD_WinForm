namespace PartsSearcher.Interfaces;

public interface IAuthorization
{
    string Role { get; }
    string Username { get; }
    bool CanManageData { get; }
    bool IsAuthorized { get; }
    bool Login(string username, string password);
    void Logout();

}