namespace Domain;

public abstract class Entity
{

}
public abstract class EntityID : Entity
{
    public int ID { get; private set; }
}

public abstract class EntityGUID : Entity
{
    public Guid GUID { get; private set; }
}

