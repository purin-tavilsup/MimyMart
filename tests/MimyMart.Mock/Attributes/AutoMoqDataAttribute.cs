using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace MimyMart.Mock.Attributes;

public class AutoMoqDataAttribute : AutoDataAttribute
{
	public AutoMoqDataAttribute() 
		: base(() => new Fixture().Customize(new AutoMoqCustomization()))
	{
	}
}