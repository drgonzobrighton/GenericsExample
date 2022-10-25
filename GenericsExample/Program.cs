// See https://aka.ms/new-console-template for more information

using System;
using GenericsExample;


//var parser = new NonGenericUserInputParser();

//var accountId = parser.GetString("id");
//var identifierNumber = parser.GetOptionalString("identifier number");
//var currentBalance = parser.GetDecimal("current balance");
//var balanceLimit = parser.GetOptionalDecimal("balance limit");
//var createdDate = parser.GetDateTime("created date");
//var modifiedDate = parser.GetOptionalDateTime("modified date");

//var bankAccount = new BankAccount
//{
//    Id = accountId,
//    IdentifierNumber = identifierNumber,
//    CurrentBalance = currentBalance,
//    BalanceLimit = balanceLimit,
//    CreatedDate = createdDate,
//    ModifiedDate = modifiedDate
//};

var parser = new GenericUserInputParser();

var accountId = parser.GetInput<string>("id");
var identifierNumber = parser.GetInput<string>("identifier number");
var currentBalance = parser.GetInput<decimal>("current balance");
var balanceLimit = parser.GetInput<decimal?>("balance limit");
var createdDate = parser.GetInput<DateTime>("created date");
var modifiedDate = parser.GetInput<DateTime?>("modified date");

var bankAccount = new BankAccount
{
    Id = accountId,
    IdentifierNumber = identifierNumber,
    CurrentBalance = currentBalance,
    BalanceLimit = balanceLimit,
    CreatedDate = createdDate,
    ModifiedDate = modifiedDate
};

Console.WriteLine(bankAccount);
Console.ReadLine();
