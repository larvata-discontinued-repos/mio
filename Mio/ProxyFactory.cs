using System.Reflection;

namespace Mio
{
    public static class ProxyFactory
    {
        public static T Create<T>()
        {
            var typeName = typeof (T).Name;
            var assemblyName = MioServicesConfig.GetMio(typeName).Type.Split(',');

            return (T)Assembly.Load(assemblyName[1]).CreateInstance(assemblyName[0]);
        }
    }
}
