using System;

namespace MagicFixturePackage.Core.Models
{
    public class MagicFixture
    {
        public T Summon<T>() where T: class {
            var instance = (T) Activator.CreateInstance(typeof(T));

            foreach (var property  in typeof(T).GetProperties()) {
                if (property.PropertyType == typeof(int)) {
                    var value = new Random().Next(1, 10);

                    property.SetValue(instance, value);
                } else if (property.PropertyType == typeof(double)) {
                    var value = new Random().NextDouble();

                    property.SetValue(instance, value);
                } else if (property.PropertyType == typeof(string)) {
                    var value = GenerateRandomString();

                    property.SetValue(instance, value);
                }
            }

            return instance;
        }

        private string GenerateRandomString() {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[10];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                var randomIndex = random.Next(chars.Length);

                stringChars[i] = chars[randomIndex];
            }

            return new String(stringChars);
        }
    }
}