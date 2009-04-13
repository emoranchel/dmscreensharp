using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DmScreenSharp.Components {
  public partial class DistanceToolip : Form {
    public DistanceToolip() {
      InitializeComponent();
    }
    public string TooltipText {
      get { return label1.Text; }
      set { label1.Text = value; }
    }
  }
}
