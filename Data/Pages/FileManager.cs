using CardModel;
namespace FilemanagerData
{
    public class Storage
    {
        public int SourceValue { get; set; }
        public string? Source { get; set; }
    }
    public class FileList {
        public decimal Id { get; set; }
        public string? Icon { get; set; }
        public string? IconColor { get; set; }
        public string? Title { get; set; }
        public string? Total { get; set; }
        public string? TotalColor { get; set; }
        public string? Storage { get; set; }
        public string? Files { get; set; }
        public string? Category { get; set; }
        public string? Size { get; set; }
        public string? Date { get; set; }
    }

    public class FilemanagerService {
        public static List<Storage> GetStorage()
        {
           var storage = new List<Storage> ();
            storage.Add(new Storage { Source = "Media", SourceValue = 38 });
            storage.Add(new Storage { Source = "Downloads", SourceValue = 36 });
            storage.Add(new Storage { Source = "Apps", SourceValue = 27 });
            storage.Add(new Storage { Source = "Documents", SourceValue = 32 });
            return storage;
        } 
        private List<FileList>  FileListData  = new List<FileList>(){
            new FileList{ Id= 1, Icon= "ri-folder-2-line", Title= "All Files", Total= "412", TotalColor= "bg-primary"},
            new FileList{ Id= 2, Icon= "ri-history-fill", Title= "Recent Files"},
            new FileList{ Id= 3, Icon= "ri-share-forward-line", Title= "Shared Files"},
            new FileList{ Id= 4, Icon= "ri-star-s-line", Title= "  favourites", Total= "02", TotalColor= "bg-primary1"},
            new FileList{ Id= 5, Icon= "ri-delete-bin-line", Title= " Recycle Bin"},
            new FileList{ Id= 6, Icon= "ri-settings-3-line", Title= "Settings"},
            new FileList{ Id= 7, Icon= "ri-questionnaire-line", Title= "Help Center"},
            new FileList{ Id= 8, Icon= "ri-folder-line", Title= "Version"},
            new FileList{ Id= 9, Icon= "ri-logout-box-line", Title= "Log out"},

            new FileList{ Id= 10, Icon= "<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M112,175.67V168a8,8,0,0,0-8-8H48a8,8,0,0,0-8,8v40a8,8,0,0,0,8,8h56a8,8,0,0,0,8-8v-8.82L144,216V160Z' opacity='0.2'></path><polyline points='112 175.67 144 160 144 216 112 199.18' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><rect x='40' y='160' width='72' height='56' rx='8' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></rect><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'></polygon><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><path d='M176,224h24a8,8,0,0,0,8-8V88L152,32H56a8,8,0,0,0-8,8v88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>", IconColor="primary",Title= "VID-14512223-AKP823.mp4", Total= "1.2KB"},
            new FileList{ Id= 11, Icon= "<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M112,175.67V168a8,8,0,0,0-8-8H48a8,8,0,0,0-8,8v40a8,8,0,0,0,8,8h56a8,8,0,0,0,8-8v-8.82L144,216V160Z' opacity='0.2'></path><polyline points='112 175.67 144 160 144 216 112 199.18' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><rect x='40' y='160' width='72' height='56' rx='8' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></rect><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'></polygon><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><path d='M176,224h24a8,8,0,0,0,8-8V88L152,32H56a8,8,0,0,0-8,8v88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>", IconColor="primary1",Title= "AUD-14512223-AKP823.mp3", Total= "25GB"},
            new FileList{ Id= 12, Icon= "<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M112,175.67V168a8,8,0,0,0-8-8H48a8,8,0,0,0-8,8v40a8,8,0,0,0,8,8h56a8,8,0,0,0,8-8v-8.82L144,216V160Z' opacity='0.2'></path><polyline points='112 175.67 144 160 144 216 112 199.18' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><rect x='40' y='160' width='72' height='56' rx='8' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></rect><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'></polygon><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><path d='M176,224h24a8,8,0,0,0,8-8V88L152,32H56a8,8,0,0,0-8,8v88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>", IconColor="primary2",Title= "VID-14211110-AKP823.mp4", Total= "36GB"},
        };
        public List<FileList> GetFileListData() => FileListData;
        private List<FileList>  AccessListData  = new List<FileList>(){
            new FileList{ Id= 1, Icon= "ti ti-photo", IconColor="primary",Title="Images",Storage="17% Used",Files="245 files",Size="24.32GB"},
            new FileList{ Id= 2, Icon= "ti ti-video", IconColor="primary1",Title="Videos",Storage="22% Used",Files="224 files",Size="26.14GB"},
            new FileList{ Id= 3, Icon= "ti ti-headphones", IconColor="primary2",Title="Audio",Storage="24% Used",Files="1354 files",Size="29.45GB"},
            new FileList{ Id= 4, Icon= "ti ti-layout-grid", IconColor="primary3",Title="Apps",Storage="46% Used",Files="18 files",Size="54.14GB"},
            new FileList{ Id= 5, Icon= "ti ti-file-description", IconColor="info",Title="Docs",Storage="18% Used",Files="102 files",Size="8.42GB"},
            new FileList{ Id= 6, Icon= "ti ti-download", IconColor="secondary",Title="Downloads",Storage="16% Used",Files="16 files",Size="6.36GB"},

            new FileList{ Id= 7, Title="Images",Files="345 Files",Size="124.16MB"},
            new FileList{ Id= 8, Title="Docs",Files="45 Files",Size="451.15KB"},
            new FileList{ Id= 9, Title="Downloads",Files="568 Files",Size="1.45GB"},
            new FileList{ Id= 10, Title="Apps",Files="247 Files",Size="15.88GB"},
        };
        public List<FileList> GetAccessListData() => AccessListData;
        
