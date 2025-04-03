Translate To English - Visual Studio Extension

Overview

Translate To English is a Visual Studio extension built using the VisualStudio.Extensibility framework. It allows developers to quickly translate selected text in the active editor to English using the Google Cloud Translation API.

Features

📝 Select text in the Visual Studio editor.

🌐 Instantly translate the selected text into English.

🔄 Replace the original text with the translated version.

🏗 Built with the latest VisualStudio.Extensibility framework.

Installation

Download the latest .vsix file from the Releases page.

Double-click the .vsix file to install the extension.

Restart Visual Studio to activate the extension.

Find the extension in Extensions → Manage Extensions in Visual Studio.

Usage

Select text in the active document.

Right-click and choose Translate to English, or trigger the command from the Extensions menu.

The text will be translated and replaced automatically.

Configuration

🔑 Google Cloud Translation API Setup

Create a Google Cloud Project at Google Cloud Console.

Enable the Translation API.

Set up authentication:

Download the Service Account Key (JSON file).

Set the environment variable for authentication:

set GOOGLE_APPLICATION_CREDENTIALS="C:\path\to\your\service-account.json"

Development & Contribution

🔧 Prerequisites

Visual Studio 2022

.NET 6+

Google Cloud Translation API credentials

🏗 Building the Extension

Clone the repository:

git clone https://github.com/Tractor8144/TranslateToEnglish.git

Open the solution in Visual Studio 2022.

Build the project using Release Mode.

The generated .vsix file will be available in:

bin\Release\TranslateExtension.vsix

Install and test the extension in Visual Studio.

Updating the Extension

Modify ExtensionEntrypoint.cs to update the version:

public override ExtensionConfiguration ExtensionConfiguration => new()
{
    Metadata = new(
        id: "TranslateExtension.a7d9ae20-182a-4ad8-bdff-86f350d8b634",
        version: "1.1.0", // Update version
        publisherName: "Your Publisher Name",
        displayName: "Translate To English",
        description: "Visual Studio extension for translating selected text to English"
    ),
};

Rebuild and repackage the .vsix file.

License

This project is licensed under the MIT License.

Acknowledgments

Google Cloud Translate API for translation services.

Microsoft VisualStudio.Extensibility framework for building VS extensions.

Contact

For issues, suggestions, or contributions, feel free to create an Issue or a Pull Request on GitHub.

🚀 Happy Coding! 🎉
