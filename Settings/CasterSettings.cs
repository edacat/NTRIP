﻿using System;
using System.Configuration;

namespace NTRIP.Settings
{   
    public class CasterSettings : ConfigurationSection
    {
        private static ConfigurationProperty _serverPassword =
            new ConfigurationProperty("ServerPassword", typeof(String), String.Empty, ConfigurationPropertyOptions.IsRequired);

        private static ConfigurationProperty _portNumber =
            new ConfigurationProperty("PortNumber", typeof(Int32), 5000, ConfigurationPropertyOptions.IsRequired);

        private static ConfigurationProperty _ntripUsers =
            new ConfigurationProperty("NTRIPUsers", typeof(NTRIPUserCollection), null, ConfigurationPropertyOptions.IsRequired);

        private static ConfigurationProperty _ntripMountPoints =
            new ConfigurationProperty("NTRIPMountPoints", typeof(NTRIPMountPointCollection), null, ConfigurationPropertyOptions.IsRequired);

        private static ConfigurationProperty _localServers =
            new ConfigurationProperty("LocalServers", typeof(LocalServerCollection), null, ConfigurationPropertyOptions.IsRequired);

        public CasterSettings()
        {
            base.Properties.Add(_serverPassword);
            base.Properties.Add(_portNumber);
            base.Properties.Add(_ntripUsers);
            base.Properties.Add(_ntripMountPoints);
            base.Properties.Add(_localServers);
        }

        [ConfigurationProperty("ServerPassword", IsRequired = true)]
        public string ServerPassword
        {
            get { return (string)this[_serverPassword]; }
            set { this[_serverPassword] = value; }
        }

        [ConfigurationProperty("PortNumber", IsRequired = true)]
        public int PortNumber
        {
            get { return (int)this[_portNumber]; }
            set { this[_portNumber] = value; }
        }

        [ConfigurationProperty("NTRIPUsers", IsRequired = true)]
        public NTRIPUserCollection NTRIPUsers
        {
            get { return (NTRIPUserCollection)this[_ntripUsers]; }
            set { this[_ntripUsers] = value; }
        }

        [ConfigurationProperty("NTRIPMountPoints", IsRequired = true)]
        public NTRIPMountPointCollection NTRIPMountPoints
        {
            get { return (NTRIPMountPointCollection)this[_ntripMountPoints]; }
            set { this[_ntripMountPoints] = value; }
        }

        [ConfigurationProperty("LocalServers", IsRequired = true)]
        public LocalServerCollection LocalServers
        {
            get { return (LocalServerCollection)this[_localServers]; }
            set { this[_localServers] = value; }
        }
    }
}
