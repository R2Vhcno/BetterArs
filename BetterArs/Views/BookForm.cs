using BetterArs.Model;
using BetterArs.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterArs.Views {
    public partial class BookForm : Form, IBookView {
        private readonly BindingSource _seatsBindingSource = new BindingSource();

        public BookForm() {
            InitializeComponent();

            _seatsDataGridView.AutoGenerateColumns = false;
            _seatsDataGridView.DataSource = _seatsBindingSource;
        }

        public event Action OnPassengerIdChanged;
        public event Action OnSeatClassChanged;
        public event Action OnSeatSelected;
        public event Action OnCancelPressed;
        public event Action OnBookAndContinuePressed;
        public event Action OnBookPressed;

        public new void Show() {
            ShowDialog();
        }

        public int FLightId {
            set => _flightIdTextBox.Text = value.ToString();
        }

        public string OriginName {
            set => _originNameLabel.Text = value;
        }

        public string DestinationName {
            set => _destinationNameLabel.Text = value;
        }

        public int PassengerId { get; set; } = 0;

        public string PassengerSurname {
            get => _passengerSurnameTextBox.Text;
            set => _passengerSurnameTextBox.Text = value;
        }

        public string PassengerName {
            get => _passengerNameTextBox.Text;
            set => _passengerNameTextBox.Text = value;
        }

        public string PassengerLastName {
            get => _passengerLastNameTextBox.Text;
            set => _passengerLastNameTextBox.Text = value;
        }

        public string PassengerPhone {
            get => _passengerPhoneTextBox.Text;
            set => _passengerPhoneTextBox.Text = value;
        }

        public string PassengerEmail {
            get => _passengerEmailTextBox.Text;
            set => _passengerEmailTextBox.Text = value;
        }

        public int SeatClass => (int)_seatsClassesComboBox.SelectedValue;

        public int SeatId {
            get {
                var seat = _seatsBindingSource.Current as PlaneSeat;

                if (seat is null) return 0;

                return seat.Id;
            }
        }

        public object SeatsDataSource {
            get => _seatsDataGridView.DataSource;
            set {
                _seatsBindingSource.DataSource = value;

                _seatsDataGridView.Refresh();
            }
        }
        public object SeatsClassesDataSource {
            get => _seatsClassesComboBox.DataSource;
            set {
                _seatsClassesComboBox.DataSource = value;

                _seatsClassesComboBox.Refresh();
            }
        }

        public bool PNRFromDataBase {
            get => _infoFromDbRadioButton.Checked;
            set {
                _infoFromDbRadioButton.Checked = value;
                _newRecordRadioButton.Checked = !value;
            }
        }

        private void _passengerIdTextBox_Validating(object sender, CancelEventArgs e) {

            if (int.TryParse(_passengerIdTextBox.Text, out int value)) {
                if (value > 0) {
                    PassengerId = value;

                    return;
                } else {
                    MessageBox.Show("Ид не может быть меньше единицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Неверный формат записи идентификатора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            e.Cancel = true;

            _passengerIdTextBox.Text = PassengerId.ToString();
            _passengerIdTextBox.SelectAll();
        }

        private void _infoFromDbRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (_infoFromDbRadioButton.Checked) {
                _passengerIdTextBox.Enabled = true;

                _passengerIdTextBox.Focus();
                _passengerIdTextBox.SelectAll();
            } else {
                _passengerIdTextBox.Enabled = false;
            }
        }

        private void _newRecordRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (_newRecordRadioButton.Checked) {
                _passengerSurnameTextBox.Enabled = true;
                _passengerNameTextBox.Enabled = true;
                _passengerLastNameTextBox.Enabled = true;
                _passengerPhoneTextBox.Enabled = true;
                _passengerEmailTextBox.Enabled = true;
            } else {
                _passengerSurnameTextBox.Enabled = false;
                _passengerNameTextBox.Enabled = false;
                _passengerLastNameTextBox.Enabled = false;
                _passengerPhoneTextBox.Enabled = false;
                _passengerEmailTextBox.Enabled = false;
            }
        }

        private void _passengerEmailTextBox_Validating(object sender, CancelEventArgs e) {
            Regex regex = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");

            if (_passengerEmailTextBox.Text.Length == 0) return;

            bool isValid = regex.IsMatch(_passengerEmailTextBox.Text);

            if (!isValid) {
                MessageBox.Show("Неверный формат записи электронной почты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _passengerEmailTextBox.SelectAll();

                e.Cancel = true;
            }
        }

        private void _passengerIdTextBox_Validated(object sender, EventArgs e) {
            OnPassengerIdChanged();
        }

        private void _cancelButton_Click(object sender, EventArgs e) {
            OnCancelPressed();
        }

        private void _bookAndContinueButton_Click(object sender, EventArgs e) {
            OnBookAndContinuePressed();
        }

        private void _bookButton_Click(object sender, EventArgs e) {
            OnBookPressed();
        }

        private void _passengerPhoneTextBox_Validating(object sender, CancelEventArgs e) {
            Regex regex = new Regex("^\\+?[1-9][0-9]{7,14}$");

            if (_passengerPhoneTextBox.Text.Length == 0) return;

            bool isValid = regex.IsMatch(_passengerPhoneTextBox.Text);

            if (!isValid) {
                MessageBox.Show("Неверный формат записи номера телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _passengerPhoneTextBox.SelectAll();

                e.Cancel = true;
            }
        }

        private void _seatsClassesComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            OnSeatClassChanged();
        }

        public void SetPassengerId(int id) {
            _passengerIdTextBox.Text = id.ToString();
        }
    }
}
