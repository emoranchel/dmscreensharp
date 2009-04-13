using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CombatTracker.Entity;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CombatTracker.Components {
  public abstract class CombatantPictureBox : PictureBox {
    protected Combatant combatant;
    protected int zoom = 25;
    private CombatantUpdatedModifiedDelegate combatantDelegate;

    public int Zoom {
      get { return zoom; }
      set {
        value = value < 25 ? 25 : value;
        this.zoom = value;
        this.Size = new System.Drawing.Size(zoom, zoom);
        combatant_Updated(combatant, Combatant.CombatantProperty.position);
        combatant_Updated(combatant, Combatant.CombatantProperty.size);
        this.Invalidate();
      }
    }

    public CombatantPictureBox(Combatant combatant, int pictureSize) {
      this.combatant = combatant;
      this.Name = "pictureBox1";
      this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.TabIndex = 4;
      this.TabStop = false;
      this.BackColor = Color.Transparent;
      combatantDelegate = new CombatantUpdatedModifiedDelegate(combatant_Updated);
      combatant.Updated += combatantDelegate;
      combatant_Updated(combatant, Combatant.CombatantProperty.portrait);
      combatant_Updated(combatant, Combatant.CombatantProperty.position);
      combatant_Updated(combatant, Combatant.CombatantProperty.size);
      this.Zoom = pictureSize;
    }

    void combatant_Updated(object source, Combatant.CombatantProperty property) {
      if (property == Combatant.CombatantProperty.position) {
        if (Parent == null || !(Parent is Panel)) {
          this.Location = new System.Drawing.Point((combatant.Position.X * zoom), (combatant.Position.Y * zoom));
        } else {
          Panel parent = (Panel)Parent;
          this.Location = new System.Drawing.Point((combatant.Position.X * zoom) + parent.AutoScrollPosition.X, (combatant.Position.Y * zoom) + parent.AutoScrollPosition.Y);
        }
      }
      if (property == Combatant.CombatantProperty.portrait) {
        this.Image = combatant.CharacterPortrait;
      }
      if (property == Combatant.CombatantProperty.size) {
        this.Size = new Size(combatant.Size.Width * zoom, combatant.Size.Height * zoom);
      }
    }

    public virtual void clean() {
      combatant.Updated -= combatantDelegate;
    }

    private bool mouseDown;
    private Point mouseLocation;
    private Point startDragLocation;
    private Point startLocation;
    private DistanceToolip tooltip = new DistanceToolip();
    protected override void OnMouseDown(MouseEventArgs e) {
      startDragLocation = this.Location;
      startLocation = getLocation(this.Location);
      Point p = new Point();
      GetCursorPos(ref p);
      mouseLocation = p;
      mouseDown = true;
      //DEBUG
      Console.WriteLine("StartDrag at:" + startDragLocation);
      //show tooltip
      tooltip.Location = new Point(p.X - 10, p.Y - 10 - tooltip.Height);
      tooltip.Show();
    }

    private Point getLocation(Point point) {
      if (Parent == null || !(Parent is Panel)) {
        return point;
      }
      Panel parent = (Panel)Parent;
      return new Point(point.X - parent.AutoScrollPosition.X, point.Y - parent.AutoScrollPosition.Y);
    }
    protected override void OnMouseUp(MouseEventArgs e) {
      mouseDown = false;
      Point p = new Point();
      GetCursorPos(ref p);
      Point finalLocation = new Point(startLocation.X + (p.X - mouseLocation.X), startLocation.Y + (p.Y - mouseLocation.Y));
      if (finalLocation.X < 0)
        finalLocation.X = 0;
      if (finalLocation.Y < 0)
        finalLocation.Y = 0;
      Point newCombatant = new Point((int)Math.Round((double)finalLocation.X / zoom), (int)Math.Round((double)finalLocation.Y / zoom));
      if (newCombatant != combatant.Position) {
        combatant.Position = newCombatant;
      } else {
        combatant_Updated(combatant, Combatant.CombatantProperty.position);
      }
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
        this.Location = new Point(startDragLocation.X + (p.X - mouseLocation.X), startDragLocation.Y + (p.Y - mouseLocation.Y));
      }
    }

    [DllImport("user32.dll")]
    static extern bool GetCursorPos(ref Point lpPoint);
  }

  public class CombatantPictureDM : CombatantPictureBox {
    public CombatantPictureDM(Combatant combatant, int pictureSize) : base(combatant, pictureSize) { }
  }
  public class CombatantPictureView : CombatantPictureBox {
    CombatantUpdatedModifiedDelegate combatantDelegate;
    public CombatantPictureView(Combatant combatant, int pictureSize) : base(combatant, pictureSize) {
      combatantDelegate = new CombatantUpdatedModifiedDelegate(combatant_Updated);
      combatant.Updated += combatantDelegate;
      combatant_Updated(combatant, Combatant.CombatantProperty.visible);
    }

    private void combatant_Updated(Combatant source, Combatant.CombatantProperty property) {
      if (property == Combatant.CombatantProperty.visible) {
        this.Visible = source.Visible;
      }
    }
    public override void clean() {
      base.clean();
      combatant.Updated -= combatantDelegate;
    }
  }
}
