using System;

namespace Ennui.Api
{
    /// <summary>
	/// Provides a set of static utilities for interfacing with random numbers n stuff.
	/// </summary>
	public static class RandomUtils
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// Represents a set of potential characters that we will select from
        /// when generating random strings.
        /// </summary>
        private const string PotentialChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        /// <summary>
        /// Generates a random string, with a random length between min & max.
        /// </summary>
        /// <param name="min">The minimum number of characters to generate.</param>
        /// <param name="max">The maximum number of characters to generate.</param>
        /// <returns>The randomly generated string.</returns>
        public static string RandomString(int min, int max)
        {
            var stringChars = new char[random.Next(min, max)];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = PotentialChars[random.Next(PotentialChars.Length)];
            }

            return new string(stringChars);
        }

        /// <summary>
        /// Calculates a random number number between 0 and max (exclusive.)
        /// </summary>
        /// <param name="max">The maximum value.</param>
        /// <returns>The calculated number.</returns>
        public static int NextInt(int max)
        {
            return random.Next(max);
        }

        /// <summary>
        /// Calculates a random number number between min and max (exclusive.)
        /// </summary>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The calculated number.</returns>
        public static int NextInt(int min, int max)
        {
            return random.Next(min, max);
        }

        /// <summary>
        /// Calculates a double between 0-1.0.
        /// </summary>
        /// <returns>The calculated double.</returns>
        public static double NextDouble()
        {
            return random.NextDouble();
        }

    }
}
