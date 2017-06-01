﻿namespace Adaptive.ReactiveTrader.Contract.Events.Trade
{
    public class TradeRejectedEvent
    {
        public TradeRejectedEvent(string tradeId, string reason)
        {
            TradeId = tradeId;
            Reason = reason;
        }

        public string TradeId { get; }
        public string Reason { get; }
    }
}