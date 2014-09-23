Mio
========
an small module for class dynamic loading

###Usage

Load Mio service in app.config
```
<configuration>
	<configSections>
		<section name="MioServices" type="Mio.MioConfigSection, Mio" />
	</configSections>
</configuration>
```

Config your module for dynamic loading
your class should inherit same interface
```
<MioServices>
	<add name="IDemo" type="Demo.Lib.Second,Demo.Lib"/>
</MioServices>
```

Create interface
```
public interface IDemo
{
    void ConsoleLog();
}
```

Implement the interface
and load derived class dynamically
```
var foobar = Mio.ProxyFactory.Create<IDemo>();
foobar.ConsoleLog();
```
