﻿using Com.DanLiris.Service.Purchasing.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.ViewModels.UnitReceiptNote
{
    public class DetailCreditBalanceReportViewModel
    {
        public DetailCreditBalanceReportViewModel()
        {
            Reports = new List<DetailCreditBalanceReport>();
            AccountingUnitSummaries = new List<SummaryDCB>();
            CurrencySummaries = new List<SummaryDCB>();
        }
        public List<DetailCreditBalanceReport> Reports { get; set; }
        public List<SummaryDCB> AccountingUnitSummaries { get; set; }
        public List<SummaryDCB> CurrencySummaries { get; set; }
        //public decimal AccountingUnitSummaryTotal { get; set; }
        //public decimal GrandTotal { get; set; }
    }

    public class SummaryDCB
    {
        public string AccountingUnitName { get; set; }
        public string CurrencyCode { get; set; }
        public decimal SubTotal { get; set; }
        public decimal SubTotalIDR { get; set; }
    }

    public class DetailCreditBalanceReport
    {
        public DateTimeOffset ReceiptDate { get; set; }
        public string UPONo { get; set; }
        public string URNNo { get; set; }
        public string InvoiceNo { get; set; }
        public string SupplierName { get; set; }
        public string CategoryName { get; set; }
        public string AccountingUnitName { get; internal set; }
        public DateTimeOffset DueDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal TotalSaldo { get; set; }
        public decimal TotalSaldoIDR { get; set; }
        //public decimal Saldo { get; set; }
        //public string ProductName { get; set; }
        //public string UnitName { get; set; }
        //public string UnitCode { get; set; }
        //public decimal DPP { get; set; }
        //public decimal DPPCurrency { get; set; }
        //public decimal VAT { get; set; }
        //public decimal VATCurrency { get; set; }
        //public decimal CurrencyRate { get; set; }
        //public decimal Total { get; set; }
        //public decimal TotalCurrency { get; set; }
        //public bool IsUseVat { get; set; }
        //public string SupplierCode { get; set; }
        //public string IPONo { get; set; }
        //public string DONo { get; set; }
        //public string CategoryCode { get; set; }
        //public string VATNo { get; set; }
        //public double Quantity { get; set; }
        //public string Uom { get; set; }
        //public DateTimeOffset PIBDate { get; internal set; }
        //public string PIBNo { get; set; }
        //public decimal PIBBM { get; set; }
        //public decimal PIBIncomeTax { get; set; }
        //public decimal PIBVat { get; set; }
        //public string PIBImportInfo { get; set; }
        //public string Remark { get; set; }
        //public decimal IncomeTax { get; set; }
        //public string AccountingCategoryName { get; internal set; }
        //public string AccountingCategoryCode { get; internal set; }
        //public string AccountingUnitCode { get; internal set; }
        //public int AccountingLayoutIndex { get; set; }
        //public string IncomeTaxBy { get; set; }
    }
}