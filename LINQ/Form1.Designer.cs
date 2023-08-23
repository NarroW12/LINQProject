namespace LINQ
{
    partial class Form1
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
            filterButton = new Button();
            addButton = new Button();
            itemtextBox = new TextBox();
            collectionListBox = new ListBox();
            filterComboBox = new ComboBox();
            filterTextBox = new TextBox();
            sortButton = new Button();
            sortOrderRadioButton = new RadioButton();
            sortLowerRadioButton = new RadioButton();
            TransformButton = new Button();
            transformComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            AggregateButton = new Button();
            AgregateComboBox = new ComboBox();
            AggregateLabel = new Label();
            SuspendLayout();
            // 
            // filterButton
            // 
            filterButton.Location = new Point(12, 149);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(94, 29);
            filterButton.TabIndex = 0;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(14, 38);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 1;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // itemtextBox
            // 
            itemtextBox.Location = new Point(125, 40);
            itemtextBox.Name = "itemtextBox";
            itemtextBox.Size = new Size(125, 27);
            itemtextBox.TabIndex = 2;
            // 
            // collectionListBox
            // 
            collectionListBox.FormattingEnabled = true;
            collectionListBox.ItemHeight = 20;
            collectionListBox.Location = new Point(444, 12);
            collectionListBox.Name = "collectionListBox";
            collectionListBox.Size = new Size(189, 324);
            collectionListBox.TabIndex = 3;
            // 
            // filterComboBox
            // 
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "Contains", "StartsWith", "EndsWith" });
            filterComboBox.Location = new Point(112, 150);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(151, 28);
            filterComboBox.TabIndex = 4;
            // 
            // filterTextBox
            // 
            filterTextBox.Location = new Point(269, 149);
            filterTextBox.Name = "filterTextBox";
            filterTextBox.Size = new Size(125, 27);
            filterTextBox.TabIndex = 5;
            // 
            // sortButton
            // 
            sortButton.Location = new Point(14, 199);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(94, 29);
            sortButton.TabIndex = 6;
            sortButton.Text = " sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // sortOrderRadioButton
            // 
            sortOrderRadioButton.AutoSize = true;
            sortOrderRadioButton.Location = new Point(114, 204);
            sortOrderRadioButton.Name = "sortOrderRadioButton";
            sortOrderRadioButton.Size = new Size(86, 24);
            sortOrderRadioButton.TabIndex = 7;
            sortOrderRadioButton.TabStop = true;
            sortOrderRadioButton.Text = "Rosnąco";
            sortOrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortLowerRadioButton
            // 
            sortLowerRadioButton.AutoSize = true;
            sortLowerRadioButton.Location = new Point(206, 204);
            sortLowerRadioButton.Name = "sortLowerRadioButton";
            sortLowerRadioButton.Size = new Size(91, 24);
            sortLowerRadioButton.TabIndex = 8;
            sortLowerRadioButton.TabStop = true;
            sortLowerRadioButton.Text = "malejąco";
            sortLowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // TransformButton
            // 
            TransformButton.Location = new Point(14, 250);
            TransformButton.Name = "TransformButton";
            TransformButton.Size = new Size(94, 29);
            TransformButton.TabIndex = 9;
            TransformButton.Text = "Transform";
            TransformButton.UseVisualStyleBackColor = true;
            TransformButton.Click += button1_Click;
            // 
            // transformComboBox
            // 
            transformComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Uppercase", "Lowercase", "Reverse" });
            transformComboBox.FormattingEnabled = true;
            transformComboBox.Items.AddRange(new object[] { "Uppercase", "Lowercase", "Reverse" });
            transformComboBox.Location = new Point(114, 251);
            transformComboBox.Name = "transformComboBox";
            transformComboBox.Size = new Size(151, 28);
            transformComboBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 17);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 11;
            label1.Text = "podaj napis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 126);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 12;
            label2.Text = "podaj filtr";
            // 
            // AggregateButton
            // 
            AggregateButton.Location = new Point(12, 307);
            AggregateButton.Name = "AggregateButton";
            AggregateButton.Size = new Size(94, 29);
            AggregateButton.TabIndex = 13;
            AggregateButton.Text = "Aggregate";
            AggregateButton.UseVisualStyleBackColor = true;
            AggregateButton.Click += AggregateButton_Click;
            // 
            // AgregateComboBox
            // 
            AgregateComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Count", "Length", "Sum" });
            AgregateComboBox.FormattingEnabled = true;
            AgregateComboBox.Items.AddRange(new object[] { "Count", "Length", "Sum" });
            AgregateComboBox.Location = new Point(114, 307);
            AgregateComboBox.Name = "AgregateComboBox";
            AgregateComboBox.Size = new Size(151, 28);
            AgregateComboBox.TabIndex = 14;
            // 
            // AggregateLabel
            // 
            AggregateLabel.AutoSize = true;
            AggregateLabel.Location = new Point(271, 315);
            AggregateLabel.Name = "AggregateLabel";
            AggregateLabel.Size = new Size(45, 20);
            AggregateLabel.TabIndex = 15;
            AggregateLabel.Text = "result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AggregateLabel);
            Controls.Add(AgregateComboBox);
            Controls.Add(AggregateButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(transformComboBox);
            Controls.Add(TransformButton);
            Controls.Add(sortLowerRadioButton);
            Controls.Add(sortOrderRadioButton);
            Controls.Add(sortButton);
            Controls.Add(filterTextBox);
            Controls.Add(filterComboBox);
            Controls.Add(collectionListBox);
            Controls.Add(itemtextBox);
            Controls.Add(addButton);
            Controls.Add(filterButton);
            Name = "Form1";
            Text = "LINQ PROJECT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button filterButton;
        private Button addButton;
        private TextBox itemtextBox;
        private ListBox collectionListBox;
        private ComboBox filterComboBox;
        private TextBox filterTextBox;
        private Button sortButton;
        private RadioButton sortOrderRadioButton;
        private RadioButton sortLowerRadioButton;
        private Button TransformButton;
        private ComboBox transformComboBox;
        private Label label1;
        private Label label2;
        private Button AggregateButton;
        private ComboBox AgregateComboBox;
        private Label AggregateLabel;
    }
}