namespace chatbot.core
{
    partial class OutGoing
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            msgPanel = new Panel();
            msgCotent = new Label();
            icon = new Panel();
            msgPanel.SuspendLayout();
            SuspendLayout();
            // 
            // msgPanel
            // 
            msgPanel.BackColor = Color.FromArgb(43, 82, 120);
            msgPanel.Controls.Add(msgCotent);
            msgPanel.Location = new Point(37, 17);
            msgPanel.Name = "msgPanel";
            msgPanel.Size = new Size(298, 117);
            msgPanel.TabIndex = 1;
            // 
            // msgCotent
            // 
            msgCotent.ForeColor = Color.White;
            msgCotent.Location = new Point(8, 7);
            msgCotent.Name = "msgCotent";
            msgCotent.Size = new Size(281, 100);
            msgCotent.TabIndex = 0;
            msgCotent.Text = "Hello world!!";
            // 
            // icon
            // 
            icon.Location = new Point(5, 17);
            icon.Name = "icon";
            icon.Size = new Size(26, 26);
            icon.TabIndex = 2;
            // 
            // OutGoing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(icon);
            Controls.Add(msgPanel);
            Name = "OutGoing";
            Size = new Size(514, 150);
            msgPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel msgPanel;
        private Label msgCotent;
        private Panel icon;
    }
}
