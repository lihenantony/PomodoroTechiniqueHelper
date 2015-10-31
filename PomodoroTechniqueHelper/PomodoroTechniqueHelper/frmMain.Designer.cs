namespace PomodoroTechniqueHelper
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnNewStudySession = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.btnViewTaskPool = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.btnReportStudySession = new System.Windows.Forms.RibbonButton();
            this.ReportTask = new System.Windows.Forms.RibbonButton();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.btnAboutThisSoftware = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.btnWatchIntroVideo = new System.Windows.Forms.RibbonButton();
            this.btnViewCompleteGuide = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.btnSetting = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.btnGiveFeedback = new System.Windows.Forms.RibbonButton();
            this.btnSendSmile = new System.Windows.Forms.RibbonButton();
            this.btnSendFrown = new System.Windows.Forms.RibbonButton();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.listboxStudySession = new System.Windows.Forms.ListBox();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Study Session";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.btnNewStudySession);
            this.ribbonPanel1.Text = "Session";
            // 
            // btnNewStudySession
            // 
            this.btnNewStudySession.Image = global::PomodoroTechniqueHelper.Properties.Resources.tomato_torrent2;
            this.btnNewStudySession.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNewStudySession.SmallImage")));
            this.btnNewStudySession.Text = "Start New Study Session";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.btnViewTaskPool);
            this.ribbonPanel2.Text = "Task Pool";
            // 
            // btnViewTaskPool
            // 
            this.btnViewTaskPool.Image = global::PomodoroTechniqueHelper.Properties.Resources.folder_tasks;
            this.btnViewTaskPool.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnViewTaskPool.SmallImage")));
            this.btnViewTaskPool.Text = "View Task Pool";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Panels.Add(this.ribbonPanel3);
            this.ribbonTab2.Text = "Report";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.btnReportStudySession);
            this.ribbonPanel3.Items.Add(this.ReportTask);
            this.ribbonPanel3.Text = "Generate Report";
            // 
            // btnReportStudySession
            // 
            this.btnReportStudySession.Image = global::PomodoroTechniqueHelper.Properties.Resources.document_new_4;
            this.btnReportStudySession.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnReportStudySession.SmallImage")));
            this.btnReportStudySession.Text = "Report For Study Session";
            // 
            // ReportTask
            // 
            this.ReportTask.Image = global::PomodoroTechniqueHelper.Properties.Resources.tasks;
            this.ReportTask.SmallImage = ((System.Drawing.Image)(resources.GetObject("ReportTask.SmallImage")));
            this.ReportTask.Text = "Report For Past Task";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Panels.Add(this.ribbonPanel4);
            this.ribbonTab3.Panels.Add(this.ribbonPanel5);
            this.ribbonTab3.Panels.Add(this.ribbonPanel6);
            this.ribbonTab3.Panels.Add(this.ribbonPanel7);
            this.ribbonTab3.Text = "Tomato";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.btnAboutThisSoftware);
            this.ribbonPanel4.Text = "About";
            // 
            // btnAboutThisSoftware
            // 
            this.btnAboutThisSoftware.Image = global::PomodoroTechniqueHelper.Properties.Resources.help_about_3;
            this.btnAboutThisSoftware.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAboutThisSoftware.SmallImage")));
            this.btnAboutThisSoftware.Text = "About This Software";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.btnWatchIntroVideo);
            this.ribbonPanel5.Items.Add(this.btnViewCompleteGuide);
            this.ribbonPanel5.Text = "Help & Tutorial";
            // 
            // btnWatchIntroVideo
            // 
            this.btnWatchIntroVideo.Image = global::PomodoroTechniqueHelper.Properties.Resources.media_optical_video;
            this.btnWatchIntroVideo.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnWatchIntroVideo.SmallImage")));
            this.btnWatchIntroVideo.Text = "Watch Intro Video";
            // 
            // btnViewCompleteGuide
            // 
            this.btnViewCompleteGuide.Image = global::PomodoroTechniqueHelper.Properties.Resources.help_contents_5;
            this.btnViewCompleteGuide.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnViewCompleteGuide.SmallImage")));
            this.btnViewCompleteGuide.Text = "View Complete Guide";
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.btnSetting);
            this.ribbonPanel6.Text = "Setting";
            // 
            // btnSetting
            // 
            this.btnSetting.Image = global::PomodoroTechniqueHelper.Properties.Resources.system_settings;
            this.btnSetting.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.SmallImage")));
            this.btnSetting.Text = "Setting";
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.btnGiveFeedback);
            this.ribbonPanel7.Items.Add(this.btnSendSmile);
            this.ribbonPanel7.Items.Add(this.btnSendFrown);
            this.ribbonPanel7.Text = "Feedback";
            // 
            // btnGiveFeedback
            // 
            this.btnGiveFeedback.Image = global::PomodoroTechniqueHelper.Properties.Resources.flag_yellow;
            this.btnGiveFeedback.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGiveFeedback.SmallImage")));
            this.btnGiveFeedback.Text = "Give Feedback";
            // 
            // btnSendSmile
            // 
            this.btnSendSmile.Image = global::PomodoroTechniqueHelper.Properties.Resources.face_smirk;
            this.btnSendSmile.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSendSmile.SmallImage")));
            this.btnSendSmile.Text = "Send Smile";
            // 
            // btnSendFrown
            // 
            this.btnSendFrown.Image = global::PomodoroTechniqueHelper.Properties.Resources.face_uncertain;
            this.btnSendFrown.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSendFrown.SmallImage")));
            this.btnSendFrown.Text = "Send Frown";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(13, 161);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            // 
            // listboxStudySession
            // 
            this.listboxStudySession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listboxStudySession.FormattingEnabled = true;
            this.listboxStudySession.Location = new System.Drawing.Point(13, 335);
            this.listboxStudySession.Name = "listboxStudySession";
            this.listboxStudySession.ScrollAlwaysVisible = true;
            this.listboxStudySession.Size = new System.Drawing.Size(227, 147);
            this.listboxStudySession.TabIndex = 2;
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbText = "Tomato";
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.DropDownButtonVisible = false;
            this.ribbon1.QuickAcessToolbar.Enabled = false;
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(718, 149);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "Pomodoro";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.LocalReport.ReportEmbeddedResource = "PomodoroTechniqueHelper.reportSingleStudySession.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(253, 161);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(453, 321);
            this.reportViewer.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 494);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.listboxStudySession);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(734, 533);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Technique Helper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnNewStudySession;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton btnViewTaskPool;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton btnReportStudySession;
        private System.Windows.Forms.RibbonButton ReportTask;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton btnAboutThisSoftware;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton btnWatchIntroVideo;
        private System.Windows.Forms.RibbonButton btnViewCompleteGuide;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton btnSetting;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonButton btnGiveFeedback;
        private System.Windows.Forms.RibbonButton btnSendSmile;
        private System.Windows.Forms.RibbonButton btnSendFrown;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListBox listboxStudySession;
        private System.Windows.Forms.Ribbon ribbon1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}