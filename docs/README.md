# SenseFramework

[![Build status](https://ci.appveyor.com/api/projects/status/qu02yhle7n24bq3s/branch/master?svg=true)](https://ci.appveyor.com/project/ekinbulut/senseframework-3o670/branch/master)

This framework is built to help development of n-tier applications by giving service oriented architectural platform.
You may built your apps by implementing of certain libraries.
Each library provides components for easiy implementations of repository pattern, unit of work, mapping, logging, aop etc.

### Modules
#### 1. Core

* **_SenseFramework.Core_** : Core library which manages all components of an application.

#### 2. Data

* **_SenseFramework.Data.EntityFramework_** : This library contains support for Entity Framework with default Context and repository pattern.
* ~~**_SenseFramework.Data.MongoDb_** : This library contains components to use MongoDb context with repository patttern.~~
* ~~**_SenseFramework.Data.NHibernate_** : This library is as same as EntityFramework but uses Nhibernate platform to build mappings with code first.~~

#### 3. Bussiness

* **_SenseFramework.Applications_** : This module provides interface to integrate your bussiness logic with senseframework.
* **_SenseFramework.Services_** : This library is for registering WCF services in your service layer.
* **_SenseFramework_** : This library is startup point of the application. This library must be called in the client runtime application. (Console or Windows Service)

### Progress

Continuously in development with new feautures.

### SenseFramework module

This module is the startup module of entire SenseFramework domain. If you have implemnted any other SenseFramework modules in an application, to run them all, you need an implementation of SenseFramework

This module can be called in any start point of application.

### For Example

Windows Service Applicaition

---

```csharp

protected override void OnStart(string[] args)
{
    var task = new Task(() =>
    {
        var fm = new SenseFrameworkModule();
        // to display senseframework events use;
        fm.TrackMessages += fm_TrackMessages;
        fm.StartUp();

    });

    task.Start();           
}

private static void fm_TrackMessages(string message)
{
    //get messages
}

```

---

### Add log4net.config

Senseframework supports log4net. So if you want to startup a project with SenseFrameworkModule;

1. Add log4net.config
2. Set Copy to Output Directory to Copy always or Copy if newer

#### Sample log4net.config

``` xml

<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <log4net>
    <appender name="Console" type="log4net.Appender.ConsoleAppender">
      <layout type="log4net.Layout.PatternLayout">
        <!--<conversionPattern value="%date %-5level %thread: %message%newline" />-->
        <conversionPattern value="%date %level %thread %logger - %message%newline" />
      </layout>
    </appender>
    
    <appender name="RollingFile" type="log4net.Appender.RollingFileAppender">
      <file value="debug.log" />
      <appendToFile value="true" />
      <maximumFileSize value="100KB" />
      <maxSizeRollBackups value="2" />

      <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%date %level %thread %logger - %message%newline" />
      </layout>
    </appender>

    <root>
      <level value="DEBUG" />
      <appender-ref ref="Console" />
      <appender-ref ref="RollingFile" />
    </root>
  </log4net>
</configuration>

```
This call will scan all modules of SenseFramework and will run up.

