namespace JasonNealC968
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productFormLabel = new Label();
            candidatesSearchTextBox = new TextBox();
            candidatesSearchButton = new Button();
            candidatesLabel = new Label();
            associatedLabel = new Label();
            candidatesDataGridView = new DataGridView();
            associatedDataGridView = new DataGridView();
            candidatesAddButton = new Button();
            associatedDeleteButton = new Button();
            cancelButton = new Button();
            saveButton = new Button();
            productMinNumericUpDown = new NumericUpDown();
            productMaxNumericUpDown = new NumericUpDown();
            productInventoryNumericUpDown = new NumericUpDown();
            productMinLabel = new Label();
            productMaxLabel = new Label();
            productPriceLabel = new Label();
            productInventoryLabel = new Label();
            productNameLabel = new Label();
            productIdLabel = new Label();
            productPriceTextBox = new TextBox();
            productNameTextBox = new TextBox();
            productIdTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)candidatesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productMinNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productMaxNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productInventoryNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // productFormLabel
            // 
            productFormLabel.AutoSize = true;
            productFormLabel.Font = new Font("Segoe UI", 12F);
            productFormLabel.Location = new Point(17, 21);
            productFormLabel.Margin = new Padding(4, 0, 4, 0);
            productFormLabel.Name = "productFormLabel";
            productFormLabel.Size = new Size(96, 21);
            productFormLabel.TabIndex = 1;
            productFormLabel.Text = "Add Product";
            // 
            // candidatesSearchTextBox
            // 
            candidatesSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            candidatesSearchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            candidatesSearchTextBox.Location = new Point(752, 44);
            candidatesSearchTextBox.Name = "candidatesSearchTextBox";
            candidatesSearchTextBox.Size = new Size(256, 29);
            candidatesSearchTextBox.TabIndex = 4;
            // 
            // candidatesSearchButton
            // 
            candidatesSearchButton.BackColor = Color.LightGray;
            candidatesSearchButton.FlatStyle = FlatStyle.Flat;
            candidatesSearchButton.Font = new Font("Segoe UI", 10F);
            candidatesSearchButton.Location = new Point(669, 44);
            candidatesSearchButton.Name = "candidatesSearchButton";
            candidatesSearchButton.Size = new Size(71, 29);
            candidatesSearchButton.TabIndex = 3;
            candidatesSearchButton.Text = "Search";
            candidatesSearchButton.UseVisualStyleBackColor = false;
            candidatesSearchButton.Click += CandidatesSearchButton_Click;
            // 
            // candidatesLabel
            // 
            candidatesLabel.AutoSize = true;
            candidatesLabel.Font = new Font("Segoe UI", 11F);
            candidatesLabel.Location = new Point(401, 73);
            candidatesLabel.Margin = new Padding(4, 0, 4, 0);
            candidatesLabel.Name = "candidatesLabel";
            candidatesLabel.Size = new Size(132, 20);
            candidatesLabel.TabIndex = 12;
            candidatesLabel.Text = "All candidate Parts";
            // 
            // associatedLabel
            // 
            associatedLabel.AutoSize = true;
            associatedLabel.Font = new Font("Segoe UI", 11F);
            associatedLabel.Location = new Point(401, 409);
            associatedLabel.Margin = new Padding(4, 0, 4, 0);
            associatedLabel.Name = "associatedLabel";
            associatedLabel.Size = new Size(230, 20);
            associatedLabel.TabIndex = 13;
            associatedLabel.Text = "Parts Associated with this Product";
            // 
            // candidatesDataGridView
            // 
            candidatesDataGridView.AllowUserToAddRows = false;
            candidatesDataGridView.AllowUserToDeleteRows = false;
            candidatesDataGridView.AllowUserToResizeColumns = false;
            candidatesDataGridView.AllowUserToResizeRows = false;
            candidatesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candidatesDataGridView.Location = new Point(405, 103);
            candidatesDataGridView.MultiSelect = false;
            candidatesDataGridView.Name = "candidatesDataGridView";
            candidatesDataGridView.ReadOnly = true;
            candidatesDataGridView.RowHeadersVisible = false;
            candidatesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            candidatesDataGridView.ShowEditingIcon = false;
            candidatesDataGridView.Size = new Size(603, 222);
            candidatesDataGridView.TabIndex = 14;
            // 
            // associatedDataGridView
            // 
            associatedDataGridView.AllowUserToAddRows = false;
            associatedDataGridView.AllowUserToDeleteRows = false;
            associatedDataGridView.AllowUserToResizeColumns = false;
            associatedDataGridView.AllowUserToResizeRows = false;
            associatedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedDataGridView.Location = new Point(405, 439);
            associatedDataGridView.MultiSelect = false;
            associatedDataGridView.Name = "associatedDataGridView";
            associatedDataGridView.ReadOnly = true;
            associatedDataGridView.RowHeadersVisible = false;
            associatedDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedDataGridView.ShowEditingIcon = false;
            associatedDataGridView.Size = new Size(603, 222);
            associatedDataGridView.TabIndex = 15;
            // 
            // candidatesAddButton
            // 
            candidatesAddButton.BackColor = Color.LightGray;
            candidatesAddButton.FlatStyle = FlatStyle.Flat;
            candidatesAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            candidatesAddButton.Location = new Point(918, 346);
            candidatesAddButton.Name = "candidatesAddButton";
            candidatesAddButton.Size = new Size(71, 36);
            candidatesAddButton.TabIndex = 16;
            candidatesAddButton.Text = "Add";
            candidatesAddButton.UseVisualStyleBackColor = false;
            candidatesAddButton.Click += AssociatedAddButton_Click;
            // 
            // associatedDeleteButton
            // 
            associatedDeleteButton.BackColor = Color.LightGray;
            associatedDeleteButton.FlatStyle = FlatStyle.Flat;
            associatedDeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            associatedDeleteButton.Location = new Point(918, 682);
            associatedDeleteButton.Name = "associatedDeleteButton";
            associatedDeleteButton.Size = new Size(71, 36);
            associatedDeleteButton.TabIndex = 17;
            associatedDeleteButton.Text = "Delete";
            associatedDeleteButton.UseVisualStyleBackColor = false;
            associatedDeleteButton.Click += AssociatedDeleteButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.LightGray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(918, 739);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(71, 36);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightGray;
            saveButton.Enabled = false;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(827, 739);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(71, 36);
            saveButton.TabIndex = 19;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // productMinNumericUpDown
            // 
            productMinNumericUpDown.Font = new Font("Segoe UI", 12F);
            productMinNumericUpDown.Location = new Point(168, 482);
            productMinNumericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            productMinNumericUpDown.Name = "productMinNumericUpDown";
            productMinNumericUpDown.Size = new Size(119, 29);
            productMinNumericUpDown.TabIndex = 33;
            productMinNumericUpDown.ValueChanged += Control_Changed;
            // 
            // productMaxNumericUpDown
            // 
            productMaxNumericUpDown.Font = new Font("Segoe UI", 12F);
            productMaxNumericUpDown.Location = new Point(168, 436);
            productMaxNumericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            productMaxNumericUpDown.Name = "productMaxNumericUpDown";
            productMaxNumericUpDown.Size = new Size(119, 29);
            productMaxNumericUpDown.TabIndex = 32;
            productMaxNumericUpDown.ValueChanged += Control_Changed;
            // 
            // productInventoryNumericUpDown
            // 
            productInventoryNumericUpDown.Font = new Font("Segoe UI", 12F);
            productInventoryNumericUpDown.Location = new Point(168, 345);
            productInventoryNumericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            productInventoryNumericUpDown.Name = "productInventoryNumericUpDown";
            productInventoryNumericUpDown.Size = new Size(183, 29);
            productInventoryNumericUpDown.TabIndex = 31;
            productInventoryNumericUpDown.ValueChanged += Control_Changed;
            // 
            // productMinLabel
            // 
            productMinLabel.AutoSize = true;
            productMinLabel.Font = new Font("Segoe UI", 11F);
            productMinLabel.Location = new Point(96, 485);
            productMinLabel.Margin = new Padding(4, 0, 4, 0);
            productMinLabel.Name = "productMinLabel";
            productMinLabel.Size = new Size(34, 20);
            productMinLabel.TabIndex = 30;
            productMinLabel.Text = "Min";
            // 
            // productMaxLabel
            // 
            productMaxLabel.AutoSize = true;
            productMaxLabel.Font = new Font("Segoe UI", 11F);
            productMaxLabel.Location = new Point(94, 439);
            productMaxLabel.Margin = new Padding(4, 0, 4, 0);
            productMaxLabel.Name = "productMaxLabel";
            productMaxLabel.Size = new Size(37, 20);
            productMaxLabel.TabIndex = 29;
            productMaxLabel.Text = "Max";
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Font = new Font("Segoe UI", 11F);
            productPriceLabel.Location = new Point(47, 393);
            productPriceLabel.Margin = new Padding(4, 0, 4, 0);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(84, 20);
            productPriceLabel.TabIndex = 28;
            productPriceLabel.Text = "Price / Cost";
            // 
            // productInventoryLabel
            // 
            productInventoryLabel.AutoSize = true;
            productInventoryLabel.Font = new Font("Segoe UI", 11F);
            productInventoryLabel.Location = new Point(61, 348);
            productInventoryLabel.Margin = new Padding(4, 0, 4, 0);
            productInventoryLabel.Name = "productInventoryLabel";
            productInventoryLabel.Size = new Size(70, 20);
            productInventoryLabel.TabIndex = 27;
            productInventoryLabel.Text = "Inventory";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Segoe UI", 11F);
            productNameLabel.Location = new Point(82, 303);
            productNameLabel.Margin = new Padding(4, 0, 4, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(49, 20);
            productNameLabel.TabIndex = 26;
            productNameLabel.Text = "Name";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Font = new Font("Segoe UI", 11F);
            productIdLabel.Location = new Point(107, 258);
            productIdLabel.Margin = new Padding(4, 0, 4, 0);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(24, 20);
            productIdLabel.TabIndex = 25;
            productIdLabel.Text = "ID";
            // 
            // productPriceTextBox
            // 
            productPriceTextBox.BackColor = Color.LightCoral;
            productPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            productPriceTextBox.Font = new Font("Segoe UI", 11F);
            productPriceTextBox.Location = new Point(168, 391);
            productPriceTextBox.Margin = new Padding(4);
            productPriceTextBox.Name = "productPriceTextBox";
            productPriceTextBox.Size = new Size(183, 27);
            productPriceTextBox.TabIndex = 24;
            productPriceTextBox.TextChanged += Control_Changed;
            // 
            // productNameTextBox
            // 
            productNameTextBox.BackColor = Color.LightCoral;
            productNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            productNameTextBox.Font = new Font("Segoe UI", 11F);
            productNameTextBox.Location = new Point(168, 301);
            productNameTextBox.Margin = new Padding(4);
            productNameTextBox.MaxLength = 50;
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(183, 27);
            productNameTextBox.TabIndex = 23;
            productNameTextBox.TextChanged += Control_Changed;
            // 
            // productIdTextBox
            // 
            productIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            productIdTextBox.Font = new Font("Segoe UI", 11F);
            productIdTextBox.Location = new Point(168, 256);
            productIdTextBox.Margin = new Padding(4);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.ReadOnly = true;
            productIdTextBox.Size = new Size(183, 27);
            productIdTextBox.TabIndex = 22;
            productIdTextBox.TabStop = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(1167, 799);
            Controls.Add(productMinNumericUpDown);
            Controls.Add(productMaxNumericUpDown);
            Controls.Add(productInventoryNumericUpDown);
            Controls.Add(productMinLabel);
            Controls.Add(productMaxLabel);
            Controls.Add(productPriceLabel);
            Controls.Add(productInventoryLabel);
            Controls.Add(productNameLabel);
            Controls.Add(productIdLabel);
            Controls.Add(productPriceTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(productIdTextBox);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(associatedDeleteButton);
            Controls.Add(candidatesAddButton);
            Controls.Add(associatedDataGridView);
            Controls.Add(candidatesDataGridView);
            Controls.Add(associatedLabel);
            Controls.Add(candidatesLabel);
            Controls.Add(candidatesSearchTextBox);
            Controls.Add(candidatesSearchButton);
            Controls.Add(productFormLabel);
            Name = "ProductForm";
            Text = "Product";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)candidatesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productMinNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)productMaxNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)productInventoryNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productFormLabel;
        private TextBox candidatesSearchTextBox;
        private Button candidatesSearchButton;
        private Label candidatesLabel;
        private Label associatedLabel;
        private DataGridView candidatesDataGridView;
        private DataGridView associatedDataGridView;
        private Button candidatesAddButton;
        private Button associatedDeleteButton;
        private Button cancelButton;
        private Button saveButton;
        private NumericUpDown productMinNumericUpDown;
        private NumericUpDown productMaxNumericUpDown;
        private NumericUpDown productInventoryNumericUpDown;
        private Label productMinLabel;
        private Label productMaxLabel;
        private Label productPriceLabel;
        private Label productInventoryLabel;
        private Label productNameLabel;
        private Label productIdLabel;
        private TextBox productPriceTextBox;
        private TextBox productNameTextBox;
        private TextBox productIdTextBox;
    }
}