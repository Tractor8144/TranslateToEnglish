# Translate To English - Visual Studio Extension

## Overview
**Translate To English** is a Visual Studio extension built using the **VisualStudio.Extensibility** framework. It allows developers to quickly translate selected text in the active editor to English using the **Google Cloud Translation API**.

## Features
- 📝 **Select text** in the Visual Studio editor.
- 🌐 **Instantly translate** the selected text into English.
- 🔄 **Replace the original text** with the translated version.
- 🏗 **Built with the latest VisualStudio.Extensibility framework**.

## Installation
1. **Download the latest `.vsix` file** from the [Releases](https://github.com/Tractor8144/TranslateToEnglish/releases) page.
2. **Double-click** the `.vsix` file to install the extension.
3. **Restart Visual Studio** to activate the extension.
4. Find the extension in **Extensions → Manage Extensions** in Visual Studio.

## Usage
1. **Select text** in the active document.
2. **Right-click** and choose `Translate to English`, or trigger the command from the **Extensions menu**.
3. The text will be **translated and replaced** automatically.

## Configuration
### 🔑 Google Cloud Translation API Setup
1. **Create a Google Cloud Project** at [Google Cloud Console](https://console.cloud.google.com/).
2. **Enable the Translation API**.
3. **Set up authentication**:
   - Download the **Service Account Key** (JSON file).
   - Set the environment variable for authentication:
     ```sh
     set GOOGLE_APPLICATION_CREDENTIALS="C:\path\to\your\service-account.json"
     ```

## Development & Contribution
### 🔧 Prerequisites
- **Visual Studio 2022**
- **.NET 6+**
- **Google Cloud Translation API credentials**

### 🏗 Building the Extension
1. Clone the repository:
   ```sh
   git clone https://github.com/YOUR_GITHUB_USERNAME/TranslateToEnglish.git
