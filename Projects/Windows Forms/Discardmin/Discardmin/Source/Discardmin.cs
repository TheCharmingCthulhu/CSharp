using Discord;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Discardmin.Source
{
    class DiscardminClient
    {
        public delegate void DiscardminErrorHandler(Exception error);
        public event DiscardminErrorHandler DiscardminLoginError;

        public delegate void DiscardminEventHandler();
        public event DiscardminEventHandler DiscardminConnected;
        public event DiscardminEventHandler DiscardminDisconnected;

        public string ApplicationName { get; set; } = "Discardmin";
        public string ApplicationVersion { get; set; } = "v0.1";
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Authorization { get; private set; }
        public List<Server> Servers { get { return _Client.Servers.ToList(); }}

        DiscordClient _Client;

        public DiscardminClient(string username, string password)
        {
            Username = username;
            Password = password;

            _Client = new DiscordClient((config) =>
            {
                config.AppName = ApplicationName;
                config.AppVersion = ApplicationVersion;
            });

            Connect();
        }

        public async void Login(string username, string password)
        {
            Username = username;
            Password = password;

            await _Client.Disconnect();

            Connect();
        }

        private async void Connect()
        {
            try
            {
                Authorization = await _Client.Connect(Username, Password);

                if (!string.IsNullOrEmpty(Authorization)) DiscardminConnected?.Invoke();
            }
            catch (Exception e)
            {
                DiscardminLoginError?.Invoke(e);
            }
        }

        public async void Disconnect()
        {
            await _Client.Disconnect();

            DiscardminDisconnected?.Invoke();
        }
    }
}
