using Xunit;

public sealed class WorkflowRuntimeTests
{
    [Fact]
    public void CiTestHostRunsOnConfiguredFramework()
    {
        Assert.Equal(10, Environment.Version.Major);
    }
}
