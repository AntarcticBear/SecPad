# SecPad

SecPad is a simple and secure helper tool for handling temporary text such as passwords, IDs, and URLs.

## Features

* No file saving
* No network communication
* Clipboard and data are cleared on exit
* Quick copy and apply workflow

## Usage

1. Paste or type text into the right text area
2. Select the part you want to use
3. Click **Apply** to store it in a field
4. Click **Copy** to copy a field value to the clipboard

## Design Concept

SecPad is designed as a **temporary helper**, not a full editor.

* Keep it simple
* Avoid unnecessary features
* Reduce the risk of leaving sensitive data

## Security Behavior

* Clipboard is cleared when the application exits
* No data is stored locally
* No external communication is performed
* No traces are left after exit

## Notes

* This tool focuses on usability and simplicity rather than advanced editing features
* Clipboard operations may fail depending on the system state, but are safely handled

## Disclaimer

This software is provided "as is", without any warranty.
The author is not responsible for any damage, data loss, or security issues resulting from its use.

## License

MIT License
