namespace JasonNealC968
{
    partial class ModifyPart
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
            partMinNumericUpDown = new NumericUpDown();
            partMaxNumericUpDown = new NumericUpDown();
            partInventoryNumericUpDown = new NumericUpDown();
            partCancelButton = new Button();
            partSaveButton = new Button();
            partCompanyNameLabel = new Label();
            partCompanyNameTextBox = new TextBox();
            partMinLabel = new Label();
            partMachineIdLabel = new Label();
            partMaxLabel = new Label();
            partPriceLabel = new Label();
            partInventoryLabel = new Label();
            partNameLabel = new Label();
            partIdLabel = new Label();
            partPriceTextBox = new TextBox();
            partNameTextBox = new TextBox();
            partIdTextBox = new TextBox();
            outsourcedRadioButton = new RadioButton();
            inHouseRadioButton = new RadioButton();
            addPartLabel = new Label();
            partMachineIdNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)partMinNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partMaxNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partInventoryNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partMachineIdNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // partMinNumericUpDown
            // 
            partMinNumericUpDown.Font = new Font("Segoe UI", 12F);
            partMinNumericUpDown.Location = new Point(436, 264);
            partMinNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            partMinNumericUpDown.Name = "partMinNumericUpDown";
            partMinNumericUpDown.Size = new Size(119, 29);
            partMinNumericUpDown.TabIndex = 42;
            partMinNumericUpDown.ValueChanged += textBox_TextChanged;
            // 
            // partMaxNumericUpDown
            // 
            partMaxNumericUpDown.Font = new Font("Segoe UI", 12F);
            partMaxNumericUpDown.Location = new Point(209, 264);
            partMaxNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            partMaxNumericUpDown.Name = "partMaxNumericUpDown";
            partMaxNumericUpDown.Size = new Size(119, 29);
            partMaxNumericUpDown.TabIndex = 41;
            partMaxNumericUpDown.ValueChanged += textBox_TextChanged;
            // 
            // partInventoryNumericUpDown
            // 
            partInventoryNumericUpDown.Font = new Font("Segoe UI", 12F);
            partInventoryNumericUpDown.Location = new Point(209, 173);
            partInventoryNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            partInventoryNumericUpDown.Name = "partInventoryNumericUpDown";
            partInventoryNumericUpDown.Size = new Size(183, 29);
            partInventoryNumericUpDown.TabIndex = 40;
            partInventoryNumericUpDown.ValueChanged += textBox_TextChanged;
            // 
            // partCancelButton
            // 
            partCancelButton.FlatStyle = FlatStyle.Flat;
            partCancelButton.Font = new Font("Segoe UI", 12F);
            partCancelButton.Location = new Point(480, 400);
            partCancelButton.Margin = new Padding(4);
            partCancelButton.Name = "partCancelButton";
            partCancelButton.Size = new Size(75, 41);
            partCancelButton.TabIndex = 32;
            partCancelButton.Text = "Cancel";
            partCancelButton.UseVisualStyleBackColor = true;
            partCancelButton.Click += partCancelButton_Click;
            // 
            // partSaveButton
            // 
            partSaveButton.Enabled = false;
            partSaveButton.FlatStyle = FlatStyle.Flat;
            partSaveButton.Font = new Font("Segoe UI", 12F);
            partSaveButton.Location = new Point(387, 400);
            partSaveButton.Margin = new Padding(4);
            partSaveButton.Name = "partSaveButton";
            partSaveButton.Size = new Size(75, 41);
            partSaveButton.TabIndex = 30;
            partSaveButton.Text = "Save";
            partSaveButton.UseVisualStyleBackColor = true;
            partSaveButton.Click += partSaveButton_Click;
            // 
            // partCompanyNameLabel
            // 
            partCompanyNameLabel.AutoSize = true;
            partCompanyNameLabel.Font = new Font("Segoe UI", 11F);
            partCompanyNameLabel.Location = new Point(56, 311);
            partCompanyNameLabel.Margin = new Padding(4, 0, 4, 0);
            partCompanyNameLabel.Name = "partCompanyNameLabel";
            partCompanyNameLabel.Size = new Size(116, 20);
            partCompanyNameLabel.TabIndex = 39;
            partCompanyNameLabel.Text = "Company Name";
            partCompanyNameLabel.Visible = false;
            // 
            // partCompanyNameTextBox
            // 
            partCompanyNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            partCompanyNameTextBox.Font = new Font("Segoe UI", 11F);
            partCompanyNameTextBox.Location = new Point(209, 309);
            partCompanyNameTextBox.Margin = new Padding(4);
            partCompanyNameTextBox.Name = "partCompanyNameTextBox";
            partCompanyNameTextBox.Size = new Size(183, 27);
            partCompanyNameTextBox.TabIndex = 29;
            partCompanyNameTextBox.Visible = false;
            partCompanyNameTextBox.TextChanged += textBox_TextChanged;
            // 
            // partMinLabel
            // 
            partMinLabel.AutoSize = true;
            partMinLabel.Font = new Font("Segoe UI", 11F);
            partMinLabel.Location = new Point(364, 267);
            partMinLabel.Margin = new Padding(4, 0, 4, 0);
            partMinLabel.Name = "partMinLabel";
            partMinLabel.Size = new Size(34, 20);
            partMinLabel.TabIndex = 37;
            partMinLabel.Text = "Min";
            // 
            // partMachineIdLabel
            // 
            partMachineIdLabel.AutoSize = true;
            partMachineIdLabel.Font = new Font("Segoe UI", 11F);
            partMachineIdLabel.Location = new Point(88, 311);
            partMachineIdLabel.Margin = new Padding(4, 0, 4, 0);
            partMachineIdLabel.Name = "partMachineIdLabel";
            partMachineIdLabel.Size = new Size(84, 20);
            partMachineIdLabel.TabIndex = 38;
            partMachineIdLabel.Text = "Machine ID";
            partMachineIdLabel.Visible = false;
            // 
            // partMaxLabel
            // 
            partMaxLabel.AutoSize = true;
            partMaxLabel.Font = new Font("Segoe UI", 11F);
            partMaxLabel.Location = new Point(135, 267);
            partMaxLabel.Margin = new Padding(4, 0, 4, 0);
            partMaxLabel.Name = "partMaxLabel";
            partMaxLabel.Size = new Size(37, 20);
            partMaxLabel.TabIndex = 36;
            partMaxLabel.Text = "Max";
            // 
            // partPriceLabel
            // 
            partPriceLabel.AutoSize = true;
            partPriceLabel.Font = new Font("Segoe UI", 11F);
            partPriceLabel.Location = new Point(88, 221);
            partPriceLabel.Margin = new Padding(4, 0, 4, 0);
            partPriceLabel.Name = "partPriceLabel";
            partPriceLabel.Size = new Size(84, 20);
            partPriceLabel.TabIndex = 35;
            partPriceLabel.Text = "Price / Cost";
            // 
            // partInventoryLabel
            // 
            partInventoryLabel.AutoSize = true;
            partInventoryLabel.Font = new Font("Segoe UI", 11F);
            partInventoryLabel.Location = new Point(102, 176);
            partInventoryLabel.Margin = new Padding(4, 0, 4, 0);
            partInventoryLabel.Name = "partInventoryLabel";
            partInventoryLabel.Size = new Size(70, 20);
            partInventoryLabel.TabIndex = 34;
            partInventoryLabel.Text = "Inventory";
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Font = new Font("Segoe UI", 11F);
            partNameLabel.Location = new Point(123, 131);
            partNameLabel.Margin = new Padding(4, 0, 4, 0);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new Size(49, 20);
            partNameLabel.TabIndex = 33;
            partNameLabel.Text = "Name";
            // 
            // partIdLabel
            // 
            partIdLabel.AutoSize = true;
            partIdLabel.Font = new Font("Segoe UI", 11F);
            partIdLabel.Location = new Point(148, 86);
            partIdLabel.Margin = new Padding(4, 0, 4, 0);
            partIdLabel.Name = "partIdLabel";
            partIdLabel.Size = new Size(24, 20);
            partIdLabel.TabIndex = 31;
            partIdLabel.Text = "ID";
            // 
            // partPriceTextBox
            // 
            partPriceTextBox.BackColor = Color.LightCoral;
            partPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            partPriceTextBox.Font = new Font("Segoe UI", 11F);
            partPriceTextBox.Location = new Point(209, 219);
            partPriceTextBox.Margin = new Padding(4);
            partPriceTextBox.Name = "partPriceTextBox";
            partPriceTextBox.Size = new Size(183, 27);
            partPriceTextBox.TabIndex = 27;
            partPriceTextBox.TextChanged += textBox_TextChanged;
            // 
            // partNameTextBox
            // 
            partNameTextBox.BackColor = Color.LightCoral;
            partNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            partNameTextBox.Font = new Font("Segoe UI", 11F);
            partNameTextBox.Location = new Point(209, 129);
            partNameTextBox.Margin = new Padding(4);
            partNameTextBox.MaxLength = 50;
            partNameTextBox.Name = "partNameTextBox";
            partNameTextBox.Size = new Size(183, 27);
            partNameTextBox.TabIndex = 26;
            partNameTextBox.TextChanged += textBox_TextChanged;
            // 
            // partIdTextBox
            // 
            partIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            partIdTextBox.Font = new Font("Segoe UI", 11F);
            partIdTextBox.Location = new Point(209, 84);
            partIdTextBox.Margin = new Padding(4);
            partIdTextBox.Name = "partIdTextBox";
            partIdTextBox.ReadOnly = true;
            partIdTextBox.Size = new Size(183, 27);
            partIdTextBox.TabIndex = 25;
            partIdTextBox.TabStop = false;
            // 
            // outsourcedRadioButton
            // 
            outsourcedRadioButton.AutoSize = true;
            outsourcedRadioButton.Font = new Font("Segoe UI", 12F);
            outsourcedRadioButton.Location = new Point(301, 25);
            outsourcedRadioButton.Margin = new Padding(4);
            outsourcedRadioButton.Name = "outsourcedRadioButton";
            outsourcedRadioButton.Size = new Size(109, 25);
            outsourcedRadioButton.TabIndex = 24;
            outsourcedRadioButton.Text = "Outsourced";
            outsourcedRadioButton.UseVisualStyleBackColor = true;
            outsourcedRadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // inHouseRadioButton
            // 
            inHouseRadioButton.AutoSize = true;
            inHouseRadioButton.Font = new Font("Segoe UI", 12F);
            inHouseRadioButton.Location = new Point(165, 25);
            inHouseRadioButton.Margin = new Padding(4);
            inHouseRadioButton.Name = "inHouseRadioButton";
            inHouseRadioButton.Size = new Size(91, 25);
            inHouseRadioButton.TabIndex = 23;
            inHouseRadioButton.Text = "In-House";
            inHouseRadioButton.UseVisualStyleBackColor = true;
            inHouseRadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // addPartLabel
            // 
            addPartLabel.AutoSize = true;
            addPartLabel.Font = new Font("Segoe UI", 12F);
            addPartLabel.Location = new Point(16, 21);
            addPartLabel.Margin = new Padding(4, 0, 4, 0);
            addPartLabel.Name = "addPartLabel";
            addPartLabel.Size = new Size(90, 21);
            addPartLabel.TabIndex = 22;
            addPartLabel.Text = "Modify Part";
            // 
            // partMachineIdNumericUpDown
            // 
            partMachineIdNumericUpDown.Font = new Font("Segoe UI", 12F);
            partMachineIdNumericUpDown.Location = new Point(209, 309);
            partMachineIdNumericUpDown.Name = "partMachineIdNumericUpDown";
            partMachineIdNumericUpDown.Size = new Size(183, 29);
            partMachineIdNumericUpDown.TabIndex = 43;
            partMachineIdNumericUpDown.ValueChanged += textBox_TextChanged;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 467);
            Controls.Add(partMachineIdNumericUpDown);
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
            Controls.Add(partPriceTextBox);
            Controls.Add(partNameTextBox);
            Controls.Add(partIdTextBox);
            Controls.Add(outsourcedRadioButton);
            Controls.Add(inHouseRadioButton);
            Controls.Add(addPartLabel);
            Name = "ModifyPart";
            Text = "Part";
            Load += ModifyPart_Load;
            ((System.ComponentModel.ISupportInitialize)partMinNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)partMaxNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)partInventoryNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)partMachineIdNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown partMinNumericUpDown;
        private NumericUpDown partMaxNumericUpDown;
        private NumericUpDown partInventoryNumericUpDown;
        private Button partCancelButton;
        private Button partSaveButton;
        private Label partCompanyNameLabel;
        private TextBox partCompanyNameTextBox;
        private Label partMinLabel;
        private Label partMachineIdLabel;
        private Label partMaxLabel;
        private Label partPriceLabel;
        private Label partInventoryLabel;
        private Label partNameLabel;
        private Label partIdLabel;
        private TextBox partPriceTextBox;
        private TextBox partNameTextBox;
        private TextBox partIdTextBox;
        private RadioButton outsourcedRadioButton;
        private RadioButton inHouseRadioButton;
        private Label addPartLabel;
        private NumericUpDown partMachineIdNumericUpDown;
    }
}