namespace PomodoroTechniqueHelper
{
    partial class frmNewTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTask));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNewTaskTypeTaskPool = new System.Windows.Forms.RadioButton();
            this.radioNewTaskTypeUnplanned = new System.Windows.Forms.RadioButton();
            this.radioNewTaskTypeCurrent = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioNotImportant = new System.Windows.Forms.RadioButton();
            this.radioImportant = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioDifficult = new System.Windows.Forms.RadioButton();
            this.radioEasy = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numEsitmateTomato = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.timePlanToFinish = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioPrioritizeAddToTaskPool = new System.Windows.Forms.RadioButton();
            this.radioPrioritizeLowestPriority = new System.Windows.Forms.RadioButton();
            this.radioPrioritizeHighestPriority = new System.Windows.Forms.RadioButton();
            this.radioPrioritizeAddToTaskList = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmToAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEsitmateTomato)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioNewTaskTypeTaskPool);
            this.groupBox1.Controls.Add(this.radioNewTaskTypeUnplanned);
            this.groupBox1.Controls.Add(this.radioNewTaskTypeCurrent);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1 - Adding Task Type:";
            // 
            // radioNewTaskTypeTaskPool
            // 
            this.radioNewTaskTypeTaskPool.AutoSize = true;
            this.radioNewTaskTypeTaskPool.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNewTaskTypeTaskPool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioNewTaskTypeTaskPool.Location = new System.Drawing.Point(7, 89);
            this.radioNewTaskTypeTaskPool.Name = "radioNewTaskTypeTaskPool";
            this.radioNewTaskTypeTaskPool.Size = new System.Drawing.Size(201, 21);
            this.radioNewTaskTypeTaskPool.TabIndex = 2;
            this.radioNewTaskTypeTaskPool.TabStop = true;
            this.radioNewTaskTypeTaskPool.Text = "New Task Added To Task Pool";
            this.radioNewTaskTypeTaskPool.UseVisualStyleBackColor = true;
            // 
            // radioNewTaskTypeUnplanned
            // 
            this.radioNewTaskTypeUnplanned.AutoSize = true;
            this.radioNewTaskTypeUnplanned.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNewTaskTypeUnplanned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioNewTaskTypeUnplanned.Location = new System.Drawing.Point(7, 62);
            this.radioNewTaskTypeUnplanned.Name = "radioNewTaskTypeUnplanned";
            this.radioNewTaskTypeUnplanned.Size = new System.Drawing.Size(148, 21);
            this.radioNewTaskTypeUnplanned.TabIndex = 1;
            this.radioNewTaskTypeUnplanned.TabStop = true;
            this.radioNewTaskTypeUnplanned.Text = "New Unplanned Task";
            this.radioNewTaskTypeUnplanned.UseVisualStyleBackColor = true;
            // 
            // radioNewTaskTypeCurrent
            // 
            this.radioNewTaskTypeCurrent.AutoSize = true;
            this.radioNewTaskTypeCurrent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNewTaskTypeCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioNewTaskTypeCurrent.Location = new System.Drawing.Point(7, 35);
            this.radioNewTaskTypeCurrent.Name = "radioNewTaskTypeCurrent";
            this.radioNewTaskTypeCurrent.Size = new System.Drawing.Size(230, 21);
            this.radioNewTaskTypeCurrent.TabIndex = 0;
            this.radioNewTaskTypeCurrent.TabStop = true;
            this.radioNewTaskTypeCurrent.Text = "New Task To Current Study Session";
            this.radioNewTaskTypeCurrent.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtTaskName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2 - Enter Task Name:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTaskName.Location = new System.Drawing.Point(7, 35);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(346, 25);
            this.txtTaskName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 132);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3 - Rate:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioNotImportant);
            this.groupBox5.Controls.Add(this.radioImportant);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(97, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(125, 87);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Importance";
            // 
            // radioNotImportant
            // 
            this.radioNotImportant.AutoSize = true;
            this.radioNotImportant.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNotImportant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioNotImportant.Location = new System.Drawing.Point(6, 51);
            this.radioNotImportant.Name = "radioNotImportant";
            this.radioNotImportant.Size = new System.Drawing.Size(109, 21);
            this.radioNotImportant.TabIndex = 4;
            this.radioNotImportant.TabStop = true;
            this.radioNotImportant.Text = "Not Important";
            this.radioNotImportant.UseVisualStyleBackColor = true;
            // 
            // radioImportant
            // 
            this.radioImportant.AutoSize = true;
            this.radioImportant.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioImportant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioImportant.Location = new System.Drawing.Point(6, 24);
            this.radioImportant.Name = "radioImportant";
            this.radioImportant.Size = new System.Drawing.Size(83, 21);
            this.radioImportant.TabIndex = 3;
            this.radioImportant.TabStop = true;
            this.radioImportant.Text = "Important";
            this.radioImportant.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioDifficult);
            this.groupBox4.Controls.Add(this.radioEasy);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(7, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(84, 87);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Easiness:";
            // 
            // radioDifficult
            // 
            this.radioDifficult.AutoSize = true;
            this.radioDifficult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDifficult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioDifficult.Location = new System.Drawing.Point(6, 51);
            this.radioDifficult.Name = "radioDifficult";
            this.radioDifficult.Size = new System.Drawing.Size(69, 21);
            this.radioDifficult.TabIndex = 4;
            this.radioDifficult.TabStop = true;
            this.radioDifficult.Text = "Difficult";
            this.radioDifficult.UseVisualStyleBackColor = true;
            // 
            // radioEasy
            // 
            this.radioEasy.AutoSize = true;
            this.radioEasy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEasy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioEasy.Location = new System.Drawing.Point(6, 24);
            this.radioEasy.Name = "radioEasy";
            this.radioEasy.Size = new System.Drawing.Size(52, 21);
            this.radioEasy.TabIndex = 3;
            this.radioEasy.TabStop = true;
            this.radioEasy.Text = "Easy";
            this.radioEasy.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.numEsitmateTomato);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox6.Location = new System.Drawing.Point(12, 354);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(359, 91);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Step 4 - Estimate:";
            // 
            // numEsitmateTomato
            // 
            this.numEsitmateTomato.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEsitmateTomato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numEsitmateTomato.Location = new System.Drawing.Point(7, 55);
            this.numEsitmateTomato.Name = "numEsitmateTomato";
            this.numEsitmateTomato.Size = new System.Drawing.Size(182, 25);
            this.numEsitmateTomato.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many tomatoes needed?";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.timePlanToFinish);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox7.Location = new System.Drawing.Point(12, 618);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(359, 69);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Step 6 - Reminder (Optional)";
            // 
            // timePlanToFinish
            // 
            this.timePlanToFinish.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePlanToFinish.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timePlanToFinish.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timePlanToFinish.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePlanToFinish.Location = new System.Drawing.Point(114, 31);
            this.timePlanToFinish.Name = "timePlanToFinish";
            this.timePlanToFinish.Size = new System.Drawing.Size(200, 25);
            this.timePlanToFinish.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(4, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plan to finish on:";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.radioPrioritizeAddToTaskPool);
            this.groupBox8.Controls.Add(this.radioPrioritizeLowestPriority);
            this.groupBox8.Controls.Add(this.radioPrioritizeHighestPriority);
            this.groupBox8.Controls.Add(this.radioPrioritizeAddToTaskList);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox8.Location = new System.Drawing.Point(12, 451);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(359, 161);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Step 5 - Prioritize (Optional)";
            // 
            // radioPrioritizeAddToTaskPool
            // 
            this.radioPrioritizeAddToTaskPool.AutoSize = true;
            this.radioPrioritizeAddToTaskPool.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPrioritizeAddToTaskPool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioPrioritizeAddToTaskPool.Location = new System.Drawing.Point(7, 132);
            this.radioPrioritizeAddToTaskPool.Name = "radioPrioritizeAddToTaskPool";
            this.radioPrioritizeAddToTaskPool.Size = new System.Drawing.Size(175, 21);
            this.radioPrioritizeAddToTaskPool.TabIndex = 9;
            this.radioPrioritizeAddToTaskPool.TabStop = true;
            this.radioPrioritizeAddToTaskPool.Text = "Add this task to task pool";
            this.radioPrioritizeAddToTaskPool.UseVisualStyleBackColor = true;
            // 
            // radioPrioritizeLowestPriority
            // 
            this.radioPrioritizeLowestPriority.AutoSize = true;
            this.radioPrioritizeLowestPriority.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPrioritizeLowestPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioPrioritizeLowestPriority.Location = new System.Drawing.Point(6, 105);
            this.radioPrioritizeLowestPriority.Name = "radioPrioritizeLowestPriority";
            this.radioPrioritizeLowestPriority.Size = new System.Drawing.Size(220, 21);
            this.radioPrioritizeLowestPriority.TabIndex = 6;
            this.radioPrioritizeLowestPriority.TabStop = true;
            this.radioPrioritizeLowestPriority.Text = "Do this task at the end of session";
            this.radioPrioritizeLowestPriority.UseVisualStyleBackColor = true;
            // 
            // radioPrioritizeHighestPriority
            // 
            this.radioPrioritizeHighestPriority.AutoSize = true;
            this.radioPrioritizeHighestPriority.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPrioritizeHighestPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioPrioritizeHighestPriority.Location = new System.Drawing.Point(6, 78);
            this.radioPrioritizeHighestPriority.Name = "radioPrioritizeHighestPriority";
            this.radioPrioritizeHighestPriority.Size = new System.Drawing.Size(170, 21);
            this.radioPrioritizeHighestPriority.TabIndex = 5;
            this.radioPrioritizeHighestPriority.TabStop = true;
            this.radioPrioritizeHighestPriority.Text = "Do this task after current";
            this.radioPrioritizeHighestPriority.UseVisualStyleBackColor = true;
            // 
            // radioPrioritizeAddToTaskList
            // 
            this.radioPrioritizeAddToTaskList.AutoSize = true;
            this.radioPrioritizeAddToTaskList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPrioritizeAddToTaskList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioPrioritizeAddToTaskList.Location = new System.Drawing.Point(6, 51);
            this.radioPrioritizeAddToTaskList.Name = "radioPrioritizeAddToTaskList";
            this.radioPrioritizeAddToTaskList.Size = new System.Drawing.Size(372, 21);
            this.radioPrioritizeAddToTaskList.TabIndex = 4;
            this.radioPrioritizeAddToTaskList.TabStop = true;
            this.radioPrioritizeAddToTaskList.Text = "Add to task list, resort task list and continue current tomato";
            this.radioPrioritizeAddToTaskList.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(4, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choose one to perform:";
            // 
            // btnConfirmToAdd
            // 
            this.btnConfirmToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmToAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmToAdd.FlatAppearance.BorderSize = 0;
            this.btnConfirmToAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirmToAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirmToAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmToAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmToAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConfirmToAdd.Location = new System.Drawing.Point(377, 26);
            this.btnConfirmToAdd.Name = "btnConfirmToAdd";
            this.btnConfirmToAdd.Size = new System.Drawing.Size(157, 82);
            this.btnConfirmToAdd.TabIndex = 9;
            this.btnConfirmToAdd.Text = "Confirm To Add";
            this.btnConfirmToAdd.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(377, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 350);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmToAdd);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewTask";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Task";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEsitmateTomato)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNewTaskTypeTaskPool;
        private System.Windows.Forms.RadioButton radioNewTaskTypeUnplanned;
        private System.Windows.Forms.RadioButton radioNewTaskTypeCurrent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioNotImportant;
        private System.Windows.Forms.RadioButton radioImportant;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioDifficult;
        private System.Windows.Forms.RadioButton radioEasy;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numEsitmateTomato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker timePlanToFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton radioPrioritizeAddToTaskPool;
        private System.Windows.Forms.RadioButton radioPrioritizeLowestPriority;
        private System.Windows.Forms.RadioButton radioPrioritizeHighestPriority;
        private System.Windows.Forms.RadioButton radioPrioritizeAddToTaskList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmToAdd;
        private System.Windows.Forms.Button btnCancel;

    }
}