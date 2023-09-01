namespace BaseDeConnaissancesEtudiants.Presentation;

partial class RawTextPanelView {
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
        splitPaneRightTextBox = new TextBox();
        this.SuspendLayout();
        // 
        // splitPaneRightTextBox
        // 
        splitPaneRightTextBox.BackColor = Color.White;
        splitPaneRightTextBox.Dock = DockStyle.Fill;
        splitPaneRightTextBox.ForeColor = Color.Black;
        splitPaneRightTextBox.Location = new Point(0, 0);
        splitPaneRightTextBox.Multiline = true;
        splitPaneRightTextBox.Name = "splitPaneRightTextBox";
        splitPaneRightTextBox.PlaceholderText = "Placeholder";
        splitPaneRightTextBox.ReadOnly = true;
        splitPaneRightTextBox.ScrollBars = ScrollBars.Both;
        splitPaneRightTextBox.Size = new Size(644, 648);
        splitPaneRightTextBox.TabIndex = 0;
        // 
        // RawTextPanelView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.Controls.Add(splitPaneRightTextBox);
        this.Name = "RawTextPanelView";
        this.Size = new Size(644, 648);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private TextBox splitPaneRightTextBox;
}
