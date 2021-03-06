using NUnit.Framework;

namespace Raygun.Druid4Net.Tests.Fluent
{
  [TestFixture]
  public class DimensionTopNMetricSpecTests
  {
    [Test]
    public void Constructor_TypeIsCorrect()
    {
      var spec = new DimensionTopNMetricSpec();
      Assert.That(spec.Type, Is.EqualTo("dimension"));
    }
    
    [Test]
    public void Constructor_WithDefaultValues_PropertiesAreSet()
    {
      var spec = new DimensionTopNMetricSpec();
      Assert.That(spec.Ordering, Is.EqualTo(SortingOrder.lexicographic));
      Assert.That(spec.PreviousStop, Is.Null);
    }
    
    [Test]
    public void Constructor_WithSpecifiedValues_PropertiesAreSet()
    {
      var spec = new DimensionTopNMetricSpec(SortingOrder.alphanumeric, "a");
      Assert.That(spec.Ordering, Is.EqualTo(SortingOrder.alphanumeric));
      Assert.That(spec.PreviousStop, Is.EqualTo("a"));
    }
  }
}