#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Dicom;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class StudyDeleteRecord: ServerEntity
    {
        #region Constructors
        public StudyDeleteRecord():base("StudyDeleteRecord")
        {}
        public StudyDeleteRecord(
             String _studyInstanceUid_
            ,DateTime _timestamp_
            ,String _serverPartitionAE_
            ,ServerEntityKey _filesystemKey_
            ,String _backupPath_
            ,String _reason_
            ,String _accessionNumber_
            ,String _patientId_
            ,String _patientsName_
            ,String _studyId_
            ,String _studyDescription_
            ,String _studyDate_
            ,String _studyTime_
            ,XmlDocument _archiveInfo_
            ,String _extendedInfo_
            ):base("StudyDeleteRecord")
        {
            StudyInstanceUid = _studyInstanceUid_;
            Timestamp = _timestamp_;
            ServerPartitionAE = _serverPartitionAE_;
            FilesystemKey = _filesystemKey_;
            BackupPath = _backupPath_;
            Reason = _reason_;
            AccessionNumber = _accessionNumber_;
            PatientId = _patientId_;
            PatientsName = _patientsName_;
            StudyId = _studyId_;
            StudyDescription = _studyDescription_;
            StudyDate = _studyDate_;
            StudyTime = _studyTime_;
            ArchiveInfo = _archiveInfo_;
            ExtendedInfo = _extendedInfo_;
        }
        #endregion

        #region Public Properties
        [DicomField(DicomTags.StudyInstanceUid, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="StudyInstanceUid")]
        public String StudyInstanceUid
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="Timestamp")]
        public DateTime Timestamp
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="ServerPartitionAE")]
        public String ServerPartitionAE
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="FilesystemGUID")]
        public ServerEntityKey FilesystemKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="BackupPath")]
        public String BackupPath
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="Reason")]
        public String Reason
        { get; set; }
        [DicomField(DicomTags.AccessionNumber, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="AccessionNumber")]
        public String AccessionNumber
        { get; set; }
        [DicomField(DicomTags.PatientId, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="PatientId")]
        public String PatientId
        { get; set; }
        [DicomField(DicomTags.PatientsName, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="PatientsName")]
        public String PatientsName
        { get; set; }
        [DicomField(DicomTags.StudyId, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="StudyId")]
        public String StudyId
        { get; set; }
        [DicomField(DicomTags.StudyDescription, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="StudyDescription")]
        public String StudyDescription
        { get; set; }
        [DicomField(DicomTags.StudyDate, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="StudyDate")]
        public String StudyDate
        { get; set; }
        [DicomField(DicomTags.StudyTime, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="StudyTime")]
        public String StudyTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="ArchiveInfo")]
        public XmlDocument ArchiveInfo
        { get { return _ArchiveInfo; } set { _ArchiveInfo = value; } }
        [NonSerialized]
        private XmlDocument _ArchiveInfo;
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDeleteRecord", ColumnName="ExtendedInfo")]
        public String ExtendedInfo
        { get; set; }
        #endregion

        #region Static Methods
        static public StudyDeleteRecord Load(ServerEntityKey key)
        {
            using (var read = PersistentStoreRegistry.GetDefaultStore().OpenReadContext())
            {
                return Load(read, key);
            }
        }
        static public StudyDeleteRecord Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IStudyDeleteRecordEntityBroker>();
            StudyDeleteRecord theObject = broker.Load(key);
            return theObject;
        }
        static public StudyDeleteRecord Insert(StudyDeleteRecord entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                StudyDeleteRecord newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public StudyDeleteRecord Insert(IUpdateContext update, StudyDeleteRecord entity)
        {
            var broker = update.GetBroker<IStudyDeleteRecordEntityBroker>();
            var updateColumns = new StudyDeleteRecordUpdateColumns();
            updateColumns.StudyInstanceUid = entity.StudyInstanceUid;
            updateColumns.Timestamp = entity.Timestamp;
            updateColumns.ServerPartitionAE = entity.ServerPartitionAE;
            updateColumns.FilesystemKey = entity.FilesystemKey;
            updateColumns.BackupPath = entity.BackupPath;
            updateColumns.Reason = entity.Reason;
            updateColumns.AccessionNumber = entity.AccessionNumber;
            updateColumns.PatientId = entity.PatientId;
            updateColumns.PatientsName = entity.PatientsName;
            updateColumns.StudyId = entity.StudyId;
            updateColumns.StudyDescription = entity.StudyDescription;
            updateColumns.StudyDate = entity.StudyDate;
            updateColumns.StudyTime = entity.StudyTime;
            updateColumns.ArchiveInfo = entity.ArchiveInfo;
            updateColumns.ExtendedInfo = entity.ExtendedInfo;
            StudyDeleteRecord newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
