using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Poker
{
    public partial class frmPoker : Form
    {
        // ── 牌面控件 ──────────────────────────────────────────────
        PictureBox[] pic = new PictureBox[5];

        // ── 下注相關 ──────────────────────────────────────────────
        int totalMoney = 100000;
        int betAmount = 0;
        bool hasBet = false;

        // ── 牌組資料 ──────────────────────────────────────────────
        int[] allPoker = new int[52];
        int[] playerPoker = new int[5];

        // ── 牌型賠率表 ─────────────────────────────────────────────
        static readonly (string key, int odds, string emoji)[] OddsTable =
        {
            ("同花大順", 250, "👑"),
            ("同花順",    50, "🌊"),
            ("鐵支",      25, "🔥"),
            ("葫蘆",       9, "🏠"),
            ("同花",       6, "♦"),
            ("順子",       4, "➡"),
            ("三條",       3, "3️⃣"),
            ("兩對",       2, "2️⃣"),
            ("一對",       1, "1️⃣"),
        };

        // ── 建構子 ────────────────────────────────────────────────
        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
            UpdateMoneyDisplay();
            // grpPoker 不存在，改用 pnlCards
        }

        // ─────────────────────────────────────────────────────────
        //  初始化牌面
        // ─────────────────────────────────────────────────────────
        private Image GetPic(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }

        private void InitializePoker()
        {
            Image back = GetPic("back");
            int cardW = back?.Width ?? 72;
            int cardH = back?.Height ?? 100;
            int spacing = 12;
            int totalW = cardW * 5 + spacing * 4;
            int startX = (pnlCards.Width - totalW) / 2;
            int startY = (pnlCards.Height - cardH) / 2;

            for (int i = 0; i < 5; i++)
            {
                pic[i] = new PictureBox
                {
                    Image = back,
                    Name = "pic" + i,
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Top = startY > 0 ? startY : 10,
                    Left = startX + (cardW + spacing) * i,
                    Visible = true,
                    Enabled = false,
                    Tag = "back",
                    Cursor = Cursors.Hand,
                    BackColor = Color.Transparent
                };
                // 底部金框 highlight 用 Panel
                Panel highlight = new Panel
                {
                    Name = "hl" + i,
                    Location = new Point(pic[i].Left, pic[i].Top + cardH + 4),
                    Size = new Size(cardW, 4),
                    BackColor = Color.Transparent,
                    Visible = false
                };
                pnlCards.Controls.Add(highlight);
                pnlCards.Controls.Add(pic[i]);
                pic[i].MouseClick += pic_Click;
            }
        }

        private Panel GetHighlight(int index)
            => pnlCards.Controls["hl" + index] as Panel;

        // ─────────────────────────────────────────────────────────
        //  顯示牌面
        // ─────────────────────────────────────────────────────────
        private void ShowCards()
        {
            for (int i = 0; i < 5; i++)
                pic[i].Image = GetPic($"pic{playerPoker[i] + 1}");
        }

        // ─────────────────────────────────────────────────────────
        //  點擊牌面（翻牌/保留選擇）
        // ─────────────────────────────────────────────────────────
        private void pic_Click(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int index = int.Parse(p.Name.Replace("pic", ""));
            Panel hl = GetHighlight(index);

            if (p.Tag.ToString() == "front")
            {
                // 蓋牌 = 標記為「要換牌」
                p.Tag = "back";
                p.Image = GetPic("back");
                if (hl != null) { hl.BackColor = Color.FromArgb(212, 60, 60); hl.Visible = true; }
            }
            else
            {
                // 翻回正面 = 保留
                p.Tag = "front";
                p.Image = GetPic("pic" + (playerPoker[index] + 1));
                if (hl != null) { hl.BackColor = Color.FromArgb(60, 200, 100); hl.Visible = true; }
            }
        }

        // ─────────────────────────────────────────────────────────
        //  更新金額顯示
        // ─────────────────────────────────────────────────────────
        private void UpdateMoneyDisplay()
        {
            lblTotalMoney.Text = totalMoney.ToString("N0");
            // 低於初始 1/4 時變紅提示
            lblTotalMoney.ForeColor = totalMoney < 250000
                ? Color.FromArgb(220, 80, 80)
                : Color.FromArgb(212, 175, 55);
        }

        // ─────────────────────────────────────────────────────────
        //  鍵盤快捷鍵
        // ─────────────────────────────────────────────────────────
        private void frmPoker_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1 when btnDealCard.Enabled:
                    btnDealCard_Click(null, null); break;
                case Keys.F2 when btnChangeCard.Enabled:
                    btnChangeCard_Click(null, null); break;
                case Keys.F3 when btnCheck.Enabled:
                    btnCheck_Click(null, null); break;
                // 數字鍵 1-5 翻牌
                case Keys.D1: ToggleCard(0); break;
                case Keys.D2: ToggleCard(1); break;
                case Keys.D3: ToggleCard(2); break;
                case Keys.D4: ToggleCard(3); break;
                case Keys.D5: ToggleCard(4); break;
            }
        }

        private void ToggleCard(int i)
        {
            if (pic[i].Enabled)
                pic_Click(pic[i], new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
        }

        // ─────────────────────────────────────────────────────────
        //  洗牌
        // ─────────────────────────────────────────────────────────
        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < allPoker.Length; i++)
            {
                int r = rand.Next(allPoker.Length);
                int t = allPoker[r]; allPoker[r] = allPoker[0]; allPoker[0] = t;
            }
        }

        // ─────────────────────────────────────────────────────────
        //  押注按鈕
        // ─────────────────────────────────────────────────────────
        private void btnBet_Click(object sender, EventArgs e)
        {
            int bet = (int)nudBet.Value;

            if (bet > totalMoney)
            {
                SetStatus($"⚠  押注金額 ({bet:N0}) 超過總資金！", Color.FromArgb(220, 80, 80));
                return;
            }

            betAmount = bet;
            totalMoney -= betAmount;
            hasBet = true;
            UpdateMoneyDisplay();

            btnDealCard.Enabled = true;
            btnBet.Enabled = false;
            nudBet.Enabled = false;

            SetStatus($"已押注 {betAmount:N0} 元　請按 [發牌] 或 F1", Color.FromArgb(180, 160, 80));
            lblWinAmount.Text = "";
            lblHandIcon.Text = "🃏";
        }

        // ─────────────────────────────────────────────────────────
        //  發牌按鈕
        // ─────────────────────────────────────────────────────────
        private void btnDealCard_Click(object sender, EventArgs e)
        {
            if (!hasBet) return;

            // 清除 highlight
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = GetPic("back");
                Panel hl = GetHighlight(i);
                if (hl != null) hl.Visible = false;
            }

            for (int i = 0; i < 52; i++) allPoker[i] = i;
            Shuffle();
            for (int i = 0; i < 5; i++) playerPoker[i] = allPoker[i];

            ShowCards();

            for (int i = 0; i < 5; i++)
            {
                pic[i].Enabled = true;
                pic[i].Tag = "front";
                Panel hl = GetHighlight(i);
                if (hl != null) { hl.BackColor = Color.FromArgb(60, 200, 100); hl.Visible = true; }
            }

            btnDealCard.Enabled = false;
            btnChangeCard.Enabled = true;
            btnCheck.Enabled = true;

            SetStatus("點擊牌面或按 1-5 翻牌（蓋牌=換牌）\n　F2 換牌　F3 判斷",
                      Color.FromArgb(160, 200, 140));
            lblWinAmount.Text = "";
        }

        // ─────────────────────────────────────────────────────────
        //  換牌按鈕
        // ─────────────────────────────────────────────────────────
        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            int cardIndex = 5;
            for (int i = 0; i < 5; i++)
            {
                if (pic[i].Tag.ToString() == "back")
                {
                    playerPoker[i] = allPoker[cardIndex++];
                    pic[i].Image = GetPic("pic" + (playerPoker[i] + 1));
                    pic[i].Tag = "front";
                }
                pic[i].Enabled = false;
                Panel hl = GetHighlight(i);
                if (hl != null) hl.Visible = false;
            }

            btnChangeCard.Enabled = false;
            btnCheck.Enabled = true;
            SetStatus("換牌完成！按 [判斷牌型] 或 F3 查看結果", Color.FromArgb(160, 200, 140));
        }

        // ─────────────────────────────────────────────────────────
        //  判斷牌型
        // ─────────────────────────────────────────────────────────
        private int GetOdds(string hand)
        {
            foreach (var (key, odds, _) in OddsTable)
                if (hand.Contains(key)) return odds;
            return 0;
        }

        private string GetHandEmoji(string hand)
        {
            foreach (var (key, _, emoji) in OddsTable)
                if (hand.Contains(key)) return emoji;
            return "💨";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string[] colorList = { "梅花", "方塊", "愛心", "黑桃" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            int[] pokerColor = new int[5];
            int[] pokerPoint = new int[5];
            for (int i = 0; i < 5; i++)
            {
                pokerColor[i] = playerPoker[i] % 4;
                pokerPoint[i] = playerPoker[i] / 4;
            }

            int[] colorCount = new int[4];
            int[] pointCount = new int[13];
            for (int i = 0; i < 5; i++)
            {
                colorCount[pokerColor[i]]++;
                pointCount[pokerPoint[i]]++;
            }

            Array.Sort(colorCount, colorList);
            Array.Reverse(colorCount); Array.Reverse(colorList);
            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount); Array.Reverse(pointList);

            bool isFlush = colorCount[0] == 5;
            bool isSingle = pointCount[0] == 1 && pointCount[4] == 1;
            bool isDiffFour = pokerPoint.Max() - pokerPoint.Min() == 4;
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) &&
                                   pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);
            bool isRoyalFlush = isFlush && isRoyal;
            bool isStraightFlush = isFlush && isSingle && isDiffFour;
            bool isStraight = isSingle && (isDiffFour || isRoyal);
            bool isFourOfAKind = pointCount[0] == 4;
            bool isFullHouse = pointCount[0] == 3 && pointCount[1] == 2;
            bool isThreeOfAKind = pointCount[0] == 3 && pointCount[1] == 1;
            bool isTwoPair = pointCount[0] == 2 && pointCount[1] == 2;
            bool isOnePair = pointCount[0] == 2 && pointCount[1] == 1;

            string result =
                isRoyalFlush ? $"{colorList[0]} 同花大順" :
                isStraightFlush ? $"{colorList[0]} 同花順" :
                isStraight ? "順子" :
                isFourOfAKind ? $"{pointList[0]} 鐵支" :
                isFullHouse ? $"{pointList[0]}三張{pointList[1]}兩張 葫蘆" :
                isFlush ? $"{colorList[0]} 同花" :
                isThreeOfAKind ? $"{pointList[0]} 三條" :
                isTwoPair ? $"{pointList[0]},{pointList[1]} 兩對" :
                isOnePair ? $"{pointList[0]} 一對" :
                                  "雜牌";

            int odds = GetOdds(result);
            string emoji = GetHandEmoji(result);
            int winAmount = betAmount * odds;
            totalMoney += winAmount;
            UpdateMoneyDisplay();

            // 更新結果顯示
            lblHandIcon.Text = emoji;
            lblResult.Text = result;

            if (winAmount > 0)
            {
                lblWinAmount.Text = $"+{winAmount:N0}";
                lblWinAmount.ForeColor = Color.FromArgb(100, 220, 120);
                pnlResult.BackColor = Color.FromArgb(20, 65, 32);
            }
            else
            {
                lblWinAmount.Text = $"-{betAmount:N0}";
                lblWinAmount.ForeColor = Color.FromArgb(220, 90, 90);
                pnlResult.BackColor = Color.FromArgb(55, 20, 20);
            }

            // 重置
            hasBet = false;
            betAmount = 0;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;
            btnDealCard.Enabled = false;

            if (totalMoney <= 0)
            {
                totalMoney = 1000000;
                UpdateMoneyDisplay();
                SetStatus("💸  已破產！資金重置為 1,000,000", Color.FromArgb(220, 90, 90));
            }
            else
            {
                SetStatus("本局結算完畢　請重新押注開始下一局", Color.FromArgb(140, 120, 60));
            }

            btnBet.Enabled = true;
            nudBet.Enabled = true;
            nudBet.Maximum = totalMoney;
        }

        // ─────────────────────────────────────────────────────────
        //  輔助：設定狀態文字
        // ─────────────────────────────────────────────────────────
        private void SetStatus(string text, Color color)
        {
            lblResult.Text = text;
            lblResult.ForeColor = color;
        }
    }
}