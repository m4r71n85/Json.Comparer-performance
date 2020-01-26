using System;

namespace JsonComparer.Models
{
    public class ValueDto : IEquatable<ValueDto>
    {
        public string TotalDebitAmount { get; set; }
        public string TotalExportGrossAmount { get; set; }
        public string VoidedDocIds { get; set; }
        public string Erstzeile { get; set; }
        public string TravellerFeeVATRate { get; set; }
        public string FeeNetAmount { get; set; }
        public string PassportNumber { get; set; }
        public string Abschlussnr { get; set; }
        public string TotalDebitFee { get; set; }
        public string TotalNonConsumableNetAmount { get; set; }
        public string OriginalServiceID { get; set; }
        public string IssuingDate { get; set; }
        public string MNAID { get; set; }
        public string VoidReason { get; set; }
        public string IsIdentityChecked { get; set; }
        public string PoxDateUTC { get; set; }
        public string Version { get; set; }
        public string Formhaendler { get; set; }
        public string TotalGrossAmount { get; set; }
        public string PurchaseDate { get; set; }
        public string Refund_ag { get; set; }
        public string E2E_ShopCountryCode { get; set; }
        public string FeeGrossAmount { get; set; }
        public string PayoutAction { get; set; }
        public string TouristMembershipIsElectronicTFS { get; set; }
        public string PassportIssuedByCountry { get; set; }
        public string RefundRule { get; set; }
        public string RefundNCID { get; set; }
        public string RefundMutable { get; set; }
        public string Provision_ok { get; set; }
        public string TouristCountryNumIsoCode { get; set; }
        public string Kaufbetrag { get; set; }
        public string Faktversion { get; set; }
        public string Active { get; set; }
        public string E2E_IssuingDate { get; set; }
        public string Istshop { get; set; }
        public string Faktlfdnr { get; set; }
        public string RefundDateUTC { get; set; }
        public string Agbelastung { get; set; }
        public string TFSRefundTransactionID { get; set; }
        public string Ustbetrag_form { get; set; }
        public string InstanceID { get; set; }
        public string Zeile { get; set; }
        public string PoxDate { get; set; }
        public string FeeVatRate { get; set; }
        public string E2E_ShopCode { get; set; }
        public string StoreTransactionNumber { get; set; }
        public string Exitagent { get; set; }
        public string UpdateDate { get; set; }
        public string Haendler { get; set; }
        public string TouristID { get; set; }
        public string PCCcomm { get; set; }
        public string ShopInvoiceNumber { get; set; }
        public string DebitNCID { get; set; }
        public string RefundKeyID { get; set; }
        public string Stornofaktlfdnr { get; set; }
        public string DocIdentifierSerialNumber { get; set; }
        public string EntityAction { get; set; }
        public string ServiceID { get; set; }
        public string ApprovalSetID { get; set; }
        public string ShopCode { get; set; }
        public string PhoneNumber { get; set; }
        public string VATRefundOperatorID { get; set; }
        public string TFSTransactionID { get; set; }
        public string Faktbetrag { get; set; }
        public string DebitNCIDType { get; set; }
        public string ModificationDate { get; set; }
        public string DebitAmount { get; set; }
        public string TokenMasked { get; set; }
        public string Ustcodebits { get; set; }
        public string PaidAmount { get; set; }
        public string CreationDate { get; set; }
        public string IsForcedEndrefund { get; set; }
        public string Refund_calc { get; set; }
        public string CreatorTrait { get; set; }
        public string SRM { get; set; }
        public string RefundDate { get; set; }
        public string PurchaseDateUTC { get; set; }
        public string Formnr { get; set; }
        public string Scanpos { get; set; }
        public string ReplacedByTransactionID { get; set; }
        public string RefundNCIDType { get; set; }
        public string TotalRefundAmount { get; set; }
        public string TravellerSignedEligibilityDeclaration { get; set; }
        public string CustomsStatus { get; set; }
        public string Istcontext { get; set; }
        public string OperatorName { get; set; }
        public string Procfee { get; set; }
        public string Refund_ok { get; set; }
        public string DocId { get; set; }
        public string Bundnr { get; set; }
        public string Expirednr { get; set; }
        public string ShopOperatorID { get; set; }
        public string Land { get; set; }
        public string Scanstatus { get; set; }
        public string AutorefundReferenceID { get; set; }
        public string RefundCurrencyIsoCode { get; set; }
        public string TravellerFeeNetAmount { get; set; }
        public string TravellerFeeVATAmount { get; set; }
        public string ImageID { get; set; }
        public string TourGuideNumber { get; set; }
        public string Tourist { get; set; }
        public string Agent { get; set; }
        public string TFSTransactionHistoryID { get; set; }
        public string IsUnconfirmed { get; set; }
        public string IssuedStatus { get; set; }
        public string BrandID { get; set; }
        public string IsOfflineIssueTxn { get; set; }
        public string Ersttourist { get; set; }
        public string PaidCurrencyIsoCode { get; set; }
        public string DebitKeyID { get; set; }
        public string TotalConsumableNetAmount { get; set; }
        public string Email { get; set; }
        public string AutorefundStatus { get; set; }
        public string TokenDisplay { get; set; }
        public string Ustbetrag_ok { get; set; }
        public string Status { get; set; }
        public string Createdrangeid { get; set; }
        public string ISTReferenceID { get; set; }
        public string TravellerFeeGrossAmount { get; set; }
        public string DeskID { get; set; }
        public string FeeVatAmount { get; set; }
        public string DIC1 { get; set; }
        public string Refundrule { get; set; }
        public string RefundPointProcessingCountryNumIsoCode { get; set; }
        public string EarlyRefundType { get; set; }
        public string TFSTransactionType { get; set; }
        public string VATRoundingPerRow { get; set; }
        public string CustomsRegistrationStatus { get; set; }
        public string Refunddatum { get; set; }
        public string Exitdatum { get; set; }
        public string FirstName { get; set; }
        public string Fehlergrund { get; set; }
        public string CreateReason { get; set; }
        public string IsVoided { get; set; }
        public string DIC0 { get; set; }
        public string RefundAmount { get; set; }
        public string LastName { get; set; }
        public string ShopCountryNumIsoCode { get; set; }
        public string TotalNetAmount { get; set; }
        public string IssuingDateUTC { get; set; }
        public string PaymentMethod { get; set; }
        public string RefundPointCountryNumIsoCode { get; set; }
        public string Exitland { get; set; }
        public string AgentCode { get; set; }
        public string Backcomm { get; set; }
        public string PayoutFeedbackTimestamp { get; set; }
        public string PayoutExecutionTimestamp { get; set; }
        public string Erstbundnr { get; set; }
        public string Token { get; set; }
        public string Istref { get; set; }
        public string LoyaltyCardID { get; set; }
        public string TotalPayment { get; set; }
        public string TotalVatAmount { get; set; }
        public string DIC2 { get; set; }
        public string WhoDebitsTravellerFeeVATAmount { get; set; }
        public string RefundPointNumber { get; set; }
        public string TravellerSignature { get; set; }
        public string DIClen { get; set; }
        public string DocIdentifierNumericCode { get; set; }
        public string SaleAssistantCode { get; set; }
        public string VatOffDiscount { get; set; }
        public string TouristMembershipID { get; set; }
        public string Earlyrefund { get; set; }
        public string PaymentStatus { get; set; }
        public string ShopID { get; set; }
        public string IsAutorefundable { get; set; }
        public string Pairnr { get; set; }
        public string IssuingCurrencyAlpISoCode { get; set; }
        public string Ausgabedatum { get; set; }
        public string Country { get; set; }
        public string Bund { get; set; }
        public string Values { get; set; }
        public string RefundID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerVers { get; set; }
        public string PaymentID { get; set; }
        public string TransactionID { get; set; }
        public string Attempt { get; set; }
        public string TransactionHistoryID { get; set; }

