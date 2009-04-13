using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CombatTracker.Entity;

namespace CombatTracker {
  static class Program {

    private static ApplicationControl control;
    public static ApplicationControl Control { get { return control; } }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Combat combat = new Combat();
      PlayersView playerView = new PlayersView(combat);
      DMScreen dmScreen = new DMScreen(combat);
      control = new ApplicationControl(playerView, dmScreen);
      Control.Closing += new FormClosedEventHandler(formClosed);
      control.init();
      Application.Run();
    }

    static void formClosed(object sender, FormClosedEventArgs e) {
      Application.ExitThread();
    }
  }
}
