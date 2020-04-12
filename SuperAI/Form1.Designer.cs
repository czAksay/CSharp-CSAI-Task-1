namespace SuperAI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblFileDescr = new System.Windows.Forms.Label();
            this.pbBrain = new System.Windows.Forms.PictureBox();
            this.pnlDoomguy = new System.Windows.Forms.Panel();
            this.pbMuted = new System.Windows.Forms.PictureBox();
            this.pnlDialog = new System.Windows.Forms.Panel();
            this.rtbDialog = new System.Windows.Forms.RichTextBox();
            this.pbDialog = new System.Windows.Forms.PictureBox();
            this.pbDoomguy = new System.Windows.Forms.PictureBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlDragBorder = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDialog2 = new System.Windows.Forms.Panel();
            this.cbDeep = new System.Windows.Forms.CheckBox();
            this.pbDoomName = new System.Windows.Forms.PictureBox();
            this.pbClearLog = new System.Windows.Forms.PictureBox();
            this.pbFileOpen = new System.Windows.Forms.PictureBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.pnlWork = new System.Windows.Forms.Panel();
            this.btnStartDialog = new System.Windows.Forms.Button();
            this.gbGraph = new System.Windows.Forms.GroupBox();
            this.pbSchema = new System.Windows.Forms.PictureBox();
            this.gbFileText = new System.Windows.Forms.GroupBox();
            this.rtbFileText = new System.Windows.Forms.RichTextBox();
            this.pnlMozg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrDialog = new System.Windows.Forms.Timer(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.tmrTalkAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlLeft.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrain)).BeginInit();
            this.pnlDoomguy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMuted)).BeginInit();
            this.pnlDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoomguy)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlDragBorder.SuspendLayout();
            this.pnlDialog2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoomName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClearLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFileOpen)).BeginInit();
            this.pnlWork.SuspendLayout();
            this.gbGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchema)).BeginInit();
            this.gbFileText.SuspendLayout();
            this.pnlMozg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Controls.Add(this.pnlDoomguy);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(222, 545);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnRestart);
            this.pnlButtons.Controls.Add(this.lblFileDescr);
            this.pnlButtons.Controls.Add(this.pbBrain);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 275);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(220, 268);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Image = global::SuperAI.Properties.Resources.home2;
            this.btnRestart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRestart.Location = new System.Drawing.Point(0, 108);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(220, 53);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Домой";
            this.btnRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblFileDescr
            // 
            this.lblFileDescr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFileDescr.ForeColor = System.Drawing.Color.White;
            this.lblFileDescr.Location = new System.Drawing.Point(10, 175);
            this.lblFileDescr.Name = "lblFileDescr";
            this.lblFileDescr.Size = new System.Drawing.Size(198, 23);
            this.lblFileDescr.TabIndex = 2;
            this.lblFileDescr.Text = "файл не выбран";
            this.lblFileDescr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbBrain
            // 
            this.pbBrain.Image = global::SuperAI.Properties.Resources.Mozg;
            this.pbBrain.Location = new System.Drawing.Point(52, 204);
            this.pbBrain.Name = "pbBrain";
            this.pbBrain.Size = new System.Drawing.Size(115, 122);
            this.pbBrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBrain.TabIndex = 0;
            this.pbBrain.TabStop = false;
            this.pbBrain.Visible = false;
            this.pbBrain.WaitOnLoad = true;
            // 
            // pnlDoomguy
            // 
            this.pnlDoomguy.Controls.Add(this.pbMuted);
            this.pnlDoomguy.Controls.Add(this.pnlDialog);
            this.pnlDoomguy.Controls.Add(this.pbDoomguy);
            this.pnlDoomguy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDoomguy.Location = new System.Drawing.Point(0, 0);
            this.pnlDoomguy.Name = "pnlDoomguy";
            this.pnlDoomguy.Size = new System.Drawing.Size(220, 275);
            this.pnlDoomguy.TabIndex = 0;
            this.pnlDoomguy.Visible = false;
            // 
            // pbMuted
            // 
            this.pbMuted.BackColor = System.Drawing.Color.Red;
            this.pbMuted.Image = global::SuperAI.Properties.Resources.mute;
            this.pbMuted.Location = new System.Drawing.Point(94, 132);
            this.pbMuted.Name = "pbMuted";
            this.pbMuted.Size = new System.Drawing.Size(38, 40);
            this.pbMuted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMuted.TabIndex = 3;
            this.pbMuted.TabStop = false;
            this.pbMuted.Visible = false;
            // 
            // pnlDialog
            // 
            this.pnlDialog.Controls.Add(this.rtbDialog);
            this.pnlDialog.Controls.Add(this.pbDialog);
            this.pnlDialog.Location = new System.Drawing.Point(4, 147);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.Size = new System.Drawing.Size(212, 124);
            this.pnlDialog.TabIndex = 2;
            // 
            // rtbDialog
            // 
            this.rtbDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDialog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbDialog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDialog.Location = new System.Drawing.Point(8, 20);
            this.rtbDialog.Name = "rtbDialog";
            this.rtbDialog.ReadOnly = true;
            this.rtbDialog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDialog.Size = new System.Drawing.Size(197, 92);
            this.rtbDialog.TabIndex = 2;
            this.rtbDialog.Text = "...";
            this.rtbDialog.TextChanged += new System.EventHandler(this.rtbDialog_TextChanged);
            // 
            // pbDialog
            // 
            this.pbDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDialog.Image = ((System.Drawing.Image)(resources.GetObject("pbDialog.Image")));
            this.pbDialog.Location = new System.Drawing.Point(0, 0);
            this.pbDialog.Name = "pbDialog";
            this.pbDialog.Size = new System.Drawing.Size(212, 124);
            this.pbDialog.TabIndex = 1;
            this.pbDialog.TabStop = false;
            this.pbDialog.WaitOnLoad = true;
            // 
            // pbDoomguy
            // 
            this.pbDoomguy.Image = global::SuperAI.Properties.Resources.d2;
            this.pbDoomguy.Location = new System.Drawing.Point(56, 12);
            this.pbDoomguy.Name = "pbDoomguy";
            this.pbDoomguy.Size = new System.Drawing.Size(115, 144);
            this.pbDoomguy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDoomguy.TabIndex = 0;
            this.pbDoomguy.TabStop = false;
            this.pbDoomguy.WaitOnLoad = true;
            this.pbDoomguy.Click += new System.EventHandler(this.pbDoomguy_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChooseFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChooseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnChooseFile.ForeColor = System.Drawing.Color.White;
            this.btnChooseFile.Location = new System.Drawing.Point(20, 67);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(567, 61);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "Выбрать файл";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.pnlDragBorder);
            this.pnlRight.Controls.Add(this.pnlMozg);
            this.pnlRight.Controls.Add(this.pnlDialog2);
            this.pnlRight.Controls.Add(this.pnlWork);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(222, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(653, 545);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlDragBorder
            // 
            this.pnlDragBorder.Controls.Add(this.btnClose);
            this.pnlDragBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlDragBorder.Name = "pnlDragBorder";
            this.pnlDragBorder.Size = new System.Drawing.Size(651, 54);
            this.pnlDragBorder.TabIndex = 2;
            this.pnlDragBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBorder_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.BackgroundImage = global::SuperAI.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(601, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlDialog2
            // 
            this.pnlDialog2.AutoScroll = true;
            this.pnlDialog2.BackColor = System.Drawing.Color.Transparent;
            this.pnlDialog2.Controls.Add(this.cbDeep);
            this.pnlDialog2.Controls.Add(this.pbDoomName);
            this.pnlDialog2.Controls.Add(this.pbClearLog);
            this.pnlDialog2.Controls.Add(this.pbFileOpen);
            this.pnlDialog2.Controls.Add(this.btnInput);
            this.pnlDialog2.Controls.Add(this.tbInput);
            this.pnlDialog2.Controls.Add(this.rtbChat);
            this.pnlDialog2.Controls.Add(this.lblHelp);
            this.pnlDialog2.Location = new System.Drawing.Point(11, 72);
            this.pnlDialog2.Name = "pnlDialog2";
            this.pnlDialog2.Size = new System.Drawing.Size(623, 451);
            this.pnlDialog2.TabIndex = 4;
            this.pnlDialog2.Visible = false;
            // 
            // cbDeep
            // 
            this.cbDeep.AutoSize = true;
            this.cbDeep.CausesValidation = false;
            this.cbDeep.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbDeep.Checked = true;
            this.cbDeep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDeep.ForeColor = System.Drawing.Color.White;
            this.cbDeep.Location = new System.Drawing.Point(289, 6);
            this.cbDeep.Name = "cbDeep";
            this.cbDeep.Size = new System.Drawing.Size(106, 17);
            this.cbDeep.TabIndex = 8;
            this.cbDeep.Text = "Глубокий поиск";
            this.cbDeep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDeep.UseVisualStyleBackColor = true;
            this.cbDeep.Visible = false;
            // 
            // pbDoomName
            // 
            this.pbDoomName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDoomName.Image = global::SuperAI.Properties.Resources.d2;
            this.pbDoomName.Location = new System.Drawing.Point(499, 20);
            this.pbDoomName.Name = "pbDoomName";
            this.pbDoomName.Size = new System.Drawing.Size(35, 35);
            this.pbDoomName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDoomName.TabIndex = 3;
            this.pbDoomName.TabStop = false;
            this.pbDoomName.Click += new System.EventHandler(this.pbDoomName_Click);
            // 
            // pbClearLog
            // 
            this.pbClearLog.BackColor = System.Drawing.Color.Transparent;
            this.pbClearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClearLog.Image = global::SuperAI.Properties.Resources.clear3;
            this.pbClearLog.Location = new System.Drawing.Point(540, 20);
            this.pbClearLog.Name = "pbClearLog";
            this.pbClearLog.Size = new System.Drawing.Size(35, 35);
            this.pbClearLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClearLog.TabIndex = 7;
            this.pbClearLog.TabStop = false;
            this.pbClearLog.Click += new System.EventHandler(this.pbClearLog_Click);
            // 
            // pbFileOpen
            // 
            this.pbFileOpen.BackColor = System.Drawing.Color.Transparent;
            this.pbFileOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFileOpen.Image = global::SuperAI.Properties.Resources.file;
            this.pbFileOpen.Location = new System.Drawing.Point(581, 20);
            this.pbFileOpen.Name = "pbFileOpen";
            this.pbFileOpen.Size = new System.Drawing.Size(35, 35);
            this.pbFileOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFileOpen.TabIndex = 5;
            this.pbFileOpen.TabStop = false;
            this.pbFileOpen.Click += new System.EventHandler(this.pbFileOpen_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.btnInput.ForeColor = System.Drawing.Color.White;
            this.btnInput.Location = new System.Drawing.Point(496, 406);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(117, 28);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = ">>";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(10, 407);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(480, 27);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "?:?:?";
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // rtbChat
            // 
            this.rtbChat.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.rtbChat.Location = new System.Drawing.Point(10, 61);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbChat.Size = new System.Drawing.Size(603, 335);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            this.rtbChat.TextChanged += new System.EventHandler(this.rtbChat_TextChanged);
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(13, 6);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(420, 49);
            this.lblHelp.TabIndex = 6;
            this.lblHelp.Text = "Введите запрос вида: \r\n< код объекта1 | ? : код связи | ? : код объекта2 | ? >.";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlWork
            // 
            this.pnlWork.AutoScroll = true;
            this.pnlWork.BackColor = System.Drawing.Color.Transparent;
            this.pnlWork.Controls.Add(this.btnStartDialog);
            this.pnlWork.Controls.Add(this.gbGraph);
            this.pnlWork.Controls.Add(this.gbFileText);
            this.pnlWork.Location = new System.Drawing.Point(10, 71);
            this.pnlWork.Name = "pnlWork";
            this.pnlWork.Size = new System.Drawing.Size(623, 451);
            this.pnlWork.TabIndex = 3;
            this.pnlWork.Visible = false;
            // 
            // btnStartDialog
            // 
            this.btnStartDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStartDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStartDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStartDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartDialog.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnStartDialog.ForeColor = System.Drawing.Color.White;
            this.btnStartDialog.Location = new System.Drawing.Point(15, 17);
            this.btnStartDialog.Name = "btnStartDialog";
            this.btnStartDialog.Size = new System.Drawing.Size(580, 49);
            this.btnStartDialog.TabIndex = 3;
            this.btnStartDialog.Text = "Перейти к диалогу";
            this.btnStartDialog.UseVisualStyleBackColor = false;
            this.btnStartDialog.Click += new System.EventHandler(this.btnStartDialog_Click);
            // 
            // gbGraph
            // 
            this.gbGraph.Controls.Add(this.pbSchema);
            this.gbGraph.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGraph.ForeColor = System.Drawing.Color.White;
            this.gbGraph.Location = new System.Drawing.Point(15, 416);
            this.gbGraph.Name = "gbGraph";
            this.gbGraph.Size = new System.Drawing.Size(580, 324);
            this.gbGraph.TabIndex = 2;
            this.gbGraph.TabStop = false;
            this.gbGraph.Text = "График анализа:";
            // 
            // pbSchema
            // 
            this.pbSchema.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbSchema.Image = global::SuperAI.Properties.Resources.schema;
            this.pbSchema.Location = new System.Drawing.Point(8, 26);
            this.pbSchema.Name = "pbSchema";
            this.pbSchema.Size = new System.Drawing.Size(563, 286);
            this.pbSchema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSchema.TabIndex = 0;
            this.pbSchema.TabStop = false;
            // 
            // gbFileText
            // 
            this.gbFileText.Controls.Add(this.rtbFileText);
            this.gbFileText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFileText.ForeColor = System.Drawing.Color.White;
            this.gbFileText.Location = new System.Drawing.Point(15, 72);
            this.gbFileText.Name = "gbFileText";
            this.gbFileText.Size = new System.Drawing.Size(580, 338);
            this.gbFileText.TabIndex = 1;
            this.gbFileText.TabStop = false;
            this.gbFileText.Text = "Текст файла:";
            // 
            // rtbFileText
            // 
            this.rtbFileText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFileText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbFileText.Location = new System.Drawing.Point(8, 27);
            this.rtbFileText.Name = "rtbFileText";
            this.rtbFileText.ReadOnly = true;
            this.rtbFileText.Size = new System.Drawing.Size(563, 299);
            this.rtbFileText.TabIndex = 0;
            this.rtbFileText.Text = "";
            // 
            // pnlMozg
            // 
            this.pnlMozg.BackColor = System.Drawing.Color.Transparent;
            this.pnlMozg.Controls.Add(this.label1);
            this.pnlMozg.Controls.Add(this.btnChooseFile);
            this.pnlMozg.Location = new System.Drawing.Point(18, 69);
            this.pnlMozg.Name = "pnlMozg";
            this.pnlMozg.Size = new System.Drawing.Size(609, 418);
            this.pnlMozg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 217);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrDialog
            // 
            this.tmrDialog.Enabled = true;
            this.tmrDialog.Interval = 1;
            this.tmrDialog.Tick += new System.EventHandler(this.tmrDialog_Tick);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "Text files (.txt)|*.txt";
            // 
            // tmrTalkAnimation
            // 
            this.tmrTalkAnimation.Enabled = true;
            this.tmrTalkAnimation.Interval = 300;
            this.tmrTalkAnimation.Tick += new System.EventHandler(this.tmrTalkAnimation_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperAI.Properties.Resources.appfon_bc;
            this.ClientSize = new System.Drawing.Size(875, 545);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI";
            this.pnlLeft.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBrain)).EndInit();
            this.pnlDoomguy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMuted)).EndInit();
            this.pnlDialog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoomguy)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlDragBorder.ResumeLayout(false);
            this.pnlDialog2.ResumeLayout(false);
            this.pnlDialog2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoomName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClearLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFileOpen)).EndInit();
            this.pnlWork.ResumeLayout(false);
            this.gbGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSchema)).EndInit();
            this.gbFileText.ResumeLayout(false);
            this.pnlMozg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlDoomguy;
        private System.Windows.Forms.PictureBox pbDoomguy;
        private System.Windows.Forms.Panel pnlDialog;
        private System.Windows.Forms.PictureBox pbDialog;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtbDialog;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.PictureBox pbBrain;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Timer tmrDialog;
        private System.Windows.Forms.Label lblFileDescr;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Panel pnlMozg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDragBorder;
        private System.Windows.Forms.Panel pnlWork;
        private System.Windows.Forms.Timer tmrTalkAnimation;
        private System.Windows.Forms.GroupBox gbFileText;
        private System.Windows.Forms.RichTextBox rtbFileText;
        private System.Windows.Forms.GroupBox gbGraph;
        private System.Windows.Forms.PictureBox pbSchema;
        private System.Windows.Forms.Button btnStartDialog;
        private System.Windows.Forms.Panel pnlDialog2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.PictureBox pbFileOpen;
        private System.Windows.Forms.PictureBox pbDoomName;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.PictureBox pbMuted;
        private System.Windows.Forms.PictureBox pbClearLog;
        private System.Windows.Forms.CheckBox cbDeep;
        private System.Windows.Forms.Button btnRestart;
    }
}

