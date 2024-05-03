using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatbot.core
{
    public partial class Incoming : UserControl
    {
        public Incoming()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return msgCotent.Text; }
            set { msgCotent.Text = value; AdjustHeight(); }
        }

        void AdjustHeight()
        {
            msgCotent.Height = Utils.GetTextHeight(msgCotent) + 10;
            msgPanel.Height = msgCotent.Height + msgCotent.Top;
            this.Height = msgPanel.Height + 10;
        }

        private void IncomingResize()
        {
            AdjustHeight();
        }
    }
}
