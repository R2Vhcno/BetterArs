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
    public partial class EditPlaneForm : Form, IEditPlaneView {
        public string PlaneId {
            get => _planeIdTextBox.Text;
            set => _planeIdTextBox.Text = value;
        }

        public string PlaneName {
            get => _planeNameTextBox.Text;
            set => _planeNameTextBox.Text = value;
        }

        public IEnumerable<PlaneSeat> PlaneSeats {
            get => _planeSeatsBindingSource.DataSource as IEnumerable<PlaneSeat>;
            set {
                _planeSeatsBindingSource.DataSource = value;

                _planeSeatsGridView.Refresh();
            }
        }

        public object Classes {
            get => _planeSeatClassComboBox.DataSource;
            set {
                _planeSeatClassComboBox.DataSource = value;

                _planeSeatClassComboBox.Refresh();
            }
        }

        public PlaneSeat SelectedPlaneSeat => _planeSeatsBindingSource.Current as PlaneSeat;

        public string PlaneSeatId {
            get => _planeSeatIdTextBox.Text;
            set => _planeSeatIdTextBox.Text = value;
        }

        public string PlaneSeatName {
            get => _planeSeatNameTextBox.Text;
            set => _planeSeatNameTextBox.Text = value;
        }

        public int? PlaneSeatClassId {
            get => _planeSeatClassComboBox.SelectedValue as int?;
            set => _planeSeatClassComboBox.SelectedValue = value;
        }

        public string PlaneSeatFare {
            get => _planeSeatFareTextBox.Text;
            set => _planeSeatFareTextBox.Text = value;
        }

        private readonly BindingSource _planeSeatsBindingSource = new BindingSource();
        private readonly BindingSource _classesBindingSource = new BindingSource();

        public EditPlaneForm() {
            InitializeComponent();

            _planeSeatsGridView.AutoGenerateColumns = false;
            _planeSeatsGridView.DataSource = _planeSeatsBindingSource;
        }

        public new void Show() {
            ShowDialog();
        }

        public event Action PlaneSeatAddButtonPressed;
        public event Action PlaneSeatEditButtonPressed;
        public event Action PlaneSeatRemoveButtonPressed;
        public event Action OkButtonPressed;
        public event Action PlaneSeatSelected;

        private void _planeSeatAddButton_Click(object sender, EventArgs e) {
            PlaneSeatAddButtonPressed();
        }

        private void _planeSeatEditButton_Click(object sender, EventArgs e) {
            PlaneSeatEditButtonPressed();
        }

        private void _planeSeatRemoveButton_Click(object sender, EventArgs e) {
            PlaneSeatRemoveButtonPressed();
        }

        private void _okButton_Click(object sender, EventArgs e) {
            OkButtonPressed();
        }

        private void _planeSeatsGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            PlaneSeatSelected();
        }
    }
}
