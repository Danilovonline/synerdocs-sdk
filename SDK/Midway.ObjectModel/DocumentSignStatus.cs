using System.ComponentModel;
using System.Runtime.Serialization;

namespace Midway.ObjectModel
{
    /// <summary>
    /// ������ ���������� ��������� �����������
    /// </summary>
    [DataContract]
    public enum DocumentSignStatus
    {
        /// <summary>
        /// ������� ���������� �� ���������
        /// </summary>
        [Description("������� �� ���������")]
        [EnumMember]
        NoSignNeeded = 0,

        /// <summary>
        /// ��������� ������� ����������
        /// </summary>
        [Description("��������� �������")]
        [EnumMember]
        WaitingForSign = 1,

        /// <summary>
        /// �������� �������� �����������
        /// </summary>
        [Description("��������")]
        [EnumMember]
        Signed = 2,

        /// <summary>
        /// ���������� ��������� ����������� ��������
        /// </summary>
        [Description("��������")]
        [EnumMember]
        SignRejected = 3,
    }
}
