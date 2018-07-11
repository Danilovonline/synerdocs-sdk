using System;
using System.Runtime.Serialization;

namespace Midway.ObjectModel.Common
{
    /// <summary>
    /// �������� ��� � �������.
    /// </summary>
    [DataContract]
    public class DateTimeRange
    {
        /// <summary>
        /// ���� � ����� ������.
        /// </summary>
        [DataMember]
        public DateTime? From { get; set; }

        /// <summary>
        /// ���� � ����� ����������.
        /// </summary>
        [DataMember]
        public DateTime? To { get; set; }
    }
}
