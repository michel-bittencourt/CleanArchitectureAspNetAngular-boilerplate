using Flunt.Notifications;

namespace Domain;

public abstract class Entity : Notifiable<Notification>
{

}
public abstract class EntityID : Entity
{
    public int ID { get; private set; }
}

public abstract class EntityGUID : Entity
{
    public EntityGUID()
    {
        ID = Guid.NewGuid();
    }
    public Guid ID { get; set; }
}
