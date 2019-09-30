using System;
using System.Collections.Generic;
using System.Linq;

namespace Midway.ObjectModel.Extensions
{
    public static class DocumentTypeExtensions
    {
        /// <summary>
        /// �������� �� ��� ��������� ���������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ���������.</returns>
        public static bool IsService(this DocumentType documentType)
            => !(documentType == DocumentType.Untyped
                || documentType == DocumentType.RevocationOffer
                || documentType.IsInvoice()
                || documentType.IsRootTitle()
                || documentType.IsEdiDocument());

        /// <summary>
        /// �������� �� ��� ��������� ��� ��� ���� ����� ��.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ����� ��.</returns>
        public static bool IsInvoice(this DocumentType documentType)
            => documentType == DocumentType.Invoice
                || documentType == DocumentType.InvoiceCorrection
                || documentType == DocumentType.InvoiceRevision
                || documentType == DocumentType.InvoiceCorrectionRevision;

        /// <summary>
        /// �������� �� ��� ��������� ��� ��� ���� ����� ����������������� ��.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ����� ����������������� ��.</returns>
        public static bool IsCorrectionInvoice(this DocumentType documentType)
            => documentType == DocumentType.InvoiceCorrection
                || documentType == DocumentType.InvoiceCorrectionRevision;

        /// <summary>
        /// �������� �� ��� ��������� ��� ��� ���� ����� ������������� ��.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ����� ������������� ��.</returns>
        public static bool IsRevisionInvoice(this DocumentType documentType)
            => documentType == DocumentType.InvoiceRevision
                || documentType == DocumentType.InvoiceCorrectionRevision;

        /// <summary>
        /// �������� �� ��� ��������� ��� ��� ���� ����� ����������������� ��� ������������� ��.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ����� ����������������� ��� ������������� ��.</returns>
        public static bool IsCorrectionOrRevision(this DocumentType documentType)
            => documentType == DocumentType.InvoiceCorrection
                || documentType == DocumentType.InvoiceRevision
                || documentType == DocumentType.InvoiceCorrectionRevision;

        /// <summary>
        /// �������� �� �������� ����������� � ������� ���������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <param name="untypedKind">��� ������������������ ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ������������ ������� ���������.</returns>
        public static bool IsChild(this DocumentType documentType, string untypedKind = null)
            => documentType.IsService()
                || documentType.IsCorrectionOrRevision()
                || (documentType == DocumentType.Untyped && untypedKind == UntypedKind.ActOfVariance)
                || (documentType == DocumentType.Untyped && untypedKind == UntypedKind.FormalizedData)
                || (documentType == DocumentType.RevocationOffer);

        /// <summary>
        /// �������� �� �������� �����������������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �����������������.</returns>
        public static bool IsUntyped(this DocumentType documentType)
            => documentType == DocumentType.Untyped
                || documentType == DocumentType.WaybillSeller
                || documentType == DocumentType.ActOfWorkSeller
                || documentType.IsWorksTransferSeller()
                || documentType.IsGoodsTransferSeller();

        /// <summary>
        /// �������� �� �������� ���������������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� ���������������.</returns>
        public static bool IsFormalized(this DocumentType documentType)
            => !documentType.IsService() && documentType != DocumentType.Untyped;

        /// <summary>
        /// �������� �� �������� ���������� �� ������� � ��� ��.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <param name="untypedKind">��� ����������������� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ���������� �� ������� � ��� ��.</returns>
        public static bool IsStatementOfInvoiceReglament(this DocumentType documentType, string untypedKind)
            => documentType == DocumentType.Untyped 
                && untypedKind == UntypedKind.StatementOfInvoiceReglament;

        /// <summary>
        /// ���������, �������� �� �������� ��������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ��������.</returns>
        public static bool IsSign(this DocumentType documentType)
            => IsReplyTitle(documentType);

        /// <summary>
        /// �������� �� �������� ��� ��� ���� ����� ������ ��������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ������� ��������.</returns>
        public static bool IsSellerTitle(this DocumentType documentType)
            => documentType.IsGeneralTransferSeller()
                || documentType.IsGoodsTransferSeller()
                || documentType.IsWorksTransferSeller()
                || documentType == DocumentType.WaybillSeller
                || documentType == DocumentType.ActOfWorkSeller;

