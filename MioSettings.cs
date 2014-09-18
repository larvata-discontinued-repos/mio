using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Mio
{
    internal class MioConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
        public MioConfigCollection MioServices
        {
            get
            {
                return (MioConfigCollection)this[""];
            }
            set
            {
                this[""] = value;
            }
        }
    }

    internal class MioConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("type", IsKey = true)]
        public string Type
        {
            get
            {
                return this["type"].ToString();
            }
            set
            {
                this["type"] = value;
            }
        }

        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get
            {
                return this["name"].ToString();
            }
            set
            {
                this["name"] = value;
            }
        }
    }

    internal class MioConfigCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new MioConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((MioConfigElement)element).Name;
        }
    }

    internal class MioServicesConfig
    {
        private static readonly Dictionary<string, MioConfigElement> Elements;

        static MioServicesConfig()
        {
            Elements = new Dictionary<string, MioConfigElement>();
            var section = (MioConfigSection)ConfigurationManager.GetSection("MioServices");
            
            foreach (MioConfigElement system in section.MioServices)
                Elements.Add(system.Name, system);
        }

        public static MioConfigElement GetMio(string name)
        {
            return Elements[name];
        }

        public static List<MioConfigElement> MioServices
        {
            get { return Elements.Values.ToList(); }
        }
    }
}