using Flunt.Notifications;

namespace Domain;

public abstract class Entity : Notifiable<Notification>
{

}
public abstract class EntityID : Entity
{
    public int Id { get; private set; }
}

public abstract class EntityGUID : Entity
{
    public EntityGUID()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
}
