namespace inclass5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = txtFile.Text;
            if (!File.Exists(fileName))
            {
                using (File.Create(fileName));
            }
            else
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    dataGridView1.Rows.Add();
                    for(int j = 0; j < 8; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = lines[i].Split('|')[j];
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = txtFile.Text;
            string[] lines = File.ReadAllLines(fileName);
            int insertId = Convert.ToInt32(txtNumber.Text);
            foreach (string line in lines)
            {
                int id = Convert.ToInt32(line.Split('|')[0]);
                if (id == insertId)
                {
                    /*Order user = new Order(Convert.ToInt32(txtId.Text), txtName.Text, txtDate.Value, Problem, note);
                    Validations obj = new Validations();
                    obj.AlreadyUser(user, ID);*/
                }
            }
        }
    }
}