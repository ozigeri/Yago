# Contributing Guidelines

Thank you for considering contributing to this project.  
Please review the following rules and workflow before contributing.

---

## Table of Contents
- [Project Access and Workflow](#project-access-and-workflow)
- [Getting Started](#getting-started)
- [Branching Rules](#branching-rules)
- [How to Contribute](#how-to-contribute)
- [Coding Standards](#coding-standards)
- [Commit Message Guidelines](#commit-message-guidelines)
- [Pull Request Process](#pull-request-process)
- [Issue Reporting Guidelines](#issue-reporting-guidelines)
- [Code Review Process](#code-review-process)
- [License](#license)

---

## Project Access and Workflow

Repository URL:  
https://github.com/ozigeri/Yago.git

Clone the repository:

git clone https://github.com/ozigeri/Yago.git


Install project dependencies as described in the README.

---

## Getting Started

### Prerequisites
Before contributing, ensure you have installed:
- Git
- The required runtime environments (Node.js, PHP, .NET, etc.)
- Project dependencies

### Setup Steps
1. Clone the repository.
2. Install project dependencies.
3. Create a new branch following the rules below.
4. Implement your changes.

---

## Branching Rules

### General Rule
Every contributor must create a new branch for each issue.

### Branch Naming

- Regular contributors:  
  Must create a new branch for each Kanban issue.  
  Example branch names:  
  `issue-14-fix-login`  
  `issue-22-add-api-endpoint`

- Column developers (oszlopos fejlesztők):  
  May maintain a personal long-running branch:  
  `gergo-dev`  
  `anna-main-dev`

### Do Not
- Push directly to `main`
- Reuse old branches for new issues
- Mix unrelated changes in one branch

---

## How to Contribute

You can contribute by:
- Fixing bugs
- Adding new features
- Improving documentation
- Refactoring or optimizing code
- Creating or updating tests
- Submitting improvement ideas through Issues

Keep contributions focused on a single topic.

---

## Coding Standards

- Write clean, readable, and consistent code.
- Follow the established style of the project.
- Use clear and descriptive names.
- Keep functions small and focused.
- Avoid unnecessary complexity.
- Add comments where clarity is needed.
- Run formatters or linters (Prettier, ESLint, PHP-CS-Fixer, etc.) if provided.

---

## Commit Message Guidelines

Only the following commit prefixes are used:

- `feat` – new feature
- `fix` – bug fix

### Examples

`feat: implement user authentication`  
`fix: correct null reference in API handler`  
`feat: add endpoint for grade submission`  
`fix: resolve index error in pagination module`

### Rules
- Keep messages short and descriptive.
- Commit often but meaningfully.
- Do not combine unrelated changes in one commit.

---

## Pull Request Process

1. Make sure your branch is up to date with `main`:

git pull origin main

2. Ensure all tests pass (if any).
3. Open a Pull Request and describe:
- What you changed
- Why you changed it
- What issue it resolves (e.g., "Fixes #14")
4. Follow any PR template if provided.
5. Keep PRs small and focused.
6. Respond to review feedback promptly.
7. A PR is merged only after reviewer approval.

---

## Issue Reporting Guidelines

When reporting an issue, please include:
- A clear, descriptive title
- Steps to reproduce
- Expected vs actual behavior
- Logs or screenshots if available
- Environment details (OS, browser/version, runtime versions)

### Feature requests should include:
- The problem or need
- The proposed solution
- Alternatives considered
- Additional context if needed

---

## Code Review Process

- All PRs must be reviewed before merging.
- Reviewers may request improvements in readability, structure, or logic.
- Discussions should remain respectful and constructive.
- Only approved, reviewed code is merged into `main`.

---

## License

By contributing to this repository, you agree that your contributions will be licensed under the same license as the project.
