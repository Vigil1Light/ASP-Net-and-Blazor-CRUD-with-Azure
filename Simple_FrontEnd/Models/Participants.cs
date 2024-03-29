﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Simple_FrontEnd.Models
{
    public partial class Participants
    {
        public Participants()
        {
            Custumers = new HashSet<Custumers>();
            PendingTransactionsFromPartd = new HashSet<PendingTransactions>();
            PendingTransactionsToPart = new HashSet<PendingTransactions>();
            Users = new HashSet<Users>();
        }

        public int Part_Id { get; set; }
        public int Ptype_Id { get; set; }
        public int Country_Id { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool IsDeleting { get; set; }

        public virtual Countries Country { get; set; }
        public virtual ParticipantsType Ptype { get; set; }
        public virtual ICollection<Custumers> Custumers { get; set; }
        public virtual ICollection<PendingTransactions> PendingTransactionsFromPartd { get; set; }
        public virtual ICollection<PendingTransactions> PendingTransactionsToPart { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}