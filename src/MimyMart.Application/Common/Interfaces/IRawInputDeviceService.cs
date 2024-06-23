using MimyMart.Application.Common.Enums;

namespace MimyMart.Application.Common.Interfaces;

public interface IRawInputDeviceService
{
	void Start(IntPtr handle);

	void Stop();

	void SetMode(RawInputDeviceMode mode);

	void LoadConfiguration();
}