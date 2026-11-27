# Engineering standards

## Repository baseline

Use private visibility for proprietary projects. Keep the README accurate: purpose, prerequisites, local startup, checks, and ownership. Use `src/` and `tests/` for new .NET services when compatible with the established structure. Store ADRs in the repository's designated architecture-record location; preserve external specification systems already in use.

Repository guidance and approved architecture take precedence over this default. Do not reorganize an existing service merely to match a folder diagram. Domain, application, infrastructure, and presentation boundaries describe dependency ownership, not a mandatory project count.

## CI and build delivery

Reusable workflows live in `.github/workflows/` of this repository:

- `dotnet-ci.yml`: restore, Release build, formatting, tests, and test-result artifacts.
- `dotnet-delivery.yml`: builds and tests a selected .NET application and publishes a versioned deployment artifact. It does not contact a live environment.

Call a workflow as a job using `Whitebeard-Solution/.github/.github/workflows/dotnet-ci.yml@<reviewed-full-commit-sha>`. Supply `project` (solution/project path) and `dotnet-version` matching the application. The delivery workflow also needs `publish-project`. Callers grant only `contents: read`. Keep workflow arguments in environment variables; never interpolate untrusted input directly into shell source.

These workflows are opt-in and do not replace product-specific pipelines automatically. Test them in the consuming repository before making their check names required. Adopt one stable required aggregate check only after a successful real run. Do not require approvals that the available reviewer pool cannot satisfy.

Use GitHub-hosted runners for untrusted pull requests. Pin external actions and cross-repository reusable workflows to full commit SHAs and review updates. Grant token writes only in the job that needs them. Avoid `pull_request_target` for executing untrusted code and do not inherit all secrets into reusable workflows.

Production delivery requires a named destination, protected environment, approved reviewer, immutable artifact, scoped OIDC federation where available, health checks, and rollback evidence. No production credentials or destination are configured by these generic workflows.

## Access roles

Organization owners manage membership, billing, and security. Keep ownership limited to trusted administrators. Engineering maintainers receive Maintain only on assigned repositories; backend/frontend developers receive Write on assigned code; quality receives Triage unless writing tests requires Write; security receives Read unless a specific remediation needs more. Platform access is scoped to CI/infrastructure responsibilities. Never grant organization-wide Admin just to run CI.

Teams represent responsibilities, not automatic entitlement to every repository. An owner must review each membership and repository assignment. CODEOWNERS is repository-specific and is not inherited from this defaults repository. Public default community-health files can be inherited when no repository-local replacement exists; private repositories require explicit adoption where GitHub does not inherit them.

## Architecture decisions

Use monotonically numbered ADRs with title, status, date, context, options, decision, consequences, validation, and superseding links. Record tradeoffs and ownership rather than asserting that one architecture is universally correct. Obtain review before treating a proposed ADR as accepted.

## References

- [Microsoft .NET support policy](https://learn.microsoft.com/en-us/dotnet/core/releases-and-support)
- [GitHub reusable workflows](https://docs.github.com/en/actions/how-tos/reuse-automations/reuse-workflows)
- [GitHub Actions secure use](https://docs.github.com/en/actions/security-for-github-actions/security-guides/security-hardening-for-github-actions)
