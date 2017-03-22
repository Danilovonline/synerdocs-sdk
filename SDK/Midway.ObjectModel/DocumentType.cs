using System.ComponentModel;
using System.Runtime.Serialization;

namespace Midway.ObjectModel
{
    /// <summary>
    /// ��� ���������
    /// </summary>
    [DataContract]
    public enum DocumentType
    {
        /// <summary>
        /// ����������������� ��������
        /// </summary>
        [EnumMember]
        [Description("�����������������")]
        Untyped = 0,

        /// <summary>
        /// ����-�������
        /// </summary>
        [EnumMember]
        [Description("����-�������")]
        Invoice = 1,

        /// <summary>
        /// ��������� ��������: ������������� (��������� ���)
        /// </summary>
        [EnumMember]
        [Description("���������: ������������� (��������� ���)")]
        ServiceInvoiceConfirmation = 2,

        /// <summary>
        /// ��������� ��������: ��������� (��������� ���)
        /// </summary>
        [EnumMember]
        [Description("���������: ��������� (��������� ���)")]
        ServiceInvoiceReceipt = 4,

        /// <summary>
        /// ��������� ��������: ����������� �� ��������� (��������� ���)
        /// </summary>
        [EnumMember]
        [Description("���������: ����������� �� ��������� (��������� ���)")]
        ServiceInvoiceAmendmentRequest = 5,

        /// <summary>
        /// ����������� �� ���������, ����� �� ������� (����� ���������)
        /// </summary>
        [EnumMember]
        [Description("���������: ����������� �� ���������, ����� �� ������� (����� ���������)")]
        ServiceAmendmentRequest = 6,

        /// <summary>
        /// ����������� � ��������� (�� ������������)
        /// </summary>
        [EnumMember]
        [Description("")]
        Comment = 7,

        /// <summary>
        /// ��������� ��������: ��������� � ��������� (����� ���������)
        /// </summary>
        [EnumMember]
        [Description("���������: ��������� � ��������� (����� ���������)")]
        ServiceReceipt = 8,

        /// <summary>
        /// ������������ ����-�������
        /// </summary>
        [EnumMember]
        [Description("������������ ����-�������")]
        InvoiceRevision = 9,

        /// <summary>
        /// ���������������� ����-�������
        /// </summary>
        [EnumMember]
        [Description("���������������� ����-�������")]
        InvoiceCorrection = 10,

        /// <summary>
        /// ������������ ���������������� ����-�������
        /// </summary>
        [EnumMember]
        [Description("������������ ���������������� ����-�������")]
        InvoiceCorrectionRevision = 11,

        /// <summary>
        /// �������� ��������� (����� ��������)
        /// </summary>
        [EnumMember]
        [Description("�������� ���������")]
        WaybillSeller = 12,

        /// <summary>
        /// �������� ��������� (����� ����������)
        /// </summary>
        [EnumMember]
        [Description("���������: �������� ��������� (����� ����������)")]
        WaybillBuyer = 13,

        /// <summary>
        /// ��� � ���������� ����� (����� �����������)
        /// </summary>
        [EnumMember]
        [Description("��� � ���������� �����")]
        ActOfWorkSeller = 14,

        /// <summary>
        /// ��� � ���������� ����� (����� ���������)
        /// </summary>
        [EnumMember]
        [Description("���������: ��� � ���������� ����� (����� ���������)")]
        ActOfWorkBuyer = 15,

        /// <summary>
        /// ��������� ��������: ��������� �� ������
        /// </summary>
        [EnumMember]
        [Description("���������: ��������� �� ������")]
        ErrorReceipt = 16,

        /// <summary>
        /// ����������� �� �������������
        /// </summary>
        [EnumMember]
        [Description("���������� �� �������������")]
        RevocationOffer = 17,

