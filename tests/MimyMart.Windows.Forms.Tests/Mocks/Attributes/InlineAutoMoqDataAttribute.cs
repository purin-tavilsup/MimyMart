﻿using AutoFixture.Xunit2;
using Xunit;

namespace MimyMart.Windows.Forms.Tests.Mocks.Attributes;

public class InlineAutoMoqDataAttribute : CompositeDataAttribute
{
	public InlineAutoMoqDataAttribute(params object[] values)
		: base(new InlineDataAttribute(values), new AutoMoqDataAttribute())
	{
	}
}