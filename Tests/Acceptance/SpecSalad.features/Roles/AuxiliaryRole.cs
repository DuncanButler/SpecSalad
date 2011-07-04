namespace SpecSalad.features.Roles
{
    public class AuxiliaryRole : ApplicationRole
    {
        public bool Add(int theValue)
        {
            int total = (int)this.Retrieve("Total");

            total += theValue;

            this.StoreValue("Total", total);

            return true;
        }
    
    }
}