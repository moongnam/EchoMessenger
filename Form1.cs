namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 입력 앞뒤 불필요한 공백 제거
            string typedText = textBox1.Text.Trim();

            if (!string.IsNullOrWhiteSpace(typedText))
            {
                // 현재 시:분:초를 타임스탬프 추가
                string timestamp = DateTime.Now.ToString("[HH:mm:ss]");
                string message = $"{timestamp} {typedText}";

                EchoWindow.Items.Add(message);
                textBox1.Clear();

                // 오른쪽 위 라벨에 대화(메시지) 개수 실시간 업데이트
                label2.Text = $"현재 대화: {EchoWindow.Items.Count}개";
            }

            textBox1.Focus();
        }

        // Enter 키를 눌렀을 때 실행될 코드
        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 엔터키 고유의 '띵' 소리를 방지합니다.
                e.SuppressKeyPress = true;

                // 버튼 클릭 메서드를 직접 호출합니다.
                button1_Click(this, EventArgs.Empty);
            }
        }

        // 크게 사용하지 않는 것들
        private void EchoWindow_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}