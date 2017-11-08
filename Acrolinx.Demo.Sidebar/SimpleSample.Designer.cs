﻿/* Copyright (c) 2016 Acrolinx GmbH */

namespace Acrolinx.Demo.Sidebar
{
    partial class SimpleSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleSample));
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.acrolinxSidebar = new Acrolinx.Sdk.Sidebar.AcrolinxSidebar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.MaxLength = 0;
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(618, 373);
            this.textBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelWarning);
            this.panel1.Controls.Add(this.labelMessage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.formatComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 68);
            this.panel1.TabIndex = 3;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(12, 33);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(33, 13);
            this.labelWarning.TabIndex = 6;
            this.labelWarning.Text = "Note:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMessage.Location = new System.Drawing.Point(57, 33);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(546, 26);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = resources.GetString("labelMessage.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Format:";
            // 
            // formatComboBox
            // 
            this.formatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Location = new System.Drawing.Point(60, 3);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(136, 21);
            this.formatComboBox.TabIndex = 3;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 68);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.textBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.acrolinxSidebar);
            this.splitContainer.Size = new System.Drawing.Size(908, 373);
            this.splitContainer.SplitterDistance = 618;
            this.splitContainer.TabIndex = 7;
            // 
            // acrolinxSidebar
            // 
            this.acrolinxSidebar.ClientLocale = "";
            this.acrolinxSidebar.ClientSignature = "SW50ZWdyYXRpb25EZXZlbG9wbWVudERlbW9Pbmx5";
            this.acrolinxSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acrolinxSidebar.Location = new System.Drawing.Point(0, 0);
            this.acrolinxSidebar.MinimumSidebarVersion = "14.4.3";
            this.acrolinxSidebar.Name = "acrolinxSidebar";
            this.acrolinxSidebar.Size = new System.Drawing.Size(286, 373);
            this.acrolinxSidebar.SupportCheckSelection = true;
            this.acrolinxSidebar.TabIndex = 0;
            this.acrolinxSidebar.InitFinished += new Acrolinx.Sdk.Sidebar.SidebarInitFinishedEventHandler(this.acrolinxSidebar_InitFinished);
            this.acrolinxSidebar.SidebarSourceNotReachable += new Acrolinx.Sdk.Sidebar.SidebarSourceNotReachableEventHandler(this.acrolinxSidebar_SidebarSourceNotReachable);
            this.acrolinxSidebar.Checked += new Acrolinx.Sdk.Sidebar.SidebarCheckedEventHandler(this.acrolinxSidebar_Checked);
            this.acrolinxSidebar.RequestCheck += new Acrolinx.Sdk.Sidebar.SidebarCheckRequestedEventHandler(this.acrolinxSidebar_RequestCheck);
            this.acrolinxSidebar.SelectRanges += new Acrolinx.Sdk.Sidebar.SidebarSelectRangesEventHandler(this.acrolinxSidebar_SelectRanges);
            this.acrolinxSidebar.ReplaceRanges += new Acrolinx.Sdk.Sidebar.SidebarReplaceRangesEventHandler(this.acrolinxSidebar_ReplaceRanges);
            // 
            // SimpleSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 441);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleSample";
            this.Text = "Acrolinx Sidebar .NET Simple";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sdk.Sidebar.AcrolinxSidebar acrolinxSidebar;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}