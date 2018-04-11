This app consists of a single page with two forms. The first form uses the `<form>` tag helper, which includes an anti-forgery token in the request body; the second form uses a raw HTML `<form>` element, which doesn't. Submitting the first form successfully reloads the page; submitting the second form results in a 400 Bad Request.

If you change this line in [Startup.cs](Startup.cs):

```csharp
options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
```

to this:

```csharp
options.Filters.Add(typeof(AutoValidateAntiforgeryTokenAttribute));
```

the anti-forgery validation doesn't take effect.