        //If values are same returns null, if are different take other value
        public ValueDto Merge(ValueDto other)
        {
            var mVals = new ValueDto
            {
                TotalDebitAmount = (TotalDebitAmount != other.TotalDebitAmount && other.TotalConsumableNetAmount != null ? other.TotalDebitAmount : null),
                TotalExportGrossAmount = (TotalExportGrossAmount == other.TotalExportGrossAmount && other.TotalExportGrossAmount != null ? other.TotalExportGrossAmount : null),
                VoidedDocIds = (VoidedDocIds == other.VoidedDocIds && other.VoidedDocIds != null ? other.VoidedDocIds : null),
                Erstzeile = (Erstzeile == other.Erstzeile && other.Erstzeile != null ? other.Erstzeile : null),
                TravellerFeeVATRate = (TravellerFeeVATRate == other.TravellerFeeVATRate && other.TravellerFeeVATRate != null ? other.TravellerFeeVATRate : null),
                FeeNetAmount = (FeeNetAmount == other.FeeNetAmount && other.FeeNetAmount != null ? other.FeeNetAmount : null),
                PassportNumber = (PassportNumber == other.PassportNumber && other.PassportNumber != null ? other.PassportNumber : null),
                Abschlussnr = (Abschlussnr == other.Abschlussnr && other.Abschlussnr != null ? other.Abschlussnr : null),
                TotalDebitFee = (TotalDebitFee == other.TotalDebitFee && other.TotalDebitFee != null ? other.TotalDebitFee : null),
                TotalNonConsumableNetAmount = (TotalNonConsumableNetAmount == other.TotalNonConsumableNetAmount && other.TotalNonConsumableNetAmount != null ? other.TotalNonConsumableNetAmount : null),
                OriginalServiceID = (OriginalServiceID == other.OriginalServiceID && other.OriginalServiceID != null ? other.OriginalServiceID : null),
                IssuingDate = (IssuingDate == other.IssuingDate && other.IssuingDate != null ? other.IssuingDate : null),
                MNAID = (MNAID == other.MNAID && other.MNAID != null ? other.MNAID : null),
                VoidReason = (VoidReason == other.VoidReason && other.VoidReason != null ? other.VoidReason : null),
                IsIdentityChecked = (IsIdentityChecked == other.IsIdentityChecked && other.IsIdentityChecked != null ? other.IsIdentityChecked : null),
                PoxDateUTC = (PoxDateUTC == other.PoxDateUTC && other.PoxDateUTC != null ? other.PoxDateUTC : null),
                Version = (Version == other.Version && other.Version != null ? other.Version : null),
                Formhaendler = (Formhaendler == other.Formhaendler && other.Formhaendler != null ? other.Formhaendler : null),
                TotalGrossAmount = (TotalGrossAmount == other.TotalGrossAmount && other.TotalGrossAmount != null ? other.TotalGrossAmount : null),
                PurchaseDate = (PurchaseDate == other.PurchaseDate && other.PurchaseDate != null ? other.PurchaseDate : null),
                Refund_ag = (Refund_ag == other.Refund_ag && other.Refund_ag != null ? other.Refund_ag : null),
                E2E_ShopCountryCode = (E2E_ShopCountryCode == other.E2E_ShopCountryCode && other.E2E_ShopCountryCode != null ? other.E2E_ShopCountryCode : null),
                FeeGrossAmount = (FeeGrossAmount == other.FeeGrossAmount && other.FeeGrossAmount != null ? other.FeeGrossAmount : null),
                PayoutAction = (PayoutAction == other.PayoutAction && other.PayoutAction != null ? other.PayoutAction : null),
                TouristMembershipIsElectronicTFS = (TouristMembershipIsElectronicTFS == other.TouristMembershipIsElectronicTFS && other.TouristMembershipIsElectronicTFS != null ? other.TouristMembershipIsElectronicTFS : null),
                PassportIssuedByCountry = (PassportIssuedByCountry == other.PassportIssuedByCountry && other.PassportIssuedByCountry != null ? other.PassportIssuedByCountry : null),
                RefundRule = (RefundRule == other.RefundRule && other.RefundRule != null ? other.RefundRule : null),
                RefundNCID = (RefundNCID == other.RefundNCID && other.RefundNCID != null ? other.RefundNCID : null),
                RefundMutable = (RefundMutable == other.RefundMutable && other.RefundMutable != null ? other.RefundMutable : null),
                Provision_ok = (Provision_ok == other.Provision_ok && other.Provision_ok != null ? other.Provision_ok : null),
                TouristCountryNumIsoCode = (TouristCountryNumIsoCode == other.TouristCountryNumIsoCode && other.TouristCountryNumIsoCode != null ? other.TouristCountryNumIsoCode : null),
                Kaufbetrag = (Kaufbetrag == other.Kaufbetrag && other.Kaufbetrag != null ? other.Kaufbetrag : null),
                Faktversion = (Faktversion == other.Faktversion && other.Faktversion != null ? other.Faktversion : null),
                Active = (Active == other.Active && other.Active != null ? other.Active : null),
                E2E_IssuingDate = (E2E_IssuingDate == other.E2E_IssuingDate && other.E2E_IssuingDate != null ? other.E2E_IssuingDate : null),
                Istshop = (Istshop == other.Istshop && other.Istshop != null ? other.Istshop : null),
                Faktlfdnr = (Faktlfdnr == other.Faktlfdnr && other.Faktlfdnr != null ? other.Faktlfdnr : null),
                RefundDateUTC = (RefundDateUTC == other.RefundDateUTC && other.RefundDateUTC != null ? other.RefundDateUTC : null),
                Agbelastung = (Agbelastung == other.Agbelastung && other.Agbelastung != null ? other.Agbelastung : null),
                TFSRefundTransactionID = (TFSRefundTransactionID == other.TFSRefundTransactionID && other.TFSRefundTransactionID != null ? other.TFSRefundTransactionID : null),
                Ustbetrag_form = (Ustbetrag_form == other.Ustbetrag_form && other.Ustbetrag_form != null ? other.Ustbetrag_form : null),
                InstanceID = (InstanceID == other.InstanceID && other.InstanceID != null ? other.InstanceID : null),
                Zeile = (Zeile == other.Zeile && other.Zeile != null ? other.Zeile : null),
                PoxDate = (PoxDate == other.PoxDate && other.PoxDate != null ? other.PoxDate : null),
                FeeVatRate = (FeeVatRate == other.FeeVatRate && other.FeeVatRate != null ? other.FeeVatRate : null),
                E2E_ShopCode = (E2E_ShopCode == other.E2E_ShopCode && other.E2E_ShopCode != null ? other.E2E_ShopCode : null),
                StoreTransactionNumber = (StoreTransactionNumber == other.StoreTransactionNumber && other.StoreTransactionNumber != null ? other.StoreTransactionNumber : null),
                Exitagent = (Exitagent == other.Exitagent && other.Exitagent != null ? other.Exitagent : null),
                UpdateDate = (UpdateDate == other.UpdateDate && other.UpdateDate != null ? other.UpdateDate : null),
                Haendler = (Haendler == other.Haendler && other.Haendler != null ? other.Haendler : null),
                TouristID = (TouristID == other.TouristID && other.TouristID != null ? other.TouristID : null),
                PCCcomm = (PCCcomm == other.PCCcomm && other.PCCcomm != null ? other.PCCcomm : null),
                ShopInvoiceNumber = (ShopInvoiceNumber == other.ShopInvoiceNumber && other.ShopInvoiceNumber != null ? other.ShopInvoiceNumber : null),
                DebitNCID = (DebitNCID == other.DebitNCID && other.DebitNCID != null ? other.DebitNCID : null),
                RefundKeyID = (RefundKeyID == other.RefundKeyID && other.RefundKeyID != null ? other.RefundKeyID : null),
                Stornofaktlfdnr = (Stornofaktlfdnr == other.Stornofaktlfdnr && other.Stornofaktlfdnr != null ? other.Stornofaktlfdnr : null),
                DocIdentifierSerialNumber = (DocIdentifierSerialNumber == other.DocIdentifierSerialNumber && other.DocIdentifierSerialNumber != null ? other.DocIdentifierSerialNumber : null),
                EntityAction = (EntityAction == other.EntityAction && other.EntityAction != null ? other.EntityAction : null),
                ServiceID = (ServiceID == other.ServiceID && other.ServiceID != null ? other.ServiceID : null),
                ApprovalSetID = (ApprovalSetID == other.ApprovalSetID && other.ApprovalSetID != null ? other.ApprovalSetID : null),
                ShopCode = (ShopCode == other.ShopCode && other.ShopCode != null ? other.ShopCode : null),
                PhoneNumber = (PhoneNumber == other.PhoneNumber && other.PhoneNumber != null ? other.PhoneNumber : null),
                VATRefundOperatorID = (VATRefundOperatorID == other.VATRefundOperatorID && other.VATRefundOperatorID != null ? other.VATRefundOperatorID : null),
                TFSTransactionID = (TFSTransactionID == other.TFSTransactionID && other.TFSTransactionID != null ? other.TFSTransactionID : null),
                Faktbetrag = (Faktbetrag == other.Faktbetrag && other.Faktbetrag != null ? other.Faktbetrag : null),
                DebitNCIDType = (DebitNCIDType == other.DebitNCIDType && other.DebitNCIDType != null ? other.DebitNCIDType : null),
                ModificationDate = (ModificationDate == other.ModificationDate && other.ModificationDate != null ? other.ModificationDate : null),
                DebitAmount = (DebitAmount == other.DebitAmount && other.DebitAmount != null ? other.DebitAmount : null),
                TokenMasked = (TokenMasked == other.TokenMasked && other.TokenMasked != null ? other.TokenMasked : null),
                Ustcodebits = (Ustcodebits == other.Ustcodebits && other.Ustcodebits != null ? other.Ustcodebits : null),
                PaidAmount = (PaidAmount == other.PaidAmount && other.PaidAmount != null ? other.PaidAmount : null),
                CreationDate = (CreationDate == other.CreationDate && other.CreationDate != null ? other.CreationDate : null),
                IsForcedEndrefund = (IsForcedEndrefund == other.IsForcedEndrefund && other.IsForcedEndrefund != null ? other.IsForcedEndrefund : null),
                Refund_calc = (Refund_calc == other.Refund_calc && other.Refund_calc != null ? other.Refund_calc : null),
                CreatorTrait = (CreatorTrait == other.CreatorTrait && other.CreatorTrait != null ? other.CreatorTrait : null),
                SRM = (SRM == other.SRM && other.SRM != null ? other.SRM : null),
                RefundDate = (RefundDate == other.RefundDate && other.RefundDate != null ? other.RefundDate : null),
                PurchaseDateUTC = (PurchaseDateUTC == other.PurchaseDateUTC && other.PurchaseDateUTC != null ? other.PurchaseDateUTC : null),
                Formnr = (Formnr == other.Formnr && other.Formnr != null ? other.Formnr : null),
                Scanpos = (Scanpos == other.Scanpos && other.Scanpos != null ? other.Scanpos : null),
                ReplacedByTransactionID = (ReplacedByTransactionID == other.ReplacedByTransactionID && other.ReplacedByTransactionID != null ? other.ReplacedByTransactionID : null),
                RefundNCIDType = (RefundNCIDType == other.RefundNCIDType && other.RefundNCIDType != null ? other.RefundNCIDType : null),
                TotalRefundAmount = (TotalRefundAmount == other.TotalRefundAmount && other.TotalRefundAmount != null ? other.TotalRefundAmount : null),
                TravellerSignedEligibilityDeclaration = (TravellerSignedEligibilityDeclaration == other.TravellerSignedEligibilityDeclaration && other.TravellerSignedEligibilityDeclaration != null ? other.TravellerSignedEligibilityDeclaration : null),
                CustomsStatus = (CustomsStatus == other.CustomsStatus && other.CustomsStatus != null ? other.CustomsStatus : null),
                Istcontext = (Istcontext == other.Istcontext && other.Istcontext != null ? other.Istcontext : null),
                OperatorName = (OperatorName == other.OperatorName && other.OperatorName != null ? other.OperatorName : null),
                Procfee = (Procfee == other.Procfee && other.Procfee != null ? other.Procfee : null),
                Refund_ok = (Refund_ok == other.Refund_ok && other.Refund_ok != null ? other.Refund_ok : null),
                DocId = (DocId == other.DocId && other.DocId != null ? other.DocId : null),
                Bundnr = (Bundnr == other.Bundnr && other.Bundnr != null ? other.Bundnr : null),
                Expirednr = (Expirednr == other.Expirednr && other.Expirednr != null ? other.Expirednr : null),
                ShopOperatorID = (ShopOperatorID == other.ShopOperatorID && other.ShopOperatorID != null ? other.ShopOperatorID : null),
                Land = (Land == other.Land && other.Land != null ? other.Land : null),
                Scanstatus = (Scanstatus == other.Scanstatus && other.Scanstatus != null ? other.Scanstatus : null),
                AutorefundReferenceID = (AutorefundReferenceID == other.AutorefundReferenceID && other.AutorefundReferenceID != null ? other.AutorefundReferenceID : null),
                RefundCurrencyIsoCode = (RefundCurrencyIsoCode == other.RefundCurrencyIsoCode && other.RefundCurrencyIsoCode != null ? other.RefundCurrencyIsoCode : null),
                TravellerFeeNetAmount = (TravellerFeeNetAmount == other.TravellerFeeNetAmount && other.TravellerFeeNetAmount != null ? other.TravellerFeeNetAmount : null),
                TravellerFeeVATAmount = (TravellerFeeVATAmount == other.TravellerFeeVATAmount && other.TravellerFeeVATAmount != null ? other.TravellerFeeVATAmount : null),
                ImageID = (ImageID == other.ImageID && other.ImageID != null ? other.ImageID : null),
                TourGuideNumber = (TourGuideNumber == other.TourGuideNumber && other.TourGuideNumber != null ? other.TourGuideNumber : null),
                Tourist = (Tourist == other.Tourist && other.Tourist != null ? other.Tourist : null),
                Agent = (Agent == other.Agent && other.Agent != null ? other.Agent : null),
                TFSTransactionHistoryID = (TFSTransactionHistoryID == other.TFSTransactionHistoryID && other.TFSTransactionHistoryID != null ? other.TFSTransactionHistoryID : null),
                IsUnconfirmed = (IsUnconfirmed == other.IsUnconfirmed && other.IsUnconfirmed != null ? other.IsUnconfirmed : null),
                IssuedStatus = (IssuedStatus == other.IssuedStatus && other.IssuedStatus != null ? other.IssuedStatus : null),
                BrandID = (BrandID == other.BrandID && other.BrandID != null ? other.BrandID : null),
                IsOfflineIssueTxn = (IsOfflineIssueTxn == other.IsOfflineIssueTxn && other.IsOfflineIssueTxn != null ? other.IsOfflineIssueTxn : null),
                Ersttourist = (Ersttourist == other.Ersttourist && other.Ersttourist != null ? other.Ersttourist : null),
                PaidCurrencyIsoCode = (PaidCurrencyIsoCode == other.PaidCurrencyIsoCode && other.PaidCurrencyIsoCode != null ? other.PaidCurrencyIsoCode : null),
                DebitKeyID = (DebitKeyID == other.DebitKeyID && other.DebitKeyID != null ? other.DebitKeyID : null),
                TotalConsumableNetAmount = (TotalConsumableNetAmount == other.TotalConsumableNetAmount && other.TotalConsumableNetAmount != null ? other.TotalConsumableNetAmount : null),
                Email = (Email == other.Email && other.Email != null ? other.Email : null),
                AutorefundStatus = (AutorefundStatus == other.AutorefundStatus && other.AutorefundStatus != null ? other.AutorefundStatus : null),
                TokenDisplay = (TokenDisplay == other.TokenDisplay && other.TokenDisplay != null ? other.TokenDisplay : null),
                Ustbetrag_ok = (Ustbetrag_ok == other.Ustbetrag_ok && other.Ustbetrag_ok != null ? other.Ustbetrag_ok : null),
                Status = (Status == other.Status && other.Status != null ? other.Status : null),
                Createdrangeid = (Createdrangeid == other.Createdrangeid && other.Createdrangeid != null ? other.Createdrangeid : null),
                ISTReferenceID = (ISTReferenceID == other.ISTReferenceID && other.ISTReferenceID != null ? other.ISTReferenceID : null),
                TravellerFeeGrossAmount = (TravellerFeeGrossAmount == other.TravellerFeeGrossAmount && other.TravellerFeeGrossAmount != null ? other.TravellerFeeGrossAmount : null),
                DeskID = (DeskID == other.DeskID && other.DeskID != null ? other.DeskID : null),
                FeeVatAmount = (FeeVatAmount == other.FeeVatAmount && other.FeeVatAmount != null ? other.FeeVatAmount : null),
                DIC1 = (DIC1 == other.DIC1 && other.DIC1 != null ? other.DIC1 : null),
                Refundrule = (Refundrule == other.Refundrule && other.Refundrule != null ? other.Refundrule : null),
                RefundPointProcessingCountryNumIsoCode = (RefundPointProcessingCountryNumIsoCode == other.RefundPointProcessingCountryNumIsoCode && other.RefundPointProcessingCountryNumIsoCode != null ? other.RefundPointProcessingCountryNumIsoCode : null),
                EarlyRefundType = (EarlyRefundType == other.EarlyRefundType && other.EarlyRefundType != null ? other.EarlyRefundType : null),
                TFSTransactionType = (TFSTransactionType == other.TFSTransactionType && other.TFSTransactionType != null ? other.TFSTransactionType : null),
                VATRoundingPerRow = (VATRoundingPerRow == other.VATRoundingPerRow && other.VATRoundingPerRow != null ? other.VATRoundingPerRow : null),
                CustomsRegistrationStatus = (CustomsRegistrationStatus == other.CustomsRegistrationStatus && other.CustomsRegistrationStatus != null ? other.CustomsRegistrationStatus : null),
                Refunddatum = (Refunddatum == other.Refunddatum && other.Refunddatum != null ? other.Refunddatum : null),
                Exitdatum = (Exitdatum == other.Exitdatum && other.Exitdatum != null ? other.Exitdatum : null),
                FirstName = (FirstName == other.FirstName && other.FirstName != null ? other.FirstName : null),
                Fehlergrund = (Fehlergrund == other.Fehlergrund && other.Fehlergrund != null ? other.Fehlergrund : null),
                CreateReason = (CreateReason == other.CreateReason && other.CreateReason != null ? other.CreateReason : null),
                IsVoided = (IsVoided == other.IsVoided && other.IsVoided != null ? other.IsVoided : null),
                DIC0 = (DIC0 == other.DIC0 && other.DIC0 != null ? other.DIC0 : null),
                RefundAmount = (RefundAmount == other.RefundAmount && other.RefundAmount != null ? other.RefundAmount : null),
                LastName = (LastName == other.LastName && other.LastName != null ? other.LastName : null),
                ShopCountryNumIsoCode = (ShopCountryNumIsoCode == other.ShopCountryNumIsoCode && other.ShopCountryNumIsoCode != null ? other.ShopCountryNumIsoCode : null),
                TotalNetAmount = (TotalNetAmount == other.TotalNetAmount && other.TotalNetAmount != null ? other.TotalNetAmount : null),
                IssuingDateUTC = (IssuingDateUTC == other.IssuingDateUTC && other.IssuingDateUTC != null ? other.IssuingDateUTC : null),
                PaymentMethod = (PaymentMethod == other.PaymentMethod && other.PaymentMethod != null ? other.PaymentMethod : null),
                RefundPointCountryNumIsoCode = (RefundPointCountryNumIsoCode == other.RefundPointCountryNumIsoCode && other.RefundPointCountryNumIsoCode != null ? other.RefundPointCountryNumIsoCode : null),
                Exitland = (Exitland == other.Exitland && other.Exitland != null ? other.Exitland : null),
                AgentCode = (AgentCode == other.AgentCode && other.AgentCode != null ? other.AgentCode : null),
                Backcomm = (Backcomm == other.Backcomm && other.Backcomm != null ? other.Backcomm : null),
                PayoutFeedbackTimestamp = (PayoutFeedbackTimestamp == other.PayoutFeedbackTimestamp && other.PayoutFeedbackTimestamp != null ? other.PayoutFeedbackTimestamp : null),
                PayoutExecutionTimestamp = (PayoutExecutionTimestamp == other.PayoutExecutionTimestamp && other.PayoutExecutionTimestamp != null ? other.PayoutExecutionTimestamp : null),
                Erstbundnr = (Erstbundnr == other.Erstbundnr && other.Erstbundnr != null ? other.Erstbundnr : null),
                Token = (Token == other.Token && other.Token != null ? other.Token : null),
                Istref = (Istref == other.Istref && other.Istref != null ? other.Istref : null),
                LoyaltyCardID = (LoyaltyCardID == other.LoyaltyCardID && other.LoyaltyCardID != null ? other.LoyaltyCardID : null),
                TotalPayment = (TotalPayment == other.TotalPayment && other.TotalPayment != null ? other.TotalPayment : null),
                TotalVatAmount = (TotalVatAmount == other.TotalVatAmount && other.TotalVatAmount != null ? other.TotalVatAmount : null),
                DIC2 = (DIC2 == other.DIC2 && other.DIC2 != null ? other.DIC2 : null),
                WhoDebitsTravellerFeeVATAmount = (WhoDebitsTravellerFeeVATAmount == other.WhoDebitsTravellerFeeVATAmount && other.WhoDebitsTravellerFeeVATAmount != null ? other.WhoDebitsTravellerFeeVATAmount : null),
                RefundPointNumber = (RefundPointNumber == other.RefundPointNumber && other.RefundPointNumber != null ? other.RefundPointNumber : null),
                TravellerSignature = (TravellerSignature == other.TravellerSignature && other.TravellerSignature != null ? other.TravellerSignature : null),
                DIClen = (DIClen == other.DIClen && other.DIClen != null ? other.DIClen : null),
                DocIdentifierNumericCode = (DocIdentifierNumericCode == other.DocIdentifierNumericCode && other.DocIdentifierNumericCode != null ? other.DocIdentifierNumericCode : null),
                SaleAssistantCode = (SaleAssistantCode == other.SaleAssistantCode && other.SaleAssistantCode != null ? other.SaleAssistantCode : null),
                VatOffDiscount = (VatOffDiscount == other.VatOffDiscount && other.VatOffDiscount != null ? other.VatOffDiscount : null),
                TouristMembershipID = (TouristMembershipID == other.TouristMembershipID && other.TouristMembershipID != null ? other.TouristMembershipID : null),
                Earlyrefund = (Earlyrefund == other.Earlyrefund && other.Earlyrefund != null ? other.Earlyrefund : null),
                PaymentStatus = (PaymentStatus == other.PaymentStatus && other.PaymentStatus != null ? other.PaymentStatus : null),
                ShopID = (ShopID == other.ShopID && other.ShopID != null ? other.ShopID : null),
                IsAutorefundable = (IsAutorefundable == other.IsAutorefundable && other.IsAutorefundable != null ? other.IsAutorefundable : null),
                Pairnr = (Pairnr == other.Pairnr && other.Pairnr != null ? other.Pairnr : null),
                IssuingCurrencyAlpISoCode = (IssuingCurrencyAlpISoCode == other.IssuingCurrencyAlpISoCode && other.IssuingCurrencyAlpISoCode != null ? other.IssuingCurrencyAlpISoCode : null),
                Ausgabedatum = (Ausgabedatum == other.Ausgabedatum && other.Ausgabedatum != null ? other.Ausgabedatum : null),
                Country = (Country == other.Country && other.Country != null ? other.Country : null),
                Bund = (Bund == other.Bund && other.Bund != null ? other.Bund : null),
                Values = (Values == other.Values && other.Values != null ? other.Values : null),
                RefundID = (RefundID == other.RefundID && other.RefundID != null ? other.RefundID : null),
                CustomerID = (CustomerID == other.CustomerID && other.CustomerID != null ? other.CustomerID : null),
                CustomerVers = (CustomerVers == other.CustomerVers && other.CustomerVers != null ? other.CustomerVers : null),
                PaymentID = (PaymentID == other.PaymentID && other.PaymentID != null ? other.PaymentID : null),
                TransactionID = (TransactionID == other.TransactionID && other.TransactionID != null ? other.TransactionID : null),
                Attempt = (Attempt == other.Attempt && other.Attempt != null ? other.Attempt : null),
                TransactionHistoryID = (TransactionHistoryID == other.TransactionHistoryID && other.TransactionHistoryID != null ? other.TransactionHistoryID : null)
            };

            return mVals;
        }


