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
        RevocationOffer = 17
    }
}
