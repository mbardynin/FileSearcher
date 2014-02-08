// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security.AccessControl;

namespace FileSearcher.Common.Model
{
	public interface IFileInfo
	{
		string Name { get; }
		Int64 Length { get; }
		string DirectoryName { get; }
		DirectoryInfo Directory { get; }
		bool IsReadOnly { get; set; }
		bool Exists { get; }
		string FullName { get; }
		string Extension { get; }
		DateTime CreationTime { get; set; }
		DateTime CreationTimeUtc { get; set; }
		DateTime LastAccessTime { get; set; }
		DateTime LastAccessTimeUtc { get; set; }
		DateTime LastWriteTime { get; set; }
		DateTime LastWriteTimeUtc { get; set; }
		FileAttributes Attributes { get; set; }

		FileSecurity GetAccessControl();
		FileSecurity GetAccessControl( AccessControlSections includeSections );
		void SetAccessControl( FileSecurity fileSecurity );
		StreamReader OpenText();
		StreamWriter CreateText();
		StreamWriter AppendText();
		FileInfo CopyTo( string destFileName );

		FileInfo CopyTo(
			string destFileName,
			bool overwrite );

		FileStream Create();
		void Delete();
		void Decrypt();
		void Encrypt();
		FileStream Open( FileMode mode );

		FileStream Open(
			FileMode mode,
			FileAccess access );

		FileStream Open(
			FileMode mode,
			FileAccess access,
			FileShare share );

		FileStream OpenRead();
		FileStream OpenWrite();
		void MoveTo( string destFileName );

		FileInfo Replace(
			string destinationFileName,
			string destinationBackupFileName );

		FileInfo Replace(
			string destinationFileName,
			string destinationBackupFileName,
			bool ignoreMetadataErrors );

		void Refresh();

		void GetObjectData(
			SerializationInfo info,
			StreamingContext context );

		string ToString();
	}
}