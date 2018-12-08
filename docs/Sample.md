## SenseFramework module

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
        fm.StartUp();

    });

    task.Start();           
}

```

---

This call will scan all modules of SenseFramework and will run up.