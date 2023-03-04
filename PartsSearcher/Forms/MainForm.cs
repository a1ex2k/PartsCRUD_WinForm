using System.ComponentModel;
using PartsSearcher.Data;
using PartsSearcher.Interfaces;

namespace PartsSearcher.Forms
{
    public partial class MainForm : Form
    {
        private readonly IFormFactory _formFactory;
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IAuthorization _authorization;
        private IRepository<IPart> _repository;
        private BindingSource _bindingSource;

        public MainForm(IFormFactory formFactory, IRepositoryFactory repositoryFactory, IAuthorization authorization)
        {
            _formFactory = formFactory;
            _repositoryFactory = repositoryFactory;
            _authorization = authorization;
            
            InitializeComponent();
            usernameToolStripMenuItem.Text = _authorization.Username;
            usernameToolStripMenuItem.Enabled = false;
            roleToolStripMenuItem.Text = _authorization.Role;
            roleToolStripMenuItem.Enabled = false;
            addButton.Visible = addButton.Enabled = _authorization.CanManageData;
            
			var bindingList = new BindingList<IPart>();
            _bindingSource = new BindingSource(bindingList, null);
            dataGrid.DataSource = _bindingSource;
        }


		private void flangesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_repository = _repositoryFactory.GetRepository<Flange>();
			propertyGrid.SelectedObject = _repository.SearchModel;
			_bindingSource.DataSource = _repository.LoadedData;
			tablesToolStripMenuItem.Text = "Детали: Фланцы";
			Text = "База деталей - Фланцы";
			emptyLabel.Visible = false;
		}
        

		private async void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			if (e.OldValue == e.ChangedItem.Value) return;
			await _repository.SearchAsync();
			_bindingSource.DataSource = _repository.LoadedData;
			emptyLabel.Visible = _repository.LoadedData.Length == 0;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			flangesToolStripMenuItem_Click(this, null);
		}

		private void dataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            if(dataGrid.SelectedRows.Count == 0) return;

            var part = dataGrid.SelectedRows[0].DataBoundItem as IPart;
            var editor = _formFactory.CreatePartDetailsForm();
            editor.Part = part;
            editor.Show();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var part = _repository.GetNewPart();
			var editor = _formFactory.CreatePartDetailsForm();
			editor.Part = part;
			editor.Show();
		}

		private async void resetButton_Click(object sender, EventArgs e)
		{
			_repository.ResetSearchModel();
			await _repository.LoadAllAsync();
			_bindingSource.DataSource = _repository.LoadedData;
			emptyLabel.Visible = _repository.LoadedData.Length == 0;
			propertyGrid.SelectedObject = _repository.SearchModel;
		}

		private async void loadAllButton_Click(object sender, EventArgs e)
		{
			await _repository.LoadAllAsync();
			_bindingSource.DataSource = _repository.LoadedData;
			emptyLabel.Visible = _repository.LoadedData.Length == 0;
		}
	}
}