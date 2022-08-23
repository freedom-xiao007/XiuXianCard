public class Card
{
    public int id;
    public string name;
    public string des;

    public Card(int _id, string _name, string _des)
    {
        this.id = _id;
        this.name = _name;
        this.des = _des;
    }
}

public class AttackCard: Card
{
    public int demage;

    public AttackCard(int _id, string _name, string _des, int _demage): base(_id, _name, _des)
    {
        this.demage = _demage;
    }
}
