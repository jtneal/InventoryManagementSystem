namespace JasonNealC968
{
    partial class AddPart
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
            addPartLabel = new Label();
            inHouseRadioButton = new RadioButton();
            outsourcedRadioButton = new RadioButton();
            partIdTextBox = new TextBox();
            partNameTextBox = new TextBox();
            partPriceTextBox = new TextBox();
            partMachineIdTextBox = new TextBox();
            partIdLabel = new Label();
            partNameLabel = new Label();
            partInventoryLabel = new Label();
            partPriceLabel = new Label();
            partMaxLabel = new Label();
            partMachineIdLabel = new Label();
            partMinLabel = new Label();
            partCompanyNameLabel = new Label();
            partCompanyNameTextBox = new TextBox();
            partSaveButton = new Button();
            partCancelButton = new Button();
            partInventoryNumericUpDown = new NumericUpDown();
            partMaxNumericUpDown = new NumericUpDown();
            partMinNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)partInventoryNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partMaxNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partMinNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // addPartLabel
            // 
            addPartLabel.AutoSize = true;
            addPartLabel.Font = new Font("Segoe UI", 12F);
            addPartLabel.Location = new Point(17, 21);
            addPartLabel.Margin = new Padding(4, 0, 4, 0);
            addPartLabel.Name = "addPartLabel";
            addPartLabel.Size = new Size(69, 21);
            addPartLabel.TabIndex = 0;
            addPartLabel.Text = "Add Part";
            // 
            // inHouseRadioButton
            // 
            inHouseRadioButton.AutoSize = true;
            inHouseRadioButton.Location = new Point(166, 25);
            inHouseRadioButton.Margin = new Padding(4);
            inHouseRadioButton.Name = "inHouseRadioButton";
            inHouseRadioButton.Size = new Size(91, 25);
            inHouseRadioButton.TabIndex = 1;
            inHouseRadioButton.Text = "In-House";
            inHouseRadioButton.UseVisualStyleBackColor = true;
            inHouseRadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // outsourcedRadioButton
            // 
            outsourcedRadioButton.AutoSize = true;
            outsourcedRadioButton.Location = new Point(302, 25);
            outsourcedRadioButton.Margin = new Padding(4);
            outsourcedRadioButton.Name = "outsourcedRadioButton";
            outsourcedRadioButton.Size = new Size(109, 25);
            outsourcedRadioButton.TabIndex = 2;
            outsourcedRadioButton.Text = "Outsourced";
            outsourcedRadioButton.UseVisualStyleBackColor = true;
            outsourcedRadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // partIdTextBox
            // 
            partIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            partIdTextBox.Font = new Font("Segoe UI", 11F);
            partIdTextBox.Location = new Point(210, 84);
            partIdTextBox.Margin = new Padding(4);
            partIdTextBox.Name = "partIdTextBox";
            partIdTextBox.ReadOnly = true;
            partIdTextBox.Size = new Size(183, 27);
            partIdTextBox.TabIndex = 3;
            partIdTextBox.TabStop = false;
            // 
            // partNameTextBox
            // 
            partNameTextBox.BackColor = Color.LightCoral;
            partNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            partNameTextBox.Font = new Font("Segoe UI", 11F);
            partNameTextBox.Location = new Point(210, 129);
            partNameTextBox.Margin = new Padding(4);
            partNameTextBox.MaxLength = 50;
            partNameTextBox.Name = "partNameTextBox";
            partNameTextBox.Size = new Size(183, 27);
            partNameTextBox.TabIndex = 4;
            partNameTextBox.TextChanged += textBox_TextChanged;
            // 
            // partPriceTextBox
            // 
            partPriceTextBox.BackColor = Color.LightCoral;
            partPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            partPriceTextBox.Font = new Font("Segoe UI", 11F);
            partPriceTextBox.Location = new Point(210, 219);
            partPriceTextBox.Margin = new Padding(4);
            partPriceTextBox.Name = "partPriceTextBox";
            partPriceTextBox.Size = new Size(183, 27);
            partPriceTextBox.TabIndex = 6;
            partPriceTextBox.TextChanged += textBox_TextChanged;
            // 
            // partMachineIdTextBox
            // 
            partMachineIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            partMachineIdTextBox.Font = new Font("Segoe UI", 11F);
            partMachineIdTextBox.Location = new Point(210, 309);
            partMachineIdTextBox.Margin = new Padding(4);
            partMachineIdTextBox.Name = "partMachineIdTextBox";
            partMachineIdTextBox.Size = new Size(183, 27);
            partMachineIdTextBox.TabIndex = 9;
            partMachineIdTextBox.Visible = false;
            // 
            // partIdLabel
            // 
            partIdLabel.AutoSize = true;
            partIdLabel.Font = new Font("Segoe UI", 11F);
            partIdLabel.Location = new Point(149, 86);
            partIdLabel.Margin = new Padding(4, 0, 4, 0);
            partIdLabel.Name = "partIdLabel";
            partIdLabel.Size = new Size(24, 20);
            partIdLabel.TabIndex = 11;
            partIdLabel.Text = "ID";
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Font = new Font("Segoe UI", 11F);
            partNameLabel.Location = new Point(124, 131);
            partNameLabel.Margin = new Padding(4, 0, 4, 0);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new Size(49, 20);
            partNameLabel.TabIndex = 12;
            partNameLabel.Text = "Name";
            // 
            // partInventoryLabel
            // 
            partInventoryLabel.AutoSize = true;
            partInventoryLabel.Font = new Font("Segoe UI", 11F);
            partInventoryLabel.Location = new Point(103, 176);
            partInventoryLabel.Margin = new Padding(4, 0, 4, 0);
            partInventoryLabel.Name = "partInventoryLabel";
            partInventoryLabel.Size = new Size(70, 20);
            partInventoryLabel.TabIndex = 13;
            partInventoryLabel.Text = "Inventory";
            // 
            // partPriceLabel
            // 
            partPriceLabel.AutoSize = true;
            partPriceLabel.Font = new Font("Segoe UI", 11F);
            partPriceLabel.Location = new Point(89, 221);
            partPriceLabel.Margin = new Padding(4, 0, 4, 0);
            partPriceLabel.Name = "partPriceLabel";
            partPriceLabel.Size = new Size(84, 20);
            partPriceLabel.TabIndex = 14;
            partPriceLabel.Text = "Price / Cost";
            // 
            // partMaxLabel
            // 
            partMaxLabel.AutoSize = true;
            partMaxLabel.Font = new Font("Segoe UI", 11F);
            partMaxLabel.Location = new Point(136, 267);
            partMaxLabel.Margin = new Padding(4, 0, 4, 0);
            partMaxLabel.Name = "partMaxLabel";
            partMaxLabel.Size = new Size(37, 20);
            partMaxLabel.TabIndex = 15;
            partMaxLabel.Text = "Max";
            // 
            // partMachineIdLabel
            // 
            partMachineIdLabel.AutoSize = true;
            partMachineIdLabel.Font = new Font("Segoe UI", 11F);
            partMachineIdLabel.Location = new Point(89, 311);
            partMachineIdLabel.Margin = new Padding(4, 0, 4, 0);
            partMachineIdLabel.Name = "partMachineIdLabel";
            partMachineIdLabel.Size = new Size(84, 20);
            partMachineIdLabel.TabIndex = 17;
            partMachineIdLabel.Text = "Machine ID";
            partMachineIdLabel.Visible = false;
            // 
            // partMinLabel
            // 
            partMinLabel.AutoSize = true;
            partMinLabel.Font = new Font("Segoe UI", 11F);
            partMinLabel.Location = new Point(365, 267);
            partMinLabel.Margin = new Padding(4, 0, 4, 0);
            partMinLabel.Name = "partMinLabel";
            partMinLabel.Size = new Size(34, 20);
            partMinLabel.TabIndex = 16;
            partMinLabel.Text = "Min";
            // 
            // partCompanyNameLabel
            // 
            partCompanyNameLabel.AutoSize = true;
            partCompanyNameLabel.Font = new Font("Segoe UI", 11F);
            partCompanyNameLabel.Location = new Point(57, 311);
            partCompanyNameLabel.Margin = new Padding(4, 0, 4, 0);
            partCompanyNameLabel.Name = "partCompanyNameLabel";
            partCompanyNameLabel.Size = new Size(116, 20);
            partCompanyNameLabel.TabIndex = 18;
            partCompanyNameLabel.Text = "Company Name";
            partCompanyNameLabel.Visible = false;
            // 
            // partCompanyNameTextBox
            // 
            partCompanyNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            partCompanyNameTextBox.Font = new Font("Segoe UI", 11F);
            partCompanyNameTextBox.Location = new Point(210, 309);
            partCompanyNameTextBox.Margin = new Padding(4);
            partCompanyNameTextBox.Name = "partCompanyNameTextBox";
            partCompanyNameTextBox.Size = new Size(183, 27);
            partCompanyNameTextBox.TabIndex = 10;
            partCompanyNameTextBox.Visible = false;
            // 
            // partSaveButton
            // 
            partSaveButton.Enabled = false;
            partSaveButton.FlatStyle = FlatStyle.Flat;
            partSaveButton.Location = new Point(388, 400);
            partSaveButton.Margin = new Padding(4);
            partSaveButton.Name = "partSaveButton";
            partSaveButton.Size = new Size(75, 41);
            partSaveButton.TabIndex = 11;
            partSaveButton.Text = "Save";
            partSaveButton.UseVisualStyleBackColor = true;
            partSaveButton.Click += partSaveButton_Click;
            // 
            // partCancelButton
            // 
            partCancelButton.FlatStyle = FlatStyle.Flat;
            partCancelButton.Location = new Point(481, 400);
            partCancelButton.Margin = new Padding(4);
            partCancelButton.Name = "partCancelButton";
            partCancelButton.Size = new Size(75, 41);
            partCancelButton.TabIndex = 12;
            partCancelButton.Text = "Cancel";
            partCancelButton.UseVisualStyleBackColor = true;
            partCancelButton.Click += partCancelButton_Click;
            // 
            // partInventoryNumericUpDown
            // 
            partInventoryNumericUpDown.Location = new Point(210, 173);
            partInventoryNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            partInventoryNumericUpDown.Name = "partInventoryNumericUpDown";
            partInventoryNumericUpDown.Size = new Size(183, 29);
            partInventoryNumericUpDown.TabIndex = 19;
            partInventoryNumericUpDown.ValueChanged += textBox_TextChanged;
            // 
            // partMaxNumericUpDown
            // 
            partMaxNumericUpDown.Location = new Point(210, 264);
            partMaxNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            partMaxNumericUpDown.Name = "partMaxNumericUpDown";
            partMaxNumericUpDown.Size = new Size(119, 29);
            partMaxNumericUpDown.TabIndex = 20;
            partMaxNumericUpDown.ValueChanged += textBox_TextChanged;
            // 
            // partMinNumericUpDown
            // 
            partMinNumericUpDown.Location = new Point(437, 264);
            partMinNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            partMinNumericUpDown.Name = "partMinNumericUpDown";
            partMinNumericUpDown.Size = new Size(119, 29);
            partMinNumericUpDown.TabIndex = 21;
            partMinNumericUpDown.ValueChanged += textBox_TextChanged;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 486);
            Controls.Add(partMinNumericUpDown);
            Controls.Add(partMaxNumericUpDown);
            Controls.Add(partInventoryNumericUpDown);
            Controls.Add(partCancelButton);
            Controls.Add(partSaveButton);
            Controls.Add(partCompanyNameLabel);
            Controls.Add(partCompanyNameTextBox);
            Controls.Add(partMinLabel);
            Controls.Add(partMachineIdLabel);
            Controls.Add(partMaxLabel);
            Controls.Add(partPriceLabel);
            Controls.Add(partInventoryLabel);
            Controls.Add(partNameLabel);
            Controls.Add(partIdLabel);
            Controls.Add(partMachineIdTextBox);
            Controls.Add(partPriceTextBox);
            Controls.Add(partNameTextBox);
            Controls.Add(partIdTextBox);
            Controls.Add(outsourcedRadioButton);
            Controls.Add(inHouseRadioButton);
            Controls.Add(addPartLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "AddPartForm";
            Text = "Part";
            ((System.ComponentModel.ISupportInitialize)partInventoryNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)partMaxNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)partMinNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addPartLabel;
        private RadioButton inHouseRadioButton;
        private RadioButton outsourcedRadioButton;
        private TextBox partIdTextBox;
        private TextBox partNameTextBox;
        private TextBox partPriceTextBox;
        private TextBox partMachineIdTextBox;
        private Label partIdLabel;
        private Label partNameLabel;
        private Label partInventoryLabel;
        private Label partPriceLabel;
        private Label partMaxLabel;
        private Label partMachineIdLabel;
        private Label partMinLabel;
        private Label partCompanyNameLabel;
        private TextBox partCompanyNameTextBox;
        private Button partSaveButton;
        private Button partCancelButton;
        private NumericUpDown partInventoryNumericUpDown;
        private NumericUpDown partMaxNumericUpDown;
        private NumericUpDown partMinNumericUpDown;
    }
}