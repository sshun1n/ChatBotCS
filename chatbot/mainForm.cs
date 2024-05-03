using chatbot.core;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Collections;
using System.Net.WebSockets;
using System.Diagnostics;
using System;
using System.IO;
using System.Text;

namespace chatbot
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ActiveControl = main;

            main.MouseWheel += new MouseEventHandler(ScrollMsg);
        }

        MessageRequest messageRequest = new MessageRequest();
        AppDesign design = new AppDesign();
        OutGoing lstmsg = new OutGoing();

        string output = String.Empty;

        private void mainForm_Load(object sender, EventArgs e)
        {
            header.BackColor = bottom.BackColor = design.TextFieldColor;
            main.BackColor = design.BackGroundColor;
            main.SendToBack();

            headerLabel.ForeColor = design.TextColor;
            headerLabel.Font = design.HeaderFont;

            textInput.BackColor = design.TextFieldColor;
            textInput.ForeColor = design.InactiveTextColor;
            textInput.Text = "¬ведите сообщение сюда...";
            textInput.BorderStyle = BorderStyle.None;

            botIcon.BackgroundImage = Resource.botIcon;
            botIcon.BackgroundImageLayout = ImageLayout.Stretch;

            sendIcon.BackgroundImage = Resource.sendIcon;
            sendIcon.BackgroundImageLayout = ImageLayout.Stretch;
            sendIcon.Cursor = Cursors.Hand;
            sendIcon.Hide();

            AddOutGoing();
        }

        private void AddIncoming(string message)
        {
            var msg = new core.Incoming();
            main.Controls.Add(msg);
            msg.BringToFront();
            msg.Dock = DockStyle.Top;
            msg.Message = message;
        }

        private async void AddOutGoing()
        {
            await Task.Run(async () =>
            {
                await Task.Run(do_python);
                while (this.output == string.Empty)
                {

                }
            });

            var msg = new core.OutGoing();

            main.Controls.Add(msg);
            msg.BringToFront();
            msg.Dock = DockStyle.Top;
            msg.Message = this.output;
            lstmsg = msg;
        }

        private void ScrollMsg(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0 && main.Height < lstmsg.Location.Y + lstmsg.Height + 20)
            {
                int y = main.Location.Y - 25;
                main.Height = main.Height + 25;
                main.Location = new Point(main.Location.X, y);
            }
            else if (e.Delta > 0 && main.Location.Y < 52)
            {
                int y = main.Location.Y + 25;
                main.Height = main.Height - 25;
                main.Location = new Point(main.Location.X, y);
            }
        }

        private void textInput_Enter(object sender, EventArgs e)
        {
            textInput.Text = "";
            textInput.ForeColor = design.TextColor;
        }

        private void textInput_Leave(object sender, EventArgs e)
        {
            textInput.Text = "¬ведите сообщение сюда...";
            textInput.ForeColor = design.InactiveTextColor;
        }

        private void header_Click(object sender, EventArgs e)
        {
            this.ActiveControl = header;
        }

        private void main_Click(object sender, EventArgs e)
        {
            this.ActiveControl = main;
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            if (textInput.Text == string.Empty || textInput.Text == "¬ведите сообщение сюда...")
            {
                sendIcon.Hide();
            }
            else
            {
                sendIcon.Show();
            }
        }

        private void do_python()
        {

            string fileName = @"C:\coding\c#\chatbot\chatbot\core\request.py";
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\stepa\AppData\Local\Programs\Python\Python39\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };


            p.Start();
            this.output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        }

        private void sendIcon_Click(object sender, EventArgs e)
        {
            string request = textInput.Text;
            textInput.Text = "";

            AddIncoming(request);

            messageRequest.UserMessage = request;
            messageRequest.Push();

            AddOutGoing();
        }
    }
}
