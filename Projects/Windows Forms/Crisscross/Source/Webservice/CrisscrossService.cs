using Crisscross.Source.Webservice.Content;
using Crisscross.Source.Webservice.Content.Interfaces;
using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Crisscross.Source.Webservice
{
    class CrisscrossService : IDisposable
    {
        const string _localhostURI = "http://localhost:80";

        readonly ICrisscrossContent _service;
        readonly HttpListener _listener;

        public CrisscrossService(ICrisscrossContent service)
        {
            if (HttpListener.IsSupported)
            {
                _listener = new HttpListener();
                _listener.Prefixes.Add(_localhostURI + "/");

                _service = service;
                foreach (var uriAttribute in _service.GetPages()) _listener.Prefixes.Add(GetPath(uriAttribute.PageInfo.URI));

                _listener.Start();

                Loop();
            }
            else throw new Exception("Service requires \"Windows XP SP2\", \"Windows Server 2003\" or later.");
        }

        private string GetPath(string path)
        {
            return string.Format("{0}/{1}/", _localhostURI, path);
        }

        private void Loop()
        {
            Task.Run(() =>
            {
                while (_listener.IsListening)
                {
                    ThreadPool.QueueUserWorkItem((c) =>
                    {
                        var context = c as HttpListenerContext;

                        try
                        {
                            var page = _service.GetPage(context.Request.Url.AbsolutePath.Trim('/'));
                            if (page != null)
                            {
                                var content = page.Execute();
                                var buffer = Encoding.UTF8.GetBytes(content);
                                context.Response.ContentLength64 = buffer.Length;
                                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                            }

                            context.Response.StatusCode = 404;
                        }
                        finally
                        {
                            context.Response.Close();
                        }

                    }, _listener.GetContext());
                }

                Dispose();
            });
        }

        public void Dispose()
        {
            _listener.Stop();
        }
    }
}
