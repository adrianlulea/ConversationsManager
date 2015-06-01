using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Framework.Data.Conversations;
using Framework.GUI.Controls.Conversations;
using Framework.GUI.Forms.Conversations;
using Framework.Util;

namespace ConversationsManager
{
    /// <summary>
    /// Default program entry.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Framework.GUI.Forms.Conversations.ConversationsManager());
        }
    }
}
