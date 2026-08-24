# B2D Antivirus Scanner 🛡️

B2D Antivirus Scanner is a simple **Windows desktop antivirus scanning application** developed using **Visual Basic .NET and Windows Forms** in Visual Studio.

The project demonstrates the basic concepts of antivirus software, including file scanning, threat detection, suspicious-file identification, and removal of detected files.

> **Note:** This is an educational antivirus project designed for learning and laboratory purposes. It is not intended to replace professional antivirus software.

## 📌 Project Overview

The purpose of B2D Antivirus Scanner is to demonstrate how a basic antivirus application can:

* Scan a selected location for suspicious files
* Detect predefined test-virus files
* Display detected threats to the user
* Remove detected test files
* Show scanning progress
* Provide a simple graphical user interface

The project is suitable for learning the fundamentals of **malware detection, file scanning, and Windows security programming**.

## 🛠️ Technologies Used

* **Visual Basic .NET**
* **Windows Forms**
* **Visual Studio**
* **.NET Framework / .NET**
* Windows File System APIs
* Git & GitHub

## 📂 Project Structure

```text
B2D Antivirus Scanner/
│
├── My Project/
│   └── ApplicationEvents.vb
│
├── Screenshots/
│   ├── Antivirus scan.png
│   ├── Code for Antivirus Scan.png
│   ├── Design Drawn For AntiVirus Scanning.png
│   └── hello
│
├── Form1.Designer.vb
├── Form1.resx
├── Form1.vb
├── B2D Antivirus Scanner.vbproj
├── B2D Antivirus Scanner.sln
├── antivirus_18850.ico
├── .gitattributes
├── .gitignore
└── README.md
```

## 🔍 How the Scanner Works

The application follows a simple scanning process:

```text
User starts the application
          ↓
Select / define scan location
          ↓
Application checks files
          ↓
Suspicious test file detected?
       ↙          ↘
     YES           NO
      ↓             ↓
Display threat   Continue scan
      ↓
Remove/quarantine test file
      ↓
Display scan result
```

## 🚀 Main Features

### 1. File Scanning

The application checks files in the configured location and looks for predefined suspicious/test files.

### 2. Threat Detection

When a test threat is detected, the application displays a message identifying the detected threat.

Example:

```text
Trojan Horse Virus Found
```

### 3. Threat Removal

The application can remove the detected test file using Windows file-system operations.

### 4. Scan Progress

A progress bar can be used to provide visual feedback while the scanner is running.

### 5. Windows GUI

The application provides a simple Windows Forms interface containing controls such as:

* Buttons
* ListBox
* ProgressBar
* Labels
* Scan controls

## 🧪 Testing

For safe testing, use **dummy/test files only** rather than real malware.

For example, the application can be configured to detect a harmless test file such as:

```text
Virus.txt
```

When the file is present, the scanner reports it as a test threat.

Example:

```text
Scanning...
Threat detected!
Trojan Horse Virus Found
Scan completed.
```

## 📸 Screenshots

### Antivirus Scanner

![Antivirus Scan](Screenshots/Antivirus%20scan.png)

### Antivirus Scan Code

![Code for Antivirus Scan](Screenshots/Code%20for%20Antivirus%20Scan.png)

### Antivirus Scanner Design

![Antivirus Design](Screenshots/Design%20Drawn%20For%20AntiVirus%20Scanning.png)

## 💻 Requirements

To run this project, you need:

* Windows 10 or Windows 11
* Visual Studio
* Visual Basic .NET support
* Windows Forms workload
* .NET Framework/.NET version compatible with the project

## ▶️ How to Run

1. Clone the repository.

```bash
git clone <YOUR-GITHUB-REPOSITORY-URL>
```

2. Open the project directory.

3. Open:

```text
B2D Antivirus Scanner.sln
```

4. Open the solution in Visual Studio.

5. Build the project:

```text
Build → Build Solution
```

6. Run the application using:

```text
F5
```

or select:

```text
Debug → Start Debugging
```

## ⚠️ Disclaimer

This project is created for **educational and cybersecurity laboratory purposes**.

It uses simple, predefined detection logic and should not be considered a complete antivirus engine. It does not provide the advanced capabilities of commercial antivirus products such as behavioral analysis, cloud-based threat intelligence, machine-learning detection, real-time protection, or kernel-level monitoring.

**Do not use real malware for testing. Use harmless test files in an isolated laboratory environment.**

## 🎯 Learning Objectives

This project helps demonstrate:

* Basic antivirus concepts
* File-system scanning
* Threat detection logic
* Windows Forms application development
* Visual Basic programming
* Basic malware-analysis concepts
* Safe cybersecurity laboratory testing
* GitHub project documentation

## 🔮 Future Improvements

Possible improvements include:

* [ ] Scan entire directories recursively
* [ ] Calculate file hashes such as SHA-256
* [ ] Detect files using a hash-based signature database
* [ ] Add quarantine functionality
* [ ] Add scan history
* [ ] Add real-time file monitoring
* [ ] Add detailed threat reports
* [ ] Add a threat severity indicator
* [ ] Add a configurable scan location
* [ ] Improve the graphical user interface
* [ ] Add unit tests
* [ ] Add logging functionality

## 👨‍💻 Author

**B2D Antivirus Scanner**

Developed as an educational cybersecurity project to demonstrate basic antivirus scanning and threat-detection concepts.

---

⭐ If you find this project useful for learning, consider giving the repository a star.
