using System.Runtime.Serialization;
using System;

namespace Midway.ObjectModel
{
    /// <summary>
    /// ����� �������� - �����������
    /// </summary>
    [DataContract]
    public class OrganizationPromoCode:PromoCode
    {
        /// <summary>
        /// ���������� �� ����� ��������� - �����������
        /// </summary>
        [DataMember]
        public string OrganizationPromoCodeId { get; set; }

    }
}