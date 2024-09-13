// <copyright file="FinancialYear2018Constants.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Constants.TaxConstants;

/// <summary>
/// Financial Year 2018 Constants.
/// </summary>
public static class FinancialYear2018Constants
{
    /// <summary>
    /// Super annuation for 2018 is 9.5 percent.
    /// </summary>
    public const decimal SuperPercentage = 0.095M;

    /// <summary>
    /// Medicare Levy Excess minimum.
    /// </summary>
    public const decimal MedicareLevyLowExcess = 21336.0M;

    /// <summary>
    /// Medicare Levy Excess Maximum.
    /// </summary>
    public const decimal MedicareLevyHighExcess = 21336.0M;

    /// <summary>
    /// Medicare Levy Excess Maximum.
    /// </summary>
    public const decimal MedicareLevyExcessReduction = 21335.0M;

    /// <summary>
    /// Medicare Levy uppper capped percentage.
    /// </summary>
    public const decimal MedicareLevyUpperCappedPercentage = 0.02M;

    /// <summary>
    /// Medicare Levy mid capped percentage.
    /// </summary>
    public const decimal MedicareLevyMidCappedPercentage = 0.1M;

    /// <summary>
    /// Budget Repair Levy Cutoff.
    /// </summary>
    public const decimal BudgetRepairLevyCutoff = 180001.0M;

    /// <summary>
    /// Budget Repair Levy percentage.
    /// </summary>
    public const decimal BudgetRepairLevyPercntage = 0.02M;
}