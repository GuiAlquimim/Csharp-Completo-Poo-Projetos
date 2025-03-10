﻿using System.Globalization;

namespace _208_exercicio_fixacao.Entites
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{DueDate.ToString("dd/MM/yyyy")} - {Amount.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
