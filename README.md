<div align="center">

# 🔗 LANLink - P2P Network Messenger

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)

A clean, modern, and light-weight Peer-to-Peer (P2P) desktop messaging application built with **C#** and **Windows Forms**. LANLink enables instant, secure, and low-latency real-time communication over Local Area Networks (LAN) using socket-based UDP protocol—featuring a sleek, modern Dark Mode interface with dynamic chat bubbles.

</div>

---

## 📸 Screenshots Showcase

| 🚀 Connection Setup | 💬 Client 1 View (Sender) | 💬 Client 2 View (Receiver) |
| :-----------------: | :-----------------------: | :-------------------------: |
| <img src="https://github.com/AbuAlwah/LANLink/blob/main/mainPage.png?raw=true"/> | <img src="https://github.com/AbuAlwah/LANLink/blob/main/mePage.png?raw=true"/> | <img src="https://github.com/AbuAlwah/LANLink/blob/main/friendPage.png?raw=true"/> |

---

## ✨ Features

- **P2P Socket Communication:** Direct local network messaging powered by UDP sockets, eliminating the need for central server infrastructure.
- **Modern Dark UI/UX:** Built with a custom, borderless dark theme featuring responsive card components, sleek input fields, and smooth contrast.
- **Dynamic Rounded Chat Bubbles:** Custom GDI+ graphics rendering (`GraphicsPath`) providing auto-resizing text bubbles with custom alignment for incoming and outgoing messages.
- **Precise Byte Management:** Efficient socket buffer handling that accurately decodes received bytes to prevent empty spacing or trailing buffer garbage in chat history.
- **Real-Time Asynchronous Listener:** Background socket callback mechanism (`BeginReceiveFrom`) ensuring zero UI freezing during high-frequency message exchange.
- **Border-less Window Dragging:** Integrated WinAPI messaging (`WM_NCLBUTTONDOWN`) allowing fluid window mobility without native OS title bars.

---

## 🛠️ Tech Stack & Architecture

- **Language:** [C# (.NET Framework)](https://docs.microsoft.com/en-us/dotnet/csharp/)
- **UI Toolkit:** [Windows Forms](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
- **Core Networking:** `System.Net.Sockets` (Socket, EndPoint, AsyncCallback)
- **Graphics & Rendering:** `System.Drawing.Drawing2D` (GraphicsPath, AntiAlias)
- **Native Interop:** `System.Runtime.InteropServices` (User32.dll for Form Movement)

---

## 📁 Project Structure

```text
LANLink/
├── Program.cs                  # Main application entry point
├── Form1.cs                    # Core UI logic, socket handlers & chat rendering
├── Form1.Designer.cs           # Form visual elements & control declarations
├── Properties/                 # Application settings & resources
└── Resources/                     
