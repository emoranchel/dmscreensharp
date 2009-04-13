using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DmScreenSharp {
  public class ApplicationControl {
    private PlayersView playersView;
    private DMScreen dmScreen;
    public event FormClosedEventHandler Closing;
    public ApplicationControl(PlayersView playersView, DMScreen dmScreen) {
      this.playersView = playersView;
      this.dmScreen = dmScreen;
      this.dmScreen.FormClosed += new FormClosedEventHandler(dmScreen_FormClosed);
    }

    void dmScreen_FormClosed(object sender, FormClosedEventArgs e) {
      if (Closing != null) {
        Closing(sender, e);
      }
    }

    public void init() {
      dmScreen.Show();
    }

    public void showPlayersView() {
      playersView.Show();
    }

  }
}
