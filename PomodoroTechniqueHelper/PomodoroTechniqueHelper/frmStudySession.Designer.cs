namespace PomodoroTechniqueHelper
{
    partial class frmStudySession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudySession));
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.lblCurrentTaskName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.btnInterruption = new System.Windows.Forms.Button();
            this.btnNewUnplannedTask = new System.Windows.Forms.Button();
            this.btnTaskList = new System.Windows.Forms.Button();
            this.lblCompleteTomato = new System.Windows.Forms.Label();
            this.lblIncompleteTomato = new System.Windows.Forms.Label();
            this.lblInterruption = new System.Windows.Forms.Label();
            this.lblUnplannedTaskAdded = new System.Windows.Forms.Label();
            this.lblInQueueTask = new System.Windows.Forms.Label();
            this.lblCompleteTask = new System.Windows.Forms.Label();
            this.lblAbandonedTask = new System.Windows.Forms.Label();
            this.lblSkippedTask = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblNextTask = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemainingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingTime.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingTime.Location = new System.Drawing.Point(3, 131);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(286, 80);
            this.lblRemainingTime.TabIndex = 0;
            this.lblRemainingTime.Text = "00:00";
            this.lblRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentTaskName
            // 
            this.lblCurrentTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTaskName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTaskName.Location = new System.Drawing.Point(3, 1);
            this.lblCurrentTaskName.Name = "lblCurrentTaskName";
            this.lblCurrentTaskName.Size = new System.Drawing.Size(286, 65);
            this.lblCurrentTaskName.TabIndex = 1;
            this.lblCurrentTaskName.Text = "Current Task Name";
            this.lblCurrentTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(341, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Complete Tomato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(333, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Incomplete Tomato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(310, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unplanned Task Added:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(377, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Interruption:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(352, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Completed Task:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(364, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "In Queue Task:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(369, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Skipped Task:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(348, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Abandoned Task:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PomodoroTechniqueHelper.Properties.Resources.tomato_torrent1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblCurrentStatus);
            this.panel1.Controls.Add(this.btnInterruption);
            this.panel1.Controls.Add(this.btnNewUnplannedTask);
            this.panel1.Controls.Add(this.lblRemainingTime);
            this.panel1.Controls.Add(this.lblCurrentTaskName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 258);
            this.panel1.TabIndex = 11;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.Location = new System.Drawing.Point(3, 66);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(286, 65);
            this.lblCurrentStatus.TabIndex = 4;
            this.lblCurrentStatus.Text = "Studying...";
            this.lblCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInterruption
            // 
            this.btnInterruption.BackColor = System.Drawing.Color.Transparent;
            this.btnInterruption.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInterruption.FlatAppearance.BorderSize = 0;
            this.btnInterruption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInterruption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInterruption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterruption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterruption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInterruption.Image = global::PomodoroTechniqueHelper.Properties.Resources.tools_report_bug;
            this.btnInterruption.Location = new System.Drawing.Point(152, 214);
            this.btnInterruption.Name = "btnInterruption";
            this.btnInterruption.Size = new System.Drawing.Size(137, 41);
            this.btnInterruption.TabIndex = 3;
            this.btnInterruption.Text = "Interruption";
            this.btnInterruption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInterruption.UseVisualStyleBackColor = false;
            // 
            // btnNewUnplannedTask
            // 
            this.btnNewUnplannedTask.BackColor = System.Drawing.Color.Transparent;
            this.btnNewUnplannedTask.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewUnplannedTask.FlatAppearance.BorderSize = 0;
            this.btnNewUnplannedTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewUnplannedTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewUnplannedTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUnplannedTask.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUnplannedTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewUnplannedTask.Image = global::PomodoroTechniqueHelper.Properties.Resources.list_add_3;
            this.btnNewUnplannedTask.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewUnplannedTask.Location = new System.Drawing.Point(3, 214);
            this.btnNewUnplannedTask.Name = "btnNewUnplannedTask";
            this.btnNewUnplannedTask.Size = new System.Drawing.Size(137, 41);
            this.btnNewUnplannedTask.TabIndex = 2;
            this.btnNewUnplannedTask.Text = "New Unplanned Task";
            this.btnNewUnplannedTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewUnplannedTask.UseVisualStyleBackColor = false;
            // 
            // btnTaskList
            // 
            this.btnTaskList.BackColor = System.Drawing.Color.Transparent;
            this.btnTaskList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTaskList.FlatAppearance.BorderSize = 0;
            this.btnTaskList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTaskList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTaskList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTaskList.Image = global::PomodoroTechniqueHelper.Properties.Resources.tasks;
            this.btnTaskList.Location = new System.Drawing.Point(465, 229);
            this.btnTaskList.Name = "btnTaskList";
            this.btnTaskList.Size = new System.Drawing.Size(98, 41);
            this.btnTaskList.TabIndex = 6;
            this.btnTaskList.Text = "Task List";
            this.btnTaskList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaskList.UseVisualStyleBackColor = false;
            // 
            // lblCompleteTomato
            // 
            this.lblCompleteTomato.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCompleteTomato.Location = new System.Drawing.Point(462, 9);
            this.lblCompleteTomato.Name = "lblCompleteTomato";
            this.lblCompleteTomato.Size = new System.Drawing.Size(101, 17);
            this.lblCompleteTomato.TabIndex = 12;
            this.lblCompleteTomato.Text = "Abandoned Task:";
            // 
            // lblIncompleteTomato
            // 
            this.lblIncompleteTomato.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblIncompleteTomato.Location = new System.Drawing.Point(462, 26);
            this.lblIncompleteTomato.Name = "lblIncompleteTomato";
            this.lblIncompleteTomato.Size = new System.Drawing.Size(101, 17);
            this.lblIncompleteTomato.TabIndex = 13;
            this.lblIncompleteTomato.Text = "Abandoned Task:";
            // 
            // lblInterruption
            // 
            this.lblInterruption.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblInterruption.Location = new System.Drawing.Point(462, 60);
            this.lblInterruption.Name = "lblInterruption";
            this.lblInterruption.Size = new System.Drawing.Size(101, 17);
            this.lblInterruption.TabIndex = 15;
            this.lblInterruption.Text = "Abandoned Task:";
            // 
            // lblUnplannedTaskAdded
            // 
            this.lblUnplannedTaskAdded.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUnplannedTaskAdded.Location = new System.Drawing.Point(462, 43);
            this.lblUnplannedTaskAdded.Name = "lblUnplannedTaskAdded";
            this.lblUnplannedTaskAdded.Size = new System.Drawing.Size(101, 17);
            this.lblUnplannedTaskAdded.TabIndex = 14;
            this.lblUnplannedTaskAdded.Text = "Abandoned Task:";
            // 
            // lblInQueueTask
            // 
            this.lblInQueueTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblInQueueTask.Location = new System.Drawing.Point(462, 112);
            this.lblInQueueTask.Name = "lblInQueueTask";
            this.lblInQueueTask.Size = new System.Drawing.Size(101, 17);
            this.lblInQueueTask.TabIndex = 17;
            this.lblInQueueTask.Text = "Abandoned Task:";
            // 
            // lblCompleteTask
            // 
            this.lblCompleteTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCompleteTask.Location = new System.Drawing.Point(462, 95);
            this.lblCompleteTask.Name = "lblCompleteTask";
            this.lblCompleteTask.Size = new System.Drawing.Size(101, 17);
            this.lblCompleteTask.TabIndex = 16;
            this.lblCompleteTask.Text = "Abandoned Task:";
            // 
            // lblAbandonedTask
            // 
            this.lblAbandonedTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblAbandonedTask.Location = new System.Drawing.Point(462, 148);
            this.lblAbandonedTask.Name = "lblAbandonedTask";
            this.lblAbandonedTask.Size = new System.Drawing.Size(101, 17);
            this.lblAbandonedTask.TabIndex = 19;
            this.lblAbandonedTask.Text = "Abandoned Task:";
            // 
            // lblSkippedTask
            // 
            this.lblSkippedTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSkippedTask.Location = new System.Drawing.Point(462, 131);
            this.lblSkippedTask.Name = "lblSkippedTask";
            this.lblSkippedTask.Size = new System.Drawing.Size(101, 17);
            this.lblSkippedTask.TabIndex = 18;
            this.lblSkippedTask.Text = "Abandoned Task:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.DarkCyan;
            this.label21.Location = new System.Drawing.Point(389, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 17);
            this.label21.TabIndex = 20;
            this.label21.Text = "Next Task:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblNextTask
            // 
            this.lblNextTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNextTask.Location = new System.Drawing.Point(462, 185);
            this.lblNextTask.Name = "lblNextTask";
            this.lblNextTask.Size = new System.Drawing.Size(101, 17);
            this.lblNextTask.TabIndex = 21;
            this.lblNextTask.Text = "Abandoned Task:";
            // 
            // frmStudySession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 282);
            this.Controls.Add(this.lblNextTask);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblAbandonedTask);
            this.Controls.Add(this.lblSkippedTask);
            this.Controls.Add(this.lblInQueueTask);
            this.Controls.Add(this.lblCompleteTask);
            this.Controls.Add(this.lblInterruption);
            this.Controls.Add(this.lblUnplannedTaskAdded);
            this.Controls.Add(this.lblIncompleteTomato);
            this.Controls.Add(this.lblCompleteTomato);
            this.Controls.Add(this.btnTaskList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmStudySession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Session";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmStudySession_Load);
            this.Shown += new System.EventHandler(this.frmStudySession_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label lblCurrentTaskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewUnplannedTask;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Button btnInterruption;
        private System.Windows.Forms.Button btnTaskList;
        private System.Windows.Forms.Label lblCompleteTomato;
        private System.Windows.Forms.Label lblIncompleteTomato;
        private System.Windows.Forms.Label lblInterruption;
        private System.Windows.Forms.Label lblUnplannedTaskAdded;
        private System.Windows.Forms.Label lblInQueueTask;
        private System.Windows.Forms.Label lblCompleteTask;
        private System.Windows.Forms.Label lblAbandonedTask;
        private System.Windows.Forms.Label lblSkippedTask;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblNextTask;
    }
}

