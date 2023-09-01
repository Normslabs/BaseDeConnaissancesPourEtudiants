namespace BaseDeConnaissancesEtudiants.Presentation;

partial class HtmlPanelView {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        splitPanelRightWebBox = new WebBrowser();
        this.SuspendLayout();
        // 
        // splitPanelRightWebBox
        // 
        splitPanelRightWebBox.Dock = DockStyle.Fill;
        splitPanelRightWebBox.Location = new Point(0, 0);
        splitPanelRightWebBox.Name = "splitPanelRightWebBox";
        splitPanelRightWebBox.ScrollBarsEnabled = true;
        splitPanelRightWebBox.AllowWebBrowserDrop = false;
        splitPanelRightWebBox.WebBrowserShortcutsEnabled = false;
        splitPanelRightWebBox.Size = new Size(644, 648);
        splitPanelRightWebBox.TabIndex = 0;
        // 
        // HtmlPanelView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.Controls.Add(splitPanelRightWebBox);
        this.Name = "HtmlPanelView";
        this.Size = new Size(644, 648);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private WebBrowser splitPanelRightWebBox;
}
