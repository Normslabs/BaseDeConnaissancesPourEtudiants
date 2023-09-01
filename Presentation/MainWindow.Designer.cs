namespace BaseDeConnaissancesEtudiants.Presentation;

partial class MainWindow {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
        mainWindowTopPanel = new Panel();
        topPanelTextBox = new TextBox();
        mainWindowBottomPanel = new Panel();
        aboutButton = new Button();
        boutonQuitter = new Button();
        mainWindowCenterSplitPanel = new SplitContainer();
        centerSplitPaneLeftListBox = new ListBox();
        mainWindowTopPanel.SuspendLayout();
        mainWindowBottomPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) mainWindowCenterSplitPanel).BeginInit();
        mainWindowCenterSplitPanel.Panel1.SuspendLayout();
        mainWindowCenterSplitPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // mainWindowTopPanel
        // 
        mainWindowTopPanel.Controls.Add(topPanelTextBox);
        mainWindowTopPanel.Dock = DockStyle.Top;
        mainWindowTopPanel.Location = new Point(0, 0);
        mainWindowTopPanel.MinimumSize = new Size(100, 40);
        mainWindowTopPanel.Name = "mainWindowTopPanel";
        mainWindowTopPanel.Size = new Size(882, 40);
        mainWindowTopPanel.TabIndex = 0;
        mainWindowTopPanel.Resize += this.MainWindowTopPanel_Resize;
        // 
        // topPanelTextBox
        // 
        topPanelTextBox.CharacterCasing = CharacterCasing.Upper;
        topPanelTextBox.Dock = DockStyle.Fill;
        topPanelTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        topPanelTextBox.Location = new Point(0, 0);
        topPanelTextBox.MinimumSize = new Size(100, 40);
        topPanelTextBox.Name = "topPanelTextBox";
        topPanelTextBox.ReadOnly = true;
        topPanelTextBox.Size = new Size(882, 40);
        topPanelTextBox.TabIndex = 0;
        topPanelTextBox.TabStop = false;
        topPanelTextBox.Text = "SÉLECTIONNEZ UNE ENTRÉE DANS LA LISTE À GAUCHE POUR OBTENIR LES EXPLICATIONS DANS LE PANNEAU À DROITE.";
        topPanelTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // mainWindowBottomPanel
        // 
        mainWindowBottomPanel.Controls.Add(aboutButton);
        mainWindowBottomPanel.Controls.Add(boutonQuitter);
        mainWindowBottomPanel.Dock = DockStyle.Bottom;
        mainWindowBottomPanel.Location = new Point(0, 513);
        mainWindowBottomPanel.MinimumSize = new Size(100, 40);
        mainWindowBottomPanel.Name = "mainWindowBottomPanel";
        mainWindowBottomPanel.Size = new Size(882, 40);
        mainWindowBottomPanel.TabIndex = 1;
        mainWindowBottomPanel.Resize += this.MainWindowBottomPanel_Resize;
        // 
        // aboutButton
        // 
        aboutButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
        aboutButton.Location = new Point(12, 6);
        aboutButton.Name = "aboutButton";
        aboutButton.Size = new Size(100, 30);
        aboutButton.TabIndex = 1;
        aboutButton.Text = "A Propos";
        aboutButton.UseVisualStyleBackColor = true;
        aboutButton.Click += this.AboutButton_Click;
        // 
        // boutonQuitter
        // 
        boutonQuitter.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        boutonQuitter.Location = new Point(770, 6);
        boutonQuitter.Name = "boutonQuitter";
        boutonQuitter.Size = new Size(100, 30);
        boutonQuitter.TabIndex = 0;
        boutonQuitter.Text = "Quitter";
        boutonQuitter.UseVisualStyleBackColor = true;
        boutonQuitter.Click += this.BoutonQuitter_Click;
        // 
        // mainWindowCenterSplitPanel
        // 
        mainWindowCenterSplitPanel.Dock = DockStyle.Fill;
        mainWindowCenterSplitPanel.Location = new Point(0, 40);
        mainWindowCenterSplitPanel.Name = "mainWindowCenterSplitPanel";
        // 
        // mainWindowCenterSplitPanel.Panel1
        // 
        mainWindowCenterSplitPanel.Panel1.Controls.Add(centerSplitPaneLeftListBox);
        mainWindowCenterSplitPanel.Panel1.Resize += this.MainWindowCenterSplitPanel_Panel1_Resize;
        mainWindowCenterSplitPanel.Panel1MinSize = 200;
        // 
        // mainWindowCenterSplitPanel.Panel2
        // 
        mainWindowCenterSplitPanel.Panel2.Resize += this.MainWindowCenterSplitPanel_Panel2_Resize;
        mainWindowCenterSplitPanel.Panel2MinSize = 400;
        mainWindowCenterSplitPanel.Size = new Size(882, 473);
        mainWindowCenterSplitPanel.SplitterDistance = 294;
        mainWindowCenterSplitPanel.TabIndex = 2;
        mainWindowCenterSplitPanel.Resize += this.MainWindowCenterSplitPanel_Resize;
        // 
        // centerSplitPaneLeftListBox
        // 
        centerSplitPaneLeftListBox.Dock = DockStyle.Fill;
        centerSplitPaneLeftListBox.FormattingEnabled = true;
        centerSplitPaneLeftListBox.IntegralHeight = false;
        centerSplitPaneLeftListBox.ItemHeight = 20;
        centerSplitPaneLeftListBox.Location = new Point(0, 0);
        centerSplitPaneLeftListBox.Name = "centerSplitPaneLeftListBox";
        centerSplitPaneLeftListBox.ScrollAlwaysVisible = true;
        centerSplitPaneLeftListBox.Size = new Size(294, 473);
        centerSplitPaneLeftListBox.TabIndex = 0;
        centerSplitPaneLeftListBox.SelectedIndexChanged += this.CenterSplitPaneLeftListBox_SelectedIndexChanged;
        // 
        // MainWindow
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(882, 553);
        this.Controls.Add(mainWindowCenterSplitPanel);
        this.Controls.Add(mainWindowBottomPanel);
        this.Controls.Add(mainWindowTopPanel);
        this.Icon = (Icon) resources.GetObject("$this.Icon");
        this.Name = "MainWindow";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Base de connaissances pour étudiants";
        this.WindowState = FormWindowState.Maximized;
        this.Resize += this.MainWindow_Resize;
        mainWindowTopPanel.ResumeLayout(false);
        mainWindowTopPanel.PerformLayout();
        mainWindowBottomPanel.ResumeLayout(false);
        mainWindowCenterSplitPanel.Panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) mainWindowCenterSplitPanel).EndInit();
        mainWindowCenterSplitPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel mainWindowTopPanel;
    private TextBox topPanelTextBox;
    private Panel mainWindowBottomPanel;
    private SplitContainer mainWindowCenterSplitPanel;
    private ListBox centerSplitPaneLeftListBox;
    private RawTextPanelView rawTextContentPanel;
    private CodePanelView codeContentPanel;
    private HtmlPanelView htmlContentPanel;
    private Button boutonQuitter;
    private Button aboutButton;
}