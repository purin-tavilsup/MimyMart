using FluentAssertions;
using MimyMart.Windows.Forms.UI;
using Xunit;

namespace MimyMart.Windows.Forms.Tests.UI;

public class BarcodeScanGateTests
{
	[Fact]
	public void TryEnter_WhenIdle_ShouldReturnTrue()
	{
		var gate = new BarcodeScanGate();

		gate.TryEnter()
			.Should()
			.BeTrue();
	}

	[Fact]
	public void TryEnter_WhileAScanIsStillBeingHandled_ShouldReturnFalse()
	{
		// The case that crashed the app: a second scan arriving through the nested message loop
		// of a dialog the first scan opened.
		var gate = new BarcodeScanGate();

		gate.TryEnter();

		gate.TryEnter()
			.Should()
			.BeFalse();
	}

	[Fact]
	public void TryEnter_AfterExit_ShouldReturnTrue()
	{
		var gate = new BarcodeScanGate();

		gate.TryEnter();
		gate.Exit();

		gate.TryEnter()
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Exit_WithoutEntering_ShouldLeaveTheGateUsable()
	{
		// Exit lives in a finally block, so it must tolerate being called on a path that never entered
		var gate = new BarcodeScanGate();

		gate.Exit();

		gate.TryEnter()
			.Should()
			.BeTrue();
	}
}
