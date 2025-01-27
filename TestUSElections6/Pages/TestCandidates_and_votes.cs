using Bunit;
using Microsoft.Extensions.DependencyInjection;
using USElections6.Pages;
using USElections6.State;
using USElections6.USElections;

namespace TestUSElections6
{
  [Collection("USElections6")]
  public class TestCandidates_and_votes
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbCardModule),
        typeof(IgbPieChartModule),
        typeof(IgbGridModule),
        typeof(IgbCategoryChartModule));
      ctx.Services.AddScoped<IStateService>(sp => new MockStateService());
      ctx.Services.AddScoped<IUSElectionsService>(sp => new MockUSElectionsService());
      var componentUnderTest = ctx.RenderComponent<Candidates_and_votes>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
