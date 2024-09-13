// <copyright file="IncomeQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces.IncomeTaxQuery;

using Constants;
using Enums;
using Constants.TaxConstants;
using Interfaces;

/// <summary>
/// The income tax calculator query.
/// </summary>
public class IncomeQuery
{
    private readonly MedicareLevyCalculator medicareLevyCalculator;
    private readonly BudgetRepairCalculator budgetRepairCalculator;
    private readonly IncomeTaxCalculator incomeTaxCalculator;

    /// <summary>
    /// Initializes a new instance of the <see cref="IncomeQuery"/> class.
    /// </summary>
    public IncomeQuery()
    {
        this.medicareLevyCalculator = new MedicareLevyCalculator();
        this.budgetRepairCalculator = new BudgetRepairCalculator();
        this.incomeTaxCalculator = new IncomeTaxCalculator();
    }

    /// <summary>
    /// Executes this query.
    /// </summary>
    /// <param name="incomeTaxRequest">The given <see cref="IncomeQueryRequest"/> object for this tax calculations.</param>
    /// <returns>A populated version of <see cref="IncomeQueryResponse"/>.</returns>
    public IncomeQueryResponse Execute(IncomeQueryRequest incomeTaxRequest)
    {
        // Calculate Super
        var taxableSalary = incomeTaxRequest.Income / (1 + FinancialYear2018Constants.SuperPercentage);
        var superContribution = taxableSalary * FinancialYear2018Constants.SuperPercentage;

        // Calculate medicare levy
        var medicareLevy = this.medicareLevyCalculator.Get2018Levy(taxableSalary);

        // Budget Repair Levy
        var budgetRepairLevy = this.budgetRepairCalculator.Get2018BudgetRepairLevy(taxableSalary);

        // Income tax
        var incomeTax = this.incomeTaxCalculator.Get2018IncomeTax(taxableSalary);

        // Net calculation
        var netIncome = incomeTaxRequest.Income - superContribution - medicareLevy - budgetRepairLevy - incomeTax;

        // Pay packet per frequency.
        decimal payPacket = decimal.Zero;

        switch (incomeTaxRequest.PayFrequency)
        {
            case PayFrequency.Weekly:
                payPacket = netIncome / DateConstants.WeeksPerYear;
                break;

            case PayFrequency.Fortnightly:
                payPacket = netIncome / DateConstants.FortnightsPerYear;
                break;

            case PayFrequency.Monthly:
                payPacket = netIncome / DateConstants.MonthsPerYear;
                break;
        }

        // Build up the response and return it.
        return new IncomeQueryResponse(
            medicareLevy != decimal.Zero,
            medicareLevy,
            budgetRepairLevy != decimal.Zero,
            budgetRepairLevy,
            incomeTaxRequest.Income,
            taxableSalary,
            superContribution,
            incomeTax,
            netIncome,
            payPacket,
            incomeTaxRequest.PayFrequency);
    }
}