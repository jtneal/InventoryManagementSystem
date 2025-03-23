namespace JasonNealC968
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inventoryManagementSystemLabel = new Label();
            partsSearchButton = new Button();
            partsSearchTextBox = new TextBox();
            partsLabel = new Label();
            partsDeleteButton = new Button();
            partsModifyButton = new Button();
            partsAddButton = new Button();
            partsDataGridView = new DataGridView();
            productsDataGridView = new DataGridView();
            productsLabel = new Label();
            productsSearchTextBox = new TextBox();
            productsAddButton = new Button();
            productsModifyButton = new Button();
            productsDeleteButton = new Button();
            productsSearchButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // inventoryManagementSystemLabel
            // 
            inventoryManagementSystemLabel.AutoSize = true;
            inventoryManagementSystemLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryManagementSystemLabel.Location = new Point(12, 12);
            inventoryManagementSystemLabel.Name = "inventoryManagementSystemLabel";
            inventoryManagementSystemLabel.Size = new Size(301, 30);
            inventoryManagementSystemLabel.TabIndex = 0;
            inventoryManagementSystemLabel.Text = "Inventory Management System";
            // 
            // partsSearchButton
            // 
            partsSearchButton.BackColor = Color.LightGray;
            partsSearchButton.FlatStyle = FlatStyle.Flat;
            partsSearchButton.Font = new Font("Segoe UI", 10F);
            partsSearchButton.Location = new Point(283, 64);
            partsSearchButton.Name = "partsSearchButton";
            partsSearchButton.Size = new Size(71, 29);
            partsSearchButton.TabIndex = 1;
            partsSearchButton.Text = "Search";
            partsSearchButton.UseVisualStyleBackColor = false;
            partsSearchButton.Click += PartsSearchButton_Click;
            // 
            // partsSearchTextBox
            // 
            partsSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            partsSearchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partsSearchTextBox.Location = new Point(366, 64);
            partsSearchTextBox.Name = "partsSearchTextBox";
            partsSearchTextBox.Size = new Size(256, 29);
            partsSearchTextBox.TabIndex = 2;
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partsLabel.Location = new Point(15, 76);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(44, 21);
            partsLabel.TabIndex = 3;
            partsLabel.Text = "Parts";
            // 
            // partsDeleteButton
            // 
            partsDeleteButton.BackColor = Color.LightGray;
            partsDeleteButton.FlatStyle = FlatStyle.Flat;
            partsDeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partsDeleteButton.Location = new Point(552, 339);
            partsDeleteButton.Name = "partsDeleteButton";
            partsDeleteButton.Size = new Size(71, 36);
            partsDeleteButton.TabIndex = 1;
            partsDeleteButton.Text = "Delete";
            partsDeleteButton.UseVisualStyleBackColor = false;
            partsDeleteButton.Click += PartsDeleteButton_Click;
            // 
            // partsModifyButton
            // 
            partsModifyButton.BackColor = Color.LightGray;
            partsModifyButton.FlatStyle = FlatStyle.Flat;
            partsModifyButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partsModifyButton.Location = new Point(469, 339);
            partsModifyButton.Name = "partsModifyButton";
            partsModifyButton.Size = new Size(71, 36);
            partsModifyButton.TabIndex = 1;
            partsModifyButton.Text = "Modify";
            partsModifyButton.UseVisualStyleBackColor = false;
            partsModifyButton.Click += PartsModifyButton_Click;
            // 
            // partsAddButton
            // 
            partsAddButton.BackColor = Color.LightGray;
            partsAddButton.FlatStyle = FlatStyle.Flat;
            partsAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partsAddButton.Location = new Point(386, 339);
            partsAddButton.Name = "partsAddButton";
            partsAddButton.Size = new Size(71, 36);
            partsAddButton.TabIndex = 1;
            partsAddButton.Text = "Add";
            partsAddButton.UseVisualStyleBackColor = false;
            partsAddButton.Click += PartsAddButton_Click;
            // 
            // partsDataGridView
            // 
            partsDataGridView.AllowUserToAddRows = false;
            partsDataGridView.AllowUserToDeleteRows = false;
            partsDataGridView.AllowUserToResizeColumns = false;
            partsDataGridView.AllowUserToResizeRows = false;
            partsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsDataGridView.Location = new Point(20, 105);
            partsDataGridView.MultiSelect = false;
            partsDataGridView.Name = "partsDataGridView";
            partsDataGridView.ReadOnly = true;
            partsDataGridView.RowHeadersVisible = false;
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsDataGridView.ShowEditingIcon = false;
            partsDataGridView.Size = new Size(603, 222);
            partsDataGridView.TabIndex = 4;
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToDeleteRows = false;
            productsDataGridView.AllowUserToResizeColumns = false;
            productsDataGridView.AllowUserToResizeRows = false;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Location = new Point(660, 105);
            productsDataGridView.MultiSelect = false;
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.ReadOnly = true;
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.ShowEditingIcon = false;
            productsDataGridView.Size = new Size(603, 222);
            productsDataGridView.TabIndex = 11;
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productsLabel.Location = new Point(655, 76);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(71, 21);
            productsLabel.TabIndex = 10;
            productsLabel.Text = "Products";
            // 
            // productsSearchTextBox
            // 
            productsSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            productsSearchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productsSearchTextBox.Location = new Point(1007, 64);
            productsSearchTextBox.Name = "productsSearchTextBox";
            productsSearchTextBox.Size = new Size(256, 29);
            productsSearchTextBox.TabIndex = 9;
            // 
            // productsAddButton
            // 
            productsAddButton.BackColor = Color.LightGray;
            productsAddButton.FlatStyle = FlatStyle.Flat;
            productsAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productsAddButton.Location = new Point(1026, 339);
            productsAddButton.Name = "productsAddButton";
            productsAddButton.Size = new Size(71, 36);
            productsAddButton.TabIndex = 5;
            productsAddButton.Text = "Add";
            productsAddButton.UseVisualStyleBackColor = false;
            productsAddButton.Click += ProductsAddButton_Click;
            // 
            // productsModifyButton
            // 
            productsModifyButton.BackColor = Color.LightGray;
            productsModifyButton.FlatStyle = FlatStyle.Flat;
            productsModifyButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productsModifyButton.Location = new Point(1109, 339);
            productsModifyButton.Name = "productsModifyButton";
            productsModifyButton.Size = new Size(71, 36);
            productsModifyButton.TabIndex = 6;
            productsModifyButton.Text = "Modify";
            productsModifyButton.UseVisualStyleBackColor = false;
            productsModifyButton.Click += ProductsModifyButton_Click;
            // 
            // productsDeleteButton
            // 
            productsDeleteButton.BackColor = Color.LightGray;
            productsDeleteButton.FlatStyle = FlatStyle.Flat;
            productsDeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productsDeleteButton.Location = new Point(1192, 339);
            productsDeleteButton.Name = "productsDeleteButton";
            productsDeleteButton.Size = new Size(71, 36);
            productsDeleteButton.TabIndex = 7;
            productsDeleteButton.Text = "Delete";
            productsDeleteButton.UseVisualStyleBackColor = false;
            productsDeleteButton.Click += ProductsDeleteButton_Click;
            // 
            // productsSearchButton
            // 
            productsSearchButton.BackColor = Color.LightGray;
            productsSearchButton.FlatStyle = FlatStyle.Flat;
            productsSearchButton.Font = new Font("Segoe UI", 10F);
            productsSearchButton.Location = new Point(924, 64);
            productsSearchButton.Name = "productsSearchButton";
            productsSearchButton.Size = new Size(71, 29);
            productsSearchButton.TabIndex = 8;
            productsSearchButton.Text = "Search";
            productsSearchButton.UseVisualStyleBackColor = false;
            productsSearchButton.Click += ProductsSearchButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.LightGray;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(1192, 411);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(71, 36);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += ExitButton_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            CancelButton = exitButton;
            ClientSize = new Size(1287, 469);
            Controls.Add(exitButton);
            Controls.Add(productsDataGridView);
            Controls.Add(productsLabel);
            Controls.Add(productsSearchTextBox);
            Controls.Add(productsAddButton);
            Controls.Add(productsModifyButton);
            Controls.Add(productsDeleteButton);
            Controls.Add(productsSearchButton);
            Controls.Add(partsDataGridView);
            Controls.Add(partsLabel);
            Controls.Add(partsSearchTextBox);
            Controls.Add(partsAddButton);
            Controls.Add(partsModifyButton);
            Controls.Add(partsDeleteButton);
            Controls.Add(partsSearchButton);
            Controls.Add(inventoryManagementSystemLabel);
            Name = "MainScreen";
            Text = "Main Screen";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label inventoryManagementSystemLabel;
        private Button partsSearchButton;
        private TextBox partsSearchTextBox;
        private Label partsLabel;
        private Button partsDeleteButton;
        private Button partsModifyButton;
        private Button partsAddButton;
        private DataGridView partsDataGridView;
        private DataGridView productsDataGridView;
        private Label productsLabel;
        private TextBox productsSearchTextBox;
        private Button productsAddButton;
        private Button productsModifyButton;
        private Button productsDeleteButton;
        private Button productsSearchButton;
        private Button exitButton;
    }
}
