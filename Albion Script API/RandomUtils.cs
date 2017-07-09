using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public const string PotentialChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        /// <summary>
        /// Generates a random string, with a random length between min & max;
        /// </summary>
        /// <returns>The randomly generated string.</returns>
        /// <param name="min">The minimum number of characters to generate.</param>
        /// <param name="max">The maximum number of characters to generate.</param>
        public static string RandomString(int min, int max)
        {
            var stringChars = new char[random.Next(min, max)];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = PotentialChars[random.Next(PotentialChars.Length)];
            }

            return new string(stringChars);
        }
    }
}
