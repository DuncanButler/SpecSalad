namespace SpecSalad.features.Roles
{
    public class SecondaryRole : ApplicationRole
    {
        public bool Add(int theValue)
        {
            int total = (int) this.Retrieve("Total");

            total += 2;

            this.StoreValue("Total",total);

            return true;
        }


         public void SubtractOne()
         {
             int total = (int)this.Retrieve("Total");

             total -= 1;

             this.StoreValue("Total",total);
         }
    }
}