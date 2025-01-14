#pragma warning disable CA1711, CS1591

using System;
using System.IO;
using MediaBrowser.Model.Drawing;

namespace MediaBrowser.Controller.Drawing
{
    public class ImageStream : IDisposable
    {
        /// <summary>
        /// Gets or sets the stream.
        /// </summary>
        /// <value>The stream.</value>
        public Stream? Stream { get; set; }

        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        /// <value>The format.</value>
        public ImageFormat Format { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Stream?.Dispose();
            }
        }
    }
}
