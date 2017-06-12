using System;
using System.Collections.Generic;
using System.Text;

namespace ieaulbtest
{
    public sealed class DocumentStatus
    {
        public DocumentStatus()
        {

        }
        private static readonly DocumentStatus instance = new DocumentStatus();
        public static DocumentStatus Instance
        {
            get
            {
                return instance;
            }
        }



        private bool downloadComplete;
        public bool DownloadComplete
        {
            get
            {
                return downloadComplete;
            }
            set
            {
                downloadComplete = value;
            }
        }
    }
}
