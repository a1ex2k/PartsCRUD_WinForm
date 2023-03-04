using PartsSearcher.Interfaces;

namespace PartsSearcher.Services;

public class Authorization : IAuthorization
{
    public string? Role { get; private set; }
    public string? Username { get; private set; }
    public bool CanManageData { get; private set; }
    public bool IsAuthorized { get; private set; }

    public bool Login(string username, string password)
    {
        if (username == "editor" && password == "eTemo28af7")
        {
            Role = "Редактор";
            Username = username;
            CanManageData = true;
            IsAuthorized = true;
            return true;
        }
        if (username == "default_viewer" && password == "default_viewer")
        {
            Role = "Наблюдатель";
            Username = username;
            CanManageData = false;
            IsAuthorized = true;
            return true;
        }

        return false;
    }

    public void Logout()
    {
        Role = null;
        Username = null;
        CanManageData = false;
        IsAuthorized = false;
    }
}