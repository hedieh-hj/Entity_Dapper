using System.ComponentModel.DataAnnotations;

namespace api_project.Model
{
    public class Lock
    {        
        public int? Id { get; set; }                
        
        public string? Serial { get; set; }        
        
        public int? Status { get; set; }        
        
        public int? Type { get; set; }        
        
        public string? Password { get; set; }        
        
        public string? Customization { get; set; }        
        
        public DateTime? CreatedOnUtc { get; set; }        
        
        public int? CreatedBy { get; set; }        
        
        public DateTime? UpdatedOnUtc { get; set; }        
        
        public int? UpdatedBy { get; set; }
        
        public int? UpdateLevel { get; set; }

        public int? PackageId { get; set; }                

        public int? LockServiceType { get; set; }
    
        public int? DigitalLicenseAuthorizedInstallCount { get; set; }

        //public string? LockUniqueID { get; set; }
    }
}
