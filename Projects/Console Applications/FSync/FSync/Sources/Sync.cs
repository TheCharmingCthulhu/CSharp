﻿using System;
using System.Linq;
using WinSCP;

namespace FSync.Sources
{
    class Sync : IDisposable
    {
        Session _session;
        SessionOptions _credentials;

        public bool IsConnected { get { return _session != null && _session.Opened; } }

        public Sync(string hostName, string userName, string password, string fingerPrint = "")
        {
            _credentials = new SessionOptions()
            {
                HostName = hostName,
                UserName = userName,
                Password = password,
            };
        }

        public void Dispose()
        {
            if (_session != null)
                Disconnect();
        }

        internal CommandExecutionResult Execute(string[] args)
        {
            return _session.ExecuteCommand(string.Join(" ", args));
        }
        
        #region <- Transfer ->
        internal string GetRemoteCurrentDirectory()
        {
            return _session.ExecuteCommand("pwd").Output;
        }

        internal RemoteFileInfo[] GetRemoteFiles(string path)
        {
            return _session.ListDirectory(path).Files.ToArray();
        }

        internal SynchronizationResult Synchronize(SynchronizationMode mode, string localPath, string remotePath, string fileMask = "")
        {
            return _session.SynchronizeDirectories(mode, localPath, remotePath, false, false, SynchronizationCriteria.Time, new TransferOptions()
            {
                FileMask = fileMask,
                OverwriteMode = OverwriteMode.Overwrite
            });
        } 
        #endregion

        #region <- Connection ->
        internal bool Connect(Protocol protocol, string fingerPrint = "")
        {
            _session = new Session();

            SyncStorage.LoadCredentials(_credentials);

            _credentials.Protocol = protocol;
            _credentials.PortNumber = 22;

            if (_credentials.SshHostKeyFingerprint == null)
                _credentials.SshHostKeyFingerprint = _session.ScanFingerprint(_credentials);

            if (!_credentials.SshHostKeyFingerprint.Equals(""))
                SyncStorage.SaveCredentials(_credentials);

            try
            {
                _session.Open(_credentials);

                return true;
            }
            catch (SessionException e)
            {
                Console.WriteLine(Program.Seperator());
                Console.WriteLine(e.Message);
                Console.WriteLine(Program.Seperator());

                return false;
            }
        }

        internal void Disconnect()
        {
            if (_session != null) _session.Close();

            _session = null;
        } 
        #endregion
    }
}
