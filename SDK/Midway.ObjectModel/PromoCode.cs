using System.Runtime.Serialization;
using System;

namespace Midway.ObjectModel
{
    /// <summary>
    /// ��������
    /// </summary>
    [DataContract]
    [KnownType(typeof(OrganizationPromoCode))]
    public class PromoCode
    {
        /// <summary>
        /// ������������ ���������
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// �������� ������ ���������
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// ���� ���������������� �������� ���������
        /// </summary>
        [DataMember]
        public bool IsValidityNotLimited { get; set; }

        /// <summary>
        /// ������ �������� ���������
        /// </summary>
        [DataMember]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// ��������� �������� ���������
        /// </summary>
        [DataMember]
        public DateTime? ExpiryDate { get; set; }

    }
}