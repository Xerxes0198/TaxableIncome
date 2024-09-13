// <copyright file="IncomeQueryResponse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces.IncomeTaxQuery;

using Classes;

/// <summary>
/// The response object for the <see cref="IncomeQuery"/> command.
/// </summary>
public class IncomeQueryResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IncomeQueryResponse"/> class.
    /// </summary>
    /// <param name="medicareLevyChargeRequired">Whether the medicare levy charge is required.</param>
    /// <param name="medicareLevy">The calculated medicareLevy.</param>
    /// <param name="budgetRepairLevyRequired">Whether the budget repair levy is required.</param>
    /// <param name="budgetRepairLevy">The calculated budgetRepairLevy.</param>
    /// <param name="grossPackage">The calculated gross package.</param>
    /// <param name="taxableSalary">The calculated taxable salary.</param>
    /// <param name="superContribution">The calculated super contribution.</param>
    /// <param name="incomeTax">The calculated income tax.</param>
    /// <param name="netIncome">The calculated net income.</param>
    /// <param name="payPacket">The calculated pay packet for the set frequency.</param>
    /// <param name="payFrequency">The selected pay frequency.</param>
    public IncomeQueryResponse(bool medicareLevyChargeRequired, decimal? medicareLevy, bool budgetRepairLevyRequired, decimal budgetRepairLevy, decimal grossPackage, decimal taxableSalary, decimal superContribution, decimal incomeTax, decimal netIncome, decimal payPacket, PayFrequency payFrequency)
    {
        this.MedicareLevyChargeRequired = medicareLevyChargeRequired;
        this.MedicareLevy = medicareLevy;
        this.BudgetRepairLevyRequired = budgetRepairLevyRequired;
        this.BudgetRepairLevy = budgetRepairLevy;
        this.GrossPackage = grossPackage;
        this.TaxableSalary = taxableSalary;
        this.SuperContribution = superContribution;
        this.IncomeTax = incomeTax;
        this.NetIncome = netIncome;
        this.PayPacket = payPacket;
        this.PayFrequency = payFrequency;
    }

    /// <summary>
    /// Gets a value indicating whether the medicare Levy surcharge was charged.
    /// </summary>
    public bool MedicareLevyChargeRequired { get; private set; }

    /// <summary>
    /// Gets medicare Levy surcharge charged.
    /// </summary>
    public decimal? MedicareLevy { get; private set; }

    /// <summary>
    /// Gets a value indicating whether the budget repair was charged.
    /// </summary>
    public bool BudgetRepairLevyRequired { get; private set; }

    /// <summary>
    /// Gets the Budget Repair Levy.
    /// </summary>
    public decimal BudgetRepairLevy { get; private set; }

    /// <summary>
    /// Gets the Gross Package.
    /// </summary>
    public decimal GrossPackage { get; private set; }

    /// <summary>
    /// Gets the Taxable Salary.
    /// </summary>
    public decimal TaxableSalary { get; private set; }

    /// <summary>
    /// Gets the super contribution.
    /// </summary>
    public decimal SuperContribution { get; private set; }

    /// <summary>
    /// Gets the income tax payable.
    /// </summary>
    public decimal IncomeTax { get; private set; }

    /// <summary>
    /// Gets the net income.
    /// </summary>
    public decimal NetIncome { get; private set; }

    /// <summary>
    /// Gets the pay packet for the desired frequency.
    /// </summary>
    public decimal PayPacket { get; private set; }

    /// <summary>
    /// Gets the pay frequency.
    /// </summary>
    public PayFrequency PayFrequency { get; private set; }
}