namespace LINQ
{
    public partial class Form1 : Form
    {
        private List<string> collection = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string item = itemtextBox.Text;
            if (!string.IsNullOrEmpty(item))
            {
                collection.Add(item);
                collectionListBox.Items.Add(item);
                itemtextBox.Clear();
            }


        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            var filterOptions = new[] { "Contains", "StartsWith", "EndsWith" };
            var selectOptions = (string)filterComboBox.SelectedItem;
            var query = collection.AsQueryable();
            switch (selectOptions)
            {
                case "Contains":
                    query = query.Where(item => item.Contains(filterTextBox.Text));
                    break;
                case "StartsWith":
                    query = query.Where(item => item.StartsWith(filterTextBox.Text));
                    break;
                case "EndsWith":
                    query = query.Where(item => item.EndsWith(filterTextBox.Text));
                    break;
                default:
                    break;
            }
            collectionListBox.Items.Clear();
            foreach (var item in query)
            {
                collectionListBox.Items.Add(item);
            }

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            var query = collection.AsQueryable();
            if (sortOrderRadioButton.Checked)
            {
                query = query.OrderBy(item => item);
            }
            else if (sortLowerRadioButton.Checked)
            {
                query = query.OrderByDescending(item => item);

            }
            collectionListBox.Items.Clear();
            foreach (var item in query)
            {
                collectionListBox.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var transformOptions = new[] { "Uppercase", "Lowercase", "Reverse" };
            var selectedOption = (string)transformComboBox.SelectedItem;
            var query = collection.AsQueryable();
            switch (selectedOption)
            {
                case "Uppercase":
                    query = query.Select(item => item.ToUpper());
                    break;
                case "Lowercase":
                    query = query.Select(item => item.ToLower());
                    break;
                case "Reverse":
                    query = query.Select(item => new string(item.Reverse().ToArray()));
                    break;
                default: break;

            }
            collectionListBox.Items.Clear();
            foreach (var item in query)
            {
                collectionListBox.Items.Add(item);
            }

        }

        private void AggregateButton_Click(object sender, EventArgs e)
        {
            var aggregateOptions = new[] { "Count", "Length", "Sum" };
            var aggregateSelect = (string)AgregateComboBox.SelectedItem;
            var query = collection.AsQueryable();
            switch (aggregateSelect)
            {
                case "Count":
                    AggregateLabel.Text = query.Count().ToString();
                    break;
                case "Length":
                    AggregateLabel.Text = query.Sum(item => item.Length).ToString();
                    break;
                case "Sum":
                    AggregateLabel.Text = query.Count(item => item.Trim().EndsWith("a", StringComparison.OrdinalIgnoreCase)).ToString();

                    break;
                default:
                    break;
            }
        }
    }
}