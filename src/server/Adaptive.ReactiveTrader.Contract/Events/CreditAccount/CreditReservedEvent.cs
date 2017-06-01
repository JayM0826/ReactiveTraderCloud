﻿namespace Adaptive.ReactiveTrader.Contract.Events.CreditAccount
{
    public class CreditReservedEvent
    {
        public CreditReservedEvent(string accountName, string tradeId)
        {
            AccountName = accountName;
            TradeId = tradeId;
        }

        public string AccountName { get; }
        public string TradeId { get; }
    }
}