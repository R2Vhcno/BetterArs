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
    public partial class EditFlightForm : Form, IEditFlightView {
        private readonly BindingSource _planesBindingSource = new BindingSource();

        public EditFlightForm() {
            InitializeComponent();

            _planesGridView.DataSource = _planesBindingSource;
            _planesGridView.AutoGenerateColumns = false;
        }

        public new void Show() {
            ShowDialog();
        }

        public string OriginCode {
            get => _originCodeTextBox.Text;
            set {
                _originCodeTextBox.Text = value;
                _originCodeTextBox.SelectAll();
            }
        }
        public string OriginAddress { get => _originCityTextBox.Text; set => _originCityTextBox.Text = value; }

        public string DestinationCode {
            get => _destinationCodeTextBox.Text;
            set {
                _destinationCodeTextBox.Text = value;
                _destinationCodeTextBox.SelectAll();
            }
        }
        public string DestinationAddress { get => _destinationCityTextBox.Text; set => _destinationCityTextBox.Text = value; }

        public DateTime DepartureTime {
            get {
                DateTime dateTime = _departureDatePicker.Value;

                var time = _departureTimePicker.Text.Split(':');
                int hours = int.Parse(time[0]);
                int minutes = int.Parse(time[1]);

                return dateTime.Add(new TimeSpan(hours, minutes, 0));
            }
            set {
                _departureDatePicker.Value = new DateTime(value.Year, value.Month, value.Day);
                _departureTimePicker.Text = string.Format("{0:D2}:{1:D2}", value.Hour, value.Minute);
            }
        }

        public TimeSpan FlightDuration {
            get {
                var time = _flightDurationPicker.Text.Split(':');
                int hours = int.Parse(time[0]);
                int minutes = int.Parse(time[1]);

                return new TimeSpan(hours, minutes, 0);
            }
            set {
                _flightDurationPicker.Text = string.Format("{0:D2}:{1:D2}", value.Hours, value.Minutes); ;
            }
        }

        public IEnumerable<PlaneView> Planes {
            get => _planesBindingSource.DataSource as IEnumerable<PlaneView>;
            set {
                _planesBindingSource.DataSource = value;

                _planesGridView.Refresh();
            }
        }

        public PlaneView SelectedPlane => _planesBindingSource.Current as PlaneView;

        public string SelectedPlaneInfo {
            get => _planeNameTextBox.Text;
            set => _planeNameTextBox.Text = value;
        }

        public event Action SelectOriginButtonPressed;
        public event Action SelectDestinationButtonPressed;
        public event Action OriginCodeChanged;
        public event Action DestinationCodeChanged;
        public event Action OkButtonPressed;
        public event Action SelectPlaneButtonPressed;

        private void _originCodeTextBox_TextChanged(object sender, EventArgs e) {
            OriginCodeChanged();
        }

        private void _destinationCodeTextBox_TextChanged(object sender, EventArgs e) {
            DestinationCodeChanged();
        }

        private void _originSelectButton_Click(object sender, EventArgs e) {
            SelectOriginButtonPressed();
        }

        private void _destinationSelectButton_Click(object sender, EventArgs e) {
            SelectDestinationButtonPressed();
        }

        private void _originCodeTextBox_Enter(object sender, EventArgs e) {
            _originCodeTextBox.SelectAll();
        }

        private void _destinationCodeTextBox_Enter(object sender, EventArgs e) {
            _destinationCodeTextBox.SelectAll();
        }

        private void _okButton_Click(object sender, EventArgs e) {
            OkButtonPressed();
        }

        private void _selectPlaneButton_Click(object sender, EventArgs e) {
            SelectPlaneButtonPressed();
        }
    }
}
