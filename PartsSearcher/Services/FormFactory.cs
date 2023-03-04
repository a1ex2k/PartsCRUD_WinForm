
using Microsoft.Extensions.DependencyInjection;
using PartsSearcher.Forms;
using PartsSearcher.Interfaces;

namespace PartsSearcher.Services;

public class FormFactory : IFormFactory
{
    private IServiceProvider _serviceProvider;

    public FormFactory(IServiceProvider serviceProvider)
    {
        this._serviceProvider = serviceProvider;
    }

    public MainForm CreateMainForm()
    {
        return _serviceProvider.GetRequiredService<MainForm>();
    }

    public PartDetailsForm CreatePartDetailsForm()
    {
		return _serviceProvider.GetRequiredService<PartDetailsForm>();
	}

    public LoginForm CreateLoginForm()
    {
	    return _serviceProvider.GetRequiredService<LoginForm>();
    }
}


