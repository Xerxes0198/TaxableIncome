// <copyright file="InputConstants.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Constants;

/// <summary>
/// Input Constants for the application.
/// </summary>
public static class InputConstants
{
    /// <summary>
    /// This is how many decimal points we want a user to define in their input.
    /// </summary>
    public const int AllowedDecimalPoints = 1;

    /// <summary>
    /// This is the income message prompt presented to the user.
    /// </summary>
    public static readonly string IncomeInputMessage = "Please enter your salary package amount: ";

    /// <summary>
    /// This is the pay cycle message prompt presented to the user.
    /// </summary>
    public static readonly string PayCycleInputMessage = "Please enter your pay frequency (W for weekly, F for fortnightly, M for monthly): ";
}