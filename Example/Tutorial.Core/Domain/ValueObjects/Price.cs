﻿using Example.Core.Domain.Enums;
using SharedKernel.Exceptions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example.Core.Domain.ValueObjects
{
    [ComplexType]
    public class Price
    {
        protected Price() // For Entity Framework Core
        {

        }

        public Price(int amount, MoneyUnit unit)
        {
            if (MoneyUnit.UnSpecified == unit)
                throw new BusinessRuleBrokenException("You must supply a valid money unit!");

            Amount = amount;

            Unit = unit;
        }


        public int Amount { get; protected set; }


        public MoneyUnit Unit { get; protected set; } = MoneyUnit.UnSpecified;


        public bool HasValue
        {
            get
            {
                return (Unit != MoneyUnit.UnSpecified);
            }
        }


        public override string ToString()
        {
            return 
                Unit != MoneyUnit.UnSpecified ? 
                Amount + " " + MoneySymbols.GetSymbol(Unit) : 
                Amount.ToString();
        }
    }
}
