using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Ivanov";
        decimal balanceTotal = 23456.78m; //decimal should be used every time the value will be currency for the precision it has
        string bankName = "FIB";
        string personalIBAN = "BG87FINV25689787654321";
        long silverCrCdNum = 1234567890123456L;
        decimal silverCrCdCreditLine = 1000m;         
        decimal silverCrCdAvailableAmount = 654.32m;
        long goldCreditCdNum = 6543210987654321L;
        decimal goldCrCdCreditLine = 5000m;
        decimal goldCrCdAvailableAmount = 5000m;
        long platinumCrCdNum = 7894561230123456L;
        decimal platinumCrCdCreditLine = 10000m;
        decimal platinumCrCdAvailableAmount = 10000m;
    }
}