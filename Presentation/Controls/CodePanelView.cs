using System;
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
/// Custom panel-like user control to display raw code information.
/// </summary>
[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
public partial class CodePanelView : UserControl {
    public CodePanelView() {
        this.InitializeComponent();
        this.Visible = false;
    }

    public void Render(string contentObject) {
        this.Visible = true;
        this.splitPaneRightCodeBox.Text = contentObject;
    }

    private void CodePanelView_Resize(object sender, EventArgs e) {
        // resize the internal TextBox
        this.splitPaneRightCodeBox.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
    }
}
