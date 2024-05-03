namespace chatbot.core
{
    partial class Incoming
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
            msgPanel.SuspendLayout();
            SuspendLayout();
            // 
            // msgPanel
            // 
            msgPanel.BackColor = Color.FromArgb(43, 82, 120);
            msgPanel.Controls.Add(msgCotent);
            msgPanel.Location = new Point(198, 14);
            msgPanel.Name = "msgPanel";
            msgPanel.Size = new Size(298, 35);
            msgPanel.TabIndex = 0;
            // 
            // msgCotent
            // 
            msgCotent.ForeColor = Color.White;
            msgCotent.Location = new Point(11, 9);
            msgCotent.Name = "msgCotent";
            msgCotent.Size = new Size(270, 15);
            msgCotent.TabIndex = 0;
            msgCotent.Text = "Hello world!!";
            // 
            // Incoming
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(msgPanel);
            Name = "Incoming";
            Size = new Size(514, 61);
            msgPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel msgPanel;
        private Label msgCotent;
    }
}
