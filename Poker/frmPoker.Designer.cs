namespace Poker
{
    partial class frmPoker
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
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grpBet = new System.Windows.Forms.GroupBox();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblMoneyTitle = new System.Windows.Forms.Label();
            this.lblBetTitle = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.grpPoker.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.grpBet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.AutoSize = true;
            this.grpPoker.Controls.Add(this.grpBet);
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(12, 27);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(645, 360);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(12, 360);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(633, 84);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(352, 33);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(275, 45);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(200, 33);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(146, 45);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(103, 33);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(91, 45);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(6, 33);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(91, 45);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // grpBet
            // 
            this.grpBet.Controls.Add(this.btnBet);
            this.grpBet.Controls.Add(this.txtBet);
            this.grpBet.Controls.Add(this.lblBetTitle);
            this.grpBet.Controls.Add(this.lblMoneyTitle);
            this.grpBet.Controls.Add(this.lblTotalMoney);
            this.grpBet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBet.Location = new System.Drawing.Point(0, 243);
            this.grpBet.Name = "grpBet";
            this.grpBet.Size = new System.Drawing.Size(633, 84);
            this.grpBet.TabIndex = 4;
            this.grpBet.TabStop = false;
            this.grpBet.Text = "下注";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalMoney.Location = new System.Drawing.Point(87, 30);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(195, 45);
            this.lblTotalMoney.TabIndex = 3;
            this.lblTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoneyTitle
            // 
            this.lblMoneyTitle.AutoSize = true;
            this.lblMoneyTitle.Location = new System.Drawing.Point(9, 40);
            this.lblMoneyTitle.Name = "lblMoneyTitle";
            this.lblMoneyTitle.Size = new System.Drawing.Size(72, 25);
            this.lblMoneyTitle.TabIndex = 4;
            this.lblMoneyTitle.Text = "總資金";
            // 
            // lblBetTitle
            // 
            this.lblBetTitle.AutoSize = true;
            this.lblBetTitle.Location = new System.Drawing.Point(288, 40);
            this.lblBetTitle.Name = "lblBetTitle";
            this.lblBetTitle.Size = new System.Drawing.Size(92, 25);
            this.lblBetTitle.TabIndex = 5;
            this.lblBetTitle.Text = "押注金額";
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(386, 37);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(142, 34);
            this.txtBet.TabIndex = 6;
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(534, 30);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(93, 45);
            this.btnBet.TabIndex = 7;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click_1);
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 456);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.Name = "frmPoker";
            this.Text = "frmPoker";
            this.grpPoker.ResumeLayout(false);
            this.grpButton.ResumeLayout(false);
            this.grpBet.ResumeLayout(false);
            this.grpBet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpBet;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblBetTitle;
        private System.Windows.Forms.Label lblMoneyTitle;
        private System.Windows.Forms.Button btnBet;
    }
}