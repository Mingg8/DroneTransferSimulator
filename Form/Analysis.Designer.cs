﻿namespace DroneTransferSimulator
{
    partial class Analysis
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
            this.itemListBox = new System.Windows.Forms.CheckedListBox();
            this.analyzeResultTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.anallysisItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambulance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.analyzeResultTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Items.AddRange(new object[] {
            "Rescue Success Rate",
            "Mean of Elapsed Time",
            "Standard Deviation of Elapsed Time"});
            this.itemListBox.Location = new System.Drawing.Point(10, 20);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(339, 148);
            this.itemListBox.TabIndex = 0;
            this.itemListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.itemListBox_ItemCheck);
            // 
            // analyzeResultTable
            // 
            this.analyzeResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analyzeResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anallysisItem,
            this.ambulance,
            this.drone});
            this.analyzeResultTable.Location = new System.Drawing.Point(12, 216);
            this.analyzeResultTable.Name = "analyzeResultTable";
            this.analyzeResultTable.RowTemplate.Height = 23;
            this.analyzeResultTable.Size = new System.Drawing.Size(362, 249);
            this.analyzeResultTable.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysis Item";
            // 
            // anallysisItem
            // 
            this.anallysisItem.HeaderText = "Analysis Item";
            this.anallysisItem.Name = "anallysisItem";
            // 
            // ambulance
            // 
            this.ambulance.HeaderText = "Ambulance";
            this.ambulance.Name = "ambulance";
            // 
            // drone
            // 
            this.drone.HeaderText = "Drone";
            this.drone.Name = "drone";
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 494);
            this.Controls.Add(this.analyzeResultTable);
            this.Controls.Add(this.groupBox1);
            this.Name = "Analysis";
            this.Text = "Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.analyzeResultTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox itemListBox;
        private System.Windows.Forms.DataGridView analyzeResultTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anallysisItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambulance;
        private System.Windows.Forms.DataGridViewTextBoxColumn drone;
    }
}