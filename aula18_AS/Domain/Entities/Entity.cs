

namespace aula18_AS.Domain.Entities
{
    public abstract class Entity
    {
        private static int proximoId = 1;
        public int Id { get;  set; }
        public Entity()
        {
            Id = proximoId;
            proximoId++;
        }

    }
}