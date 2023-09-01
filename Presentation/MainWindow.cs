using BaseDeConnaissancesEtudiants.Business;
using BaseDeConnaissancesEtudiants.Business.Interfaces;
using BaseDeConnaissancesEtudiants.DataAccess.Interfaces;
using BaseDeConnaissancesEtudiants.DataAccess.Models;
using Markdig;
using NSAIL;
using NSAIL.ApplicationComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeConnaissancesEtudiants.Presentation;
public partial class MainWindow : Form, IView {
    public Guid UniqueId { get; private set; }
    public ApplicationComponentType ComponentType { get { return ApplicationComponentType.SERVICE; } }
    public string Discriminant { get; private set; }
    public IApplication ParentApplication { get; private set; }

    private readonly double topPanelHeightPercentage = 0.1;
    private readonly double bottomPanelHeightPercentage = 0.1;


    public MainWindow(IApplication parent) {
        this.UniqueId = Guid.NewGuid();
        this.Discriminant = "MAIN_WINDOW";
        this.ParentApplication = parent;

        this.rawTextContentPanel = new RawTextPanelView();
        this.codeContentPanel = new CodePanelView();
        this.htmlContentPanel = new HtmlPanelView();
        this.InitializeComponent();
        this.mainWindowCenterSplitPanel.Panel2.Controls.Add(this.rawTextContentPanel);
        this.mainWindowCenterSplitPanel.Panel2.Controls.Add(this.codeContentPanel);
        this.mainWindowCenterSplitPanel.Panel2.Controls.Add(this.htmlContentPanel);
    }

    private void MainWindow_Resize(object sender, EventArgs e) {
        this.ResizeFormPanels();
    }

    private void ResizeFormPanels() {
        int topPanelHeight = (int) Math.Ceiling(this.ClientSize.Height * this.topPanelHeightPercentage);
        int bottomPanelHeight = (int) Math.Ceiling(this.ClientSize.Height * this.bottomPanelHeightPercentage);
        int centerPanelHeight = this.ClientSize.Height - (topPanelHeight + bottomPanelHeight);

        // resize panels
        this.mainWindowTopPanel.Size = new Size(this.ClientSize.Width, topPanelHeight);
        this.mainWindowCenterSplitPanel.Size = new Size(this.ClientSize.Width, centerPanelHeight);
        this.mainWindowBottomPanel.Size = new Size(this.ClientSize.Width, bottomPanelHeight);

        // ajust position of the panels
        this.mainWindowCenterSplitPanel.Location = new Point(0, topPanelHeight);
        this.mainWindowBottomPanel.Location = new Point(0, topPanelHeight + centerPanelHeight);

    }


    private void MainWindowTopPanel_Resize(object sender, EventArgs e) {

    }
    private void MainWindowCenterSplitPanel_Resize(object sender, EventArgs e) {

    }

    private void MainWindowBottomPanel_Resize(object sender, EventArgs e) {

    }

    private void MainWindowCenterSplitPanel_Panel1_Resize(object sender, EventArgs e) {
        // Resize the knowledge components list box.
        this.centerSplitPaneLeftListBox.Size = this.mainWindowCenterSplitPanel.Panel1.ClientSize;
    }

    private void MainWindowCenterSplitPanel_Panel2_Resize(object sender, EventArgs e) {
        // Resize the child content panels
        this.rawTextContentPanel.Size = this.mainWindowCenterSplitPanel.Panel2.ClientSize;
        this.codeContentPanel.Size = this.mainWindowCenterSplitPanel.Panel2.ClientSize;
        this.htmlContentPanel.Size = this.mainWindowCenterSplitPanel.Panel2.ClientSize;
    }

    private void BoutonQuitter_Click(object sender, EventArgs e) {
        this.ParentApplication.Terminate();
    }

    private void AboutButton_Click(object sender, EventArgs e) {

    }

    private void CenterSplitPaneLeftListBox_SelectedIndexChanged(object sender, EventArgs e) {
        object selectedItem = this.centerSplitPaneLeftListBox.SelectedItem;
        if (selectedItem is TextKnowledgeComponent component) {
            switch (component.FormatType) {
                case TextFormatEnum.HTML:
                    this.DisplayHtmlComponent(component);
                    break;
                case TextFormatEnum.Markdown:
                    this.DisplayMarkdownComponent(component);
                    break;
                case TextFormatEnum.Code:
                    this.DisplayRawCodeComponent(component);
                    break;
                case TextFormatEnum.RawText:
                default:
                    this.DisplayRawTextComponent(component);
                    break;
            }
        }
    }

    private void DisplayRawTextComponent(TextKnowledgeComponent component) {
        this.htmlContentPanel.Visible = false;
        this.codeContentPanel.Visible = false;
        this.rawTextContentPanel.Render(component.TextContent);
    }

    private void DisplayRawCodeComponent(TextKnowledgeComponent component) {
        this.rawTextContentPanel.Visible = false;
        this.htmlContentPanel.Visible = false;
        this.codeContentPanel.Render(component.TextContent);
    }

    private void DisplayHtmlComponent(TextKnowledgeComponent component) {
        this.rawTextContentPanel.Visible = false;
        this.codeContentPanel.Visible = false;
        this.htmlContentPanel.Render(component.TextContent);
    }

    private void DisplayMarkdownComponent(TextKnowledgeComponent component) {
        string converted = Markdown.ToHtml(component.TextContent);
        this.rawTextContentPanel.Visible = false;
        this.codeContentPanel.Visible = false;
        this.htmlContentPanel.Render(converted);
    }

    public void FillKnowledgeComponentList(List<IKnowledgeComponent> knowledgeComponents) {
        this.centerSplitPaneLeftListBox.ItemHeight = 40;
        this.centerSplitPaneLeftListBox.DataSource = knowledgeComponents;
    }
}
