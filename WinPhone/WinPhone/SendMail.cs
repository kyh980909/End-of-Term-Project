using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WinPhone
{
    public partial class SendMail : Form
    {
        SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // gmail smtp 포트번호 
        public SendMail()
        {
            InitializeComponent();          
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (Mail_ID.Text != "" && Mail_PW.Text != "" && Sender_Name.Text != "" && To.Text != "")
            {
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; // SSL 사용 설정
                client.DeliveryMethod = SmtpDeliveryMethod.Network; // 전자메일 지정
                client.Credentials = new System.Net.NetworkCredential(Mail_ID.Text, Mail_PW.Text);      //보내는 사람의 계정을 알아야 보내니깐 인증하는코드
                //MessageBox.Show("잘못된 아이디와 비밀번호 입니다.");
                try
                {
                    MailAddress from = new MailAddress(Mail_ID.Text + "@gmail.com", Sender_Name.Text);  //보내는사람,이름
                    MailAddress to = new MailAddress(To.Text);                //받는사람
                    MailMessage message = new MailMessage(from, to);          //보내는사람, 받는사람
                    message.Body = Context.Text;    // 메일 내용
                    message.Subject = Subject.Text; // 메일 제목 
                    try
                    {
                        client.Send(message);//MailMessage class의 send메소드를 이용해서 실제로 보낸다.

                        message.Dispose(); //자원 해제
                        MessageBox.Show("전송 완료", "완료");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("아이디와 비밀번호가 잘못됬거나\n구글 계정 설정에서 보안 수준이 낮은 앱을 허용하였는지 확인해 주세요.    (https://myaccount.google.com/lesssecureapps)");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("잘못된 이메일 형식입니다. 입력하신 이메일을 다시 확인해 주세요.");
                }            
            }
            else
            {
                MessageBox.Show("모두 입력해주세요!");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();   // Form1폼 클래스 생성
            form1.Visible = true;        // Form1폼을 보이게 함
            Close();
        }
    }
}
