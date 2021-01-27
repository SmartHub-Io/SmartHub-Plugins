using System;
using System.Collections.Generic;
using SmartHub.BasePlugin.Interfaces;
using SmartHub.BasePlugin.Interfaces.DeviceTypes;

namespace ShellyPlugin.DeviceTypes
{
    public class ShellyOne : ShellyBase, ILight, IHttpSupport
    {
        public override string Name { get; set; } = $"{nameof(ShellyOne)}";
        public string SettingsRelay { get; set; } = "/settings/relay/0";
        public string Relay { get; set; } = "/relay/0";


        ILight GetStatus()
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
                QueryParams.Add(TurnOnOff, "On");
            }
            if (onOff.Value == false)
            {
                QueryParams.Add(TurnOnOff, "Off");
            }
            return this;
        }

        ILight ILight.SetRgba(int red, int green, int blue, int alpha)
        {
            return this;
        }

        public ILight InstantiateQuery()
        {
            throw new NotImplementedException();
        }

        public ILight SetStatus()
        {
            throw new NotImplementedException();
        }
    }
}