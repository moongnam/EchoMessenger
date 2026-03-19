namespace EchoMessenger
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
            Button Button1;
            label1 = new Label();
            EchoWindow = new ListBox();
            textBox1 = new TextBox();
            label2 = new Label();
            Button1 = new Button();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.BackColor = SystemColors.GradientInactiveCaption;
            Button1.Font = new Font("휴먼엑스포", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Button1.ForeColor = Color.SteelBlue;
            Button1.Location = new Point(610, 372);
            Button1.Name = "Button1";
            Button1.Size = new Size(105, 40);
            Button1.TabIndex = 3;
            Button1.Text = "전송";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("휴먼편지체", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(31, 33);
            label1.Name = "label1";
            label1.Size = new Size(416, 51);
            label1.TabIndex = 0;
            label1.Text = "˚₊‧ Echo Messenger";
            label1.Click += label1_Click;
            // 
            // EchoWindow
            // 
            EchoWindow.BackColor = SystemColors.Window;
            EchoWindow.BorderStyle = BorderStyle.FixedSingle;
            EchoWindow.Font = new Font("함초롬돋움", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            EchoWindow.FormattingEnabled = true;
            EchoWindow.Location = new Point(56, 100);
            EchoWindow.Name = "EchoWindow";
            EchoWindow.Size = new Size(659, 242);
            EchoWindow.TabIndex = 1;
            EchoWindow.SelectedIndexChanged += EchoWindow_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("함초롬돋움", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(56, 372);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(539, 40);
            textBox1.TabIndex = 2;
            textBox1.Text = "이곳에 입력하세요...";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(595, 64);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "메시지 카운팅";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Button1);
            Controls.Add(textBox1);
            Controls.Add(EchoWindow);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox EchoWindow;
        private TextBox textBox1;
        private Button Button1;
        private Label label2;
    }
}
