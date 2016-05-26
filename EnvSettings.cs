using System;

namespace Utilities
{
    public static class EnvSettings
    {
        public static string Get(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }

        public static string Get(string key, EnvironmentVariableTarget target)
        {
            return Environment.GetEnvironmentVariable(key, target);
        }

        public static TValue Get<TValue>(string key)
        {
            var value = Get(key);

            if (string.IsNullOrEmpty(value))
            {
                return default(TValue);
            }

            return (TValue) Convert.ChangeType(value, typeof (TValue));
        }

        public static TValue Get<TValue>(string key, EnvironmentVariableTarget target)
        {
            var value = Get(key, target);

            if (string.IsNullOrEmpty(value))
            {
                return default(TValue);
            }

            return (TValue) Convert.ChangeType(value, typeof (TValue));
        }

        public static bool TryGet<TValue>(string key, out TValue value)
        {
            try
            {
                value = Get<TValue>(key);
                return true;
            }
            catch (Exception)
            {
                value = default(TValue);
                return false;
            }
        }

        public static bool TryGet<TValue>(string key, EnvironmentVariableTarget target, out TValue value)
        {
            try
            {
                value = Get<TValue>(key, target);
                return true;
            }
            catch (Exception)
            {
                value = default(TValue);
                return false;
            }
        }
    }
}