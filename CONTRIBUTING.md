# Contributing to WhiteBeard Solution

Follow the repository's own guidance first. These organization defaults apply where a repository has no more specific convention.

## Development

- Use a supported .NET SDK and pin it in `global.json`. Prefer the current LTS for new services; migrate existing applications through a reviewed change rather than changing their runtime implicitly.
- Keep changes focused. Branch from the repository's documented integration branch and open a pull request with the problem, resulting behavior, validation, and material risks.
- Run restore, Release build, automated tests, and formatting checks before requesting review. Never report a check you did not run.
- Commit no credentials, personal data, production exports, or local configuration secrets. Use secret storage and sanitized examples.
- Preserve existing work and public contracts. Discuss breaking changes and persisted-data migrations before implementation.

## Architecture and code

- Apply SOLID through cohesive responsibilities, explicit contracts, dependency injection at the composition root, and interfaces at meaningful boundaries. Avoid abstractions without a concrete need.
- In Clean Architecture, Domain owns business invariants without infrastructure dependencies. Application coordinates use cases and defines ports. Infrastructure implements persistence and external integrations. API/UI adapters translate requests and responses. Dependencies point inward.
- Enforce authorization and tenant/resource ownership in application use cases. UI visibility is not an authorization control. Reuse the same application behavior across API, UI, and agent integrations.
- Use async I/O with cancellation, explicit validation, structured logging without secrets, and consistent error responses. Keep transactions short and protect concurrent updates where required.
- Enable nullable reference types and analyzers for new .NET code. Treat warnings deliberately; do not suppress them globally to pass CI.
- Test domain rules, authorization failures, boundary contracts, and meaningful integration behavior. Use test doubles only where they represent the real contract.

## Review and delivery

- Include tests appropriate to the change, accessibility evidence for UI work, and compatibility/recovery evidence for migrations.
- Resolve review conversations and check CI before merging. Prefer squash merges with a descriptive title. Keep required checks tied to workflows that actually run.
- Deploy only through a repository-specific approved environment and deployment workflow. Publishing a build artifact is not a production deployment.
- Record consequential architecture choices as ADRs using [ADR-TEMPLATE.md](ADR-TEMPLATE.md). Accepted decisions need reviewer agreement; later decisions supersede them rather than rewriting history.

See [ENGINEERING.md](ENGINEERING.md) for reusable workflow adoption and access conventions.
