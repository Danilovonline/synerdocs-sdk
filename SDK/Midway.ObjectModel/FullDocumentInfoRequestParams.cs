using System.Runtime.Serialization;

namespace Midway.ObjectModel
{
    /// <summary>
    /// ��������� �������� ������ ���������� � ���������.
    /// </summary>
    [DataContract]
    public class FullDocumentInfoRequestParams
    {
        /// <summary>
        /// ����������� �� ���������.
        /// </summary>
        public FullDocumentInfoRequestParams()
        {
            this.GetContent = true;
            this.GetCard = true;
            this.GetRelatedDocuments = true;
            this.GetServiceDocuments = true;
            this.GetSigns = true;
            this.GetDocumentDeletionState = true;
            this.GetAvailableOperations = true;
        }

        /// <summary>
        /// ��������� ���������� ���������?
        /// </summary>
        [DataMember]
        public bool GetContent { get; set; }

        /// <summary>
        /// ��������� �������� ���������?
        /// </summary>
        [DataMember]
        public bool GetCard { get; set; }

        /// <summary>
        /// ��������� �������?
        /// </summary>
        [DataMember]
        public bool GetSigns { get; set; }

        /// <summary>
        /// ��������� ��������� ���������?
        /// </summary>
        [DataMember]
        public bool GetServiceDocuments { get; set; }

        /// <summary>
        /// ��������� ��������� ���������?
        /// </summary>
        [DataMember]
        public bool GetRelatedDocuments { get; set; }

        /// <summary>
        /// ��������� ����������� �� �������������?
        /// </summary>
        [DataMember]
        public bool GetRevocationOffers { get; set; }

        /// <summary>
        /// ��������� ���������� � ��������� ���������?
        /// </summary>
        [DataMember]
        public bool GetDocumentDeletionState { get; set; }

        /// <summary>
        /// ��������� ���������� � ��������� ���������?
        /// </summary>
        [DataMember]
        public bool? GetAvailableOperations { get; set; }

        /// <summary>
        /// ���������� ���� ��� ������������ ������� �� ������ ����� �������� �������:
        /// TODO - ��������� ��� �������� � ��� ������?
        /// </summary>
        [DataMember]
        public string UserLogin { get; set; }

        /// <summary>
        /// <c>true</c>, ���� ��������� ��������� ���������� � ����� ���������� ����������������; ����� - <c>false</c>.
        /// </summary>
        [DataMember]
        public bool GetDocumentFlowParticipantsRoles { get; set; }

        public override string ToString() 
            => $"GetAvailableOperations: {GetAvailableOperations}, " +
               $"GetContent: {GetContent}, " +
               $"GetCard: {GetCard}, " +
               $"GetSigns: {GetSigns}, " +
               $"GetServiceDocuments: {GetServiceDocuments}, " +
               $"GetRelatedDocuments: {GetRelatedDocuments}";
    }
}
