namespace update_site.Entities
{
    public class Update
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripton { get; set; }
        public string OS { get; set; } // so I know what system this is for
        public bool Is32Bit { get; set; } // So I know if this update is for 32 or 64 bit OS's
        public int KBNumber { get; set; }
        public bool IsOptional { get; set; } // So I know if it's optional or important
        public string DownloadUrl { get; set; } // Public url
        public string FileLocation { get; set; } // My url
    }
}