        /// <summary>
        /// �������� �� �������� ��� ��� ���� ����� ������ ����������
        /// </summary>
        /// <param name="documentType">��� ���������</param>
        /// <returns><c>true</c>, ���� �������� �������� ������� ����������</returns>
        public static bool IsBuyerTitle(this DocumentType documentType)
            => documentType.IsGeneralTransferBuyer()
                || documentType == DocumentType.GoodsTransferBuyer
                || documentType == DocumentType.WorksTransferBuyer
                || documentType == DocumentType.WaybillBuyer
                || documentType == DocumentType.ActOfWorkBuyer;

        public static DocumentType[] NoServiceTypes()
            => Types().Where(t => !IsService(t)).ToArray();

        public static DocumentType[] ServiceTypes()
            => Types().Where(t => t.IsService()).ToArray();

        private static IEnumerable<DocumentType> Types()
            => Enum.GetValues(typeof(DocumentType)).Cast<DocumentType>();

        /// <summary>
        /// �������� �� �������� ��� ��� ���.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ��� ��� ���.</returns>
        public static bool IsGeneralTransfer(this DocumentType documentType)
            => documentType.IsGeneralTransferSeller()
                || documentType.IsGeneralTransferBuyer();

        /// <summary>
        /// ��������: �������� �� �������� ������������ ��������� � �������� ������,
        /// ����������� ����� (�� �������� �����), ���, ���.
        /// </summary>
        /// <returns></returns>
        public static bool IsTransferDocumentRevision(this DocumentType documentType)
            => documentType.IsGeneralTransferRevision()
                || documentType == DocumentType.WorksTransferRevisionSeller
                || documentType == DocumentType.GoodsTransferRevisionSeller;

        /// <summary>
        /// �������� �� �������� ������������ ��� ��� ���.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ������� ��������.</returns>
        public static bool IsGeneralTransferRevision(this DocumentType documentType)
            => documentType == DocumentType.GeneralTransferRevisionSeller
                || documentType == DocumentType.GeneralTransferCorrectionRevisionSeller;

        /// <summary>
        /// ���� �� ����������� ������ ���������� �������� �������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� ���� ����������� ������ ���������� �������� �������.</returns>
        public static bool IsNeedSignOptional(this DocumentType documentType)
            => documentType == DocumentType.Untyped
                || documentType.IsWorksTransferSeller()
                || documentType.IsGeneralTransferSeller();

        /// <summary>
        /// �������� �� �������� EDI-����������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� EDI-����������.</returns>
        public static bool IsEdiDocument(this DocumentType documentType)
            => documentType == DocumentType.EdiGeneral
                || documentType == DocumentType.EdiOrders
                || documentType == DocumentType.EdiOrdrsp
                || documentType == DocumentType.EdiDesadv
                || documentType == DocumentType.EdiRecadv;

        /// <summary>
        /// ��������� �� ��� ��������� � ��������� ���������� ��� ��/���.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� ��� ��������� ��������� � ��������� ���������� ��� ��/���.</returns>
        public static bool IsInvoiceServiceDocument(this DocumentType documentType)
            => documentType == DocumentType.ServiceInvoiceConfirmation
                || documentType == DocumentType.ServiceInvoiceReceipt
                || documentType == DocumentType.ServiceInvoiceAmendmentRequest;

        /// <summary>
        /// ��������� �� ��� ��������� � ���������� ��/���.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� ��� ��������� ��������� � ���������� ��/���.</returns>
        public static bool IsInvoiceRegulationDocument(this DocumentType documentType)
            => documentType.IsInvoice()
                || documentType.IsGeneralTransfer()
                || documentType.IsInvoiceServiceDocument();

        /// <summary>
        /// �������� �� �������� ������� �������� ��������� � �������� ������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ������� ��������.</returns>
        public static bool IsGoodsTransferSeller(this DocumentType documentType)
            => documentType == DocumentType.GoodsTransferSeller
                || documentType == DocumentType.GoodsTransferRevisionSeller;

        /// <summary>
        /// �������� �� �������� ������� ����������� ��������� � �������� ����������� ����� (�� �������� �����).
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ������� �����������.</returns>
        public static bool IsWorksTransferSeller(this DocumentType documentType)
            => documentType == DocumentType.WorksTransferSeller
                || documentType == DocumentType.WorksTransferRevisionSeller;

