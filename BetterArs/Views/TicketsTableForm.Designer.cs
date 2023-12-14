namespace BetterArs.Views {
    partial class TicketsTableForm {
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
            this._pnrGridView = new System.Windows.Forms.DataGridView();
            this._originColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._destinationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._departureDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._seatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._contactsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._birthdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._surnameTextBox = new System.Windows.Forms.TextBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._lastnameTextBox = new System.Windows.Forms.TextBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._editButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._intelligentCleaningButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._pnrGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnrGridView
            // 
            this._pnrGridView.AllowUserToAddRows = false;
            this._pnrGridView.AllowUserToDeleteRows = false;
            this._pnrGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnrGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._pnrGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._originColumn,
            this._destinationColumn,
            this._departureDateColumn,
            this._seatColumn,
            this._nameColumn,
            this._contactsColumn,
            this._birthdateColumn});
            this._pnrGridView.Location = new System.Drawing.Point(12, 44);
            this._pnrGridView.MultiSelect = false;
            this._pnrGridView.Name = "_pnrGridView";
            this._pnrGridView.ReadOnly = true;
            this._pnrGridView.Size = new System.Drawing.Size(776, 365);
            this._pnrGridView.TabIndex = 0;
            // 
            // _originColumn
            // 
            this._originColumn.DataPropertyName = "Origin";
            this._originColumn.HeaderText = "Аэропорт отправления";
            this._originColumn.Name = "_originColumn";
            this._originColumn.ReadOnly = true;
            // 
            // _destinationColumn
            // 
            this._destinationColumn.DataPropertyName = "Destination";
            this._destinationColumn.HeaderText = "Аэропорт прибытия";
            this._destinationColumn.Name = "_destinationColumn";
            this._destinationColumn.ReadOnly = true;
            // 
            // _departureDateColumn
            // 
            this._departureDateColumn.DataPropertyName = "Departure_Time";
            this._departureDateColumn.HeaderText = "Врямя отправления";
            this._departureDateColumn.Name = "_departureDateColumn";
            this._departureDateColumn.ReadOnly = true;
            // 
            // _seatColumn
            // 
            this._seatColumn.DataPropertyName = "Seat";
            this._seatColumn.HeaderText = "Место";
            this._seatColumn.Name = "_seatColumn";
            this._seatColumn.ReadOnly = true;
            // 
            // _nameColumn
            // 
            this._nameColumn.DataPropertyName = "Name";
            this._nameColumn.HeaderText = "Пассажир";
            this._nameColumn.Name = "_nameColumn";
            this._nameColumn.ReadOnly = true;
            // 
            // _contactsColumn
            // 
            this._contactsColumn.DataPropertyName = "Contact_Info";
            this._contactsColumn.HeaderText = "Контакты";
            this._contactsColumn.Name = "_contactsColumn";
            this._contactsColumn.ReadOnly = true;
            // 
            // _birthdateColumn
            // 
            this._birthdateColumn.DataPropertyName = "Birth_Date";
            this._birthdateColumn.HeaderText = "Дата рождения";
            this._birthdateColumn.Name = "_birthdateColumn";
            this._birthdateColumn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this._surnameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._nameTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this._lastnameTextBox, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 26);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // _surnameTextBox
            // 
            this._surnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._surnameTextBox.Location = new System.Drawing.Point(68, 3);
            this._surnameTextBox.Name = "_surnameTextBox";
            this._surnameTextBox.Size = new System.Drawing.Size(164, 20);
            this._surnameTextBox.TabIndex = 3;
            this._surnameTextBox.Text = "*";
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameTextBox.Location = new System.Drawing.Point(285, 3);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(164, 20);
            this._nameTextBox.TabIndex = 4;
            this._nameTextBox.Text = "*";
            // 
            // _lastnameTextBox
            // 
            this._lastnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lastnameTextBox.Location = new System.Drawing.Point(527, 3);
            this._lastnameTextBox.Name = "_lastnameTextBox";
            this._lastnameTextBox.Size = new System.Drawing.Size(165, 20);
            this._lastnameTextBox.TabIndex = 5;
            this._lastnameTextBox.Text = "*";
            // 
            // _searchButton
            // 
            this._searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._searchButton.Location = new System.Drawing.Point(713, 13);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(75, 23);
            this._searchButton.TabIndex = 2;
            this._searchButton.Text = "Поиск";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this._searchButton_Click);
            // 
            // _editButton
            // 
            this._editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._editButton.Location = new System.Drawing.Point(12, 415);
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(99, 23);
            this._editButton.TabIndex = 4;
            this._editButton.Text = "Редактировать";
            this._editButton.UseVisualStyleBackColor = true;
            this._editButton.Click += new System.EventHandler(this._editButton_Click);
            // 
            // _deleteButton
            // 
            this._deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._deleteButton.Location = new System.Drawing.Point(117, 415);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(75, 23);
            this._deleteButton.TabIndex = 5;
            this._deleteButton.Text = "Удалить";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this._deleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "|";
            // 
            // _intelligentCleaningButton
            // 
            this._intelligentCleaningButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._intelligentCleaningButton.Enabled = false;
            this._intelligentCleaningButton.Location = new System.Drawing.Point(213, 415);
            this._intelligentCleaningButton.Name = "_intelligentCleaningButton";
            this._intelligentCleaningButton.Size = new System.Drawing.Size(203, 23);
            this._intelligentCleaningButton.TabIndex = 7;
            this._intelligentCleaningButton.Text = "Очистка по выполненным рейсам";
            this._intelligentCleaningButton.UseVisualStyleBackColor = true;
            this._intelligentCleaningButton.Click += new System.EventHandler(this._intelligentCleaningButton_Click);
            // 
            // TicketsTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._intelligentCleaningButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._editButton);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._pnrGridView);
            this.Name = "TicketsTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "АИС Авиалиния | PNR";
            this.Load += new System.EventHandler(this.TicketsTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pnrGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _pnrGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _surnameTextBox;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _lastnameTextBox;
        private System.Windows.Forms.Button _editButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _intelligentCleaningButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _originColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _destinationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _departureDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _seatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _contactsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _birthdateColumn;
    }
}