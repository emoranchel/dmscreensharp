using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CombatTracker.Components {
  public class TrimmedPictureBox : PictureBox {
    protected override void OnPaint(PaintEventArgs pe) {
      pe.Graphics.SetClip(new Rectangle(0, 0, this.Width, this.Height / 2));
      base.OnPaint(pe);
    }
  }
}
