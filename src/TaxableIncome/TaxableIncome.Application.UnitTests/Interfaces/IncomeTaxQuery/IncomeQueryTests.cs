// <copyright file="IncomeQueryTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.UnitTests.Interfaces.IncomeTaxQuery;

using Enums;
using TaxableIncome.Application.Interfaces.IncomeTaxQuery;

/// <summary>
/// Tests for <see cref="IncomeQuery"/>.
/// </summary>
public class IncomeQueryTests : BaseUnitTests
{
    /// <summary>
    /// Assembles a request and checks that the expected response is returned.
    /// Example data pulled from supplied assignment sheet.
    /// </summary>
    [Fact]
    public void IncomeQuery_Execute_ReturnsExpectedResponse()
    {
        var request = new IncomeQueryRequest(65000M, PayFrequency.Monthly);

        var response = this.IncomeQuery.Execute(request);

        Assert.Equal(65000M, response.GrossPackage);
        Assert.Equal(5639.27M, response.SuperContribution);

        Assert.Equal(59360.73M, response.TaxableSalary);

        Assert.True(response.MedicareLevyChargeRequired);
        Assert.Equal(1188.00M, response.MedicareLevy);

        Assert.False(response.BudgetRepairLevyRequired);
        Assert.Equal(10839.00M, response.IncomeTax);

        Assert.Equal(47333.73M, response.NetIncome);
        Assert.Equal(3944.48M, response.PayPacket);
    }
}