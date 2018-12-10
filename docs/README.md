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
