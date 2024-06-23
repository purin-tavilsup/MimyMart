using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace MimyMart.Application.Tests.Mocks.Attributes;

public class CustomAutoDataAttribute : AutoDataAttribute
{
	public CustomAutoDataAttribute()
		: base(() => new Fixture().Customize(new CompositeCustomization(new AutoMoqCustomization())))
	{
	}
}