        /// <summary>
        /// �������� �� �������� ������� �������� �������������� ������������� ���������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ������� ��������.</returns>
        public static bool IsGeneralTransferSeller(this DocumentType documentType)
            => documentType == DocumentType.GeneralTransferSeller
                || documentType == DocumentType.GeneralTransferRevisionSeller
                || documentType.IsGeneralTransferCorrectionSeller();

        /// <summary>
        /// �������� �� �������� ������������� ���������������� ����������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ������� ��������.</returns>
        public static bool IsGeneralTransferCorrectionSeller(this DocumentType documentType)
            => documentType == DocumentType.GeneralTransferCorrectionSeller
                || documentType == DocumentType.GeneralTransferCorrectionRevisionSeller;

        /// <summary>
        /// �������� �� �������� ������� ���������� �������������� ������������� ���������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ������� ����������.</returns>
        public static bool IsGeneralTransferBuyer(this DocumentType documentType)
            => documentType == DocumentType.GeneralTransferBuyer
                || documentType == DocumentType.GeneralTransferCorrectionBuyer;

        /// <summary>
        /// �������� �� �������� ������� ���������� �������������� ������������� ���������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns><c>true</c>, ���� �������� �������� ������� ����������.</returns>
        public static bool IsGeneralTransferCorrectionBuyer(this DocumentType documentType)
            => documentType == DocumentType.GeneralTransferCorrectionBuyer;

        /// <summary>
        /// ���������, �������� �� �������� ������� ���������������� ������������ ���������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns>
        /// <c>true</c>, ���� �������� �������� ������� ���������������� ������������ ���������.
        /// </returns>
        public static bool IsTransportWaybillConsignorTitle(this DocumentType documentType)
            => documentType == DocumentType.TransportWaybillConsignorTitle;

        /// <summary>
        /// ���������, �������� �� �������� �������� ������� ������������ ���������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns>
        /// <c>true</c>, ���� �������� �������� �������� ������� ������������ ���������.
        /// </returns>
        public static bool IsTransportWaybillReplyTitle(this DocumentType documentType)
            => documentType == DocumentType.TransportWaybillCargoReceivedTitle
                || documentType == DocumentType.TransportWaybillCargoDeliveredTitle
                || documentType == DocumentType.TransportWaybillConsigneeTitle
                || documentType == DocumentType.TransportWaybillCarrierTitle;

        /// <summary>
        /// ���������, �������� �� �������� ��� ��� ���� �������� �������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns>
        /// <c>true</c>, ���� �������� �������� ��� ��� ���� �������� �������.
        /// </returns>
        public static bool IsRootTitle(this DocumentType documentType)
            => documentType.IsSellerTitle()
                || documentType.IsTransportWaybillConsignorTitle()
                || documentType.IsGoodsTransportWaybillConsignorTitle();

        /// <summary>
        /// ���������, �������� �� �������� ��� ��� ���� �������� �������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns>
        /// <c>true</c>, ���� �������� �������� ��� ��� ���� �������� �������.
        /// </returns>
        public static bool IsReplyTitle(this DocumentType documentType)
            => documentType.IsBuyerTitle()
                || documentType.IsTransportWaybillReplyTitle()
                || documentType.IsGoodsTransportWaybillReplyTitle();

        /// <summary>
        /// ���������, �������� �� �������� ������� ���������������� �������-������������ ���������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns>
        /// <c>true</c>, ���� �������� �������� ������� ���������������� �������-������������ ���������.
        /// </returns>
        public static bool IsGoodsTransportWaybillConsignorTitle(this DocumentType documentType)
            => documentType == DocumentType.GoodsTransportWaybillConsignorTitle;

        /// <summary>
        /// ���������, �������� �� �������� �������� ������� �������-������������ ���������.
        /// </summary>
        /// <param name="documentType">��� ���������.</param>
        /// <returns>
        /// <c>true</c>, ���� �������� �������� �������� ������� �������-������������ ���������.
        /// </returns>
        public static bool IsGoodsTransportWaybillReplyTitle(this DocumentType documentType)
            => documentType == DocumentType.GoodsTransportWaybillCargoReceivedTitle
               || documentType == DocumentType.GoodsTransportWaybillCargoDeliveredTitle
               || documentType == DocumentType.GoodsTransportWaybillConsigneeTitle;
    }
}