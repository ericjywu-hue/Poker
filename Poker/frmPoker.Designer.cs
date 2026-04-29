namespace Poker
{
    partial class frmPoker
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.lblTableLabel = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.lblHandIcon = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWinAmount = new System.Windows.Forms.Label();
            this.pnlBet = new System.Windows.Forms.Panel();
            this.lblBetHeader = new System.Windows.Forms.Label();
            this.pnlMoneyBox = new System.Windows.Forms.Panel();
            this.lblMoneyIcon = new System.Windows.Forms.Label();
            this.lblMoneyTitle = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.pnlBetInput = new System.Windows.Forms.Panel();
            this.lblBetLabel = new System.Windows.Forms.Label();
            this.nudBet = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblKeyHint = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlTable.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.pnlBet.SuspendLayout();
            this.pnlMoneyBox.SuspendLayout();
            this.pnlBetInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.pnlTable);
            this.pnlMain.Controls.Add(this.pnlBet);
            this.pnlMain.Controls.Add(this.pnlActions);
            this.pnlMain.Controls.Add(this.lblKeyHint);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(16);
            this.pnlMain.Size = new System.Drawing.Size(720, 620);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(26)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Location = new System.Drawing.Point(16, 16);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(688, 64);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ROYAL POKER";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(18, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(186, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "五張撲克牌 · Five Card Draw";
            // 
            // pnlTable
            // 
            this.pnlTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(68)))), ((int)(((byte)(38)))));
            this.pnlTable.Controls.Add(this.lblTableLabel);
            this.pnlTable.Controls.Add(this.pnlCards);
            this.pnlTable.Controls.Add(this.pnlResult);
            this.pnlTable.Location = new System.Drawing.Point(16, 88);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(688, 260);
            this.pnlTable.TabIndex = 1;
            // 
            // lblTableLabel
            // 
            this.lblTableLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblTableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(80)))));
            this.lblTableLabel.Location = new System.Drawing.Point(0, 6);
            this.lblTableLabel.Name = "lblTableLabel";
            this.lblTableLabel.Size = new System.Drawing.Size(688, 16);
            this.lblTableLabel.TabIndex = 0;
            this.lblTableLabel.Text = "P O K E R   T A B L E";
            this.lblTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlCards.Location = new System.Drawing.Point(16, 26);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(656, 150);
            this.pnlCards.TabIndex = 1;
            // 
            // pnlResult
            // 
            this.pnlResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(28)))));
            this.pnlResult.Controls.Add(this.lblHandIcon);
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Controls.Add(this.lblWinAmount);
            this.pnlResult.Location = new System.Drawing.Point(16, 185);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(656, 64);
            this.pnlResult.TabIndex = 2;
            // 
            // lblHandIcon
            // 
            this.lblHandIcon.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.lblHandIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.lblHandIcon.Location = new System.Drawing.Point(8, 10);
            this.lblHandIcon.Name = "lblHandIcon";
            this.lblHandIcon.Size = new System.Drawing.Size(46, 44);
            this.lblHandIcon.TabIndex = 0;
            this.lblHandIcon.Text = "♠";
            this.lblHandIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblResult.Location = new System.Drawing.Point(60, 8);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(440, 48);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "請押注後發牌開始遊戲";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWinAmount
            // 
            this.lblWinAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWinAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(220)))), ((int)(((byte)(120)))));
            this.lblWinAmount.Location = new System.Drawing.Point(510, 8);
            this.lblWinAmount.Name = "lblWinAmount";
            this.lblWinAmount.Size = new System.Drawing.Size(140, 48);
            this.lblWinAmount.TabIndex = 2;
            this.lblWinAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlBet
            // 
            this.pnlBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(26)))));
            this.pnlBet.Controls.Add(this.lblBetHeader);
            this.pnlBet.Controls.Add(this.pnlMoneyBox);
            this.pnlBet.Controls.Add(this.pnlBetInput);
            this.pnlBet.Location = new System.Drawing.Point(16, 360);
            this.pnlBet.Name = "pnlBet";
            this.pnlBet.Size = new System.Drawing.Size(688, 100);
            this.pnlBet.TabIndex = 2;
            // 
            // lblBetHeader
            // 
            this.lblBetHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblBetHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.lblBetHeader.Location = new System.Drawing.Point(0, 6);
            this.lblBetHeader.Name = "lblBetHeader";
            this.lblBetHeader.Size = new System.Drawing.Size(688, 16);
            this.lblBetHeader.TabIndex = 0;
            this.lblBetHeader.Text = "─── 下注區 ───";
            this.lblBetHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMoneyBox
            // 
            this.pnlMoneyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(20)))));
            this.pnlMoneyBox.Controls.Add(this.lblMoneyIcon);
            this.pnlMoneyBox.Controls.Add(this.lblMoneyTitle);
            this.pnlMoneyBox.Controls.Add(this.lblTotalMoney);
            this.pnlMoneyBox.Location = new System.Drawing.Point(16, 28);
            this.pnlMoneyBox.Name = "pnlMoneyBox";
            this.pnlMoneyBox.Size = new System.Drawing.Size(280, 58);
            this.pnlMoneyBox.TabIndex = 1;
            // 
            // lblMoneyIcon
            // 
            this.lblMoneyIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblMoneyIcon.Location = new System.Drawing.Point(8, 6);
            this.lblMoneyIcon.Name = "lblMoneyIcon";
            this.lblMoneyIcon.Size = new System.Drawing.Size(40, 44);
            this.lblMoneyIcon.TabIndex = 0;
            this.lblMoneyIcon.Text = "💰";
            this.lblMoneyIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoneyTitle
            // 
            this.lblMoneyTitle.AutoSize = true;
            this.lblMoneyTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMoneyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.lblMoneyTitle.Location = new System.Drawing.Point(56, 8);
            this.lblMoneyTitle.Name = "lblMoneyTitle";
            this.lblMoneyTitle.Size = new System.Drawing.Size(51, 19);
            this.lblMoneyTitle.TabIndex = 1;
            this.lblMoneyTitle.Text = "總資金";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTotalMoney.Location = new System.Drawing.Point(54, 24);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(220, 30);
            this.lblTotalMoney.TabIndex = 2;
            this.lblTotalMoney.Text = "100,000";
            // 
            // pnlBetInput
            // 
            this.pnlBetInput.BackColor = System.Drawing.Color.Transparent;
            this.pnlBetInput.Controls.Add(this.lblBetLabel);
            this.pnlBetInput.Controls.Add(this.nudBet);
            this.pnlBetInput.Controls.Add(this.btnBet);
            this.pnlBetInput.Location = new System.Drawing.Point(310, 28);
            this.pnlBetInput.Name = "pnlBetInput";
            this.pnlBetInput.Size = new System.Drawing.Size(362, 58);
            this.pnlBetInput.TabIndex = 2;
            // 
            // lblBetLabel
            // 
            this.lblBetLabel.AutoSize = true;
            this.lblBetLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.lblBetLabel.Location = new System.Drawing.Point(0, 4);
            this.lblBetLabel.Name = "lblBetLabel";
            this.lblBetLabel.Size = new System.Drawing.Size(65, 19);
            this.lblBetLabel.TabIndex = 0;
            this.lblBetLabel.Text = "押注金額";
            // 
            // nudBet
            // 
            this.nudBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(20)))));
            this.nudBet.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.nudBet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.nudBet.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBet.Location = new System.Drawing.Point(0, 24);
            this.nudBet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBet.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBet.Name = "nudBet";
            this.nudBet.Size = new System.Drawing.Size(200, 33);
            this.nudBet.TabIndex = 0;
            this.nudBet.ThousandsSeparator = true;
            this.nudBet.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(30)))));
            this.btnBet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBet.FlatAppearance.BorderSize = 0;
            this.btnBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnBet.Location = new System.Drawing.Point(210, 22);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(148, 32);
            this.btnBet.TabIndex = 1;
            this.btnBet.Text = "押注  ↵";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(26)))));
            this.pnlActions.Controls.Add(this.btnDealCard);
            this.pnlActions.Controls.Add(this.btnChangeCard);
            this.pnlActions.Controls.Add(this.btnCheck);
            this.pnlActions.Location = new System.Drawing.Point(16, 472);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(688, 80);
            this.pnlActions.TabIndex = 3;
            // 
            // btnDealCard
            // 
            this.btnDealCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.btnDealCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDealCard.Enabled = false;
            this.btnDealCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnDealCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDealCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDealCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(230)))), ((int)(((byte)(180)))));
            this.btnDealCard.Location = new System.Drawing.Point(16, 20);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(200, 42);
            this.btnDealCard.TabIndex = 2;
            this.btnDealCard.Text = "🃏  發牌  [F1]";
            this.btnDealCard.UseVisualStyleBackColor = false;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnChangeCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.btnChangeCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnChangeCard.Location = new System.Drawing.Point(236, 20);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(200, 42);
            this.btnChangeCard.TabIndex = 3;
            this.btnChangeCard.Text = "🔄  換牌  [F2]";
            this.btnChangeCard.UseVisualStyleBackColor = false;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(130)))));
            this.btnCheck.Location = new System.Drawing.Point(456, 20);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(216, 42);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "✔  判斷牌型  [F3]";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblKeyHint
            // 
            this.lblKeyHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblKeyHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(70)))));
            this.lblKeyHint.Location = new System.Drawing.Point(16, 560);
            this.lblKeyHint.Name = "lblKeyHint";
            this.lblKeyHint.Size = new System.Drawing.Size(688, 18);
            this.lblKeyHint.TabIndex = 4;
            this.lblKeyHint.Text = "Tab 切換焦點　　Enter / Space 確認按鈕　　點擊牌面可翻牌保留";
            this.lblKeyHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPoker
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(720, 620);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🃏  Royal Poker";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPoker_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            this.pnlResult.ResumeLayout(false);
            this.pnlBet.ResumeLayout(false);
            this.pnlMoneyBox.ResumeLayout(false);
            this.pnlMoneyBox.PerformLayout();
            this.pnlBetInput.ResumeLayout(false);
            this.pnlBetInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Controls
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Label lblTableLabel;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Label lblHandIcon;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWinAmount;
        private System.Windows.Forms.Panel pnlBet;
        private System.Windows.Forms.Label lblBetHeader;
        private System.Windows.Forms.Panel pnlMoneyBox;
        private System.Windows.Forms.Label lblMoneyIcon;
        private System.Windows.Forms.Label lblMoneyTitle;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Panel pnlBetInput;
        private System.Windows.Forms.Label lblBetLabel;
        private System.Windows.Forms.NumericUpDown nudBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblKeyHint;
    }
}