﻿using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Windows.Forms.Interfaces;
using MimyMart.Windows.Forms.UI;

namespace MimyMart.Windows.Forms;

[ExcludeFromCodeCoverage]
public class Machine : IMachine
{
	private readonly MainForm _mainForm;
	private readonly IStoreConfigurationService _storeConfigurationService;
	private readonly IRawInputDeviceService _rawInputDeviceService;

	public Machine(MainForm mainForm,
				   IStoreConfigurationService storeConfigurationService,
				   IRawInputDeviceService rawInputDeviceService)
	{
		_mainForm = mainForm;
		_storeConfigurationService = storeConfigurationService;
		_rawInputDeviceService = rawInputDeviceService;
	}

	public void Dispose()
	{
		Shutdown();
	}

	public void Launch()
	{
		try
		{
			_rawInputDeviceService.Start(_mainForm.Handle);

			StartUserInterface();
		}
		catch (Exception ex)
		{
			var messageForm = new MessageForm();
			messageForm.ShowDialog($"Error: {ex.Message}", "Unexpected error has occurred!");
		}
	}

	private static string GetVersion()
	{
		var assembly = System.Reflection.Assembly.GetExecutingAssembly();
		var versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

		return versionInfo.FileVersion ?? "0.0.0";
	}

	private void Shutdown()
	{
		Console.WriteLine("MimyMart is shutting down...");

		_rawInputDeviceService.Stop();
	}

	private void StartUserInterface()
	{
		var version = GetVersion();
		var storeConfig = _storeConfigurationService.Get();

		_mainForm.AutoScroll = true;
		_mainForm.SetVersion(version);
		_mainForm.SetStoreName(storeConfig.StoreFullName ?? string.Empty);

		System.Windows.Forms.Application.Run(_mainForm);
	}
}