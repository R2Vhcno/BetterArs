using BetterArs.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterArs.Views {
    public partial class AirportSelectorForm : Form {
        private readonly BindingSource _dataBindingSource = new BindingSource();
        private IEnumerable<Airport> _dataSource = null;

        public IEnumerable<Airport> DataSource {
            get => _dataSource;
            set {
                _dataSource = value;

                Search("");

                _dataGrid.Refresh();
            }
        }

        public string SearchColumn { get; set; }

        public string SelectionColumn { get; set; }

        public Airport SelectedValue {
            get => _dataBindingSource.Current as Airport;
        }

        public AirportSelectorForm() {
            InitializeComponent();

            _dataGrid.AutoGenerateColumns = false;
        }

        private void Search(string searchQuery) {
            if (string.IsNullOrEmpty(searchQuery)) {
                _dataBindingSource.DataSource = _dataSource;
                _dataGrid.Refresh();

                return;
            }

            searchQuery = searchQuery.Trim().ToLower();

            var values = from airport in _dataSource
                         where airport.Name.ToLower().StartsWith(searchQuery) ||
                               airport.LocalCode.ToLower().StartsWith(searchQuery) ||
                               airport.City.ToLower().StartsWith(searchQuery) ||
                               airport.IATACode.ToLower().StartsWith(searchQuery)
                         select airport;

            if (values.Count() == 0) {
                MessageBox.Show("По данному поисковому запросу результатов не найдено", "Нет результата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _dataBindingSource.DataSource = values;
            _dataGrid.Refresh();

            if (values.Count() == 1) {
                if (_dataGrid.SelectedCells.Count > 0) {
                    _okButton.PerformClick();
                }
            }
        }

        private void SearchSelectorDialog_Load(object sender, EventArgs e) {
            if (DataSource != null) {
                _dataGrid.DataSource = _dataBindingSource;
            }

            _dataGrid.ClearSelection();
            _okButton.Enabled = false;
        }

        private void _dataGrid_SelectionChanged(object sender, EventArgs e) {
            if (_dataGrid.SelectedCells.Count > 0) {
                _okButton.Enabled = true;
            } else {
                _okButton.Enabled = false;
            }
        }

        private void _searchButton_Click(object sender, EventArgs e) {
            Search(_searchTextBox.Text);
        }

        private void _dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void _searchTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Search(_searchTextBox.Text);

                e.Handled = true;
            }
        }

        private void AirportSelectorForm_Shown(object sender, EventArgs e) {
            _searchTextBox.Focus();
            _okButton.Enabled = false;
        }
    }
}
