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
    public partial class PlanesTableForm : Form, IPlanesTableView {
        private readonly BindingSource _planesBindingSource = new BindingSource();

        public PlanesTableForm() {
            InitializeComponent();

            _planesGridView.AutoGenerateColumns = false;
            _planesGridView.DataSource = _planesBindingSource;
        }

        public new void Show() {
            ShowDialog();
        }

        public string PlaneName {
            get => _planeNameTextBox.Text;
            set => _planeNameTextBox.Text = value;
        }
        public IEnumerable<PlaneView> Planes {
            get => _planesBindingSource.DataSource as IEnumerable<PlaneView>;
            set => _planesBindingSource.DataSource = value;
        }

        public PlaneView SelectedPlane => _planesBindingSource.Current as PlaneView;

        public event Action SearchButtonPressed;
        public event Action AddButtonPressed;
        public event Action EditButtonPressed;
        public event Action RemoveButtonPressed;
        public event Action CopyButtonPressed;

        private void _searchButton_Click(object sender, EventArgs e) {
            SearchButtonPressed();
        }

        private void _addPlaneButton_Click(object sender, EventArgs e) {
            AddButtonPressed();
        }

        private void _editPlaneButton_Click(object sender, EventArgs e) {
            EditButtonPressed();
        }

        private void _removePlaneButton_Click(object sender, EventArgs e) {
            RemoveButtonPressed();
        }

        private void _copyPlaneButton_Click(object sender, EventArgs e) {
            CopyButtonPressed();
        }
    }
}