        public bool HasValue()
        {
            return !(string.IsNullOrWhiteSpace(TotalDebitAmount)
                    && string.IsNullOrWhiteSpace(TotalExportGrossAmount)
                    && string.IsNullOrWhiteSpace(VoidedDocIds)
                    && string.IsNullOrWhiteSpace(Erstzeile)
                    && string.IsNullOrWhiteSpace(TravellerFeeVATRate)
                    && string.IsNullOrWhiteSpace(FeeNetAmount)
                    && string.IsNullOrWhiteSpace(PassportNumber)
                    && string.IsNullOrWhiteSpace(Abschlussnr)
                    && string.IsNullOrWhiteSpace(TotalDebitFee)
                    && string.IsNullOrWhiteSpace(TotalNonConsumableNetAmount)
                    && string.IsNullOrWhiteSpace(OriginalServiceID)
                    && string.IsNullOrWhiteSpace(IssuingDate)
                    && string.IsNullOrWhiteSpace(MNAID)
                    && string.IsNullOrWhiteSpace(VoidReason)
                    && string.IsNullOrWhiteSpace(IsIdentityChecked)
                    && string.IsNullOrWhiteSpace(PoxDateUTC)
                    && string.IsNullOrWhiteSpace(Version)
                    && string.IsNullOrWhiteSpace(Formhaendler)
                    && string.IsNullOrWhiteSpace(TotalGrossAmount)
                    && string.IsNullOrWhiteSpace(PurchaseDate)
                    && string.IsNullOrWhiteSpace(Refund_ag)
                    && string.IsNullOrWhiteSpace(E2E_ShopCountryCode)
                    && string.IsNullOrWhiteSpace(FeeGrossAmount)
                    && string.IsNullOrWhiteSpace(PayoutAction)
                    && string.IsNullOrWhiteSpace(TouristMembershipIsElectronicTFS)
                    && string.IsNullOrWhiteSpace(PassportIssuedByCountry)
                    && string.IsNullOrWhiteSpace(RefundRule)
                    && string.IsNullOrWhiteSpace(RefundNCID)
                    && string.IsNullOrWhiteSpace(RefundMutable)
                    && string.IsNullOrWhiteSpace(Provision_ok)
                    && string.IsNullOrWhiteSpace(TouristCountryNumIsoCode)
                    && string.IsNullOrWhiteSpace(Kaufbetrag)
                    && string.IsNullOrWhiteSpace(Faktversion)
                    && string.IsNullOrWhiteSpace(Active)
                    && string.IsNullOrWhiteSpace(E2E_IssuingDate)
                    && string.IsNullOrWhiteSpace(Istshop)
                    && string.IsNullOrWhiteSpace(Faktlfdnr)
                    && string.IsNullOrWhiteSpace(RefundDateUTC)
                    && string.IsNullOrWhiteSpace(Agbelastung)
                    && string.IsNullOrWhiteSpace(TFSRefundTransactionID)
                    && string.IsNullOrWhiteSpace(Ustbetrag_form)
                    && string.IsNullOrWhiteSpace(InstanceID)
                    && string.IsNullOrWhiteSpace(Zeile)
                    && string.IsNullOrWhiteSpace(PoxDate)
                    && string.IsNullOrWhiteSpace(FeeVatRate)
                    && string.IsNullOrWhiteSpace(E2E_ShopCode)
                    && string.IsNullOrWhiteSpace(StoreTransactionNumber)
                    && string.IsNullOrWhiteSpace(Exitagent)
                    && string.IsNullOrWhiteSpace(UpdateDate)
                    && string.IsNullOrWhiteSpace(Haendler)
                    && string.IsNullOrWhiteSpace(TouristID)
                    && string.IsNullOrWhiteSpace(PCCcomm)
                    && string.IsNullOrWhiteSpace(ShopInvoiceNumber)
                    && string.IsNullOrWhiteSpace(DebitNCID)
                    && string.IsNullOrWhiteSpace(RefundKeyID)
                    && string.IsNullOrWhiteSpace(Stornofaktlfdnr)
                    && string.IsNullOrWhiteSpace(DocIdentifierSerialNumber)
                    && string.IsNullOrWhiteSpace(EntityAction)
                    && string.IsNullOrWhiteSpace(ServiceID)
                    && string.IsNullOrWhiteSpace(ApprovalSetID)
                    && string.IsNullOrWhiteSpace(ShopCode)
                    && string.IsNullOrWhiteSpace(PhoneNumber)
                    && string.IsNullOrWhiteSpace(VATRefundOperatorID)
                    && string.IsNullOrWhiteSpace(TFSTransactionID)
                    && string.IsNullOrWhiteSpace(Faktbetrag)
                    && string.IsNullOrWhiteSpace(DebitNCIDType)
                    && string.IsNullOrWhiteSpace(ModificationDate)
                    && string.IsNullOrWhiteSpace(DebitAmount)
                    && string.IsNullOrWhiteSpace(TokenMasked)
                    && string.IsNullOrWhiteSpace(Ustcodebits)
                    && string.IsNullOrWhiteSpace(PaidAmount)
                    && string.IsNullOrWhiteSpace(CreationDate)
                    && string.IsNullOrWhiteSpace(IsForcedEndrefund)
                    && string.IsNullOrWhiteSpace(Refund_calc)
                    && string.IsNullOrWhiteSpace(CreatorTrait)
                    && string.IsNullOrWhiteSpace(SRM)
                    && string.IsNullOrWhiteSpace(RefundDate)
                    && string.IsNullOrWhiteSpace(PurchaseDateUTC)
                    && string.IsNullOrWhiteSpace(Formnr)
                    && string.IsNullOrWhiteSpace(Scanpos)
                    && string.IsNullOrWhiteSpace(ReplacedByTransactionID)
                    && string.IsNullOrWhiteSpace(RefundNCIDType)
                    && string.IsNullOrWhiteSpace(TotalRefundAmount)
                    && string.IsNullOrWhiteSpace(TravellerSignedEligibilityDeclaration)
                    && string.IsNullOrWhiteSpace(CustomsStatus)
                    && string.IsNullOrWhiteSpace(Istcontext)
                    && string.IsNullOrWhiteSpace(OperatorName)
                    && string.IsNullOrWhiteSpace(Procfee)
                    && string.IsNullOrWhiteSpace(Refund_ok)
                    && string.IsNullOrWhiteSpace(DocId)
                    && string.IsNullOrWhiteSpace(Bundnr)
                    && string.IsNullOrWhiteSpace(Expirednr)
                    && string.IsNullOrWhiteSpace(ShopOperatorID)
                    && string.IsNullOrWhiteSpace(Land)
                    && string.IsNullOrWhiteSpace(Scanstatus)
                    && string.IsNullOrWhiteSpace(AutorefundReferenceID)
                    && string.IsNullOrWhiteSpace(RefundCurrencyIsoCode)
                    && string.IsNullOrWhiteSpace(TravellerFeeNetAmount)
                    && string.IsNullOrWhiteSpace(TravellerFeeVATAmount)
                    && string.IsNullOrWhiteSpace(ImageID)
                    && string.IsNullOrWhiteSpace(TourGuideNumber)
                    && string.IsNullOrWhiteSpace(Tourist)
                    && string.IsNullOrWhiteSpace(Agent)
                    && string.IsNullOrWhiteSpace(TFSTransactionHistoryID)
                    && string.IsNullOrWhiteSpace(IsUnconfirmed)
                    && string.IsNullOrWhiteSpace(IssuedStatus)
                    && string.IsNullOrWhiteSpace(BrandID)
                    && string.IsNullOrWhiteSpace(IsOfflineIssueTxn)
                    && string.IsNullOrWhiteSpace(Ersttourist)
                    && string.IsNullOrWhiteSpace(PaidCurrencyIsoCode)
                    && string.IsNullOrWhiteSpace(DebitKeyID)
                    && string.IsNullOrWhiteSpace(TotalConsumableNetAmount)
                    && string.IsNullOrWhiteSpace(Email)
                    && string.IsNullOrWhiteSpace(AutorefundStatus)
                    && string.IsNullOrWhiteSpace(TokenDisplay)
                    && string.IsNullOrWhiteSpace(Ustbetrag_ok)
                    && string.IsNullOrWhiteSpace(Status)
                    && string.IsNullOrWhiteSpace(Createdrangeid)
                    && string.IsNullOrWhiteSpace(ISTReferenceID)
                    && string.IsNullOrWhiteSpace(TravellerFeeGrossAmount)
                    && string.IsNullOrWhiteSpace(DeskID)
                    && string.IsNullOrWhiteSpace(FeeVatAmount)
                    && string.IsNullOrWhiteSpace(DIC1)
                    && string.IsNullOrWhiteSpace(Refundrule)
                    && string.IsNullOrWhiteSpace(RefundPointProcessingCountryNumIsoCode)
                    && string.IsNullOrWhiteSpace(EarlyRefundType)
                    && string.IsNullOrWhiteSpace(TFSTransactionType)
                    && string.IsNullOrWhiteSpace(VATRoundingPerRow)
                    && string.IsNullOrWhiteSpace(CustomsRegistrationStatus)
                    && string.IsNullOrWhiteSpace(Refunddatum)
                    && string.IsNullOrWhiteSpace(Exitdatum)
                    && string.IsNullOrWhiteSpace(FirstName)
                    && string.IsNullOrWhiteSpace(Fehlergrund)
                    && string.IsNullOrWhiteSpace(CreateReason)
                    && string.IsNullOrWhiteSpace(IsVoided)
                    && string.IsNullOrWhiteSpace(DIC0)
                    && string.IsNullOrWhiteSpace(RefundAmount)
                    && string.IsNullOrWhiteSpace(LastName)
                    && string.IsNullOrWhiteSpace(ShopCountryNumIsoCode)
                    && string.IsNullOrWhiteSpace(TotalNetAmount)
                    && string.IsNullOrWhiteSpace(IssuingDateUTC)
                    && string.IsNullOrWhiteSpace(PaymentMethod)
                    && string.IsNullOrWhiteSpace(RefundPointCountryNumIsoCode)
                    && string.IsNullOrWhiteSpace(Exitland)
                    && string.IsNullOrWhiteSpace(AgentCode)
                    && string.IsNullOrWhiteSpace(Backcomm)
                    && string.IsNullOrWhiteSpace(PayoutFeedbackTimestamp)
                    && string.IsNullOrWhiteSpace(PayoutExecutionTimestamp)
                    && string.IsNullOrWhiteSpace(Erstbundnr)
                    && string.IsNullOrWhiteSpace(Token)
                    && string.IsNullOrWhiteSpace(Istref)
                    && string.IsNullOrWhiteSpace(LoyaltyCardID)
                    && string.IsNullOrWhiteSpace(TotalPayment)
                    && string.IsNullOrWhiteSpace(TotalVatAmount)
                    && string.IsNullOrWhiteSpace(DIC2)
                    && string.IsNullOrWhiteSpace(WhoDebitsTravellerFeeVATAmount)
                    && string.IsNullOrWhiteSpace(RefundPointNumber)
                    && string.IsNullOrWhiteSpace(TravellerSignature)
                    && string.IsNullOrWhiteSpace(DIClen)
                    && string.IsNullOrWhiteSpace(DocIdentifierNumericCode)
                    && string.IsNullOrWhiteSpace(SaleAssistantCode)
                    && string.IsNullOrWhiteSpace(VatOffDiscount)
                    && string.IsNullOrWhiteSpace(TouristMembershipID)
                    && string.IsNullOrWhiteSpace(Earlyrefund)
                    && string.IsNullOrWhiteSpace(PaymentStatus)
                    && string.IsNullOrWhiteSpace(ShopID)
                    && string.IsNullOrWhiteSpace(IsAutorefundable)
                    && string.IsNullOrWhiteSpace(Pairnr)
                    && string.IsNullOrWhiteSpace(IssuingCurrencyAlpISoCode)
                    && string.IsNullOrWhiteSpace(Ausgabedatum)
                    && string.IsNullOrWhiteSpace(Country)
                    && string.IsNullOrWhiteSpace(Bund)
                    && string.IsNullOrWhiteSpace(Values)
                    && string.IsNullOrWhiteSpace(RefundID)
                    && string.IsNullOrWhiteSpace(CustomerID)
                    && string.IsNullOrWhiteSpace(CustomerVers)
                    && string.IsNullOrWhiteSpace(PaymentID)
                    && string.IsNullOrWhiteSpace(TransactionID)
                    && string.IsNullOrWhiteSpace(Attempt)
                    && string.IsNullOrWhiteSpace(TransactionHistoryID));
        }


