namespace vsop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {   
            //��ͤ�������ѡ��
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert str to double
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);
            // int ���������ö + - * / ��
            // doubie / flout �Ţ�ȹ���
            double iResult = iNum1 + iNum2; // �ѧ���� + 
            // ����Ū��� Result
            // �դس���ѵ� text
            result.Text = iResult.ToString(); // .ToString() �ŧ��Ѻ�� str
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert str to double
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);
            double iResuit = iNum1 - iNum2; // �ѧ���� -
            result.Text = iResuit.ToString(); // .ToString() �ŧ��Ѻ�� str
        }
        private void button4_Click(object sender, EventArgs e)
        {

            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert str to double
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);
            double iResuit = iNum1 * iNum2; // �ѧ���� *
            result.Text = iResuit.ToString();// .ToString() �ŧ��Ѻ�� str
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert str to double
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);
            double iResuit = iNum1 / iNum2; // �ѧ���� /
            result.Text = iResuit.ToString();// .ToString() �ŧ��Ѻ�� str
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            //��ҧ��ͤ���� Textbox
            num1.Text = "";
            num2.Text = "";
            result.Text = "";
        }
    }
}
