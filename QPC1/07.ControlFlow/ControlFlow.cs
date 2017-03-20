public class Chef
{
    private Bowl GetBowl()
    {
        //... 
    }

    private Carrot GetCarrot()
    {
        //...
    }

    private Potato GetPotato()
    {
        //...
    }

    private void Cut(Vegetable potato)
    {
        //...
    }

    public void Cook()
    {
        Potato potato = GetPotato();
        Peel(potato);
        Cut(potato);

        Carrot carrot = GetCarrot();
        Peel(carrot);
        Cut(carrot);

        Bowls bowl = GetBowl();          
        bowl.Add(carrot);
        bowl.Add(potato);
    }

}
