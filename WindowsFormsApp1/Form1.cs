using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button01.Click += new System.EventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //텍스트박스
            // TextBox에 초기값 할당
            textBox1.Text = "서울특별시 영등포구 신길동 123번지";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("이름 : 홍길동");
            sb.AppendLine("나이 : 27세");
            sb.AppendLine("국적 : 한국");
            textBox2.Text = sb.ToString();

            textBox3.MaxLength = 10;
            textBox4.ReadOnly = true;
            textBox5.PasswordChar = '*';

            textBox3.Text = "서울특별시 영등포구 신길동 123번지";
            textBox4.Text = "서울특별시 영등포구 신길동 123번지";
            textBox5.Text = "서울특별시 영등포구 신길동 123번지";

            //체크박스
            // Checked 상태로 초기화 하기
            checkBox1.Checked = true;
            // Unchecked 상태로 초기화 하기
            checkBox2.Checked = false;
            // Intermediate 상태로 초기화 하기
            // [디자인]에서 오른쪽 마우스 클릭 후 속성에서
            // 모양에서 CheckState에서 Indeterminate 선택

            // Indeterminate에 속한 4번 체크박스 Checked 상태로 초기화
            checkBox4.Checked = true;
            // Indeterminate에 속한 5번 체크박스 Unchecked 상태로 초기화
            checkBox5.Checked = false;
            // checkBox6의 체크상태가 바뀔 때 마다 checkBox6_CheckedChanged 함수를 호출
            checkBox6.CheckStateChanged += checkBox6_CheckedChanged;

            //체크드리스트 박스
            checkedListBox1.Items.Add("기성용" + "\n");
            checkedListBox1.Items.Add("손흥민" + "\n");
            checkedListBox1.Items.Add("이승우" + "\n");
            checkedListBox1.Items.Add("황희찬" + "\n");
            checkedListBox1.Items.Add("조현우" + "\n");
            checkedListBox1.Items.Add("김영권" + "\n");

            //콤보 박스
            string[] data = { "사과", "토마토", "포도", "배", "복숭아" };
            // comboBox1은 Simple
            // comboBox2는 DropDown
            // comboBox3는 DropDownList

            // 각 콤보박스에 데이타를 초기화
            comboBox1.Items.AddRange(data);
            comboBox2.Items.AddRange(data);
            comboBox3.Items.AddRange(data);

            // 처음 선택값 지정. 첫째 아이템 선택
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            // simple 콤보 박스의 목록을 초기화 하고 다시 목록 추가
            /*
            comboBox1.Items.Add("Item 1");
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "1", "2", "3" });
            */


        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            // 텍스트 박스에다가 변경 될 때 마다 변경! 이라고 계속 적기
            textBox1.ReadOnly = true;
            textBox1.Text += " 변경! ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("abc");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("선수를 선택하였습니다");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.csharpstudy.com");
        }
    }
}
