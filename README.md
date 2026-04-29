# 🃏 Royal Poker — 五張撲克牌

---

## 專案簡介

以 **C# WinForms** 開發的五張撲克牌遊戲，玩家可以發牌、選擇保留或換牌，並根據最終牌型獲得對應賠率的獎金。介面採深夜賭場風格設計，支援完整鍵盤操作，無需使用滑鼠即可完成整局遊戲。

---

## 功能介紹

### 核心功能
- **發牌**：從 52 張牌中隨機洗牌並發出 5 張
- **換牌**：點擊（或按數字鍵 1–5）翻牌標記要換的牌，再按換牌確認
- **判斷牌型**：自動識別 9 種牌型並計算中獎金額

### 下注系統
| 項目 | 說明 |
|------|------|
| 初始資金 | 1,000,000 元 |
| 押注方式 | NumericUpDown 輸入，最低 100 元，每次 +100 |
| 結算 | 判斷牌型後自動計算 `押注金額 × 賠率` |
| 破產重置 | 資金歸零時自動重置為 1,000,000 元 |

### 賠率表
| 牌型 | 賠率 |
|------|------|
| 皇家同花順 | 250 |
| 同花順 | 50 |
| 四條（鐵支） | 25 |
| 葫蘆 | 9 |
| 同花 | 6 |
| 順子 | 4 |
| 三條 | 3 |
| 兩對 | 2 |
| 一對 | 1 |
| 雜牌 | 0 |

### 鍵盤操作（無滑鼠可完整遊玩）
| 按鍵 | 功能 |
|------|------|
| `F1` | 發牌 |
| `F2` | 換牌 |
| `F3` | 判斷牌型 |
| `1` – `5` | 翻轉對應第 N 張牌（蓋牌 = 標記換牌） |
| `Tab` | 在控件之間切換焦點 |
| `Enter` / `Space` | 確認目前焦點的按鈕 |

### 介面特色
- 深夜賭場風格：深綠賭桌、金色標題、暗色背景
- 牌面底部彩色指示條：🟢 綠色 = 保留、🔴 紅色 = 要換牌
- 結果直接顯示於介面，不彈出多餘視窗
- 資金低於 25 萬時金額數字轉紅色提示

---

## 執行說明

### 環境需求
- Windows 10 / 11
- Visual Studio 2019 或以上
- .NET Framework 4.7.2 或以上

### 執行步驟
1. 解壓縮專案資料夾
2. 開啟 `Poker.sln`
3. 確認牌面圖片資源（`back`、`pic1`–`pic52`）已加入 `Properties/Resources`
4. 按 `F5` 或點選「啟動」執行

### 遊戲流程
```
輸入押注金額 → 按「押注」
→ 按「發牌」（F1）
→ 點擊牌面或按 1–5 標記要換的牌
→ 按「換牌」（F2）確認換牌  ← 可略過直接判斷
→ 按「判斷牌型」（F3）查看結果與獎金
→ 重新押注，開始下一局
```

---

## 專案結構

```
Poker/
├── frmPoker.cs            # 主要遊戲邏輯（發牌、換牌、判斷、下注）
├── frmPoker.Designer.cs   # 視窗介面配置
├── Program.cs             # 程式進入點
├── Properties/
│   └── Resources.resx     # 撲克牌圖片資源
Poker.sln              # 方案檔
```

---

## 螢幕截圖

<img width="480" height="480" alt="image" src="https://github.com/user-attachments/assets/36fde7aa-2bc6-4840-9bb1-8099f446c8ea" />
<img width="480" height="480" alt="image" src="https://github.com/user-attachments/assets/38968c0c-38f2-455f-96d7-e3bac92f3d47" />
<img width="480" height="480" alt="image" src="https://github.com/user-attachments/assets/8195b23f-90b1-4f89-9718-04bf150a85f6" />
<img width="480" height="480" alt="image" src="https://github.com/user-attachments/assets/faf9381d-086c-45a7-8534-a4dc47c337cb" />
<img width="480" height="480" alt="image" src="https://github.com/user-attachments/assets/3913b152-cdcc-4e8b-a0f6-4d982caec5f6" />
<img width="480" height="480" alt="image" src="https://github.com/user-attachments/assets/9f0f7502-1716-4cf2-9086-6d94b8d8ae68" />


---

## 開發環境

- **語言**：C#
- **框架**：Windows Forms (.NET Framework)
- **IDE**：Visual Studio
