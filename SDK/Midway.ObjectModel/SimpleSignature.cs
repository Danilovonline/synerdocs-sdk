using System;
using System.Runtime.Serialization;

namespace Midway.ObjectModel
{
    /// <summary>
    /// ������� ����������� �������.
    /// </summary>
    [DataContract]
    public class SimpleSignature : ISignature
    {
        /// <summary>
        /// ������������� �������.
        /// </summary>
        [DataMember(IsRequired = true)]
        public string Id { get; set; }

        /// <summary>
        /// ������������� ������������ ���������.
        /// </summary>
        [DataMember(IsRequired = true)]
        public string DocumentId { get; set; }

        /// <summary>
        /// ���� �����������-�����������.
        /// </summary>
        [DataMember]
        public string SenderBoxId { get; set; }

        /// <summary>
        /// ���� ����������.
        /// </summary>
        [DataMember]
        public DateTime SignedAt { get; set; }

        /// <summary>
        /// ������ �������.
        /// </summary>
        [DataMember]
        public string Version { get; set; }

        /// <summary>
        /// ��������� �������.
        /// </summary>
        [DataMember]
        public SimpleSignatureRequisites Requisites { get; set; }

        /// <summary>
        /// ��� ����������� ���������.
        /// </summary>
        [DataMember]
        public byte[] AttributesHash { get; set; }

        /// <summary>
        /// ��� ������������ ���������.
        /// </summary>
        [DataMember]
        public byte[] DocumentHash { get; set; }

        /// <summary>
        /// ��� �������� �������.
        /// </summary>
        [DataMember]
        public byte[] ValidationCode { get; set; }

        /// <summary>
        /// <c>true</c>, ���� ������� �������; ����� - <c>false</c>.
        /// </summary>
        [DataMember]
        public bool IsValid { get; set; }

        /// <summary>
        /// �������� ���������� �������.
        /// </summary>
        [DataMember(IsRequired = true)]
        public byte[] Raw { get; set; }
    }
}
