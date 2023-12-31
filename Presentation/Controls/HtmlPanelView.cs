﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeConnaissancesEtudiants.Presentation;

/// <summary>
/// Custom panel-like user control to display HTML pages.
/// </summary>
[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
public partial class HtmlPanelView : UserControl {


    public HtmlPanelView() : base() {
        this.InitializeComponent();
    }

    public void Render(string contentObject) {
        this.Visible = true;
        this.splitPanelRightWebBox.DocumentText = contentObject;
    }

    private void HtmlPanelView_Resize(object sender, EventArgs e) {
        // resize the internal WebBrowser component
        this.splitPanelRightWebBox.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
    }
}
