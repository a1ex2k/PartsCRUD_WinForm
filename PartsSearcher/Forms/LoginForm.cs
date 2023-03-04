using PartsSearcher.Interfaces;

namespace PartsSearcher.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IAuthorization _authorization;

        public LoginForm(IAuthorization authorization)
        {
            _authorization = authorization;
            InitializeComponent();
        }


        private void autologinButton_Click(object sender, EventArgs e)
        {
            _authorization.Login("default_viewer", "default_viewer");
            Close();
		}

        private void loginButton_Click(object sender, EventArgs e)
        {
            var isAuthorized = _authorization.Login(usernameBox.Text, passwordBox.Text);
            if (isAuthorized)
            {
                Close();
                return;
            }

            MessageBox.Show($"Неверные имя пользователя или пароль", "Неудачный вход", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            passwordBox.Text = String.Empty;
            usernameBox.Text = String.Empty;
        }
    }
}
