namespace Code_First_Relation.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }

        //Her Postun Bir User tarafından atılması gerekmektedir.
        public UserEntity User { get; set; }


    }
}
