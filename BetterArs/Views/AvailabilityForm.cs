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
    public partial class AvailabilityForm : Form, IAvailabilityView {
        private readonly BindingSource _flightsBindingSource = new BindingSource();

        public AvailabilityForm() {
            InitializeComponent();
        }

        public Form WFHandle => this;

        public string OriginCode {
            get => _originCodeTextBox.Text;
            set {
                _originCodeTextBox.Text = value;
                _originCodeTextBox.SelectAll();
            }
        }

        public string DestinationCode {
            get => _destinationCodeTextBox.Text;
            set {
                _destinationCodeTextBox.Text = value;
                _destinationCodeTextBox.SelectAll();
            }
        }

        public string OriginAddress {
            get => _originCityTextBox.Text;
            set => _originCityTextBox.Text = value;
        }

        public string DestinationAddress {
            get => _destinationCityTextBox.Text;
            set => _destinationCityTextBox.Text = value;
        }

        public int Persons {
            get {
                int value;

                if (int.TryParse(_personCountTextBox.Text, out value))
                    return value;

                return 0;
            }
            set => _personCountTextBox.Text = value.ToString();
        }

        public DateTime Date {
            get => _departureDatePicker.Value;
            set => _departureDatePicker.Value = value;
        }

        public object FlightsDataSource {
            get => _flightsBindingSource.DataSource;
            set {
                _flightsBindingSource.DataSource = value;

                _flightsGridView.Refresh();
            }
        }

        public event Action SearchButtonPressed;
        public event Action BookButtonPressed;
        public event Action OriginCodeChanged;
        public event Action DestinationCodeChanged;
        public event Action OriginSelectDialogRequested;
        public event Action DestinationSelectDialogRequested;
        public event Action ShowAllButtonPressed;
        public event Action NewFlightButtonPressed;
        public event Action EditFlightButtonPressed;
        public event Action RemoveFlightButtonPressed;
        public event Action ViewPNRTable;

        public int SelectedFlightId {
            get {
                var flight = _flightsBindingSource.Current as FlightView;

                if (flight is null) return 0;

                return flight.Id;
            }
        }

        public bool ShowAllButtonVisible { get => _showAllButton.Visible; set => _showAllButton.Visible = value; }

        public new void Show() {
            Application.Run(this);
        }

        private void _originSelectButton_Click(object sender, EventArgs e) {
            OriginSelectDialogRequested();
        }

        private void _destinationSelectButton_Click(object sender, EventArgs e) {
            DestinationSelectDialogRequested();
        }

        private void _searchButton_Click(object sender, EventArgs e) {
            SearchButtonPressed();
        }

        private void _originCodeTextBox_TextChanged(object sender, EventArgs e) {
            OriginCodeChanged();
        }

        private void _destinationCodeTextBox_TextChanged(object sender, EventArgs e) {
            DestinationCodeChanged();
        }

        private void AvailabilityForm_Load(object sender, EventArgs e) {
            _flightsGridView.AutoGenerateColumns = false;
            _flightsGridView.DataSource = _flightsBindingSource;
        }

        private void _originCodeTextBox_Click(object sender, EventArgs e) {
            _originCodeTextBox.SelectAll();
        }

        private void _destinationCodeTextBox_Click(object sender, EventArgs e) {
            _destinationCodeTextBox.SelectAll();
        }

        private void _bookButton_Click(object sender, EventArgs e) {
            BookButtonPressed();
        }

        private void _showAllButton_Click(object sender, EventArgs e) {
            ShowAllButtonPressed();
        }

        private void _newButton_Click(object sender, EventArgs e) {
            NewFlightButtonPressed();
        }

        private void _editButton_Click(object sender, EventArgs e) {
            EditFlightButtonPressed();
        }

        private void _deleteButton_Click(object sender, EventArgs e) {
            RemoveFlightButtonPressed();
        }

        private void _pnrButton_Click(object sender, EventArgs e) {
            ViewPNRTable();
        }
    }
}
