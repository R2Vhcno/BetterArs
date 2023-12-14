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
    public partial class EditPNRForm : Form, IEditPNRView {
        public EditPNRForm() {
            InitializeComponent();
        }

        public new void Show() {
            ShowDialog();
        }

        public string SurName {
            get => _passengerSurnameTextBox.Text;
            set => _passengerSurnameTextBox.Text = value;
        }

        public string FirstName {
            get => _passengerNameTextBox.Text;
            set => _passengerNameTextBox.Text = value;
        }

        public string LastName {
            get => _passengerLastNameTextBox.Text;
            set => _passengerLastNameTextBox.Text = value;
        }
        public string Phone {
            get => _passengerPhoneTextBox.Text;
            set => _passengerPhoneTextBox.Text = value;
        }
        public string Email {
            get => _passengerEmailTextBox.Text;
            set => _passengerEmailTextBox.Text = value;
        }
        public bool IsInvoicePaid {
            get => !_unpaidInvoiceLabel.Visible;
            set {
                _unpaidInvoiceLabel.Visible = !value;
                _payInvoiceButton.Visible = !value;
            }
        }

        public DateTime BirthDate {
            get => _birthDatePicker.Value;
            set => _birthDatePicker.Value = value;
        }

        public event Action PayInvoiceButtonPressed;
        public event Action OkButtonPressed;

        private void _payInvoiceButton_Click(object sender, EventArgs e) {
            PayInvoiceButtonPressed();
        }

        private void _okButton_Click(object sender, EventArgs e) {
            OkButtonPressed();
        }
    }
}
