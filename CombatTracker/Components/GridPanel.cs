using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CombatTracker.Components {
  class GridPanel : Panel {

    private int gridSize;

    public int GridSize {
      get { return gridSize; }
      set {
        if (this.gridSize == value)
          return;
        this.gridSize = value;
        this.Invalidate();
      }
    }

    protected override void OnPaint(PaintEventArgs e) {
      base.OnPaint(e);
      if (gridSize > 0) {
        for (int i = 0; i < Width; i += gridSize) {
          e.Graphics.DrawLine(Pens.Black, new Point(i, 0), new Point(i, Height));
        }
        for (int i = 0; i < Height; i += gridSize) {
          e.Graphics.DrawLine(Pens.Black, new Point(0, i), new Point(Width, i));
        }
      }
    }
  }
}
