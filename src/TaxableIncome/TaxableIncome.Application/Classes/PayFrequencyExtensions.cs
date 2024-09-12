// <copyright file="PayFrequencyExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Constants;

using Classes;

/// <summary>
/// Pay frequency extensions.
/// </summary>
public static class PayFrequencyExtensions
{
    /// <summary>
    /// Takes in a character and attempts to return pay cycle which matches. Throws an exception if no match is found.
    /// </summary>
    /// <param name="c">The character which represents the pay cycle.</param>
    /// <returns>A <see cref="PayFrequency"/> matching the given character.</returns>
    public static PayFrequency CharacterToPayCycle(this char c)
    {
        switch (c)
        {
            case 'w':
                return PayFrequency.Weekly;

            case 'f':
                return PayFrequency.Fortnightly;

            case 'm':
                return PayFrequency.Monthly;

            default:
                throw new ArgumentException($"No valid pay cycle match found for {c}");
        }
    }
}