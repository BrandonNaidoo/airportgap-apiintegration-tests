# airportgap-apiintegration-tests

## Build Status

| Service        | Status                                                                                                                                                                                                                                                 |
| -------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **GitHub**     | [![GitHub Workflow Status](https://github.com/BrandonNaidoo/airportgap-apiintegration-tests/actions/workflows/run-tests.yml/badge.svg)](https://github.com/BrandonNaidoo/airportgap-apiintegration-tests/actions/workflows/run-tests.yml)
| **CircleCI**   | [![CircleCI](https://dl.circleci.com/status-badge/img/circleci/LdsahFmCXeTHzXz4vmYWNf/PkM4oLjrucgogEVyoVNoaZ/tree/main.svg?style=svg)](https://dl.circleci.com/status-badge/redirect/circleci/LdsahFmCXeTHzXz4vmYWNf/PkM4oLjrucgogEVyoVNoaZ/tree/main)
| **SonarCloud** | [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=BrandonNaidoo_airportgap-apiintegration-tests&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=BrandonNaidoo_airportgap-apiintegration-tests)    

---

## Project Overview


This project contains C# integration tests for the [Airport Gap API](https://airportgap.com/docs) built using NUnit. The tests demonstrate:

- A reusable HTTP client framework with support for authenticated and unauthenticated requests
- FluentAssertions for expressive and maintainable assertions
- Continuous Integration via Github Actions, CircleCI and static code analysis with SonarCloud

---

## Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later
- A valid Airport Gap API token set as an environment variable for authenticated tests (see below)


### Setup

1. Clone the repository:
    ```bash
    git clone https://github.com/BrandonNaidoo/airportgap-apiintegration-tests.git
    cd airportgap-apiintegration-tests
    ```
1. Set the API token environment variable:
   On Windows (PowerShell):
   ```bash
   $env:AIRPORT_GAP_API_TOKEN = "your_api_token_here"
   ```
   On macOS/Linux:
   ```bash
   export AIRPORT_GAP_API_TOKEN=your_api_token_here
   ```
1. Restore dependencies and build:
   ```bash
   dotnet restore
   dotnet build
   ```

---

## 🚀 Running Tests

Run all tests using the .NET CLI:

```bash
dotnet test
```

This will execute the NUnit tests, using the API token from the environment variable for authenticated requests where applicable.

---

## 🧩 Project Structure

## Project Structure

- `.github/` — GitHub Actions workflows for running tests
- `.circleci/` — CircleCI configuration for CI pipelines
- `AirportGap.Models/`
  - `Models/` — Request and response data models
- `NUnit.IntegrationTests/`
  - `Framework/` — HTTP client, factories, request/response builders
  - `Tests/` — NUnit test classes organized by API features
- `Postman.IntegrationTests/`  — Postman Collection organized by API features
- `RestAssured.IntegrationTests/`
  - `Framework/` — HTTP client, factories, request/response builders
  - `Tests/` — RestAssured.Net test classes organized by API features
- `.editorconfig` — Code style and formatting rules
- `.gitignore` — Files and folders to ignore in Git
- `LICENSE` — License information for the project
- `README.md` — Project documentation and setup instructions

---

## ⚙️ CI/CD and Quality

- **GitHub Actions** and **CircleCI** are both configured to run integration tests on push and pull request events
- **SonarCloud** provides code quality and coverage reports, linked in the badges above
- Tests enforce code style via .NET analyzers and run with FluentAssertions for clarity

---

## 🤝 Contributing

At this time, this project is not open to external contributions.

Please feel free to fork the repository for personal use or experimentation, but I am not currently accepting pull requests or feature suggestions.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## 🙌 Acknowledgments

Thanks to [Dev Tester](https://dev-tester.com/) for providing a publicly Api for testing.