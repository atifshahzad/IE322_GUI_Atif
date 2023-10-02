namespace IE322_App_KAU
{
    partial class frmCollections
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
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRemoveRange = new System.Windows.Forms.Button();
            this.BtnRemoveAt = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnCreateArrayList = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.LblCapacity = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnTrimToSize = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnPeek = new System.Windows.Forms.Button();
            this.BtnPush = new System.Windows.Forms.Button();
            this.BtnPop = new System.Windows.Forms.Button();
            this.BtnCreateStack = new System.Windows.Forms.Button();
            this.GrpQueue = new System.Windows.Forms.GroupBox();
            this.BtnEnqueue = new System.Windows.Forms.Button();
            this.BtnDequeue = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtmRemoveHash = new System.Windows.Forms.Button();
            this.BtnCreateHash = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GrpQueue.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstDisplay
            // 
            this.LstDisplay.FormattingEnabled = true;
            this.LstDisplay.Location = new System.Drawing.Point(21, 19);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(122, 199);
            this.LstDisplay.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnTrimToSize);
            this.groupBox1.Controls.Add(this.BtnRemoveRange);
            this.groupBox1.Controls.Add(this.BtnRemoveAt);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.BtnRemove);
            this.groupBox1.Controls.Add(this.BtnCreateArrayList);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ArrayList";
            // 
            // BtnRemoveRange
            // 
            this.BtnRemoveRange.Location = new System.Drawing.Point(6, 134);
            this.BtnRemoveRange.Name = "BtnRemoveRange";
            this.BtnRemoveRange.Size = new System.Drawing.Size(96, 23);
            this.BtnRemoveRange.TabIndex = 3;
            this.BtnRemoveRange.Text = "Remove range";
            this.BtnRemoveRange.UseVisualStyleBackColor = true;
            this.BtnRemoveRange.Click += new System.EventHandler(this.BtnRemoveRange_Click);
            // 
            // BtnRemoveAt
            // 
            this.BtnRemoveAt.Location = new System.Drawing.Point(6, 105);
            this.BtnRemoveAt.Name = "BtnRemoveAt";
            this.BtnRemoveAt.Size = new System.Drawing.Size(96, 23);
            this.BtnRemoveAt.TabIndex = 2;
            this.BtnRemoveAt.Text = "Remove At";
            this.BtnRemoveAt.UseVisualStyleBackColor = true;
            this.BtnRemoveAt.Click += new System.EventHandler(this.BtnRemoveAt_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(6, 76);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(96, 23);
            this.BtnRemove.TabIndex = 1;
            this.BtnRemove.Text = "Remove ";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnCreateArrayList
            // 
            this.BtnCreateArrayList.Location = new System.Drawing.Point(6, 19);
            this.BtnCreateArrayList.Name = "BtnCreateArrayList";
            this.BtnCreateArrayList.Size = new System.Drawing.Size(96, 23);
            this.BtnCreateArrayList.TabIndex = 0;
            this.BtnCreateArrayList.Text = "Create Array List";
            this.BtnCreateArrayList.UseVisualStyleBackColor = true;
            this.BtnCreateArrayList.Click += new System.EventHandler(this.BtnCreateArrayList_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(149, 29);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(38, 13);
            this.LblCount.TabIndex = 2;
            this.LblCount.Text = "Count:";
            // 
            // LblCapacity
            // 
            this.LblCapacity.AutoSize = true;
            this.LblCapacity.Location = new System.Drawing.Point(149, 58);
            this.LblCapacity.Name = "LblCapacity";
            this.LblCapacity.Size = new System.Drawing.Size(51, 13);
            this.LblCapacity.TabIndex = 2;
            this.LblCapacity.Text = "Capacity:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.LstDisplay);
            this.groupBox2.Controls.Add(this.LblCapacity);
            this.groupBox2.Controls.Add(this.LblCount);
            this.groupBox2.Location = new System.Drawing.Point(260, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 229);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(6, 48);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(96, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add items";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnTrimToSize
            // 
            this.BtnTrimToSize.Location = new System.Drawing.Point(120, 144);
            this.BtnTrimToSize.Name = "BtnTrimToSize";
            this.BtnTrimToSize.Size = new System.Drawing.Size(96, 23);
            this.BtnTrimToSize.TabIndex = 3;
            this.BtnTrimToSize.Text = "Trim To Size";
            this.BtnTrimToSize.UseVisualStyleBackColor = true;
            this.BtnTrimToSize.Click += new System.EventHandler(this.BtnTrimToSize_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnPeek);
            this.groupBox3.Controls.Add(this.BtnPush);
            this.groupBox3.Controls.Add(this.BtnPop);
            this.groupBox3.Controls.Add(this.BtnCreateStack);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 188);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stack";
            // 
            // BtnPeek
            // 
            this.BtnPeek.Location = new System.Drawing.Point(6, 105);
            this.BtnPeek.Name = "BtnPeek";
            this.BtnPeek.Size = new System.Drawing.Size(96, 23);
            this.BtnPeek.TabIndex = 2;
            this.BtnPeek.Text = "Peek";
            this.BtnPeek.UseVisualStyleBackColor = true;
            this.BtnPeek.Click += new System.EventHandler(this.BtnPeek_Click);
            // 
            // BtnPush
            // 
            this.BtnPush.Location = new System.Drawing.Point(6, 48);
            this.BtnPush.Name = "BtnPush";
            this.BtnPush.Size = new System.Drawing.Size(96, 23);
            this.BtnPush.TabIndex = 1;
            this.BtnPush.Text = "Push";
            this.BtnPush.UseVisualStyleBackColor = true;
            this.BtnPush.Click += new System.EventHandler(this.BtnPushClick);
            // 
            // BtnPop
            // 
            this.BtnPop.Location = new System.Drawing.Point(6, 76);
            this.BtnPop.Name = "BtnPop";
            this.BtnPop.Size = new System.Drawing.Size(96, 23);
            this.BtnPop.TabIndex = 1;
            this.BtnPop.Text = "Pop";
            this.BtnPop.UseVisualStyleBackColor = true;
            this.BtnPop.Click += new System.EventHandler(this.BtnPop_Click);
            // 
            // BtnCreateStack
            // 
            this.BtnCreateStack.Location = new System.Drawing.Point(6, 19);
            this.BtnCreateStack.Name = "BtnCreateStack";
            this.BtnCreateStack.Size = new System.Drawing.Size(96, 23);
            this.BtnCreateStack.TabIndex = 0;
            this.BtnCreateStack.Text = "Create Stack";
            this.BtnCreateStack.UseVisualStyleBackColor = true;
            this.BtnCreateStack.Click += new System.EventHandler(this.BtnCreateStack_Click);
            // 
            // GrpQueue
            // 
            this.GrpQueue.Controls.Add(this.BtnEnqueue);
            this.GrpQueue.Controls.Add(this.BtnDequeue);
            this.GrpQueue.Controls.Add(this.button4);
            this.GrpQueue.Location = new System.Drawing.Point(546, 224);
            this.GrpQueue.Name = "GrpQueue";
            this.GrpQueue.Size = new System.Drawing.Size(242, 188);
            this.GrpQueue.TabIndex = 4;
            this.GrpQueue.TabStop = false;
            this.GrpQueue.Text = "Queue";
            // 
            // BtnEnqueue
            // 
            this.BtnEnqueue.Location = new System.Drawing.Point(6, 48);
            this.BtnEnqueue.Name = "BtnEnqueue";
            this.BtnEnqueue.Size = new System.Drawing.Size(96, 23);
            this.BtnEnqueue.TabIndex = 1;
            this.BtnEnqueue.Text = "Enqueue";
            this.BtnEnqueue.UseVisualStyleBackColor = true;
            this.BtnEnqueue.Click += new System.EventHandler(this.BtnEnqueueClick);
            // 
            // BtnDequeue
            // 
            this.BtnDequeue.Location = new System.Drawing.Point(6, 76);
            this.BtnDequeue.Name = "BtnDequeue";
            this.BtnDequeue.Size = new System.Drawing.Size(96, 23);
            this.BtnDequeue.TabIndex = 1;
            this.BtnDequeue.Text = "Dequeue";
            this.BtnDequeue.UseVisualStyleBackColor = true;
            this.BtnDequeue.Click += new System.EventHandler(this.BtnDequeue_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Create Queue";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnCreateQueue_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.BtmRemoveHash);
            this.groupBox4.Controls.Add(this.BtnCreateHash);
            this.groupBox4.Location = new System.Drawing.Point(546, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 188);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HashTable";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnAddHash_Click);
            // 
            // BtmRemoveHash
            // 
            this.BtmRemoveHash.Location = new System.Drawing.Point(6, 76);
            this.BtmRemoveHash.Name = "BtmRemoveHash";
            this.BtmRemoveHash.Size = new System.Drawing.Size(96, 23);
            this.BtmRemoveHash.TabIndex = 1;
            this.BtmRemoveHash.Text = "Remove";
            this.BtmRemoveHash.UseVisualStyleBackColor = true;
            this.BtmRemoveHash.Click += new System.EventHandler(this.BtnRemoveHash_Click);
            // 
            // BtnCreateHash
            // 
            this.BtnCreateHash.Location = new System.Drawing.Point(6, 19);
            this.BtnCreateHash.Name = "BtnCreateHash";
            this.BtnCreateHash.Size = new System.Drawing.Size(96, 23);
            this.BtnCreateHash.TabIndex = 0;
            this.BtnCreateHash.Text = "Create Hash Table";
            this.BtnCreateHash.UseVisualStyleBackColor = true;
            this.BtnCreateHash.Click += new System.EventHandler(this.BtnCreateHashTable_Click);
            // 
            // frmCollections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GrpQueue);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCollections";
            this.Text = "Collections";
            this.Load += new System.EventHandler(this.frmCollections_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.GrpQueue.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCreateArrayList;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblCapacity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRemoveRange;
        private System.Windows.Forms.Button BtnRemoveAt;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnTrimToSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnPeek;
        private System.Windows.Forms.Button BtnPush;
        private System.Windows.Forms.Button BtnPop;
        private System.Windows.Forms.Button BtnCreateStack;
        private System.Windows.Forms.GroupBox GrpQueue;
        private System.Windows.Forms.Button BtnEnqueue;
        private System.Windows.Forms.Button BtnDequeue;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtmRemoveHash;
        private System.Windows.Forms.Button BtnCreateHash;
    }
}