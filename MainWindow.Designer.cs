using System;

namespace BaroChecklist
{
    partial class MainWindow
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
            this.costsGroup = new System.Windows.Forms.GroupBox();
            this.creditsCost = new System.Windows.Forms.Label();
            this.ducatsCost = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.filterTextTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Checklist = new BaroChecklist.TreeViewExtension();
            this.versionText = new System.Windows.Forms.TextBox();
            this.creditsIcon = new System.Windows.Forms.PictureBox();
            this.ducatsIcon = new System.Windows.Forms.PictureBox();
            this.itemPicture = new System.Windows.Forms.PictureBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.costsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducatsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // costsGroup
            // 
            this.costsGroup.BackColor = System.Drawing.SystemColors.ControlDark;
            this.costsGroup.Controls.Add(this.creditsIcon);
            this.costsGroup.Controls.Add(this.creditsCost);
            this.costsGroup.Controls.Add(this.ducatsCost);
            this.costsGroup.Controls.Add(this.ducatsIcon);
            this.costsGroup.Location = new System.Drawing.Point(295, 239);
            this.costsGroup.Name = "costsGroup";
            this.costsGroup.Size = new System.Drawing.Size(208, 186);
            this.costsGroup.TabIndex = 2;
            this.costsGroup.TabStop = false;
            this.costsGroup.Text = "Costs";
            // 
            // creditsCost
            // 
            this.creditsCost.AutoSize = true;
            this.creditsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsCost.Location = new System.Drawing.Point(68, 82);
            this.creditsCost.Name = "creditsCost";
            this.creditsCost.Size = new System.Drawing.Size(74, 39);
            this.creditsCost.TabIndex = 1;
            this.creditsCost.Text = "N/A";
            // 
            // ducatsCost
            // 
            this.ducatsCost.AutoSize = true;
            this.ducatsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ducatsCost.Location = new System.Drawing.Point(68, 26);
            this.ducatsCost.Name = "ducatsCost";
            this.ducatsCost.Size = new System.Drawing.Size(74, 39);
            this.ducatsCost.TabIndex = 1;
            this.ducatsCost.Text = "N/A";
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(295, 11);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(100, 20);
            this.filterBox.TabIndex = 3;
            this.filterBox.Text = "Enter Filter...";
            this.filterBox.WordWrap = false;
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            this.filterBox.MouseHover += new System.EventHandler(this.filterTextBox_Hover);
            // 
            // Checklist
            // 
            this.Checklist.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Checklist.CheckBoxes = true;
            this.Checklist.Location = new System.Drawing.Point(0, 0);
            this.Checklist.Name = "Checklist";
            this.Checklist.Size = new System.Drawing.Size(289, 449);
            this.Checklist.TabIndex = 0;
            this.Checklist.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.Checklist_AfterCheck);
            this.Checklist.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Checklist_AfterSelect);
            // 
            // versionText
            // 
            this.versionText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.versionText.Location = new System.Drawing.Point(698, 429);
            this.versionText.Name = "versionText";
            this.versionText.ReadOnly = true;
            this.versionText.Size = new System.Drawing.Size(100, 20);
            this.versionText.TabIndex = 4;
            this.versionText.Text = "Version";
            this.versionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // creditsIcon
            // 
            this.creditsIcon.Image = global::BaroChecklist.Properties.Resources.Image_Credits_Large;
            this.creditsIcon.Location = new System.Drawing.Point(6, 77);
            this.creditsIcon.Name = "creditsIcon";
            this.creditsIcon.Size = new System.Drawing.Size(54, 50);
            this.creditsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creditsIcon.TabIndex = 2;
            this.creditsIcon.TabStop = false;
            // 
            // ducatsIcon
            // 
            this.ducatsIcon.Image = global::BaroChecklist.Properties.Resources.Image_Ducats;
            this.ducatsIcon.Location = new System.Drawing.Point(6, 19);
            this.ducatsIcon.Name = "ducatsIcon";
            this.ducatsIcon.Size = new System.Drawing.Size(54, 52);
            this.ducatsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducatsIcon.TabIndex = 0;
            this.ducatsIcon.TabStop = false;
            // 
            // itemPicture
            // 
            this.itemPicture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.itemPicture.Location = new System.Drawing.Point(295, 37);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.Size = new System.Drawing.Size(208, 196);
            this.itemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.itemPicture.TabIndex = 1;
            this.itemPicture.TabStop = false;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(723, 389);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 34);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Check For Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.costsGroup);
            this.Controls.Add(this.itemPicture);
            this.Controls.Add(this.Checklist);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MainWindow";
            this.Text = "Baro Checklist";
            this.costsGroup.ResumeLayout(false);
            this.costsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducatsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox itemPicture;
        private System.Windows.Forms.GroupBox costsGroup;
        private TreeViewExtension Checklist;
        private System.Windows.Forms.PictureBox ducatsIcon;
        private System.Windows.Forms.Label ducatsCost;
        private System.Windows.Forms.PictureBox creditsIcon;
        private System.Windows.Forms.Label creditsCost;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.ToolTip filterTextTooltip;
        private System.Windows.Forms.TextBox versionText;
        private System.Windows.Forms.Button updateButton;
    }
}

