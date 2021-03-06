﻿namespace ChitChat
{
    partial class UserMain
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.contacts = new System.Windows.Forms.ListBox();
            this.chatBtn = new System.Windows.Forms.Button();
            this.addCtBtn = new System.Windows.Forms.Button();
            this.checkNoti_ = new System.Windows.Forms.Timer(this.components);
            this.notificationBox = new System.Windows.Forms.RichTextBox();
            this.organizeMessages_ = new System.Windows.Forms.Timer(this.components);
            this.createGrpChat_btn = new System.Windows.Forms.Button();
            this.checkAcceptedInvitation_ = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(12, 9);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(534, 46);
            this.welcomeLbl.TabIndex = 3;
            this.welcomeLbl.Text = "Hi ";
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contacts
            // 
            this.contacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts.FormattingEnabled = true;
            this.contacts.ItemHeight = 18;
            this.contacts.Location = new System.Drawing.Point(12, 93);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(304, 182);
            this.contacts.TabIndex = 4;
            // 
            // chatBtn
            // 
            this.chatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chatBtn.BackColor = System.Drawing.Color.Orange;
            this.chatBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBtn.Location = new System.Drawing.Point(219, 292);
            this.chatBtn.Name = "chatBtn";
            this.chatBtn.Size = new System.Drawing.Size(97, 43);
            this.chatBtn.TabIndex = 8;
            this.chatBtn.Text = "Chat";
            this.chatBtn.UseVisualStyleBackColor = false;
            this.chatBtn.Click += new System.EventHandler(this.chatBtn_Click);
            // 
            // addCtBtn
            // 
            this.addCtBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCtBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCtBtn.BackColor = System.Drawing.Color.Orange;
            this.addCtBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCtBtn.Location = new System.Drawing.Point(420, 292);
            this.addCtBtn.Name = "addCtBtn";
            this.addCtBtn.Size = new System.Drawing.Size(126, 43);
            this.addCtBtn.TabIndex = 10;
            this.addCtBtn.Text = "Add Contact";
            this.addCtBtn.UseVisualStyleBackColor = false;
            this.addCtBtn.Click += new System.EventHandler(this.addCtBtn_Click);
            // 
            // notificationBox
            // 
            this.notificationBox.BackColor = System.Drawing.SystemColors.Window;
            this.notificationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationBox.Location = new System.Drawing.Point(359, 93);
            this.notificationBox.MaxLength = 0;
            this.notificationBox.Name = "notificationBox";
            this.notificationBox.ReadOnly = true;
            this.notificationBox.Size = new System.Drawing.Size(187, 182);
            this.notificationBox.TabIndex = 11;
            this.notificationBox.Text = "";
            // 
            // createGrpChat_btn
            // 
            this.createGrpChat_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createGrpChat_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createGrpChat_btn.BackColor = System.Drawing.Color.Orange;
            this.createGrpChat_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGrpChat_btn.Location = new System.Drawing.Point(12, 292);
            this.createGrpChat_btn.Name = "createGrpChat_btn";
            this.createGrpChat_btn.Size = new System.Drawing.Size(201, 43);
            this.createGrpChat_btn.TabIndex = 12;
            this.createGrpChat_btn.Text = "Invite to a group chat";
            this.createGrpChat_btn.UseVisualStyleBackColor = false;
            this.createGrpChat_btn.Click += new System.EventHandler(this.createGrpChat_btn_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(558, 347);
            this.Controls.Add(this.createGrpChat_btn);
            this.Controls.Add(this.notificationBox);
            this.Controls.Add(this.addCtBtn);
            this.Controls.Add(this.chatBtn);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.welcomeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserMain";
            this.Text = "User Main";
            this.Load += new System.EventHandler(this.UserMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.ListBox contacts;
        private System.Windows.Forms.Button chatBtn;
        private System.Windows.Forms.Button addCtBtn;
        private System.Windows.Forms.Timer checkNoti_;
        private System.Windows.Forms.RichTextBox notificationBox;
        private System.Windows.Forms.Timer organizeMessages_;
        private System.Windows.Forms.Button createGrpChat_btn;
        private System.Windows.Forms.Timer checkAcceptedInvitation_;
    }
}