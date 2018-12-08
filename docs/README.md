# SenseFramework

This framework is built to help development of n-tier applications by giving service oriented architectural platform.
You may built your apps by implementing of certain libraries.
Each library provides components for easiy implementations of repository pattern, unit of work, mapping, logging, aop etc.

Build status

### Modules
#### 1. Core

* **_SenseFramework.Core_** : Core library which manages all components of an application.

#### 2. Data

* **_SenseFramework.Data.EntityFramework_** : This library contains support for Entity Framework with default Context and repository pattern.
* ~~**_SenseFramework.Data.MongoDb_** : This library contains components to use MongoDb context with repository patttern.~~
* ~~**_SenseFramework.Data.NHibernate_** : This library is as same as EntityFramework but uses Nhibernate platform to build mappings with code first.~~

#### 3. Bussiness

* ~~**_SenseFramework.Applications_** : Currently in development.~~
* **_SenseFramework.Services_** : This library is for registering WCF services in your service layer.
* **_SenseFramework_** : This library is startup point of the application. This library must be called in the client runtime application. (Console or Windows Service)

### Progress

Continuously in development with new feautures.
