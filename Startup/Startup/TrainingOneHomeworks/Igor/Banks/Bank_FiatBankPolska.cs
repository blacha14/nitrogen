﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banki.Interfaces;
using Banki.ClientClass;
using System.Numerics;

namespace Banki.Banks
{
    public class Bank_FiatBankPolska : Bank
    {
        public Bank_FiatBankPolska(List<Bank> banks)
        {
            this.id = 2140;
            this.name = "Fiat Bank Polska";
            this.history = new List<Transaction>();
            this.banks = banks;
        }

        public override List<string> showHistory()
        {
            List<string> ret = new List<string>();
            ret.Add("----------------------");
            ret.Add("Bank transaction history : ");
            foreach (var obj in history)
            {
                ret.Add("Operation: " + obj.operationType + " From: " + obj.getSender() + " (Bank : " + obj.senderBankName + ")" + " To: " + obj.getReceiver() + " (Bank : " + obj.receiverBankName + ")" + " Amount: " + obj.getAmount());
            }
            return ret;
        }

        public override bool Transfer(Transaction transfer)
        {
            return transfer.doOperation();
        }

        public override List<Transaction> getHistory()
        {
            return this.history;
        }
    }
}
