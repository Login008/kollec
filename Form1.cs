using System.Collections;

namespace collek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Hashtable list = new Hashtable();
        public Hashtable list1 = new Hashtable();
        private void button2_Click(object sender, EventArgs e)
        {
            string number, family;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                number = textBox2.Text;
                family = textBox1.Text;
                if (!list.ContainsValue(number) && !list.ContainsKey(family))
                {
                    list.Add(family, number);
                    list1.Add(number, family);
                    listBox1.Items.Add($"{family} {number}");
                }
                else if (list.ContainsKey(family))
                    MessageBox.Show("Уже существует такая фамилия в записной книжке");
                else
                    MessageBox.Show("Данный номер телефона уже есть в записной книжке");
            }
            else
                MessageBox.Show("Заполните оба поля");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string family, number;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                family = textBox1.Text;
                number = textBox2.Text;
                if (list.ContainsKey(family))
                {
                    list.Remove(family);
                    list1.Remove(number);
                    listBox1.Items.Remove($"{family} {number}");
                }
                else
                    MessageBox.Show("Такой фамилии и номера нет в записной книжке");
            }
            else
                MessageBox.Show("Заполните поле фамилия");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number, family = "";
            if (textBox1.Text != "" && textBox2.Text == "")
            {
                family = textBox1.Text;
                if (list.ContainsKey(family))
                    MessageBox.Show($"{list[family]}");
                else
                    MessageBox.Show("Данной фамилии нет в записной книжке");
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                number = textBox2.Text;
                if (list.ContainsValue(number))
                    MessageBox.Show($"{list1[number]}");
                else
                    MessageBox.Show("Данного номера нет в записной книжке");
            }
            else
                MessageBox.Show("Заполните одно из полей");
        }
    }
}