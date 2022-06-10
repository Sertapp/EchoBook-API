using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIBank_1.Models.Context;
using WebAPIBank_1.Models.Entities;

namespace WebAPIBank_1.Models.Init
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            CardInfo ci = new CardInfo();
            ci.CardUserName = "Sertap Ugur";
            ci.CardNumber = "1111 1111 1111 1111";
            ci.CardExpiryYear = 2023;
            ci.CardExpiryMonth = 12;
            ci.SecurityNumber = "222";
            ci.Limit = 20000;
            ci.Balance = 20000;
            context.Cards.Add(ci);
            context.SaveChanges();
        }
    }
}