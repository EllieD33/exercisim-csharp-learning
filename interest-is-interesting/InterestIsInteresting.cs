using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
    {
        < 0 => 3.213f,
        < 1000 => 0.5f,
        < 5000 => 1.621f,
        _ => 2.475f
    };
    }

    public static decimal Interest(decimal balance) => (decimal)SavingsAccount.InterestRate(balance) * balance / 100m;

    public static decimal AnnualBalanceUpdate(decimal balance) => SavingsAccount.Interest(balance) + balance;

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        decimal newBalance = balance;
        while (newBalance < targetBalance)
        {
            newBalance = AnnualBalanceUpdate(newBalance);
            years++;
        }

        return years;
    }
}
