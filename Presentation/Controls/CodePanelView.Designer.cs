namespace BaseDeConnaissancesEtudiants.Presentation;

partial class CodePanelView {
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
        splitPaneRightCodeBox = new TextBox();
        this.SuspendLayout();
        // 
        // splitPaneRightCodeBox
        // 
        splitPaneRightCodeBox.BackColor = Color.Black;
        splitPaneRightCodeBox.Dock = DockStyle.Fill;
        splitPaneRightCodeBox.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
        splitPaneRightCodeBox.ForeColor = Color.PaleGreen;
        splitPaneRightCodeBox.Location = new Point(0, 0);
        splitPaneRightCodeBox.Multiline = true;
        splitPaneRightCodeBox.Name = "splitPaneRightCodeBox";
        splitPaneRightCodeBox.ReadOnly = true;
        splitPaneRightCodeBox.ScrollBars = ScrollBars.Vertical;
        splitPaneRightCodeBox.Size = new Size(644, 648);
        splitPaneRightCodeBox.TabIndex = 0;
        splitPaneRightCodeBox.Text = "<No Data>";
        // 
        // CodePanelView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.Controls.Add(splitPaneRightCodeBox);
        this.Name = "CodePanelView";
        this.Size = new Size(644, 648);
        this.Resize += this.CodePanelView_Resize;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private TextBox splitPaneRightCodeBox;
}
