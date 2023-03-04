using PartsSearcher.Forms;

namespace PartsSearcher.Interfaces;

public interface IFormFactory
{
    MainForm CreateMainForm();
    PartDetailsForm CreatePartDetailsForm();
    LoginForm CreateLoginForm();
}