        /// <summary>
        /// �������� � �������� ����������� ����� (����� �����������)
        /// </summary>
        [EnumMember]
        [Description("�������� � �������� ����������� �����")]
        WorksTransferSeller = 18,

        /// <summary>
        /// ���������: �������� �������� ����������� ����� (����� ���������)
        /// </summary>
        [EnumMember]
        [Description("���������: �������� �������� ����������� ����� (����� ���������)")]
        WorksTransferBuyer = 19,

        /// <summary>
        /// �������� � �������� ������� (����� ��������)
        /// </summary>
        [EnumMember]
        [Description("�������� � �������� �������")]
        GoodsTransferSeller = 20,

        /// <summary>
        /// ���������: �������� � �������� ������� (����� ����������)
        /// </summary>
        [EnumMember]
        [Description("���������: �������� � �������� ������� (����� ����������)")]
        GoodsTransferBuyer = 21,

        /// <summary>
        /// ������������ �������� � �������� ����������� ����� (����� �����������)
        /// </summary>
        [EnumMember]
        [Description("������������ �������� � �������� ����������� �����")]
        WorksTransferRevisionSeller = 22,

        /// <summary>
        /// ������������ �������� � �������� ������� (����� ��������)
        /// </summary>
        [EnumMember]
        [Description("������������ �������� � �������� �������")]
        GoodsTransferRevisionSeller = 23,

        /// <summary>
        /// ������������� ������������ �������� (����� ��������)
        /// </summary>
        [EnumMember]
        [Description("������������� ������������ ��������")]
        GeneralTransferSeller = 24,

        /// <summary>
        /// ���������: ������������� ������������ �������� (����� ����������)
        /// </summary>
        [EnumMember]
        [Description("���������: ������������� ������������ �������� (����� ����������)")]
        GeneralTransferBuyer = 25,

        /// <summary>
        /// ������������ ������������� ������������ �������� (����� ��������)
        /// </summary>
        [EnumMember]
        [Description("������������ ������������� ������������ ��������")]
        GeneralTransferRevisionSeller = 26,

        /// <summary>
        /// ������������� ���������������� �������� (����� ��������)
        /// </summary>
        [EnumMember]
        [Description("������������� ���������������� ��������")]
        GeneralTransferCorrectionSeller = 27,

        /// <summary>
        /// ���������: ������������� ���������������� �������� (����� ����������)
        /// </summary>
        [EnumMember]
        [Description("���������: ������������� ���������������� �������� (����� ����������)")]
        GeneralTransferCorrectionBuyer = 28,

        /// <summary>
        /// ������������ ������������� ���������������� �������� (����� ��������)
        /// </summary>
        [EnumMember]
        [Description("������������ ������������� ���������������� ��������")]
        GeneralTransferCorrectionRevisionSeller = 29,

        /// <summary>
        /// ������������ EDI ��������
        /// ������������ ������ ��� ����������� ����������
        /// </summary>
        [EnumMember]
        [Description("������������ EDI ��������")]
        EdiGeneral = 1000,

        /// <summary>
        /// EDI �������� ORDERS
        /// ������������ ������ ��� ����������� ����������
        /// </summary>
        [EnumMember]
        [Description("EDI �������� ORDERS")]
        EdiOrders = 1001,

        /// <summary>
        /// EDI �������� ORDRSP
        /// ������������ ������ ��� ����������� ����������
        /// </summary>
        [EnumMember]
        [Description("EDI �������� ORDRSP")]
        EdiOrdrsp = 1002,

        /// <summary>
        /// EDI �������� DESADV
        /// ������������ ������ ��� ����������� ����������
        /// </summary>
        [EnumMember]
        [Description("EDI �������� DESADV")]
        EdiDesadv = 1003,

        /// <summary>
        /// EDI �������� RECADV
        /// ������������ ������ ��� ����������� ����������
        /// </summary>
        [EnumMember]
        [Description("EDI �������� RECADV")]
        EdiRecadv = 1004,
    }
}
