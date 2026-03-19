namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 3. Enter 키 입력을 감지하기 위해 이벤트 핸들러를 연결합니다.
            // 디자인 보기에서 textBox1의 속성창(번개 모양 아이콘) -> KeyDown을 더블클릭해도 됩니다.
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typedText = textBox1.Text;
            EchoWindow.Items.Add(typedText);
            textBox1.Clear();
        }

        private void EchoWindow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
