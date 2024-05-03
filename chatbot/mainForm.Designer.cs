namespace chatbot
{
    partial class mainForm
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
            header = new Panel();
            headerLabel = new Label();
            botIcon = new Panel();
            bottom = new Panel();
            sendIcon = new Panel();
            textInput = new TextBox();
            main = new Panel();
            header.SuspendLayout();
            bottom.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(headerLabel);
            header.Controls.Add(botIcon);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Padding = new Padding(15);
            header.Size = new Size(514, 52);
            header.TabIndex = 0;
            header.Click += header_Click;
            // 
            // headerLabel
            // 
            headerLabel.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(41, 18);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(171, 22);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Chat Bot";
            headerLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // botIcon
            // 
            botIcon.Dock = DockStyle.Left;
            botIcon.Location = new Point(15, 15);
            botIcon.Name = "botIcon";
            botIcon.Size = new Size(22, 22);
            botIcon.TabIndex = 0;
            // 
            // bottom
            // 
            bottom.Controls.Add(sendIcon);
            bottom.Controls.Add(textInput);
            bottom.Dock = DockStyle.Bottom;
            bottom.Location = new Point(0, 556);
            bottom.Name = "bottom";
            bottom.Padding = new Padding(15, 15, 15, 10);
            bottom.Size = new Size(514, 45);
            bottom.TabIndex = 1;
            // 
            // sendIcon
            // 
            sendIcon.Location = new Point(477, 13);
            sendIcon.Name = "sendIcon";
            sendIcon.Size = new Size(22, 20);
            sendIcon.TabIndex = 1;
            sendIcon.Click += sendIcon_Click;
            // 
            // textInput
            // 
            textInput.Dock = DockStyle.Left;
            textInput.Location = new Point(15, 15);
            textInput.Multiline = true;
            textInput.Name = "textInput";
            textInput.Size = new Size(441, 20);
            textInput.TabIndex = 0;
            textInput.TextChanged += textInput_TextChanged;
            textInput.Enter += textInput_Enter;
            textInput.Leave += textInput_Leave;
            // 
            // main
            // 
            main.Location = new Point(0, 52);
            main.Name = "main";
            main.Size = new Size(514, 507);
            main.TabIndex = 2;
            main.Click += main_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 601);
            Controls.Add(main);
            Controls.Add(bottom);
            Controls.Add(header);
            Name = "mainForm";
            Text = "Chat";
            Load += mainForm_Load;
            header.ResumeLayout(false);
            bottom.ResumeLayout(false);
            bottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Panel bottom;
        private Panel main;
        private Label headerLabel;
        private Panel botIcon;
        private TextBox textInput;
        private Panel sendIcon;
    }
}
