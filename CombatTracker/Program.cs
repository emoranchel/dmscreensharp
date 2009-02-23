using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CombatTracker.Entity;

namespace CombatTracker {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Combat combat = new Combat();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      CombatView cv = new CombatView(combat);
      CombatScreen cs = new CombatScreen(combat);
      cs.FormClosed += new FormClosedEventHandler(formClosed);
      cv.FormClosed +=new FormClosedEventHandler(formClosed);
      cs.Show();
      cv.Show();
      Application.Run();
    }

    static void formClosed(object sender, FormClosedEventArgs e) {
      Application.ExitThread();
    }
  }
}
