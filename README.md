# C# EnvSettings Utility

Quick and simple wrapper around the .Net Environment.GetEnvironmentVariable() function accessing environment variables.

Example uses:

```
// Get a string value by default
EnvSettings.Get("")

EnvSettings.Get("", EnvironmentVariableTarget.Machine)

// Get an int value from the AppSettings
EnvSettings.Get<int>("TimeoutValue")

EnvSettings.Get<int>("TimeoutValue", EnvironmentVariableTarget.User)

// A safe check around getting a numeric value
long value;
EnvSettings.TryGet<long>("IsntNumericValue", out value)

EnvSettings.TryGet<long>("IsntNumericValue", EnvironmentVariableTarget.Process, out value)
```