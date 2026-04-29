using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class frmPoker : Form
    {
        PictureBox[] pic = new PictureBox[5];

        // ── 下注相關變數 ──
        int totalMoney = 1000000;   // 總資金
        int betAmount = 0;          // 本局押注金額
        bool hasBet = false;        // 是否已押注

        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
            UpdateMoneyDisplay();
        }

        private Image GetPic(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }

        private void InitializePoker()
        {
            // 動態產生5張牌
            for (int i = 0; i < 5; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetPic("back");
                pic[i].Name = "pic" + i;
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                pic[i].Visible = true;
                pic[i].Enabled = false;
                pic[i].Tag = "back";
                // 將 pic 丟至到 grpPoker 內
                this.grpPoker.Controls.Add(pic[i]);
                pic[i].MouseClick += new MouseEventHandler(pic_Click);
            }
        }

        /// <summary>
        /// 更新總資金顯示
        /// </summary>
        private void UpdateMoneyDisplay()
        {
            lblTotalMoney.Text = totalMoney.ToString("N0");
        }

        /// <summary>
        /// 顯示五張撲克牌到桌面上
        /// </summary>
        private void ShowCards()
        {
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = this.GetPic($"pic{playerPoker[i] + 1}");
            }
        }

        private void pic_Click(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            // 取得 pic 的索引值
            int index = int.Parse(pic.Name.Replace("pic", ""));

            int cardNum = playerPoker[index] + 1;
            // 如果 pic 的 Tag 為 back，則將顯示撲克牌
            if (pic.Tag.ToString() == "back")
            {
                pic.Tag = "front";
                pic.Image = GetPic("pic" + (allPoker[index] + 1));
            }
            else
            {
                pic.Tag = "back";
                pic.Image = GetPic("back");
            }
        }

        int[] allPoker = new int[52];
        int[] playerPoker = new int[5];

        /// <summary>
        /// 押注按鈕：扣除押注金額，鎖定押注，啟用發牌
        /// </summary>
        private void btnBet_Click_1(object sender, EventArgs e)
        {
            int bet;
            if (!int.TryParse(txtBet.Text, out bet) || bet <= 0)
            {
                MessageBox.Show("請輸入有效的押注金額（正整數）！", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bet > totalMoney)
            {
                MessageBox.Show("押注金額不可超過總資金！", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            betAmount = bet;
            totalMoney -= betAmount;
            hasBet = true;

            UpdateMoneyDisplay();

            // 押注後啟用發牌，禁用押注
            btnDealCard.Enabled = true;
            btnBet.Enabled = false;
            txtBet.Enabled = false;

            lblResult.Text = $"已押注 {betAmount:N0} 元，請發牌！";
        }

        private void btnDealCard_Click(object sender, EventArgs e)
        {
            if (!hasBet)
            {
                MessageBox.Show("請先押注再發牌！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 先將牌面蓋掉
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = GetPic("back");
            }
            // 初始化52張牌
            for (int i = 0; i < 52; i++)
            {
                allPoker[i] = i;
            }
            // 洗牌
            Shuffle();
            // 發牌
            for (int i = 0; i < 5; i++)
            {
                playerPoker[i] = allPoker[i];
            }

            this.ShowCards();

            // 啟用所有牌的點擊事件
            for (int i = 0; i < 5; i++)
            {
                pic[i].Enabled = true;
                pic[i].Tag = "front";
            }
            btnDealCard.Enabled = false;
            btnChangeCard.Enabled = true;
            btnCheck.Enabled = true;
            lblResult.Text = "";
        }

        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < allPoker.Length; i++)
            {
                int r = rand.Next(allPoker.Length);
                int temp = allPoker[r];
                allPoker[r] = allPoker[0];
                allPoker[0] = temp;
            }
        }

        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            int cardIndex = 5;
            for (int i = 0; i < pic.Length; i++)
            {
                if (pic[i].Tag.ToString() == "back")
                {
                    playerPoker[i] = allPoker[cardIndex];
                    pic[i].Image = GetPic("pic" + (playerPoker[i] + 1));
                    pic[i].Tag = "front";
                    cardIndex++;
                }
            }
            // 禁用所有牌的點擊事件
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Enabled = false;
            }
            btnCheck.Enabled = true;
            btnChangeCard.Enabled = false;
        }

        /// <summary>
        /// 取得牌型賠率
        /// </summary>
        private int GetOdds(string handName)
        {
            if (handName.Contains("同花大順")) return 250;
            if (handName.Contains("同花順")) return 50;
            if (handName.Contains("鐵支")) return 25;
            if (handName.Contains("葫蘆")) return 9;
            if (handName.Contains("同花")) return 6;
            if (handName == "順子") return 4;
            if (handName.Contains("三條")) return 3;
            if (handName.Contains("兩對")) return 2;
            if (handName.Contains("一對")) return 1;
            return 0; // 雜牌
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string[] colorList = { "梅花", "方塊", "愛心", "黑桃" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            // 計錄目前五張撲克牌的花色和點數的陣列
            int[] pokerColor = new int[5];
            int[] pokerPoint = new int[5];
            // 將每張牌的顏色和點數分別存入 pokerColor 和 pokerPoint 陣列
            for (int i = 0; i < 5; i++)
            {
                pokerColor[i] = playerPoker[i] % 4;
                pokerPoint[i] = playerPoker[i] / 4;
            }
            // 統計 color 和 point 出現次數
            int[] colorCount = new int[4];
            int[] pointCount = new int[13];
            for (int i = 0; i < 5; i++)
            {
                int color = pokerColor[i];
                int point = pokerPoint[i];
                colorCount[color]++;
                pointCount[point]++;
            }
            // 排序 colorCount 和 pointCount 由大到小
            Array.Sort(colorCount, colorList);
            Array.Reverse(colorCount);
            Array.Reverse(colorList);
            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount);
            Array.Reverse(pointList);
            // 判斷是否為同花
            bool isFlush = (colorCount[0] == 5);
            // 判斷是否為五張單張
            bool isSingle = (pointCount[0] == 1 && pointCount[1] == 1 && pointCount[2] == 1 &&
            pointCount[3] == 1 && pointCount[4] == 1);
            // 判斷是否為差四
            bool isDiffFout = (pokerPoint.Max() - pokerPoint.Min() == 4);
            // 判斷是否為大順
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) &&
            pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);
            // 判斷是否為同花大順
            bool isRoyalisFlush = isFlush && isRoyal;
            // 判斷是否為同花順
            bool isStraightFlush = isFlush && isSingle && isDiffFout;
            // 判斷是否為順子
            bool isStraight = isSingle && (isDiffFout || isRoyal);
            // 判斷是否為鐵支
            bool isFourOfAKind = (pointCount[0] == 4);
            // 判斷是否為葫蘆
            bool isFullHouse = (pointCount[0] == 3 && pointCount[1] == 2);
            // 判斷是否為三條
            bool isThreeOfAKind = (pointCount[0] == 3 && pointCount[1] == 1);
            // 判斷是否為兩對
            bool isTwoPair = (pointCount[0] == 2 && pointCount[1] == 2);
            // 判斷是否為一對
            bool isOnePair = (pointCount[0] == 2 && pointCount[1] == 1);

            string result = "";
            if (isRoyalisFlush)
                result = $"{colorList[0]} 同花大順";
            else if (isStraightFlush)
                result = $"{colorList[0]} 同花順";
            else if (isStraight)
                result = "順子";
            else if (isFourOfAKind)
                result = $"{pointList[0]} 鐵支";
            else if (isFullHouse)
                result = $"{pointList[0]}三張{pointList[1]}兩張 葫蘆";
            else if (isFlush)
                result = $"{colorList[0]} 同花";
            else if (isThreeOfAKind)
                result = $"{pointList[0]} 三條";
            else if (isTwoPair)
                result = $"{pointList[0]},{pointList[1]} 兩對";
            else if (isOnePair)
                result = $"{pointList[0]} 一對";
            else
                result = "雜牌";

            // ── 計算中獎金額 ──
            int odds = GetOdds(result);
            int winAmount = betAmount * odds;
            totalMoney += winAmount;
            UpdateMoneyDisplay();

            if (winAmount > 0)
                lblResult.Text = $"{result}　賠率 x{odds}　獲得 {winAmount:N0} 元！";
            else
                lblResult.Text = $"{result}　未中獎";

            // 重置下注狀態，準備下一局
            hasBet = false;
            betAmount = 0;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;
            btnDealCard.Enabled = false;

            // 若資金歸零
            if (totalMoney <= 0)
            {
                MessageBox.Show("你已破產！遊戲結束。", "遊戲結束",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                totalMoney = 1000000; // 重置資金
                UpdateMoneyDisplay();
            }

            // 開放押注，進行下一局
            btnBet.Enabled = true;
            txtBet.Enabled = true;
        }

    }
}