        public bool Equals(ValueDto other)
        {
            return (TotalDebitAmount == other.TotalDebitAmount
                && TotalExportGrossAmount == other.TotalExportGrossAmount
                && VoidedDocIds == other.VoidedDocIds
                && Erstzeile == other.Erstzeile
                && TravellerFeeVATRate == other.TravellerFeeVATRate
                && FeeNetAmount == other.FeeNetAmount
                && PassportNumber == other.PassportNumber
                && Abschlussnr == other.Abschlussnr
                && TotalDebitFee == other.TotalDebitFee
                && TotalNonConsumableNetAmount == other.TotalNonConsumableNetAmount
                && OriginalServiceID == other.OriginalServiceID
                && IssuingDate == other.IssuingDate
                && MNAID == other.MNAID
                && VoidReason == other.VoidReason
                && IsIdentityChecked == other.IsIdentityChecked
                && PoxDateUTC == other.PoxDateUTC
                && Version == other.Version
                && Formhaendler == other.Formhaendler
                && TotalGrossAmount == other.TotalGrossAmount
                && PurchaseDate == other.PurchaseDate
                && Refund_ag == other.Refund_ag
                && E2E_ShopCountryCode == other.E2E_ShopCountryCode
                && FeeGrossAmount == other.FeeGrossAmount
                && PayoutAction == other.PayoutAction
                && TouristMembershipIsElectronicTFS == other.TouristMembershipIsElectronicTFS
                && PassportIssuedByCountry == other.PassportIssuedByCountry
                && RefundRule == other.RefundRule
                && RefundNCID == other.RefundNCID
                && RefundMutable == other.RefundMutable
                && Provision_ok == other.Provision_ok
                && TouristCountryNumIsoCode == other.TouristCountryNumIsoCode
                && Kaufbetrag == other.Kaufbetrag
                && Faktversion == other.Faktversion
                && Active == other.Active
                && E2E_IssuingDate == other.E2E_IssuingDate
                && Istshop == other.Istshop
                && Faktlfdnr == other.Faktlfdnr
                && RefundDateUTC == other.RefundDateUTC
                && Agbelastung == other.Agbelastung
                && TFSRefundTransactionID == other.TFSRefundTransactionID
                && Ustbetrag_form == other.Ustbetrag_form
                && InstanceID == other.InstanceID
                && Zeile == other.Zeile
                && PoxDate == other.PoxDate
                && FeeVatRate == other.FeeVatRate
                && E2E_ShopCode == other.E2E_ShopCode
                && StoreTransactionNumber == other.StoreTransactionNumber
                && Exitagent == other.Exitagent
                && UpdateDate == other.UpdateDate
                && Haendler == other.Haendler
                && TouristID == other.TouristID
                && PCCcomm == other.PCCcomm
                && ShopInvoiceNumber == other.ShopInvoiceNumber
                && DebitNCID == other.DebitNCID
                && RefundKeyID == other.RefundKeyID
                && Stornofaktlfdnr == other.Stornofaktlfdnr
                && DocIdentifierSerialNumber == other.DocIdentifierSerialNumber
                && EntityAction == other.EntityAction
                && ServiceID == other.ServiceID
                && ApprovalSetID == other.ApprovalSetID
                && ShopCode == other.ShopCode
                && PhoneNumber == other.PhoneNumber
                && VATRefundOperatorID == other.VATRefundOperatorID
                && TFSTransactionID == other.TFSTransactionID
                && Faktbetrag == other.Faktbetrag
                && DebitNCIDType == other.DebitNCIDType
                && ModificationDate == other.ModificationDate
                && DebitAmount == other.DebitAmount
                && TokenMasked == other.TokenMasked
                && Ustcodebits == other.Ustcodebits
                && PaidAmount == other.PaidAmount
                && CreationDate == other.CreationDate
                && IsForcedEndrefund == other.IsForcedEndrefund
                && Refund_calc == other.Refund_calc
                && CreatorTrait == other.CreatorTrait
                && SRM == other.SRM
                && RefundDate == other.RefundDate
                && PurchaseDateUTC == other.PurchaseDateUTC
                && Formnr == other.Formnr
                && Scanpos == other.Scanpos
                && ReplacedByTransactionID == other.ReplacedByTransactionID
                && RefundNCIDType == other.RefundNCIDType
                && TotalRefundAmount == other.TotalRefundAmount
                && TravellerSignedEligibilityDeclaration == other.TravellerSignedEligibilityDeclaration
                && CustomsStatus == other.CustomsStatus
                && Istcontext == other.Istcontext
                && OperatorName == other.OperatorName
                && Procfee == other.Procfee
                && Refund_ok == other.Refund_ok
                && DocId == other.DocId
                && Bundnr == other.Bundnr
                && Expirednr == other.Expirednr
                && ShopOperatorID == other.ShopOperatorID
                && Land == other.Land
                && Scanstatus == other.Scanstatus
                && AutorefundReferenceID == other.AutorefundReferenceID
                && RefundCurrencyIsoCode == other.RefundCurrencyIsoCode
                && TravellerFeeNetAmount == other.TravellerFeeNetAmount
                && TravellerFeeVATAmount == other.TravellerFeeVATAmount
                && ImageID == other.ImageID
                && TourGuideNumber == other.TourGuideNumber
                && Tourist == other.Tourist
                && Agent == other.Agent
                && TFSTransactionHistoryID == other.TFSTransactionHistoryID
                && IsUnconfirmed == other.IsUnconfirmed
                && IssuedStatus == other.IssuedStatus
                && BrandID == other.BrandID
                && IsOfflineIssueTxn == other.IsOfflineIssueTxn
                && Ersttourist == other.Ersttourist
                && PaidCurrencyIsoCode == other.PaidCurrencyIsoCode
                && DebitKeyID == other.DebitKeyID
                && TotalConsumableNetAmount == other.TotalConsumableNetAmount
                && Email == other.Email
                && AutorefundStatus == other.AutorefundStatus
                && TokenDisplay == other.TokenDisplay
                && Ustbetrag_ok == other.Ustbetrag_ok
                && Status == other.Status
                && Createdrangeid == other.Createdrangeid
                && ISTReferenceID == other.ISTReferenceID
                && TravellerFeeGrossAmount == other.TravellerFeeGrossAmount
                && DeskID == other.DeskID
                && FeeVatAmount == other.FeeVatAmount
                && DIC1 == other.DIC1
                && Refundrule == other.Refundrule
                && RefundPointProcessingCountryNumIsoCode == other.RefundPointProcessingCountryNumIsoCode
                && EarlyRefundType == other.EarlyRefundType
                && TFSTransactionType == other.TFSTransactionType
                && VATRoundingPerRow == other.VATRoundingPerRow
                && CustomsRegistrationStatus == other.CustomsRegistrationStatus
                && Refunddatum == other.Refunddatum
                && Exitdatum == other.Exitdatum
                && FirstName == other.FirstName
                && Fehlergrund == other.Fehlergrund
                && CreateReason == other.CreateReason
                && IsVoided == other.IsVoided
                && DIC0 == other.DIC0
                && RefundAmount == other.RefundAmount
                && LastName == other.LastName
                && ShopCountryNumIsoCode == other.ShopCountryNumIsoCode
                && TotalNetAmount == other.TotalNetAmount
                && IssuingDateUTC == other.IssuingDateUTC
                && PaymentMethod == other.PaymentMethod
                && RefundPointCountryNumIsoCode == other.RefundPointCountryNumIsoCode
                && Exitland == other.Exitland
                && AgentCode == other.AgentCode
                && Backcomm == other.Backcomm
                && PayoutFeedbackTimestamp == other.PayoutFeedbackTimestamp
                && PayoutExecutionTimestamp == other.PayoutExecutionTimestamp
                && Erstbundnr == other.Erstbundnr
                && Token == other.Token
                && Istref == other.Istref
                && LoyaltyCardID == other.LoyaltyCardID
                && TotalPayment == other.TotalPayment
                && TotalVatAmount == other.TotalVatAmount
                && DIC2 == other.DIC2
                && WhoDebitsTravellerFeeVATAmount == other.WhoDebitsTravellerFeeVATAmount
                && RefundPointNumber == other.RefundPointNumber
                && TravellerSignature == other.TravellerSignature
                && DIClen == other.DIClen
                && DocIdentifierNumericCode == other.DocIdentifierNumericCode
                && SaleAssistantCode == other.SaleAssistantCode
                && VatOffDiscount == other.VatOffDiscount
                && TouristMembershipID == other.TouristMembershipID
                && Earlyrefund == other.Earlyrefund
                && PaymentStatus == other.PaymentStatus
                && ShopID == other.ShopID
                && IsAutorefundable == other.IsAutorefundable
                && Pairnr == other.Pairnr
                && IssuingCurrencyAlpISoCode == other.IssuingCurrencyAlpISoCode
                && Ausgabedatum == other.Ausgabedatum
                && Country == other.Country
                && Bund == other.Bund
                && Values == other.Values
                && RefundID == other.RefundID
                && CustomerID == other.CustomerID
                && CustomerVers == other.CustomerVers
                && PaymentID == other.PaymentID
                && TransactionID == other.TransactionID
                && Attempt == other.Attempt
                && TransactionHistoryID == other.TransactionHistoryID);
        }

