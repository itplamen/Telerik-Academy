namespace _01.RefactorClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Chef
    {
        public Carrot GetCarrot()
        {
            return new Carrot();
        }

        public Potato GetPotato()
        {
            return new Potato();
        }

        public void Peel(Vegetable vegetable)
        {
            // TODO: Implement this method
            throw new NotImplementedException("Method Peel() is not implemented!");
        }

        public Bowl GetBowl()
        {
            return new Bowl();
        }

        public void Cut(Vegetable potato)
        {
            // TODO: Implement this method
            throw new NotImplementedException("Method Cut() is not implemented!");
        }

        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();

            this.Peel(potato);
            this.Peel(carrot);

            Bowl bowl = new Bowl();
            bowl = this.GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);

            this.Cut(potato);
            this.Cut(carrot);
        }
    }
}
