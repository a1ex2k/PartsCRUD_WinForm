using Microsoft.EntityFrameworkCore;
using PartsSearcher.Data;
using PartsSearcher.Interfaces;

namespace PartsSearcher.Forms;

public partial class PartDetailsForm : Form
{
	private readonly IRepositoryFactory _repositoryFactory;
	private IRepository<IPart> _repository;
    private readonly IAuthorization _authorization;
    private IPart _part;
    private IPart _partTemp;

  
    public IPart Part
    {
        get => _part;
        set
        {
	        _repository = _repositoryFactory.GetRepositoryFor(value);
			_part = value;
			_partTemp = new Flange();
            _repository.CopyValues(_part, _partTemp);
            propertyGrid.SelectedObject = _partTemp;
            Text = _part.Id == default ? $"{_part.ToString()} - создание" : _part.ToString();
            deleteButton.Enabled = deleteButton.Visible = _part.Id != default && _authorization.CanManageData;
        }
    }

    public PartDetailsForm(IRepositoryFactory repositoryFactory, IAuthorization authorization)
    {
	    _repositoryFactory = repositoryFactory;
	    _authorization = authorization;
	    InitializeComponent();
		saveButton.Enabled = saveButton.Visible = _authorization.CanManageData;
	}


    public async Task SaveAsync()
    {
	    if (_partTemp.Equals(_part)) return;
		_repository.CopyValues(_partTemp, _part);

		if (await _repository.SaveOrUpdateAsync(_part))
		{
			Close();
		}
		else
		{
			MessageBox.Show("Не удалось сохранить деталь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
    }

    public async Task DeleteAsync()
    {
		if (!_partTemp.Equals(_part))
		{
			MessageBox.Show($"Нельзя удалить деталь, так как параметры были изменены", "Удалить?", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			return;
		}

		var result = MessageBox.Show($"Вы уверены, что хотите удалить деталь?\r\n{_partTemp.ToString()}", "Удалить?", MessageBoxButtons.YesNo,
			MessageBoxIcon.Error);
		if (result == DialogResult.No) return;

		if (await _repository.SoftDeleteAsync(_part))
		{
			Close();
		}
		else
		{
			MessageBox.Show("Не удалось удалить деталь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

    private async void saveButton_Click(object sender, EventArgs e)
    {
	    await SaveAsync();
    }

    private async void deleteButton_Click(object sender, EventArgs e)
    {
		await DeleteAsync();
	}

	private void cancelButton_Click(object sender, EventArgs e)
	{
        Close();
	}

}