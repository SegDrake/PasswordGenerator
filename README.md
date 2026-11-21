# PasswordGenerator

A cryptographically secure console password generator written in **C#** utilizing `System.Security.Cryptography` for robust complexity and input handling.

## Features
- **Cryptographic Security:** Powered by `System.Security.Cryptography.RandomNumberGenerator` (CSPRNG).
- **Batch Generation:** Create 1 to 100 passwords per execution.
- **Custom Length:** Configurable from 12 to 128 characters (12-char minimum enforced).
- **Complexity Checks:** Guarantees digits, upper/lowercase letters, and special symbols.
- **Input Validation:** Handles invalid entries gracefully with prompt alerts.

## Example Output
```text
How many passwords to generate? (1 to 100): 5
Enter password length (minimum 12 characters): 15

Generating: 5 passwords, length 15 each.

Password strong: *Z^K5%YyVAN|ehp
Password strong: 9vBpQbv?1O6Wkf9
Password strong: 0CiPT5u87JFLHLb
Password strong: FPM%AD7^0oYdY%@
Password strong: XfKsS1k1jVyXuek
```

## Tech Stack
- C# / .NET Console Application
- `System.Security.Cryptography`

## Getting Started
1. Clone the repo:
   ```bash
   git clone https://github.com
   ```
2. Run via terminal:
   ```bash
   dotnet run
   ```
   Or open the project in Visual Studio and press `F5`.
