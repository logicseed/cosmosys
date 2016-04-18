﻿namespace IceCreamManager.View
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.RevenueTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.TrucksTab = new System.Windows.Forms.TabPage();
            this.ItemsTab = new System.Windows.Forms.TabPage();
            this.LayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ShowDeletedItems = new System.Windows.Forms.CheckBox();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.EditItemButton = new System.Windows.Forms.Button();
            this.DriversTab = new System.Windows.Forms.TabPage();
            this.RoutesTab = new System.Windows.Forms.TabPage();
            this.CitiesTab = new System.Windows.Forms.TabPage();
            this.ButtonIcons = new System.Windows.Forms.ImageList(this.components);
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExtraButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.MainToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.MainFormLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainTabs.SuspendLayout();
            this.RevenueTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.ItemsTab.SuspendLayout();
            this.LayoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.ExtraButtonsLayout.SuspendLayout();
            this.MainFormLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.RevenueTab);
            this.MainTabs.Controls.Add(this.TrucksTab);
            this.MainTabs.Controls.Add(this.ItemsTab);
            this.MainTabs.Controls.Add(this.DriversTab);
            this.MainTabs.Controls.Add(this.RoutesTab);
            this.MainTabs.Controls.Add(this.CitiesTab);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.ImageList = this.ButtonIcons;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Margin = new System.Windows.Forms.Padding(0);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.Padding = new System.Drawing.Point(8, 8);
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(843, 606);
            this.MainTabs.TabIndex = 0;
            // 
            // RevenueTab
            // 
            this.RevenueTab.Controls.Add(this.tabControl1);
            this.RevenueTab.ImageIndex = 3;
            this.RevenueTab.Location = new System.Drawing.Point(4, 33);
            this.RevenueTab.Name = "RevenueTab";
            this.RevenueTab.Padding = new System.Windows.Forms.Padding(3);
            this.RevenueTab.Size = new System.Drawing.Size(835, 569);
            this.RevenueTab.TabIndex = 0;
            this.RevenueTab.Text = "!Revenue";
            this.RevenueTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(815, 531);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(821, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(821, 537);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(821, 537);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(821, 537);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // TrucksTab
            // 
            this.TrucksTab.ImageIndex = 5;
            this.TrucksTab.Location = new System.Drawing.Point(4, 33);
            this.TrucksTab.Name = "TrucksTab";
            this.TrucksTab.Padding = new System.Windows.Forms.Padding(3);
            this.TrucksTab.Size = new System.Drawing.Size(835, 569);
            this.TrucksTab.TabIndex = 1;
            this.TrucksTab.Text = "!Trucks";
            this.TrucksTab.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.LayoutTable);
            this.ItemsTab.ImageIndex = 2;
            this.ItemsTab.Location = new System.Drawing.Point(4, 33);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTab.Size = new System.Drawing.Size(835, 569);
            this.ItemsTab.TabIndex = 2;
            this.ItemsTab.Text = "!Items";
            this.ItemsTab.UseVisualStyleBackColor = true;
            // 
            // LayoutTable
            // 
            this.LayoutTable.ColumnCount = 4;
            this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutTable.Controls.Add(this.RemoveItemButton, 2, 0);
            this.LayoutTable.Controls.Add(this.ShowDeletedItems, 3, 0);
            this.LayoutTable.Controls.Add(this.ItemGridView, 0, 1);
            this.LayoutTable.Controls.Add(this.AddItemButton, 0, 0);
            this.LayoutTable.Controls.Add(this.EditItemButton, 1, 0);
            this.LayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutTable.Location = new System.Drawing.Point(3, 3);
            this.LayoutTable.Name = "LayoutTable";
            this.LayoutTable.RowCount = 2;
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutTable.Size = new System.Drawing.Size(829, 563);
            this.LayoutTable.TabIndex = 1;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RemoveItemButton.AutoSize = true;
            this.RemoveItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveItemButton.Location = new System.Drawing.Point(165, 3);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Padding = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.RemoveItemButton.Size = new System.Drawing.Size(75, 29);
            this.RemoveItemButton.TabIndex = 2;
            this.RemoveItemButton.Text = "!Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ShowDeletedItems
            // 
            this.ShowDeletedItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ShowDeletedItems.AutoSize = true;
            this.ShowDeletedItems.Checked = true;
            this.ShowDeletedItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowDeletedItems.Location = new System.Drawing.Point(246, 9);
            this.ShowDeletedItems.Name = "ShowDeletedItems";
            this.ShowDeletedItems.Size = new System.Drawing.Size(96, 17);
            this.ShowDeletedItems.TabIndex = 3;
            this.ShowDeletedItems.Text = "!Show Deleted";
            this.ShowDeletedItems.UseVisualStyleBackColor = true;
            this.ShowDeletedItems.CheckedChanged += new System.EventHandler(this.RefreshItemTable);
            // 
            // ItemGridView
            // 
            this.ItemGridView.AllowUserToAddRows = false;
            this.ItemGridView.AllowUserToDeleteRows = false;
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LayoutTable.SetColumnSpan(this.ItemGridView, 4);
            this.ItemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemGridView.Location = new System.Drawing.Point(3, 38);
            this.ItemGridView.MultiSelect = false;
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.ReadOnly = true;
            this.ItemGridView.RowHeadersVisible = false;
            this.ItemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemGridView.Size = new System.Drawing.Size(823, 522);
            this.ItemGridView.TabIndex = 4;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddItemButton.AutoSize = true;
            this.AddItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItemButton.Location = new System.Drawing.Point(3, 3);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Padding = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.AddItemButton.Size = new System.Drawing.Size(75, 29);
            this.AddItemButton.TabIndex = 1;
            this.AddItemButton.Text = "!Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // EditItemButton
            // 
            this.EditItemButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EditItemButton.AutoSize = true;
            this.EditItemButton.Location = new System.Drawing.Point(84, 3);
            this.EditItemButton.Name = "EditItemButton";
            this.EditItemButton.Padding = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.EditItemButton.Size = new System.Drawing.Size(75, 29);
            this.EditItemButton.TabIndex = 0;
            this.EditItemButton.Text = "!Edit";
            this.EditItemButton.UseVisualStyleBackColor = true;
            this.EditItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // DriversTab
            // 
            this.DriversTab.ImageIndex = 1;
            this.DriversTab.Location = new System.Drawing.Point(4, 33);
            this.DriversTab.Name = "DriversTab";
            this.DriversTab.Padding = new System.Windows.Forms.Padding(3);
            this.DriversTab.Size = new System.Drawing.Size(835, 569);
            this.DriversTab.TabIndex = 3;
            this.DriversTab.Text = "!Drivers";
            this.DriversTab.UseVisualStyleBackColor = true;
            // 
            // RoutesTab
            // 
            this.RoutesTab.ImageIndex = 4;
            this.RoutesTab.Location = new System.Drawing.Point(4, 33);
            this.RoutesTab.Name = "RoutesTab";
            this.RoutesTab.Padding = new System.Windows.Forms.Padding(3);
            this.RoutesTab.Size = new System.Drawing.Size(835, 569);
            this.RoutesTab.TabIndex = 4;
            this.RoutesTab.Text = "!Routes";
            this.RoutesTab.UseVisualStyleBackColor = true;
            // 
            // CitiesTab
            // 
            this.CitiesTab.ImageIndex = 0;
            this.CitiesTab.Location = new System.Drawing.Point(4, 33);
            this.CitiesTab.Name = "CitiesTab";
            this.CitiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.CitiesTab.Size = new System.Drawing.Size(835, 569);
            this.CitiesTab.TabIndex = 5;
            this.CitiesTab.Text = "!Cities";
            this.CitiesTab.UseVisualStyleBackColor = true;
            // 
            // ButtonIcons
            // 
            this.ButtonIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ButtonIcons.ImageStream")));
            this.ButtonIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ButtonIcons.Images.SetKeyName(0, "Cities.png");
            this.ButtonIcons.Images.SetKeyName(1, "Drivers.png");
            this.ButtonIcons.Images.SetKeyName(2, "Items.png");
            this.ButtonIcons.Images.SetKeyName(3, "Revenue.png");
            this.ButtonIcons.Images.SetKeyName(4, "Routes.png");
            this.ButtonIcons.Images.SetKeyName(5, "Trucks.png");
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.StatusLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 606);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(843, 25);
            this.StatusBar.TabIndex = 3;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(300, 19);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Image = global::IceCreamManager.Properties.Resources.Progress;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(20, 2, 2, 2);
            this.StatusLabel.Size = new System.Drawing.Size(114, 20);
            this.StatusLabel.Text = "!Processing...";
            // 
            // ExtraButtonsLayout
            // 
            this.ExtraButtonsLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtraButtonsLayout.AutoSize = true;
            this.ExtraButtonsLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExtraButtonsLayout.ColumnCount = 3;
            this.ExtraButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ExtraButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ExtraButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ExtraButtonsLayout.Controls.Add(this.SettingsButton, 0, 0);
            this.ExtraButtonsLayout.Controls.Add(this.LogButton, 1, 0);
            this.ExtraButtonsLayout.Controls.Add(this.AboutButton, 2, 0);
            this.ExtraButtonsLayout.Location = new System.Drawing.Point(745, -2);
            this.ExtraButtonsLayout.Name = "ExtraButtonsLayout";
            this.ExtraButtonsLayout.RowCount = 1;
            this.ExtraButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ExtraButtonsLayout.Size = new System.Drawing.Size(90, 22);
            this.ExtraButtonsLayout.TabIndex = 8;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(4, 0);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(22, 22);
            this.SettingsButton.TabIndex = 7;
            this.MainToolTips.SetToolTip(this.SettingsButton, "!Settings");
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogButton.FlatAppearance.BorderSize = 0;
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.Image = ((System.Drawing.Image)(resources.GetObject("LogButton.Image")));
            this.LogButton.Location = new System.Drawing.Point(34, 0);
            this.LogButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(22, 22);
            this.LogButton.TabIndex = 8;
            this.MainToolTips.SetToolTip(this.LogButton, "!View Log");
            this.LogButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.Location = new System.Drawing.Point(64, 0);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(22, 22);
            this.AboutButton.TabIndex = 9;
            this.MainToolTips.SetToolTip(this.AboutButton, "!About");
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainFormLayout
            // 
            this.MainFormLayout.ColumnCount = 1;
            this.MainFormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainFormLayout.Controls.Add(this.MainTabs, 0, 0);
            this.MainFormLayout.Controls.Add(this.StatusBar, 0, 1);
            this.MainFormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormLayout.Location = new System.Drawing.Point(0, 0);
            this.MainFormLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainFormLayout.Name = "MainFormLayout";
            this.MainFormLayout.RowCount = 2;
            this.MainFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainFormLayout.Size = new System.Drawing.Size(843, 631);
            this.MainFormLayout.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 631);
            this.Controls.Add(this.ExtraButtonsLayout);
            this.Controls.Add(this.MainFormLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "MainForm";
            this.Text = "!Ice Cream Manager";
            this.MainTabs.ResumeLayout(false);
            this.RevenueTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ItemsTab.ResumeLayout(false);
            this.LayoutTable.ResumeLayout(false);
            this.LayoutTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ExtraButtonsLayout.ResumeLayout(false);
            this.MainFormLayout.ResumeLayout(false);
            this.MainFormLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage RevenueTab;
        private System.Windows.Forms.TabPage TrucksTab;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.TabPage ItemsTab;
        private System.Windows.Forms.TabPage DriversTab;
        private System.Windows.Forms.TabPage RoutesTab;
        private System.Windows.Forms.TabPage CitiesTab;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ImageList ButtonIcons;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.TableLayoutPanel ExtraButtonsLayout;
        private System.Windows.Forms.ToolTip MainToolTips;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel MainFormLayout;
        private System.Windows.Forms.TableLayoutPanel LayoutTable;
        protected System.Windows.Forms.Button RemoveItemButton;
        protected System.Windows.Forms.CheckBox ShowDeletedItems;
        public System.Windows.Forms.DataGridView ItemGridView;
        protected System.Windows.Forms.Button AddItemButton;
        protected System.Windows.Forms.Button EditItemButton;
    }
}