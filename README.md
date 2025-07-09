# ❌⭕ Tic-Tac-Toe Game

A simple 2-player **Tic-Tac-Toe (XO)** desktop game built using **C# and Windows Forms (.NET Framework)**. Players take turns to place X and O symbols on the grid until one wins or the game ends in a draw.

---

## 🖼️ Screenshot

![Tic-Tac-Toe Screenshot](Screenshot%20Tic-Tac-Toe%20Game.png)

---

## ✨ Features

- 2-player mode with turn tracking
- Detects all **winning conditions** (rows, columns, diagonals)
- Highlights winning boxes with a different **background color**
- Displays the **game result** (Winner or Draw)
- Shows **error message** when selecting an already filled box
- Hover effect on each cell (changes background color on mouse enter/leave)
- **Restart** button to reset the game instantly

---

## 🧠 Code Highlights

- Used `PictureBox.Tag` to store player moves (X / O)
- Logic separated into helper methods:
  - `get_picture(PictureBox box)` – handles player move and turn switch
  - `check_winner()` – checks all win conditions
- Clean UI handling and win checking logic
- Design-time setup with fixed grid layout

---

## 🛠️ Tech Stack

- **Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **IDE**: Visual Studio

---

## 🚀 How to Run

1. Clone or download this repository
2. Open the `.sln` file in **Visual Studio**
3. Click **Start** or press `F5` to run the game

---

## 📁 Files Included

- `Form1.cs` – Main game logic
- `Form1.Designer.cs` – UI layout
- `Resources` – X, O, and question mark images
- `Screenshot Tic-Tac-Toe Game.png` – Game screenshot
- `README.md` – Project documentation

---

## 👨‍💻 Developed By

**Mohamed Ramadan Wehebi**  
- 🔗 [GitHub](https://github.com/mohamedramadan567)  
- 🔗 [LinkedIn](https://www.linkedin.com/in/mohamed-ramadan-732a82287/)

---

## 📜 License

Free to use and modify for learning or personal projects. Contributions welcome!
