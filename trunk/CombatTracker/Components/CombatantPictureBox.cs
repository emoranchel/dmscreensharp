using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CombatTracker.Entity;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CombatTracker.Components {
  public class CombatantPictureBox : PictureBox {
    private Combatant combatant;
    private int zoom = 25;
    private CombatantUpdatedModifiedDelegate combatantDelegate;

    public int Zoom {
      get { return zoom; }
      set { value = value < 25 ? 25 : value; this.zoom = value; this.Size = new System.Drawing.Size(zoom, zoom); combatant_Updated(combatant, Combatant.CombatantProperty.ALL); this.Invalidate(); }
    }

    public CombatantPictureBox(Combatant combatant, int pictureSize) {
      this.combatant = combatant;
      this.Name = "pictureBox1";
      this.Size = new System.Drawing.Size(zoom, zoom);
      this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.TabIndex = 4;
      this.TabStop = false;
      this.BackColor = Color.Transparent;
      combatantDelegate = new CombatantUpdatedModifiedDelegate(combatant_Updated);
      combatant.Updated += combatantDelegate;
      combatant_Updated(combatant, Combatant.CombatantProperty.ALL);
    }

    void combatant_Updated(object source, Combatant.CombatantProperty property) {
      if (property == Combatant.CombatantProperty.position || property == Combatant.CombatantProperty.ALL) {
        this.Location = new System.Drawing.Point((combatant.PosX * zoom), (combatant.PosY * zoom));
      }
      if (property == Combatant.CombatantProperty.portrait || property == Combatant.CombatantProperty.ALL) {
        this.Image = combatant.CharacterPortrait;
      }
    }

    public void clean() {
      combatant.Updated -= combatantDelegate;
    }

    private bool mouseDown;
    private Point mouseLocation;
    private Point startLocation;
    private DistanceToolip tooltip = new DistanceToolip();
    protected override void OnMouseDown(MouseEventArgs e) {
      startLocation = this.Location;
      Point p = new Point();
      GetCursorPos(ref p);
      mouseLocation = p;
      mouseDown = true;
      tooltip.Location = new Point(p.X - 10, p.Y - 10 - tooltip.Height);
      tooltip.Show();
    }
    protected override void OnMouseUp(MouseEventArgs e) {
      mouseDown = false;
      Point finalLocation = new Point(this.Location.X, this.Location.Y);
      finalLocation.X += e.X;
      finalLocation.Y += e.Y;
      if (finalLocation.X < 0)
        finalLocation.X = 0;
      if (finalLocation.Y < 0)
        finalLocation.Y = 0;
      combatant.PosX = (finalLocation.X / zoom);
      combatant.PosY = (finalLocation.Y / zoom);
      combatant_Updated(combatant, Combatant.CombatantProperty.position);
      tooltip.Hide();
    }
    protected override void OnMouseMove(MouseEventArgs e) {
      if (mouseDown) {
        Point p = new Point();
        GetCursorPos(ref p);
        double deltaX = p.X - mouseLocation.X;
        double deltaY = p.Y - mouseLocation.Y;
        deltaX = deltaX / zoom;
        deltaY = deltaY / zoom;
        double distance = Math.Sqrt(Math.Pow(deltaY, 2) + Math.Pow(deltaX, 2));
        tooltip.TooltipText = distance.ToString("N02");
        tooltip.Location = new Point(p.X - 10, p.Y - e.Y - tooltip.Height);
        this.Location = new Point(startLocation.X + (p.X - mouseLocation.X), startLocation.Y + (p.Y - mouseLocation.Y));
      }
    }

    [DllImport("user32.dll")]
    static extern bool GetCursorPos(ref Point lpPoint);
  }
}
