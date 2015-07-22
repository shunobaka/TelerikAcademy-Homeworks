namespace ChefClassRefactoring
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            Peel(carrot);
            this.Cut(carrot);

            Bowl bowl;
            bowl = this.GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);
        }

        private void Cut(Vegetable potato)
        {
            // ...
        }

        private Bowl GetBowl()
        {
            // ... 
        }

        private Carrot GetCarrot()
        {
            // ...
        }

        private Potato GetPotato()
        {
            // ...
        }
    }
}
