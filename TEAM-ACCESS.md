# Teams and access roles

## Organization responsibilities

| Team | Responsibility | Normal repository role |
| --- | --- | --- |
| engineering-maintainers | Shared standards and engineering governance | Maintain on shared engineering repositories |
| architecture | ADRs, domain boundaries and architectural review | Read on assigned products |
| backend / frontend | Implementation within the assigned discipline | Write on assigned products |
| platform | Build automation and operational tooling | Write on assigned tooling |
| quality-assurance | Defect triage and acceptance coordination | Triage on assigned products |
| security | Security review and vulnerability coordination | Read on assigned products |
| product-management | Requirements, priorities and acceptance | Triage on assigned products |
| design | Product experience, accessibility and visual consistency | Read on assigned applications |
| documentation | Documentation and shared-guidance coordination | Triage on shared standards |
| release-management | Release readiness and release issue coordination | Triage on assigned products |

Organization Owner remains a separate, explicitly approved individual role. Team membership does not confer Owner, billing, CI/CD Admin, production access, or Security Manager authority. Where alert administration requires additional privileges, an owner must make a separate scoped decision.

## Project structure

Each product uses this hierarchy:

```text
project-<name>                  Read — coordination and visibility
├── project-<name>-developers   Write — implementation and tests
└── project-<name>-maintainers  Maintain — repository maintenance
```

The parent receives only Read on its own product repository. Children inherit that baseline and receive their own direct Write or Maintain grant. Membership in a parent does not make someone a child-team member. A maintainer of one product does not gain access to other products.

Read and Triage collaborators can propose changes through pull requests where repository and fork policies allow it. Triage does not grant source-write access. Maintain does not grant the destructive or membership powers of repository Admin.

## Onboarding and access reviews

1. An owner verifies the person's identity and approved project responsibilities before inviting or adding them.
2. Assign the project team and only the functional teams needed for the work. Review the combined effective permissions: the highest applicable grant wins.
3. Add developers and maintainers through their separate child teams; use Read or Triage for stakeholders and coordinators.
4. Review repository access when responsibilities change or a person leaves. Do not remove the sole owner or remove an existing member's needed access without an approved transition.
5. Review memberships and direct grants periodically. Keep private repository inventories and access-review records in the organization's private administration records.

The current free-plan baseline uses GitHub's built-in repository roles. Custom role definitions and paid policy enforcement are not simulated by team names. Branch rules and security features must be checked against the repository's actual plan and visibility.
