namespace PodCast.DAL.Entities
{
    public class Footer
    {
        public int Id { get; set; }
        public string DesigndeBy { get; set; }
        public string LogoUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AppUrl { get; set; }
        public string GoogleUrl { get; set; }
        public ICollection<SocialMedia> SocialMedia { get; set; }

    }
}
