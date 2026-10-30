# Unity 6 遊戲教學與 AI 協作範本

適用 Editor：**Unity 6000.3.17f1**。文件使用繁體中文，輸入統一使用 **Input System Package (New)**。

這是資料夾與協作文件骨架，尚不是能直接執行的完整 Unity 專案，未包含遊戲程式、場景與 Unity 產生的設定。請先依 [初始化指南](docs/02_初始化與InputSystem.md) 建立真正的專案，再合併本骨架。

## 閱讀順序

1. [資料夾與文件說明](docs/01_資料夾與文件說明.md)
2. [初始化與 Input System](docs/02_初始化與InputSystem.md)
3. [AI 協作流程](docs/03_AI協作流程.md)
4. [教學路線與發布檢查](docs/04_教學與發布檢查.md)

AI 開始工作前須讀取根目錄 `AGENTS.md`；不會自動讀取的工具，請使用 `docs/05_AI啟動提示詞.md`。

建議 Repo 名稱：`Unity6-AI-Teaching-Template`。建立 GitHub 公開 Repository 後，在 Settings 勾選 Template repository，讓同學以 Use this template 建立各自專案。正式開放前，先完成 Unity 初始化與 Editor 驗證。

## 授權

尚未選定授權。建議自有程式與文件採 MIT；公開前由維護者加入正式 LICENSE。第三方素材須各自確認可否再散布，不能直接套用專案授權。

5. [Agent 相容性與解壓縮指南](docs/06_Agent相容性與解壓縮指南.md)

已提供 Codex、Kiro、Antigravity 與 Claude Code 入口，以及 .gitignore。請完整解壓縮，包含以點開頭的檔案與資料夾。

## 課程資產架構 v0.2

3D 資產以 `Assets/_Project/Art/Models/<模型名稱>/` 為單位，FBX、專屬貼圖／材質直接同層存放；可共用的 Material 放在 `Art/Materials/`。2D Sprite 與逐格動畫依角色放在 `Art/Sprites/<角色名稱>/`。詳見 `docs/01_資料夾與文件說明.md`。本 ZIP 不包含實際 Cat 模型或 Roll a Ball 程式碼。
# 專案名稱：Unity 期中作業

## 1. Project Name｜專案名稱
gg

## 2. Unity Version｜Unity 版本
Unity 6000.3.17f1

## 3. Git Tool｜使用工具
JetBrains Rider

## 4. Step-by-step｜操作過程
1. 在 Rider 中開啟 Unity 專案範本。
2. 啟用 Git 版本控制（Enable Version Control Integration）。
3. 將專案變更進行 Commit（本機版本紀錄）。
4. 連結至 GitHub 帳號並將專案 Push 上傳至遠端儲存庫。

## 5. What I Learned｜概念學習筆記
- **Repository（儲存庫）**：用來記錄與存放專案所有歷史版本及檔案的地方（分為本機 Local 與遠端 Remote）。
- **Commit（提交）**：在本地端存檔，記錄當前專案的變更狀態與版本快照。
- **Push（推送）**：將本地端 Commit 好的版本歷史上傳發布至遠端 GitHub 儲存庫。
- **Pull（拉取）**：將遠端 GitHub 上的最新變更與版本下載並同步合併回本地端電腦。
- **.gitignore（忽略檔）**：告訴 Git 不需要追蹤與上傳的檔案或資料夾（如 Unity 的 Library、Temp 等快取資料），避免佔用空間與造成版本衝突。
