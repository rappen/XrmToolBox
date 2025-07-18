﻿namespace XrmToolBox.New
{
    partial class MostRecentlyUsedItemControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPlugin = new System.Windows.Forms.Label();
            this.lblConnectionName = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmsMru = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cmsMru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlugin
            // 
            this.lblPlugin.AutoEllipsis = true;
            this.lblPlugin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPlugin.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlugin.Location = new System.Drawing.Point(93, 6);
            this.lblPlugin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlugin.Name = "lblPlugin";
            this.lblPlugin.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblPlugin.Size = new System.Drawing.Size(549, 42);
            this.lblPlugin.TabIndex = 1;
            this.lblPlugin.Text = "[Tool Name]";
            // 
            // lblConnectionName
            // 
            this.lblConnectionName.AutoEllipsis = true;
            this.lblConnectionName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConnectionName.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lblConnectionName.ForeColor = System.Drawing.Color.Gray;
            this.lblConnectionName.Location = new System.Drawing.Point(93, 48);
            this.lblConnectionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionName.Name = "lblConnectionName";
            this.lblConnectionName.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblConnectionName.Size = new System.Drawing.Size(549, 32);
            this.lblConnectionName.TabIndex = 2;
            this.lblConnectionName.Text = "[Connection Name]";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Tool used";
            // 
            // cmsMru
            // 
            this.cmsMru.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsMru.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemove,
            this.toolStripSeparator1,
            this.tsmiRemoveAll});
            this.cmsMru.Name = "cmsMru";
            this.cmsMru.Size = new System.Drawing.Size(315, 70);
            this.cmsMru.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMru_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(311, 6);
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Image = global::XrmToolBox.Properties.Resources.close24;
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(314, 30);
            this.tsmiRemove.Text = "Remove from this list";
            this.tsmiRemove.ToolTipText = "Remove this item from the Most Recently Used items";
            // 
            // tsmiRemoveAll
            // 
            this.tsmiRemoveAll.Image = global::XrmToolBox.Properties.Resources.Eraser24;
            this.tsmiRemoveAll.Name = "tsmiRemoveAll";
            this.tsmiRemoveAll.Size = new System.Drawing.Size(314, 30);
            this.tsmiRemoveAll.Text = "Clear Most Recently Used tools list";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Location = new System.Drawing.Point(13, 6);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(80, 74);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // MostRecentlyUsedItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.cmsMru;
            this.Controls.Add(this.lblConnectionName);
            this.Controls.Add(this.lblPlugin);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Name = "MostRecentlyUsedItemControl";
            this.Padding = new System.Windows.Forms.Padding(13, 6, 0, 6);
            this.Size = new System.Drawing.Size(642, 86);
            this.Load += new System.EventHandler(this.MostRecentlyUsedItemControl_Load);
            this.cmsMru.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblPlugin;
        private System.Windows.Forms.Label lblConnectionName;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip cmsMru;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveAll;
    }
}
