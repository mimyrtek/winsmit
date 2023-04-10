namespace WinSmit
{
    partial class WSMain:ComponentFactory.Krypton.Toolkit.KryptonForm

    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WSMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSmitFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProjectPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.winsmittreecount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menu_opt_BG = new System.ComponentModel.BackgroundWorker();
            this.cmd_opt_BG = new System.ComponentModel.BackgroundWorker();
            this.name_hdr_BG = new System.ComponentModel.BackgroundWorker();
            this.cmd_hdr_BG = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.projectPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.projectTreeView = new WinSmit.WinSmitTreeView();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.winsmitPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.winsmitTreeView = new WinSmit.WinSmitTreeView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.workspace = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.winSmitTreeView1 = new WinSmit.WinSmitTreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sm_menu_opt_page = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.sm_menu_opt_treeView = new System.Windows.Forms.TreeView();
            this.sm_cmd_opt_page = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.sm_treeView = new System.Windows.Forms.TreeView();
            this.sm_cmd_hdr_page = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.sm_name_hdr_page = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonNavigator2 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.kryptonPage3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
            this.kryptonPage4 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.alias_propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectPage)).BeginInit();
            this.projectPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winsmitPage)).BeginInit();
            this.winsmitPage.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workspace)).BeginInit();
            this.workspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sm_menu_opt_page)).BeginInit();
            this.sm_menu_opt_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sm_cmd_opt_page)).BeginInit();
            this.sm_cmd_opt_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sm_cmd_hdr_page)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_name_hdr_page)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator2)).BeginInit();
            this.kryptonNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            this.kryptonPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).BeginInit();
            this.kryptonPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importSmitFileToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newToolStripMenuItem.Text = "&New Project";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openToolStripMenuItem.Text = "&Open Project";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // importSmitFileToolStripMenuItem
            // 
            this.importSmitFileToolStripMenuItem.Name = "importSmitFileToolStripMenuItem";
            this.importSmitFileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.importSmitFileToolStripMenuItem.Text = "Import Smit File";
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(185, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveToolStripMenuItem.Text = "&Save Project";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveAsToolStripMenuItem.Text = "Save Project &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(147, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.testToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProjectPageToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showProjectPageToolStripMenuItem
            // 
            this.showProjectPageToolStripMenuItem.Name = "showProjectPageToolStripMenuItem";
            this.showProjectPageToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.showProjectPageToolStripMenuItem.Text = "Show project page";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.testToolStripMenuItem.Text = "test";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(126, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.winsmittreecount,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // winsmittreecount
            // 
            this.winsmittreecount.Name = "winsmittreecount";
            this.winsmittreecount.Size = new System.Drawing.Size(109, 17);
            this.winsmittreecount.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save_edit.gif");
            this.imageList1.Images.SetKeyName(1, "bbsave.ico");
            this.imageList1.Images.SetKeyName(2, "menu.gif");
            this.imageList1.Images.SetKeyName(3, "option.gif");
            this.imageList1.Images.SetKeyName(4, "comment.png");
            this.imageList1.Images.SetKeyName(5, "menu1.gif");
            this.imageList1.Images.SetKeyName(6, "cmd1.gif");
            this.imageList1.Images.SetKeyName(7, "cmdhdr1.gif");
            this.imageList1.Images.SetKeyName(8, "name1.gif");
            this.imageList1.Images.SetKeyName(9, "alias.gif");
            this.imageList1.Images.SetKeyName(10, "menudialog.gif");
            this.imageList1.Images.SetKeyName(11, "menuinfo.gif");
            this.imageList1.Images.SetKeyName(12, "menumenu.gif");
            this.imageList1.Images.SetKeyName(13, "menuname.gif");
            this.imageList1.Images.SetKeyName(14, "menualiasgif.gif");
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menu_opt_BG
            // 
            this.menu_opt_BG.WorkerReportsProgress = true;
            this.menu_opt_BG.WorkerSupportsCancellation = true;
            this.menu_opt_BG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.menu_opt_BG_DoWork);
            this.menu_opt_BG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.menu_opt_BG_RunWorkerCompleted);
            this.menu_opt_BG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.menu_opt_BG_ProgressChanged);
            // 
            // cmd_opt_BG
            // 
            this.cmd_opt_BG.WorkerReportsProgress = true;
            this.cmd_opt_BG.WorkerSupportsCancellation = true;
            this.cmd_opt_BG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cmd_opt_BG_DoWork);
            this.cmd_opt_BG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.cmd_opt_BG_RunWorkerCompleted);
            this.cmd_opt_BG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.cmd_opt_BG_ProgressChanged);
            // 
            // name_hdr_BG
            // 
            this.name_hdr_BG.WorkerReportsProgress = true;
            this.name_hdr_BG.WorkerSupportsCancellation = true;
            this.name_hdr_BG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.name_hdr_BG_DoWork);
            this.name_hdr_BG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.name_hdr_BG_RunWorkerCompleted);
            this.name_hdr_BG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.name_hdr_BG_ProgressChanged);
            // 
            // cmd_hdr_BG
            // 
            this.cmd_hdr_BG.WorkerReportsProgress = true;
            this.cmd_hdr_BG.WorkerSupportsCancellation = true;
            this.cmd_hdr_BG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cmd_hdr_BG_DoWork);
            this.cmd_hdr_BG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.cmd_hdr_BG_RunWorkerCompleted);
            this.cmd_hdr_BG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.cmd_hdr_BG_ProgressChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator6,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator7,
            this.helpToolStripButton,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.kryptonNavigator1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(792, 502);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 4;
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.SlantEqualFar;
            // 
            // 
            // 
            this.kryptonNavigator1.Button.CloseButton.ExtraText = "";
            this.kryptonNavigator1.Button.CloseButton.Image = null;
            this.kryptonNavigator1.Button.CloseButton.Text = "";
            this.kryptonNavigator1.Button.CloseButton.ToolTipImage = null;
            this.kryptonNavigator1.Button.CloseButton.UniqueName = "7D2324993F3B45907D2324993F3B4590";
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            // 
            // 
            // 
            this.kryptonNavigator1.Button.ContextButton.ExtraText = "";
            this.kryptonNavigator1.Button.ContextButton.Image = null;
            this.kryptonNavigator1.Button.ContextButton.Text = "";
            this.kryptonNavigator1.Button.ContextButton.ToolTipImage = null;
            this.kryptonNavigator1.Button.ContextButton.UniqueName = "132A454359D94E83132A454359D94E83";
            // 
            // 
            // 
            this.kryptonNavigator1.Button.NextButton.ExtraText = "";
            this.kryptonNavigator1.Button.NextButton.Image = null;
            this.kryptonNavigator1.Button.NextButton.Text = "";
            this.kryptonNavigator1.Button.NextButton.ToolTipImage = null;
            this.kryptonNavigator1.Button.NextButton.UniqueName = "2BCF0C66976144522BCF0C6697614452";
            // 
            // 
            // 
            this.kryptonNavigator1.Button.PreviousButton.ExtraText = "";
            this.kryptonNavigator1.Button.PreviousButton.Image = null;
            this.kryptonNavigator1.Button.PreviousButton.Text = "";
            this.kryptonNavigator1.Button.PreviousButton.ToolTipImage = null;
            this.kryptonNavigator1.Button.PreviousButton.UniqueName = "0BDE75F45A2F4B0D0BDE75F45A2F4B0D";
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Header.HeaderValuesPrimary.Description = "";
            this.kryptonNavigator1.Header.HeaderValuesPrimary.Heading = "(Empty)";
            this.kryptonNavigator1.Header.HeaderValuesPrimary.Image = null;
            this.kryptonNavigator1.Header.HeaderValuesSecondary.Description = "";
            this.kryptonNavigator1.Header.HeaderValuesSecondary.Heading = " ";
            this.kryptonNavigator1.Header.HeaderValuesSecondary.Image = null;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator1.Pages.Add(this.projectPage);
            this.kryptonNavigator1.Pages.Add(this.winsmitPage);
            this.kryptonNavigator1.SelectedIndex = 1;
            this.kryptonNavigator1.Size = new System.Drawing.Size(264, 502);
            this.kryptonNavigator1.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator1.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // projectPage
            // 
            this.projectPage.Controls.Add(this.projectTreeView);
            this.projectPage.Controls.Add(this.propertyGrid1);
            this.projectPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.projectPage.Name = "projectPage";
            this.projectPage.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.projectPage.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.projectPage.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.projectPage.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.projectPage.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.projectPage.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.projectPage.Size = new System.Drawing.Size(262, 479);
            this.projectPage.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.projectPage.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.projectPage.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.projectPage.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.projectPage.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.projectPage.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.projectPage.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.projectPage.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.projectPage.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.projectPage.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.projectPage.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.projectPage.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.projectPage.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.projectPage.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.projectPage.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.projectPage.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.projectPage.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.projectPage.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.projectPage.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.projectPage.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.projectPage.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.projectPage.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.projectPage.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.projectPage.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.projectPage.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.projectPage.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.projectPage.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.projectPage.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.projectPage.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.projectPage.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.projectPage.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.projectPage.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.projectPage.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.projectPage.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.projectPage.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.projectPage.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.projectPage.Text = "Projects";
            this.projectPage.ToolTipTitle = "Page ToolTip";
            this.projectPage.UniqueName = "1BA278743CEB4F9B1BA278743CEB4F9B";
            // 
            // projectTreeView
            // 
            this.projectTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTreeView.ImageIndex = 4;
            this.projectTreeView.ImageList = this.imageList1;
            this.projectTreeView.Location = new System.Drawing.Point(0, 0);
            this.projectTreeView.Name = "projectTreeView";
            this.projectTreeView.SelectedImageKey = "comment.png";
            this.projectTreeView.Size = new System.Drawing.Size(262, 248);
            this.projectTreeView.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 248);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(262, 231);
            this.propertyGrid1.TabIndex = 0;
            // 
            // winsmitPage
            // 
            this.winsmitPage.Controls.Add(this.winsmitTreeView);
            this.winsmitPage.Controls.Add(this.toolStrip2);
            this.winsmitPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.winsmitPage.Name = "winsmitPage";
            this.winsmitPage.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.winsmitPage.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.winsmitPage.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.winsmitPage.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.winsmitPage.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.winsmitPage.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.winsmitPage.Size = new System.Drawing.Size(262, 479);
            this.winsmitPage.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.winsmitPage.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.winsmitPage.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.winsmitPage.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.winsmitPage.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.winsmitPage.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.winsmitPage.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.winsmitPage.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.winsmitPage.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.winsmitPage.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.winsmitPage.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.winsmitPage.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.winsmitPage.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.winsmitPage.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.winsmitPage.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.winsmitPage.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.winsmitPage.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.winsmitPage.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.winsmitPage.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.winsmitPage.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.winsmitPage.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.winsmitPage.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.winsmitPage.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.winsmitPage.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.winsmitPage.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.winsmitPage.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.winsmitPage.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.winsmitPage.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.winsmitPage.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.winsmitPage.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.winsmitPage.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.winsmitPage.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.winsmitPage.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.winsmitPage.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.winsmitPage.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.winsmitPage.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.winsmitPage.Text = "WinSmit";
            this.winsmitPage.ToolTipTitle = "Page ToolTip";
            this.winsmitPage.UniqueName = "617E7E6761EC4BCA617E7E6761EC4BCA";
            // 
            // winsmitTreeView
            // 
            this.winsmitTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winsmitTreeView.ImageIndex = 5;
            this.winsmitTreeView.ImageList = this.imageList1;
            this.winsmitTreeView.Location = new System.Drawing.Point(0, 25);
            this.winsmitTreeView.Name = "winsmitTreeView";
            this.winsmitTreeView.SelectedImageIndex = 5;
            this.winsmitTreeView.Size = new System.Drawing.Size(262, 454);
            this.winsmitTreeView.TabIndex = 2;
            this.winsmitTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.winsmitTreeView_AfterSelect_1);
            this.winsmitTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.winsmitTreeView_BeforeSelect);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(262, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(105, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.workspace);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.kryptonNavigator2);
            this.splitContainer2.Size = new System.Drawing.Size(524, 502);
            this.splitContainer2.SplitterDistance = 322;
            this.splitContainer2.TabIndex = 0;
            // 
            // workspace
            // 
            this.workspace.AutoSize = true;
            this.workspace.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.SlantEqualFar;
            // 
            // 
            // 
            this.workspace.Button.CloseButton.ExtraText = "";
            this.workspace.Button.CloseButton.Image = null;
            this.workspace.Button.CloseButton.Text = "";
            this.workspace.Button.CloseButton.ToolTipImage = null;
            this.workspace.Button.CloseButton.UniqueName = "7DD251E05C0140427DD251E05C014042";
            // 
            // 
            // 
            this.workspace.Button.ContextButton.ExtraText = "";
            this.workspace.Button.ContextButton.Image = null;
            this.workspace.Button.ContextButton.Text = "";
            this.workspace.Button.ContextButton.ToolTipImage = null;
            this.workspace.Button.ContextButton.UniqueName = "B740DE0D45904E34B740DE0D45904E34";
            // 
            // 
            // 
            this.workspace.Button.NextButton.ExtraText = "";
            this.workspace.Button.NextButton.Image = null;
            this.workspace.Button.NextButton.Text = "";
            this.workspace.Button.NextButton.ToolTipImage = null;
            this.workspace.Button.NextButton.UniqueName = "8C3B5D260DBF4BFF8C3B5D260DBF4BFF";
            // 
            // 
            // 
            this.workspace.Button.PreviousButton.ExtraText = "";
            this.workspace.Button.PreviousButton.Image = null;
            this.workspace.Button.PreviousButton.Text = "";
            this.workspace.Button.PreviousButton.ToolTipImage = null;
            this.workspace.Button.PreviousButton.UniqueName = "4B622A7A43C14A6F4B622A7A43C14A6F";
            this.workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspace.Header.HeaderValuesPrimary.Description = "";
            this.workspace.Header.HeaderValuesPrimary.Heading = "(Empty)";
            this.workspace.Header.HeaderValuesPrimary.Image = null;
            this.workspace.Header.HeaderValuesSecondary.Description = "";
            this.workspace.Header.HeaderValuesSecondary.Heading = " ";
            this.workspace.Header.HeaderValuesSecondary.Image = null;
            this.workspace.Location = new System.Drawing.Point(0, 0);
            this.workspace.Name = "workspace";
            this.workspace.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.workspace.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.workspace.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.workspace.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.workspace.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.workspace.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.workspace.Pages.Add(this.kryptonPage1);
            this.workspace.Pages.Add(this.sm_menu_opt_page);
            this.workspace.Pages.Add(this.sm_cmd_opt_page);
            this.workspace.Pages.Add(this.sm_cmd_hdr_page);
            this.workspace.Pages.Add(this.sm_name_hdr_page);
            this.workspace.SelectedIndex = 0;
            this.workspace.Size = new System.Drawing.Size(524, 322);
            this.workspace.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.workspace.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.workspace.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.workspace.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.workspace.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.workspace.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.workspace.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.workspace.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.workspace.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.workspace.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.workspace.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.workspace.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.workspace.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.workspace.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.workspace.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.workspace.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.workspace.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.workspace.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.workspace.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.workspace.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.workspace.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.workspace.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.workspace.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.workspace.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.workspace.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.workspace.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.workspace.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.workspace.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.workspace.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.workspace.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.workspace.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.workspace.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.workspace.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.workspace.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.workspace.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.workspace.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.workspace.TabIndex = 0;
            this.workspace.Text = "kryptonNavigator2";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoScroll = true;
            this.kryptonPage1.Controls.Add(this.splitContainer3);
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage1.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage1.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage1.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage1.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage1.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage1.Size = new System.Drawing.Size(522, 299);
            this.kryptonPage1.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage1.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage1.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage1.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage1.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage1.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage1.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage1.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage1.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage1.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage1.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage1.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "590D5F392FCA49EE590D5F392FCA49EE";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.listBox1);
            this.splitContainer3.Size = new System.Drawing.Size(522, 299);
            this.splitContainer3.SplitterDistance = 263;
            this.splitContainer3.TabIndex = 7;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.button7);
            this.splitContainer4.Panel1.Controls.Add(this.button4);
            this.splitContainer4.Panel1.Controls.Add(this.button5);
            this.splitContainer4.Panel1.Controls.Add(this.button2);
            this.splitContainer4.Panel1.Controls.Add(this.button1);
            this.splitContainer4.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer4_Panel1_Paint);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.winSmitTreeView1);
            this.splitContainer4.Size = new System.Drawing.Size(263, 299);
            this.splitContainer4.SplitterDistance = 101;
            this.splitContainer4.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(26, 139);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "sort tree";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "GetEndPoints";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "hide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // winSmitTreeView1
            // 
            this.winSmitTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winSmitTreeView1.Location = new System.Drawing.Point(0, 0);
            this.winSmitTreeView1.Name = "winSmitTreeView1";
            this.winSmitTreeView1.Size = new System.Drawing.Size(158, 299);
            this.winSmitTreeView1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 290);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 7;
            // 
            // sm_menu_opt_page
            // 
            this.sm_menu_opt_page.Controls.Add(this.sm_menu_opt_treeView);
            this.sm_menu_opt_page.MinimumSize = new System.Drawing.Size(50, 50);
            this.sm_menu_opt_page.Name = "sm_menu_opt_page";
            this.sm_menu_opt_page.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.Size = new System.Drawing.Size(522, 299);
            this.sm_menu_opt_page.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_menu_opt_page.Text = "sm_menu_opt";
            this.sm_menu_opt_page.ToolTipTitle = "Page ToolTip";
            this.sm_menu_opt_page.UniqueName = "771D3DA1FF82437F771D3DA1FF82437F";
            // 
            // sm_menu_opt_treeView
            // 
            this.sm_menu_opt_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sm_menu_opt_treeView.ImageIndex = 5;
            this.sm_menu_opt_treeView.ImageList = this.imageList1;
            this.sm_menu_opt_treeView.Location = new System.Drawing.Point(0, 0);
            this.sm_menu_opt_treeView.Name = "sm_menu_opt_treeView";
            this.sm_menu_opt_treeView.SelectedImageIndex = 5;
            this.sm_menu_opt_treeView.Size = new System.Drawing.Size(522, 299);
            this.sm_menu_opt_treeView.TabIndex = 0;
            this.sm_menu_opt_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.sm_menu_opt_treeView_AfterSelect);
            // 
            // sm_cmd_opt_page
            // 
            this.sm_cmd_opt_page.Controls.Add(this.sm_treeView);
            this.sm_cmd_opt_page.MinimumSize = new System.Drawing.Size(50, 50);
            this.sm_cmd_opt_page.Name = "sm_cmd_opt_page";
            this.sm_cmd_opt_page.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.Size = new System.Drawing.Size(522, 299);
            this.sm_cmd_opt_page.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_opt_page.Text = "sm_cmd_opt";
            this.sm_cmd_opt_page.ToolTipTitle = "Page ToolTip";
            this.sm_cmd_opt_page.UniqueName = "DAC7ED5EC19342A5DAC7ED5EC19342A5";
            // 
            // sm_treeView
            // 
            this.sm_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sm_treeView.ImageIndex = 6;
            this.sm_treeView.ImageList = this.imageList1;
            this.sm_treeView.Location = new System.Drawing.Point(0, 0);
            this.sm_treeView.Name = "sm_treeView";
            this.sm_treeView.SelectedImageIndex = 6;
            this.sm_treeView.Size = new System.Drawing.Size(522, 299);
            this.sm_treeView.TabIndex = 0;
            // 
            // sm_cmd_hdr_page
            // 
            this.sm_cmd_hdr_page.MinimumSize = new System.Drawing.Size(50, 50);
            this.sm_cmd_hdr_page.Name = "sm_cmd_hdr_page";
            this.sm_cmd_hdr_page.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.Size = new System.Drawing.Size(522, 299);
            this.sm_cmd_hdr_page.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_cmd_hdr_page.Text = "sm_cmd_hdr";
            this.sm_cmd_hdr_page.ToolTipTitle = "Page ToolTip";
            this.sm_cmd_hdr_page.UniqueName = "88F947C8404642A588F947C8404642A5";
            // 
            // sm_name_hdr_page
            // 
            this.sm_name_hdr_page.MinimumSize = new System.Drawing.Size(50, 50);
            this.sm_name_hdr_page.Name = "sm_name_hdr_page";
            this.sm_name_hdr_page.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.Size = new System.Drawing.Size(522, 299);
            this.sm_name_hdr_page.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.sm_name_hdr_page.Text = "sm_name_hdr";
            this.sm_name_hdr_page.ToolTipTitle = "Page ToolTip";
            this.sm_name_hdr_page.UniqueName = "3D2AE36E8E0046BC3D2AE36E8E0046BC";
            // 
            // kryptonNavigator2
            // 
            // 
            // 
            // 
            this.kryptonNavigator2.Button.CloseButton.ExtraText = "";
            this.kryptonNavigator2.Button.CloseButton.Image = null;
            this.kryptonNavigator2.Button.CloseButton.Text = "";
            this.kryptonNavigator2.Button.CloseButton.ToolTipImage = null;
            this.kryptonNavigator2.Button.CloseButton.UniqueName = "3664300BABAD4C043664300BABAD4C04";
            // 
            // 
            // 
            this.kryptonNavigator2.Button.ContextButton.ExtraText = "";
            this.kryptonNavigator2.Button.ContextButton.Image = null;
            this.kryptonNavigator2.Button.ContextButton.Text = "";
            this.kryptonNavigator2.Button.ContextButton.ToolTipImage = null;
            this.kryptonNavigator2.Button.ContextButton.UniqueName = "D2201EEC71194D4DD2201EEC71194D4D";
            // 
            // 
            // 
            this.kryptonNavigator2.Button.NextButton.ExtraText = "";
            this.kryptonNavigator2.Button.NextButton.Image = null;
            this.kryptonNavigator2.Button.NextButton.Text = "";
            this.kryptonNavigator2.Button.NextButton.ToolTipImage = null;
            this.kryptonNavigator2.Button.NextButton.UniqueName = "3FB5A36EABD84C6D3FB5A36EABD84C6D";
            // 
            // 
            // 
            this.kryptonNavigator2.Button.PreviousButton.ExtraText = "";
            this.kryptonNavigator2.Button.PreviousButton.Image = null;
            this.kryptonNavigator2.Button.PreviousButton.Text = "";
            this.kryptonNavigator2.Button.PreviousButton.ToolTipImage = null;
            this.kryptonNavigator2.Button.PreviousButton.UniqueName = "D5A3691A71294A5DD5A3691A71294A5D";
            this.kryptonNavigator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator2.Header.HeaderValuesPrimary.Description = "";
            this.kryptonNavigator2.Header.HeaderValuesPrimary.Heading = "(Empty)";
            this.kryptonNavigator2.Header.HeaderValuesPrimary.Image = null;
            this.kryptonNavigator2.Header.HeaderValuesSecondary.Description = "";
            this.kryptonNavigator2.Header.HeaderValuesSecondary.Heading = " ";
            this.kryptonNavigator2.Header.HeaderValuesSecondary.Image = null;
            this.kryptonNavigator2.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator2.Name = "kryptonNavigator2";
            this.kryptonNavigator2.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator2.Pages.Add(this.kryptonPage2);
            this.kryptonNavigator2.Pages.Add(this.kryptonPage3);
            this.kryptonNavigator2.Pages.Add(this.kryptonPage4);
            this.kryptonNavigator2.SelectedIndex = 1;
            this.kryptonNavigator2.Size = new System.Drawing.Size(524, 176);
            this.kryptonNavigator2.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonNavigator2.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonNavigator2.TabIndex = 0;
            this.kryptonNavigator2.Text = "kryptonNavigator2";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.Controls.Add(this.button6);
            this.kryptonPage2.Controls.Add(this.button3);
            this.kryptonPage2.Controls.Add(this.kryptonLabel4);
            this.kryptonPage2.Controls.Add(this.kryptonLabel3);
            this.kryptonPage2.Controls.Add(this.kryptonLabel2);
            this.kryptonPage2.Controls.Add(this.kryptonLabel1);
            this.kryptonPage2.Controls.Add(this.progressBar4);
            this.kryptonPage2.Controls.Add(this.progressBar3);
            this.kryptonPage2.Controls.Add(this.progressBar2);
            this.kryptonPage2.Controls.Add(this.progressBar1);
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage2.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage2.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage2.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage2.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage2.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage2.Size = new System.Drawing.Size(522, 152);
            this.kryptonPage2.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage2.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage2.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage2.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage2.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage2.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage2.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage2.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage2.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage2.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage2.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage2.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "D9BBB975C4F44B85D9BBB975C4F44B85";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(152, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "fill sm_menu_opt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(15, 75);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(75, 19);
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Text = "sm_cmd_hdr";
            this.kryptonLabel4.Values.ExtraText = "";
            this.kryptonLabel4.Values.Image = null;
            this.kryptonLabel4.Values.Text = "sm_cmd_hdr";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(15, 54);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(82, 19);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Text = "sm_name_hdr";
            this.kryptonLabel3.Values.ExtraText = "";
            this.kryptonLabel3.Values.Image = null;
            this.kryptonLabel3.Values.Text = "sm_name_hdr";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 33);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(74, 19);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Text = "sm_cmd_opt";
            this.kryptonLabel2.Values.ExtraText = "";
            this.kryptonLabel2.Values.Image = null;
            this.kryptonLabel2.Values.Text = "sm_cmd_opt";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(81, 19);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Text = "sm_menu_opt";
            this.kryptonLabel1.Values.ExtraText = "";
            this.kryptonLabel1.Values.Image = null;
            this.kryptonLabel1.Values.Text = "sm_menu_opt";
            // 
            // progressBar4
            // 
            this.progressBar4.ForeColor = System.Drawing.Color.Purple;
            this.progressBar4.Location = new System.Drawing.Point(101, 79);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(400, 15);
            this.progressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar4.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.Color.Purple;
            this.progressBar3.Location = new System.Drawing.Point(101, 58);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(400, 15);
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar3.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.Purple;
            this.progressBar2.Location = new System.Drawing.Point(101, 37);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(400, 15);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Purple;
            this.progressBar1.Location = new System.Drawing.Point(101, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 15);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.Controls.Add(this.propertyGrid2);
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage3.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage3.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage3.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage3.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage3.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage3.Size = new System.Drawing.Size(522, 152);
            this.kryptonPage3.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage3.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage3.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage3.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage3.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage3.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage3.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage3.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage3.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage3.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage3.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage3.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage3.Text = "kryptonPage3";
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "DBD76F91A8AA4C55DBD76F91A8AA4C55";
            // 
            // propertyGrid2
            // 
            this.propertyGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid2.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid2.Name = "propertyGrid2";
            this.propertyGrid2.Size = new System.Drawing.Size(522, 152);
            this.propertyGrid2.TabIndex = 0;
            // 
            // kryptonPage4
            // 
            this.kryptonPage4.Controls.Add(this.alias_propertyGrid);
            this.kryptonPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage4.Name = "kryptonPage4";
            this.kryptonPage4.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage4.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage4.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage4.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage4.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage4.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage4.Size = new System.Drawing.Size(522, 152);
            this.kryptonPage4.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage4.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage4.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage4.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage4.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage4.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage4.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage4.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage4.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage4.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage4.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty;
            this.kryptonPage4.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty;
            this.kryptonPage4.Text = "kryptonPage4";
            this.kryptonPage4.ToolTipTitle = "Page ToolTip";
            this.kryptonPage4.UniqueName = "033893FF0DCB426C033893FF0DCB426C";
            // 
            // alias_propertyGrid
            // 
            this.alias_propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alias_propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.alias_propertyGrid.Name = "alias_propertyGrid";
            this.alias_propertyGrid.Size = new System.Drawing.Size(522, 152);
            this.alias_propertyGrid.TabIndex = 0;
            // 
            // WSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WSMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinSmit";
            this.Load += new System.EventHandler(this.WSMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectPage)).EndInit();
            this.projectPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.winsmitPage)).EndInit();
            this.winsmitPage.ResumeLayout(false);
            this.winsmitPage.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workspace)).EndInit();
            this.workspace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sm_menu_opt_page)).EndInit();
            this.sm_menu_opt_page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sm_cmd_opt_page)).EndInit();
            this.sm_cmd_opt_page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sm_cmd_hdr_page)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_name_hdr_page)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator2)).EndInit();
            this.kryptonNavigator2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            this.kryptonPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            this.kryptonPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).EndInit();
            this.kryptonPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProjectPageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importSmitFileToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker menu_opt_BG;
        private System.ComponentModel.BackgroundWorker cmd_opt_BG;
        private System.ComponentModel.BackgroundWorker name_hdr_BG;
        private System.ComponentModel.BackgroundWorker cmd_hdr_BG;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage projectPage;
        private WinSmitTreeView projectTreeView;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private ComponentFactory.Krypton.Navigator.KryptonPage winsmitPage;
        private WinSmitTreeView winsmitTreeView;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator workspace;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage sm_menu_opt_page;
        private System.Windows.Forms.TreeView sm_menu_opt_treeView;
        private ComponentFactory.Krypton.Navigator.KryptonPage sm_cmd_opt_page;
        private System.Windows.Forms.TreeView sm_treeView;
        private ComponentFactory.Krypton.Navigator.KryptonPage sm_cmd_hdr_page;
        private ComponentFactory.Krypton.Navigator.KryptonPage sm_name_hdr_page;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator2;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PropertyGrid propertyGrid2;
        private System.Windows.Forms.ToolStripStatusLabel winsmittreecount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private WinSmitTreeView winSmitTreeView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button6;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage4;
        private System.Windows.Forms.PropertyGrid alias_propertyGrid;
        private System.Windows.Forms.Button button7;
    }
}

