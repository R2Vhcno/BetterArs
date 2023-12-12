using BetterArs.Model;
using BetterArs.Views.Interfaces;
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
    public partial class TicketsTableForm : Form, ITicketsTableView {
        private readonly BindingSource _pnrBindingSource = new BindingSource();
        public TicketsTableForm() {
            InitializeComponent();

            _pnrGridView.AutoGenerateColumns = false;
            _pnrGridView.DataSource = _pnrBindingSource;
        }

        public new void Show() {
            ShowDialog();
        }

        public string PassengerName {
            get => _nameTextBox.Text;
            set => _nameTextBox.Text = value;
        }

        public string PassengerSurname {
            get => _surnameTextBox.Text;
            set => _surnameTextBox.Text = value;
        }
        public string PassengerLastname {
            get => _lastnameTextBox.Text;
            set => _lastnameTextBox.Text = value;
        }

        public IEnumerable<PNRView> PNRs {
            get => throw new NotSupportedException();
            set {
                _pnrBindingSource.DataSource = value;

                _pnrGridView.Refresh();
            }
        }

        public PNRView SelectedPNR {
            get => _pnrBindingSource.Current as PNRView;
            set => throw new NotSupportedException();
        }

        public event Action SearchButtonPressed;
        public event Action EditButtonPressed;
        public event Action DeleteButtonPressed;
        public event Action CleanupButtonPressed;

        private void TicketsTableForm_Load(object sender, EventArgs e) {
            _pnrGridView.Refresh();
        }

        private void _editButton_Click(object sender, EventArgs e) {
            EditButtonPressed();
        }

        private void _deleteButton_Click(object sender, EventArgs e) {
            DeleteButtonPressed();
        }

        private void _intelligentCleaningButton_Click(object sender, EventArgs e) {
            CleanupButtonPressed();
        }

        private void _searchButton_Click(object sender, EventArgs e) {
            SearchButtonPressed();
        }
    }
}
