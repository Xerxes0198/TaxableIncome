// <copyright file="PayCycleEnum.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Constants;

/// <summary>
/// Pay Cycle Enum definition.
/// </summary>
public static class PayCycleEnum
{
    /// <summary>
    /// This enum is to hold pay cycle data.
    /// </summary>
    public enum PayCycle
    {
        /// <summary>
        /// Weekly pay cycle.
        /// </summary>
        Weekly,

        /// <summary>
        ///  Fortnightly pay cycle.
        /// </summary>
        Fortnightly,

        /// <summary>
        /// Monthly  pay cycle.
        /// </summary>
        Monthly,
    }

    /// <summary>
    /// Takes in a character and attempts to return pay cycle which matches. Throws an exception if no match is found.
    /// </summary>
    /// <param name="c">The character which represents the pay cycle.</param>
    /// <returns>A <see cref="PayCycle"/> matching the given character.</returns>
    public static PayCycle CharacterToPayCycle(this char c)
    {
        switch (c)
        {
            case 'w':
                return PayCycle.Weekly;

            case 'f':
                return PayCycle.Fortnightly;

            case 'm':
                return PayCycle.Monthly;

            default:
                throw new ArgumentException($"No valid pay cycle match found for {c}");
        }
    }
}