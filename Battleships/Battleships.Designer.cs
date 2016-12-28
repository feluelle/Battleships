namespace Battleships
{
    partial class frm_Battleships
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
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleplayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItemSingleplayer = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItemSingleplayer = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItemSingleplayer = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItemSingleplayer = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItemMultiplayer = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItemMultiplayer = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItemMultiplayer = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItemMultiplayer = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfd_Save = new System.Windows.Forms.SaveFileDialog();
            this.ofd_Open = new System.Windows.Forms.OpenFileDialog();
            this.ms_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(425, 24);
            this.ms_Menu.TabIndex = 3;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleplayerToolStripMenuItem,
            this.multiplayerToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // singleplayerToolStripMenuItem
            // 
            this.singleplayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItemSingleplayer,
            this.loadToolStripMenuItemSingleplayer,
            this.saveToolStripMenuItemSingleplayer,
            this.closeToolStripMenuItemSingleplayer});
            this.singleplayerToolStripMenuItem.Name = "singleplayerToolStripMenuItem";
            this.singleplayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.singleplayerToolStripMenuItem.Text = "Singleplayer";
            // 
            // newToolStripMenuItemSingleplayer
            // 
            this.newToolStripMenuItemSingleplayer.Name = "newToolStripMenuItemSingleplayer";
            this.newToolStripMenuItemSingleplayer.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItemSingleplayer.Text = "New";
            this.newToolStripMenuItemSingleplayer.Click += new System.EventHandler(this.newToolStripMenuItemSingleplayer_Click);
            // 
            // loadToolStripMenuItemSingleplayer
            // 
            this.loadToolStripMenuItemSingleplayer.Name = "loadToolStripMenuItemSingleplayer";
            this.loadToolStripMenuItemSingleplayer.Size = new System.Drawing.Size(103, 22);
            this.loadToolStripMenuItemSingleplayer.Text = "Load";
            this.loadToolStripMenuItemSingleplayer.Click += new System.EventHandler(this.loadToolStripMenuItemSingleplayer_Click);
            // 
            // saveToolStripMenuItemSingleplayer
            // 
            this.saveToolStripMenuItemSingleplayer.Name = "saveToolStripMenuItemSingleplayer";
            this.saveToolStripMenuItemSingleplayer.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItemSingleplayer.Text = "Save";
            this.saveToolStripMenuItemSingleplayer.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItemSingleplayer
            // 
            this.closeToolStripMenuItemSingleplayer.Name = "closeToolStripMenuItemSingleplayer";
            this.closeToolStripMenuItemSingleplayer.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItemSingleplayer.Text = "Close";
            this.closeToolStripMenuItemSingleplayer.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // multiplayerToolStripMenuItem
            // 
            this.multiplayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItemMultiplayer,
            this.loadToolStripMenuItemMultiplayer,
            this.saveToolStripMenuItemMultiplayer,
            this.closeToolStripMenuItemMultiplayer});
            this.multiplayerToolStripMenuItem.Name = "multiplayerToolStripMenuItem";
            this.multiplayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.multiplayerToolStripMenuItem.Text = "Multiplayer";
            // 
            // newToolStripMenuItemMultiplayer
            // 
            this.newToolStripMenuItemMultiplayer.Name = "newToolStripMenuItemMultiplayer";
            this.newToolStripMenuItemMultiplayer.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItemMultiplayer.Text = "New";
            this.newToolStripMenuItemMultiplayer.Click += new System.EventHandler(this.newToolStripMenuItemMultiplayer_Click);
            // 
            // loadToolStripMenuItemMultiplayer
            // 
            this.loadToolStripMenuItemMultiplayer.Name = "loadToolStripMenuItemMultiplayer";
            this.loadToolStripMenuItemMultiplayer.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItemMultiplayer.Text = "Load";
            this.loadToolStripMenuItemMultiplayer.Click += new System.EventHandler(this.loadToolStripMenuItemMultiplayer_Click);
            // 
            // saveToolStripMenuItemMultiplayer
            // 
            this.saveToolStripMenuItemMultiplayer.Name = "saveToolStripMenuItemMultiplayer";
            this.saveToolStripMenuItemMultiplayer.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItemMultiplayer.Text = "Save";
            this.saveToolStripMenuItemMultiplayer.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItemMultiplayer
            // 
            this.closeToolStripMenuItemMultiplayer.Name = "closeToolStripMenuItemMultiplayer";
            this.closeToolStripMenuItemMultiplayer.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItemMultiplayer.Text = "Close";
            this.closeToolStripMenuItemMultiplayer.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creationToolStripMenuItem,
            this.startToolStripMenuItem});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // creationToolStripMenuItem
            // 
            this.creationToolStripMenuItem.Name = "creationToolStripMenuItem";
            this.creationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creationToolStripMenuItem.Text = "Creation";
            this.creationToolStripMenuItem.Click += new System.EventHandler(this.creationToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // sfd_Save
            // 
            this.sfd_Save.Filter = "XML-File | *.xml";
            // 
            // ofd_Open
            // 
            this.ofd_Open.Filter = "XML-File | *.xml";
            // 
            // frm_Battleships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 440);
            this.Controls.Add(this.ms_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ms_Menu;
            this.MaximizeBox = false;
            this.Name = "frm_Battleships";
            this.Text = "Battleships";
            this.Load += new System.EventHandler(this.frm_Battleships_Load);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfd_Save;
        private System.Windows.Forms.OpenFileDialog ofd_Open;
        private System.Windows.Forms.ToolStripMenuItem singleplayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItemSingleplayer;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItemSingleplayer;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItemSingleplayer;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItemSingleplayer;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItemMultiplayer;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItemMultiplayer;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItemMultiplayer;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItemMultiplayer;
    }
}