        public override int GetHashCode()
        {
            return (string.IsNullOrWhiteSpace(TotalDebitAmount) ? 0 : TotalDebitAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TotalExportGrossAmount) ? 0 : TotalExportGrossAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(VoidedDocIds) ? 0 : VoidedDocIds.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Erstzeile) ? 0 : Erstzeile.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TravellerFeeVATRate) ? 0 : TravellerFeeVATRate.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(FeeNetAmount) ? 0 : FeeNetAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PassportNumber) ? 0 : PassportNumber.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Abschlussnr) ? 0 : Abschlussnr.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TotalDebitFee) ? 0 : TotalDebitFee.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TotalNonConsumableNetAmount) ? 0 : TotalNonConsumableNetAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(OriginalServiceID) ? 0 : OriginalServiceID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(IssuingDate) ? 0 : IssuingDate.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(MNAID) ? 0 : MNAID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(VoidReason) ? 0 : VoidReason.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(IsIdentityChecked) ? 0 : IsIdentityChecked.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PoxDateUTC) ? 0 : PoxDateUTC.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Version) ? 0 : Version.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Formhaendler) ? 0 : Formhaendler.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TotalGrossAmount) ? 0 : TotalGrossAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PurchaseDate) ? 0 : PurchaseDate.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Refund_ag) ? 0 : Refund_ag.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(E2E_ShopCountryCode) ? 0 : E2E_ShopCountryCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(FeeGrossAmount) ? 0 : FeeGrossAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PayoutAction) ? 0 : PayoutAction.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TouristMembershipIsElectronicTFS) ? 0 : TouristMembershipIsElectronicTFS.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PassportIssuedByCountry) ? 0 : PassportIssuedByCountry.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundRule) ? 0 : RefundRule.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundNCID) ? 0 : RefundNCID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundMutable) ? 0 : RefundMutable.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Provision_ok) ? 0 : Provision_ok.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TouristCountryNumIsoCode) ? 0 : TouristCountryNumIsoCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Kaufbetrag) ? 0 : Kaufbetrag.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Faktversion) ? 0 : Faktversion.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Active) ? 0 : Active.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(E2E_IssuingDate) ? 0 : E2E_IssuingDate.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Istshop) ? 0 : Istshop.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Faktlfdnr) ? 0 : Faktlfdnr.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundDateUTC) ? 0 : RefundDateUTC.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Agbelastung) ? 0 : Agbelastung.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TFSRefundTransactionID) ? 0 : TFSRefundTransactionID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Ustbetrag_form) ? 0 : Ustbetrag_form.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(InstanceID) ? 0 : InstanceID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Zeile) ? 0 : Zeile.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PoxDate) ? 0 : PoxDate.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(FeeVatRate) ? 0 : FeeVatRate.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(E2E_ShopCode) ? 0 : E2E_ShopCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(StoreTransactionNumber) ? 0 : StoreTransactionNumber.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Exitagent) ? 0 : Exitagent.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(UpdateDate) ? 0 : UpdateDate.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Haendler) ? 0 : Haendler.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TouristID) ? 0 : TouristID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PCCcomm) ? 0 : PCCcomm.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ShopInvoiceNumber) ? 0 : ShopInvoiceNumber.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DebitNCID) ? 0 : DebitNCID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundKeyID) ? 0 : RefundKeyID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Stornofaktlfdnr) ? 0 : Stornofaktlfdnr.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DocIdentifierSerialNumber) ? 0 : DocIdentifierSerialNumber.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(EntityAction) ? 0 : EntityAction.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ServiceID) ? 0 : ServiceID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ApprovalSetID) ? 0 : ApprovalSetID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ShopCode) ? 0 : ShopCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PhoneNumber) ? 0 : PhoneNumber.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(VATRefundOperatorID) ? 0 : VATRefundOperatorID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TFSTransactionID) ? 0 : TFSTransactionID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Faktbetrag) ? 0 : Faktbetrag.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DebitNCIDType) ? 0 : DebitNCIDType.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ModificationDate) ? 0 : ModificationDate.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DebitAmount) ? 0 : DebitAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TokenMasked) ? 0 : TokenMasked.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Ustcodebits) ? 0 : Ustcodebits.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PaidAmount) ? 0 : PaidAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(CreationDate) ? 0 : CreationDate.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(IsForcedEndrefund) ? 0 : IsForcedEndrefund.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Refund_calc) ? 0 : Refund_calc.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(CreatorTrait) ? 0 : CreatorTrait.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(SRM) ? 0 : SRM.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundDate) ? 0 : RefundDate.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PurchaseDateUTC) ? 0 : PurchaseDateUTC.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Formnr) ? 0 : Formnr.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Scanpos) ? 0 : Scanpos.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ReplacedByTransactionID) ? 0 : ReplacedByTransactionID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundNCIDType) ? 0 : RefundNCIDType.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TotalRefundAmount) ? 0 : TotalRefundAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TravellerSignedEligibilityDeclaration) ? 0 : TravellerSignedEligibilityDeclaration.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(CustomsStatus) ? 0 : CustomsStatus.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Istcontext) ? 0 : Istcontext.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(OperatorName) ? 0 : OperatorName.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Procfee) ? 0 : Procfee.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Refund_ok) ? 0 : Refund_ok.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DocId) ? 0 : DocId.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Bundnr) ? 0 : Bundnr.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Expirednr) ? 0 : Expirednr.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ShopOperatorID) ? 0 : ShopOperatorID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Land) ? 0 : Land.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Scanstatus) ? 0 : Scanstatus.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(AutorefundReferenceID) ? 0 : AutorefundReferenceID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundCurrencyIsoCode) ? 0 : RefundCurrencyIsoCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TravellerFeeNetAmount) ? 0 : TravellerFeeNetAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TravellerFeeVATAmount) ? 0 : TravellerFeeVATAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ImageID) ? 0 : ImageID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TourGuideNumber) ? 0 : TourGuideNumber.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Tourist) ? 0 : Tourist.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Agent) ? 0 : Agent.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TFSTransactionHistoryID) ? 0 : TFSTransactionHistoryID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(IsUnconfirmed) ? 0 : IsUnconfirmed.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(IssuedStatus) ? 0 : IssuedStatus.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(BrandID) ? 0 : BrandID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(IsOfflineIssueTxn) ? 0 : IsOfflineIssueTxn.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Ersttourist) ? 0 : Ersttourist.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PaidCurrencyIsoCode) ? 0 : PaidCurrencyIsoCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DebitKeyID) ? 0 : DebitKeyID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TotalConsumableNetAmount) ? 0 : TotalConsumableNetAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Email) ? 0 : Email.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(AutorefundStatus) ? 0 : AutorefundStatus.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TokenDisplay) ? 0 : TokenDisplay.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Ustbetrag_ok) ? 0 : Ustbetrag_ok.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Status) ? 0 : Status.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Createdrangeid) ? 0 : Createdrangeid.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ISTReferenceID) ? 0 : ISTReferenceID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TravellerFeeGrossAmount) ? 0 : TravellerFeeGrossAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DeskID) ? 0 : DeskID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(FeeVatAmount) ? 0 : FeeVatAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DIC1) ? 0 : DIC1.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Refundrule) ? 0 : Refundrule.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundPointProcessingCountryNumIsoCode) ? 0 : RefundPointProcessingCountryNumIsoCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(EarlyRefundType) ? 0 : EarlyRefundType.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TFSTransactionType) ? 0 : TFSTransactionType.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(VATRoundingPerRow) ? 0 : VATRoundingPerRow.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(CustomsRegistrationStatus) ? 0 : CustomsRegistrationStatus.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Refunddatum) ? 0 : Refunddatum.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Exitdatum) ? 0 : Exitdatum.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(FirstName) ? 0 : FirstName.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Fehlergrund) ? 0 : Fehlergrund.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(CreateReason) ? 0 : CreateReason.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(IsVoided) ? 0 : IsVoided.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DIC0) ? 0 : DIC0.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundAmount) ? 0 : RefundAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(LastName) ? 0 : LastName.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ShopCountryNumIsoCode) ? 0 : ShopCountryNumIsoCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TotalNetAmount) ? 0 : TotalNetAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(IssuingDateUTC) ? 0 : IssuingDateUTC.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PaymentMethod) ? 0 : PaymentMethod.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundPointCountryNumIsoCode) ? 0 : RefundPointCountryNumIsoCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Exitland) ? 0 : Exitland.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(AgentCode) ? 0 : AgentCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Backcomm) ? 0 : Backcomm.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PayoutFeedbackTimestamp) ? 0 : PayoutFeedbackTimestamp.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PayoutExecutionTimestamp) ? 0 : PayoutExecutionTimestamp.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Erstbundnr) ? 0 : Erstbundnr.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Token) ? 0 : Token.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Istref) ? 0 : Istref.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(LoyaltyCardID) ? 0 : LoyaltyCardID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TotalPayment) ? 0 : TotalPayment.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TotalVatAmount) ? 0 : TotalVatAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DIC2) ? 0 : DIC2.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(WhoDebitsTravellerFeeVATAmount) ? 0 : WhoDebitsTravellerFeeVATAmount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundPointNumber) ? 0 : RefundPointNumber.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TravellerSignature) ? 0 : TravellerSignature.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DIClen) ? 0 : DIClen.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(DocIdentifierNumericCode) ? 0 : DocIdentifierNumericCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(SaleAssistantCode) ? 0 : SaleAssistantCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(VatOffDiscount) ? 0 : VatOffDiscount.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TouristMembershipID) ? 0 : TouristMembershipID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Earlyrefund) ? 0 : Earlyrefund.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PaymentStatus) ? 0 : PaymentStatus.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(ShopID) ? 0 : ShopID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(IsAutorefundable) ? 0 : IsAutorefundable.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Pairnr) ? 0 : Pairnr.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(IssuingCurrencyAlpISoCode) ? 0 : IssuingCurrencyAlpISoCode.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Ausgabedatum) ? 0 : Ausgabedatum.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Country) ? 0 : Country.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Bund) ? 0 : Bund.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Values) ? 0 : Values.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundID) ? 0 : RefundID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(CustomerID) ? 0 : CustomerID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(CustomerVers) ? 0 : CustomerVers.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PaymentID) ? 0 : PaymentID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TransactionID) ? 0 : TransactionID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Attempt) ? 0 : Attempt.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TransactionHistoryID) ? 0 : TransactionHistoryID.GetHashCode());
        }

    }
}
