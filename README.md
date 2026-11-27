# WhiteBeard Solution engineering workspace

Shared engineering standards, community defaults, reusable automation, and the public organization profile.

- [Engineering standards and workflow adoption](ENGINEERING.md)
- [Contribution guidelines](CONTRIBUTING.md)
- [Team structure and access roles](TEAM-ACCESS.md)
- [Architecture decision template](ADR-TEMPLATE.md)
- [Security reporting](SECURITY.md)
- [Organization profile](profile/README.md)

Reusable workflows are in `.github/workflows/`. Use a reviewed full commit SHA when calling them from another repository. Product-specific guidance and existing release pipelines remain authoritative.

The **Workflow validation** workflow exercises the reusable .NET CI and delivery workflows against a small .NET 10 fixture. It verifies test execution and runs the produced application artifact. This validates the shared automation contract; it is not a test or deployment of a production product.
