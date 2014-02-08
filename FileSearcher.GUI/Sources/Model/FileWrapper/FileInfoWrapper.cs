// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.Serialization;
using System.Security.AccessControl;

using FileSearcher.Common.Model;

namespace FileSearcher.GUI.Model.FileWrapper
{
	public class FileInfoWrapper : IFileInfo
	{
		private readonly FileInfo _fileInfo;

		public FileInfoWrapper( FileInfo fileInfo )
		{
			Contract.Requires<ArgumentNullException>( fileInfo != null );
			_fileInfo = fileInfo;
		}

		public string Name { get { return _fileInfo.Name; } }

		public Int64 Length { get { return _fileInfo.Length; } }

		public string DirectoryName { get { return _fileInfo.DirectoryName; } }

		public DirectoryInfo Directory { get { return _fileInfo.Directory; } }

		public bool IsReadOnly { get { return _fileInfo.IsReadOnly; } set { _fileInfo.IsReadOnly = value; } }

		public bool Exists { get { return _fileInfo.Exists; } }

		public FileSecurity GetAccessControl()
		{
			return _fileInfo.GetAccessControl();
		}

		public FileSecurity GetAccessControl( AccessControlSections includeSections )
		{
			return _fileInfo.GetAccessControl( includeSections );
		}

		public void SetAccessControl( FileSecurity fileSecurity )
		{
			_fileInfo.SetAccessControl( fileSecurity );
		}

		public StreamReader OpenText()
		{
			return _fileInfo.OpenText();
		}

		public StreamWriter CreateText()
		{
			return _fileInfo.CreateText();
		}

		public StreamWriter AppendText()
		{
			return _fileInfo.AppendText();
		}

		public FileInfo CopyTo( string destFileName )
		{
			return _fileInfo.CopyTo( destFileName );
		}

		public FileInfo CopyTo(
			string destFileName,
			bool overwrite )
		{
			return _fileInfo.CopyTo( destFileName, overwrite );
		}

		public FileStream Create()
		{
			return _fileInfo.Create();
		}

		public void Delete()
		{
			_fileInfo.Delete();
		}

		public void Decrypt()
		{
			_fileInfo.Decrypt();
		}

		public void Encrypt()
		{
			_fileInfo.Encrypt();
		}

		public FileStream Open( FileMode mode )
		{
			return _fileInfo.Open( mode );
		}

		public FileStream Open(
			FileMode mode,
			FileAccess access )
		{
			return _fileInfo.Open( mode, access );
		}

		public FileStream Open(
			FileMode mode,
			FileAccess access,
			FileShare share )
		{
			return _fileInfo.Open( mode, access, share );
		}

		public FileStream OpenRead()
		{
			return _fileInfo.OpenRead();
		}

		public FileStream OpenWrite()
		{
			return _fileInfo.OpenWrite();
		}

		public void MoveTo( string destFileName )
		{
			_fileInfo.MoveTo( destFileName );
		}

		public FileInfo Replace(
			string destinationFileName,
			string destinationBackupFileName )
		{
			return _fileInfo.Replace( destinationFileName, destinationBackupFileName );
		}

		public FileInfo Replace(
			string destinationFileName,
			string destinationBackupFileName,
			bool ignoreMetadataErrors )
		{
			return _fileInfo.Replace( destinationFileName, destinationBackupFileName, ignoreMetadataErrors );
		}

		public string FullName { get { return _fileInfo.FullName; } }

		public string Extension { get { return _fileInfo.Extension; } }

		public DateTime CreationTime { get { return _fileInfo.CreationTime; } set { _fileInfo.CreationTime = value; } }

		public DateTime CreationTimeUtc
		{
			get { return _fileInfo.CreationTimeUtc; }
			set { _fileInfo.CreationTimeUtc = value; }
		}

		public DateTime LastAccessTime { get { return _fileInfo.LastAccessTime; } set { _fileInfo.LastAccessTime = value; } }

		public DateTime LastAccessTimeUtc
		{
			get { return _fileInfo.LastAccessTimeUtc; }
			set { _fileInfo.LastAccessTimeUtc = value; }
		}

		public DateTime LastWriteTime { get { return _fileInfo.LastWriteTime; } set { _fileInfo.LastWriteTime = value; } }

		public DateTime LastWriteTimeUtc
		{
			get { return _fileInfo.LastWriteTimeUtc; }
			set { _fileInfo.LastWriteTimeUtc = value; }
		}

		public FileAttributes Attributes { get { return _fileInfo.Attributes; } set { _fileInfo.Attributes = value; } }

		public void Refresh()
		{
			_fileInfo.Refresh();
		}

		public void GetObjectData(
			SerializationInfo info,
			StreamingContext context )
		{
			_fileInfo.GetObjectData( info, context );
		}
	}
}