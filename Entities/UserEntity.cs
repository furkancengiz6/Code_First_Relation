namespace Code_First_Relation.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        //Bir Yazarın birden çok postu olabilir.
        public List<PostEntity> Posts { get; set; }

    }
}
