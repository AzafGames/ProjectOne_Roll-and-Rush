# Security Policy

## 🔐 Security Policy — Roll and Rush

**Roll and Rush** is an early-development 3D game project built with **Unity and C#**.

This repository is publicly available as part of the development and learning process. While security is not currently a primary gameplay focus, reasonable security practices are followed to protect the project and its contributors.

---

## 📌 Supported Versions

Roll and Rush is currently under active development.

At this stage, security-related fixes will primarily apply to the **latest version of the project available in the main branch**.

| Version                    | Supported |
| -------------------------- | --------- |
| Latest development version | ✅ Yes     |
| Older development versions | ❌ No      |
| Archived versions          | ❌ No      |

As the project develops, this policy may be updated to reflect released versions.

---

## 🚨 Reporting a Security Vulnerability

If you discover a security vulnerability or security-related issue in **Roll and Rush**, please report it privately rather than creating a public GitHub issue.

For supported repositories, you can use GitHub's **Private Vulnerability Reporting** feature to submit a report.

When reporting an issue, please provide as much relevant information as possible.

### Please include:

* A clear description of the vulnerability
* Steps required to reproduce the issue
* The affected feature, system, file, or component
* The potential impact of the vulnerability
* Screenshots or videos, if applicable
* Relevant error messages or logs
* Any possible mitigation or suggested solution, if known

Providing detailed information will make it easier to investigate and reproduce the issue.

---

## 🔒 Responsible Disclosure

Please do not publicly disclose security vulnerabilities before they have been reviewed.

If a vulnerability is reported, it may be investigated and addressed before details are publicly discussed.

Please avoid:

* Publicly posting unpatched vulnerabilities
* Publishing exploit code before the issue is addressed
* Accessing or modifying data that does not belong to you
* Attempting to disrupt project infrastructure
* Performing attacks against external services using this project

Security research should be conducted responsibly and within applicable laws.

---

## 🛡️ Sensitive Information

Please **never commit sensitive information** to this repository.

Examples include:

* API keys
* Access tokens
* Passwords
* Authentication credentials
* Private certificates
* Private SSH keys
* Database credentials
* Personal access tokens
* Private configuration files containing secrets

If sensitive information is accidentally committed, it should be considered compromised and the relevant credential should be revoked or rotated immediately.

---

## 📁 Repository Security

The project uses GitHub for source-code management and collaboration.

The repository should avoid committing unnecessary generated or temporary Unity files.

Examples of files and directories that generally should not be committed include:

```text
Library/
Temp/
Logs/
Obj/
Build/
Builds/
UserSettings/
```

A Unity-specific `.gitignore` should be used to prevent unnecessary generated files from being uploaded.

---

## 🧪 Development Status

**Project:** Roll and Rush
**Engine:** Unity
**Language:** C#
**Project Type:** 3D Game
**Development Status:** Early Development

The project is currently being developed from scratch. Gameplay systems, architecture, dependencies, and project structure may change during development.

---

## 📬 Security Contact

For security-related issues, please use GitHub's private vulnerability reporting functionality when it is available for this repository.

For general bugs, gameplay issues, feature requests, and development discussions, please use the appropriate **GitHub Issues** or project discussion channels instead of the security reporting process.

---

## 📜 Policy Updates

This security policy may be updated as **Roll and Rush** develops and additional systems, dependencies, services, or online functionality are introduced.

The latest version of this policy will always be available in this repository.

---

**Roll and Rush** 🎮
*An independent Unity game-development project.*
