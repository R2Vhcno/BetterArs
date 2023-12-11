namespace BetterArs.Views {
    partial class AirportSelectorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this._dataGrid = new System.Windows.Forms.DataGridView();
            this._searchTextBox = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._searchButton = new System.Windows.Forms.Button();
            this._dataGridIATACodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridLocalCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridCityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGrid
            // 
            this._dataGrid.AllowUserToAddRows = false;
            this._dataGrid.AllowUserToDeleteRows = false;
            this._dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._dataGridIATACodeColumn,
            this._dataGridLocalCodeColumn,
            this._dataGridNameColumn,
            this._dataGridCityColumn});
            this._dataGrid.Location = new System.Drawing.Point(12, 38);
            this._dataGrid.MultiSelect = false;
            this._dataGrid.Name = "_dataGrid";
            this._dataGrid.ReadOnly = true;
            this._dataGrid.Size = new System.Drawing.Size(517, 276);
            this._dataGrid.TabIndex = 0;
            this._dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGrid_CellDoubleClick);
            this._dataGrid.SelectionChanged += new System.EventHandler(this._dataGrid_SelectionChanged);
            // 
            // _searchTextBox
            // 
            this._searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchTextBox.Location = new System.Drawing.Point(59, 12);
            this._searchTextBox.Name = "_searchTextBox";
            this._searchTextBox.Size = new System.Drawing.Size(389, 20);
            this._searchTextBox.TabIndex = 1;
            this._searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._searchTextBox_KeyDown);
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Enabled = false;
            this._okButton.Location = new System.Drawing.Point(454, 329);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 2;
            this._okButton.Text = "Выбрать";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(373, 329);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 3;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск:";
            // 
            // _searchButton
            // 
            this._searchButton.Location = new System.Drawing.Point(454, 9);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(75, 23);
            this._searchButton.TabIndex = 5;
            this._searchButton.Text = "Найти";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this._searchButton_Click);
            // 
            // _dataGridIATACodeColumn
            // 
            this._dataGridIATACodeColumn.DataPropertyName = "IATACode";
            this._dataGridIATACodeColumn.HeaderText = "Код IATA";
            this._dataGridIATACodeColumn.Name = "_dataGridIATACodeColumn";
            this._dataGridIATACodeColumn.ReadOnly = true;
            // 
            // _dataGridLocalCodeColumn
            // 
            this._dataGridLocalCodeColumn.DataPropertyName = "LocalCode";
            this._dataGridLocalCodeColumn.HeaderText = "Код";
            this._dataGridLocalCodeColumn.Name = "_dataGridLocalCodeColumn";
            this._dataGridLocalCodeColumn.ReadOnly = true;
            // 
            // _dataGridNameColumn
            // 
            this._dataGridNameColumn.DataPropertyName = "Name";
            this._dataGridNameColumn.HeaderText = "Название";
            this._dataGridNameColumn.Name = "_dataGridNameColumn";
            this._dataGridNameColumn.ReadOnly = true;
            // 
            // _dataGridCityColumn
            // 
            this._dataGridCityColumn.DataPropertyName = "City";
            this._dataGridCityColumn.HeaderText = "Город";
            this._dataGridCityColumn.Name = "_dataGridCityColumn";
            this._dataGridCityColumn.ReadOnly = true;
            // 
            // AirportSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 364);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._searchTextBox);
            this.Controls.Add(this._dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AirportSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите аэропорт";
            this.Load += new System.EventHandler(this.SearchSelectorDialog_Load);
            this.Shown += new System.EventHandler(this.AirportSelectorForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGrid;
        private System.Windows.Forms.TextBox _searchTextBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridIATACodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridLocalCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridCityColumn;
    }
}