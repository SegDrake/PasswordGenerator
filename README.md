# 🔐 PasswordGenerator

A console password generator written in **C#** featuring input validation and automatic password complexity checks.

## ✨ Features
- **Batch Generation:** Generate from **1 to 100** passwords in a single run.
- **Custom Password Length:** Supports lengths from **12 to 128 characters** (enforcing a 12-character minimum security threshold).
- **Complexity Enforcement:** Automatically verifies that every generated password includes digits, uppercase and lowercase letters, and special characters (`!@#%^&*?/|`).
- **Input Validation:** Built-in error handling (`int.TryParse`) with red console alerts prevents crashes on invalid, empty, or out-of-range inputs.

## 🖥️ Example Output
```text
Сколько паролей сгенерировать? (от 1 до 100): 5
Введите длину пароля (минимум 12 символов): 15

Будет сгенерировано: 5 паролей, длина каждого 15 символов.

Пароль надежный: *Z^K5%YyVAN|ehp
Пароль надежный: 9vBpQbv?1O6Wkf9
Пароль надежный: 0CiPT5u87JFLHLb
Пароль надежный: FPM%AD7^0oYdY%@
Пароль надежный: XfKsS1k1jVyXuek
```

## 🛠️ Tech Stack
- **Language:** C#
- **Framework:** .NET (Console Application)

## 🚀 Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com
   ```
2. Navigate to the project directory and run the application via terminal:
   ```bash
   dotnet run
   ```
   Alternatively, open `GeneratedPassword.csproj` in **Visual Studio** and press `F5`.