        public TableText[] FilesHeaders = new TableText[]
        {
            new TableText { Title = "File Name" },
            new TableText { Title = "Category" },
            new TableText { Title = "Size" },
            new TableText { Title = "Date Modified" },
            new TableText { Title = "Action" },
        };        
        public TableText[] GetFilesHeadersData() => FilesHeaders;
        
        private List<FileList> RecentListData  = new List<FileList>(){
            new FileList{ Id= 1, Icon= "<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M112,175.67V168a8,8,0,0,0-8-8H48a8,8,0,0,0-8,8v40a8,8,0,0,0,8,8h56a8,8,0,0,0,8-8v-8.82L144,216V160Z' opacity='0.2'></path><polyline points='112 175.67 144 160 144 216 112 199.18' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><rect x='40' y='160' width='72' height='56' rx='8' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></rect><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'></polygon><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><path d='M176,224h24a8,8,0,0,0,8-8V88L152,32H56a8,8,0,0,0-8,8v88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>", IconColor="primary1",Title="VIDEO_88745_KKI451.mp4",Category="Videos",Size="89MB",Date="15,Aug 2024"},

            new FileList{ Id= 2, Icon= "<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><path d='M112,175.67V168a8,8,0,0,0-8-8H48a8,8,0,0,0-8,8v40a8,8,0,0,0,8,8h56a8,8,0,0,0,8-8v-8.82L144,216V160Z' opacity='0.2'/><polyline points='112 175.67 144 160 144 216 112 199.18' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><rect x='40' y='160' width='72' height='56' rx='8' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'/><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><path d='M176,224h24a8,8,0,0,0,8-8V88L152,32H56a8,8,0,0,0-8,8v88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/></svg>", IconColor="primary1",Title="VID-14211110-AKP823.mp4",Category="Videos",Size="12MB",Date="18,May 2024"},
            
            new FileList{ Id= 3, Icon= "<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><path d='M168,192h16a20,20,0,0,0,0-40H168v56' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><line x1='128' y1='152' x2='128' y2='208' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><polyline points='56 152 88 152 56 208 88 208' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'/><path d='M48,112V40a8,8,0,0,1,8-8h96l56,56v24' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/></svg>", IconColor="primary2",Title="AC-20241.zip",Category="Archives",Size="564KB",Date="06,Mar 2024"},

            new FileList{ Id= 4, Icon= "<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><polygon points='48 200 48 160 72 160 96 136 96 224 72 200 48 200' opacity='0.2'/><polygon points='48 200 48 160 72 160 96 136 96 224 72 200 48 200' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><path d='M128,152a32.5,32.5,0,0,1,0,56' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'/><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><path d='M168,224h32a8,8,0,0,0,8-8V88L152,32H56a8,8,0,0,0-8,8v80' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/></svg>", IconColor="primary3",Title="AUD__145_24152.mp3",Category="Archives",Size="264KB",Date="26,Apr 2024"},

            new FileList{ Id= 5, Icon= " <svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'/><path d='M48,112V40a8,8,0,0,1,8-8h96l56,56v24' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><polyline points='216 152 184 152 184 208' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><line x1='208' y1='184' x2='184' y2='184' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><path d='M48,192H64a20,20,0,0,0,0-40H48v56' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><path d='M112,152v56h16a28,28,0,0,0,0-56Z' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/></svg>", IconColor="secondary",Title="Document-file.pdf",Category="Documents",Size="2.6MB",Date="07,Feb 2024"},
        };
        public List<FileList> GetRecentListData() => RecentListData;
        private List<FileList>  StorageListData  = new List<FileList>(){
            new FileList{ Id= 1, Icon= "ti ti-photo", IconColor="primary",Title="Media",Storage="90",Files="3,145 files",Size="45GB"},
            new FileList{ Id= 2, Icon= "ti ti-download", IconColor="primary1",Title="Downloads",Storage="90",Files="568 files",Size="66GB"},
            new FileList{ Id= 3, Icon= "ti ti-layout-grid", IconColor="primary2",Title="Apps",Storage="90",Files="74 files",Size="55GB"},
            new FileList{ Id= 4, Icon= "ti ti-file-description", IconColor="primary3",Title="Documents",Storage="90",Files="1,441 files",Size="34GB"},
        };
        public List<FileList> GetStorageListData() => StorageListData;
    }
}