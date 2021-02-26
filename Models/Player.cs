namespace NetCoreMediatRExample.Models
{
    public class Player : IBaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Location { get; set; }
        public string ProfileUrl { get; set; }
    }
}
