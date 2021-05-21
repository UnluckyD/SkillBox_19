//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankSystemApp.DataAccess
{
    using MsgBoxAlertClass;
    using System;
    
    public partial class Credit
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> dateBegin { get; set; }
        public Nullable<System.DateTime> dateEnd { get; set; }
        public Nullable<System.DateTime> dateLast { get; set; }
        public decimal amount { get; set; }
        public decimal monthly { get; set; }
        public decimal Amount { set { amount = decimal.Parse((double.Parse(value.ToString()) * ((1 +  (double)BankValues.creditProcentPerYear/ 100))).ToString()); } }

        public Credit()
        {
            dateBegin = DateTime.Now;
            dateLast = DateTime.Now;
        }

        void GetMonthly()
        {
            try
            {
                var term = ((DateTime)dateEnd).Month - ((DateTime)dateBegin).Month;
                if (term > 0)
                    monthly = amount / term;
                else
                    monthly = amount;
            }
            catch (Exception ex)
            {
                Alerts.MsgError($"Ошибка получения суммы ежимесячной выплаты:\n{ex.Message}");
            }
        }
    }
}
