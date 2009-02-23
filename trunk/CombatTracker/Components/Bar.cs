using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace CombatTracker.Components {
  class Bar : Panel {
    private double value;

    public double Value {
      get { return value; }
      set { this.value = value > 100 ? 100 : value < 0 ? 0 : value; this.Invalidate(); }
    }

    private Color backBar = Color.Black;
    private Color foreBar = Color.Green;

    public Color BackBar {
      get { return backBar; }
      set { backBar = value; }
    }

    public Color ForeBar {
      get { return foreBar; }
      set { foreBar = value; }
    }

    protected override void OnPaint(PaintEventArgs e) {
      Graphics g = e.Graphics;
      g.FillRectangle(new SolidBrush(backBar), new Rectangle(0, 0, Width, Height));
      g.FillRectangle(new SolidBrush(foreBar), new Rectangle(0, 0, (int)(Width * (value / 100.0)), Height));
      base.OnPaint(e);
    }
  }
}
