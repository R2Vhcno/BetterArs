namespace BetterArs.Views {
    partial class PlanesTableForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this._planeNameTextBox = new System.Windows.Forms.TextBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._planesGridView = new System.Windows.Forms.DataGridView();
            this._addPlaneButton = new System.Windows.Forms.Button();
            this._editPlaneButton = new System.Windows.Forms.Button();
            this._removePlaneButton = new System.Windows.Forms.Button();
            this._copyPlaneButton = new System.Windows.Forms.Button();
            this._planeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._planeSeatsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._planesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // _planeNameTextBox
            // 
            this._planeNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._planeNameTextBox.Location = new System.Drawing.Point(104, 14);
            this._planeNameTextBox.Name = "_planeNameTextBox";
            this._planeNameTextBox.Size = new System.Drawing.Size(603, 20);
            this._planeNameTextBox.TabIndex = 1;
            this._planeNameTextBox.Text = "*";
            // 
            // _searchButton
            // 
            this._searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._searchButton.Location = new System.Drawing.Point(713, 12);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(75, 23);
            this._searchButton.TabIndex = 2;
            this._searchButton.Text = "Поиск";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this._searchButton_Click);
            // 
            // _planesGridView
            // 
            this._planesGridView.AllowUserToAddRows = false;
            this._planesGridView.AllowUserToDeleteRows = false;
            this._planesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._planesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._planesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._planeNameColumn,
            this._planeSeatsCountColumn});
            this._planesGridView.Location = new System.Drawing.Point(12, 41);
            this._planesGridView.Name = "_planesGridView";
            this._planesGridView.ReadOnly = true;
            this._planesGridView.Size = new System.Drawing.Size(773, 368);
            this._planesGridView.TabIndex = 3;
            // 
            // _addPlaneButton
            // 
            this._addPlaneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addPlaneButton.Location = new System.Drawing.Point(12, 415);
            this._addPlaneButton.Name = "_addPlaneButton";
            this._addPlaneButton.Size = new System.Drawing.Size(75, 23);
            this._addPlaneButton.TabIndex = 4;
            this._addPlaneButton.Text = "Добавить";
            this._addPlaneButton.UseVisualStyleBackColor = true;
            this._addPlaneButton.Click += new System.EventHandler(this._addPlaneButton_Click);
            // 
            // _editPlaneButton
            // 
            this._editPlaneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._editPlaneButton.Location = new System.Drawing.Point(93, 415);
            this._editPlaneButton.Name = "_editPlaneButton";
            this._editPlaneButton.Size = new System.Drawing.Size(99, 23);
            this._editPlaneButton.TabIndex = 5;
            this._editPlaneButton.Text = "Редактировать";
            this._editPlaneButton.UseVisualStyleBackColor = true;
            this._editPlaneButton.Click += new System.EventHandler(this._editPlaneButton_Click);
            // 
            // _removePlaneButton
            // 
            this._removePlaneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._removePlaneButton.Location = new System.Drawing.Point(198, 415);
            this._removePlaneButton.Name = "_removePlaneButton";
            this._removePlaneButton.Size = new System.Drawing.Size(75, 23);
            this._removePlaneButton.TabIndex = 6;
            this._removePlaneButton.Text = "Удалить";
            this._removePlaneButton.UseVisualStyleBackColor = true;
            this._removePlaneButton.Click += new System.EventHandler(this._removePlaneButton_Click);
            // 
            // _copyPlaneButton
            // 
            this._copyPlaneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._copyPlaneButton.Location = new System.Drawing.Point(279, 415);
            this._copyPlaneButton.Name = "_copyPlaneButton";
            this._copyPlaneButton.Size = new System.Drawing.Size(91, 23);
            this._copyPlaneButton.TabIndex = 7;
            this._copyPlaneButton.Text = "Скопировать";
            this._copyPlaneButton.UseVisualStyleBackColor = true;
            this._copyPlaneButton.Click += new System.EventHandler(this._copyPlaneButton_Click);
            // 
            // _planeNameColumn
            // 
            this._planeNameColumn.DataPropertyName = "Name";
            this._planeNameColumn.HeaderText = "Наименование";
            this._planeNameColumn.Name = "_planeNameColumn";
            this._planeNameColumn.ReadOnly = true;
            // 
            // _planeSeatsCountColumn
            // 
            this._planeSeatsCountColumn.DataPropertyName = "AvailableSeats";
            this._planeSeatsCountColumn.HeaderText = "Кол-во мест";
            this._planeSeatsCountColumn.Name = "_planeSeatsCountColumn";
            this._planeSeatsCountColumn.ReadOnly = true;
            // 
            // PlanesTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._copyPlaneButton);
            this.Controls.Add(this._removePlaneButton);
            this.Controls.Add(this._editPlaneButton);
            this.Controls.Add(this._addPlaneButton);
            this.Controls.Add(this._planesGridView);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this._planeNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "PlanesTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "АИС Авиалиния | Авиапарк";
            ((System.ComponentModel.ISupportInitialize)(this._planesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _planeNameTextBox;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.DataGridView _planesGridView;
        private System.Windows.Forms.Button _addPlaneButton;
        private System.Windows.Forms.Button _editPlaneButton;
        private System.Windows.Forms.Button _removePlaneButton;
        private System.Windows.Forms.Button _copyPlaneButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _planeNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _planeSeatsCountColumn;
    }
}