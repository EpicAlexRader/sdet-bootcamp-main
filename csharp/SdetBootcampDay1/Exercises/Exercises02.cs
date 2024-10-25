﻿using Microsoft.VisualBasic;
using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        /**
         * TODO: rewrite these three tests into a single, parameterized test.
         * You decide if you want to use [TestCase] or [TestCaseSource], but
         * I would like to know why you chose the option you chose afterwards.
         */
        /*[Test]
        public void CreateNewSavingsAccount_Deposit100Withdraw50_BalanceShouldBe50()
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(100);
            account.Withdraw(50);

            Assert.That(account.Balance, Is.EqualTo(50));
        }

        [Test]
        public void CreateNewSavingsAccount_Deposit1000Withdraw1000_BalanceShouldBe0()
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(1000);
            account.Withdraw(1000);

            Assert.That(account.Balance, Is.EqualTo(0));
        }

        [Test]
        public void CreateNewSavingsAccount_Deposit250Withdraw1_BalanceShouldBe249()
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(250);
            account.Withdraw(1);

            Assert.That(account.Balance, Is.EqualTo(249));
        }
        */

        //homework
        [Test, TestCaseSource(nameof(CreateNewSavingsAccount_DepositWithdrawValues))]
        public void CreateNewSavingsAccount_DepositWithdraw(int dep, int with, int ans)
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(dep);
            account.Withdraw(with);

            Assert.That(account.Balance, Is.EqualTo(ans));
        }

        public static object [] CreateNewSavingsAccount_DepositWithdrawValues =
        {
            //Diposite, withdraw, expected result
            new object[] { 100, 50, 50 },
            new object[] { 1000, 1000, 0}, 
            new object[] { 250, 1, 249 }
        };

        //in class
        [Test, TestCaseSource("SavingsDepositeInfo")]
        public void TestDateClass(int first, int second, int expected)
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(first);
            account.Withdraw(second);

            Assert.That(account.Balance, Is.EqualTo(expected));
        }

        private static IEnumerable<TestCaseData> SavingsDepositeInfo()
        {
            yield return new TestCaseData( 100, 50, 50 ).SetName("T1");
            yield return new TestCaseData( 1000, 1000, 0 ).SetName("T2");
            yield return new TestCaseData( 250, 1, 249 ).SetName("T3");
        }
    }
}
