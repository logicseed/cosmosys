﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamManager.View
{
    public partial class SalesPanel : UserControl
    {
        SalesReportPanel salesReportPanel = new SalesReportPanel();
        SalesToolbar salesToolbar = new SalesToolbar();
        SalesChartPanel salesChartPanel = new SalesChartPanel();

        public SalesPanel()
        {
            InitializeComponent();

            salesChartPanel.Dock = DockStyle.Fill;
            salesReportPanel.Dock = DockStyle.Fill;

            salesToolbarPanel.Add(salesToolbar, 1);
            salesToolbarPanel.Add(salesReportPanel, 2);
        }
    }
}