using System.Collections.Generic;
using Example.Core.Domain.Enums;

namespace Example.Core.Domain.ValueObjects
{
    public static class MoneySymbols
    {
        private static Dictionary<MoneyUnit, string> _symbols;

        static MoneySymbols()
        {
            if (_symbols != null)
                return;

            _symbols = new Dictionary<MoneyUnit, string>
            {
                { MoneyUnit.UnSpecified, string.Empty },

                { MoneyUnit.Dollar, "$" },

                { MoneyUnit.Euro, "€" },
            };
        }

        public static string GetSymbol(MoneyUnit moneyUnit)
        {
            return _symbols[moneyUnit].ToString();
        }
    }
}
