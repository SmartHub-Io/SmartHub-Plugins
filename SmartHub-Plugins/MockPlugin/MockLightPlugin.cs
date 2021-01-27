using SmartHub.BasePlugin.Interfaces.DeviceTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MockPlugin
{
	public class MockLightPlugin : IMockLightPlugin
	{
		public string TurnOnOff { get; set; } = "turn=";
		private StringBuilder Builder { get; set; }

		public Tuple<string, Dictionary<string, string>> GetStatus()
		{
			throw new NotImplementedException();
		}

		ILight ILight.SetLight(bool? onOff)
		{
			if (onOff is null)
			{
				return this;
			}
			if (onOff.Value)
			{
				Builder.Append(TurnOnOff + "On");
			}
			if (onOff.Value == false)
			{
				Builder.Append(TurnOnOff + "Off");
			}
			return this;
		}

		public ILight SetRgba(int red, int green, int blue, int alpha)
		{
			//TODO: Implement logic
			return this;
		}

		public ILight InstantiateQuery()
		{
			throw new NotImplementedException();
		}

		public Tuple<string, Dictionary<string, string>> Build()
		{
			throw new NotImplementedException();
		}

		public ILight SetStatus()
		{
			throw new NotImplementedException();
		}
	}
}