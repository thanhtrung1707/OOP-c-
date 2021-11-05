namespace ClassDiagram
{
    public class Hero : Character
    {
        public string FullName;

        public Hero(int hp, int attackpoint, string fullName)
        :base(hp, attackpoint)
        {
            FullName = fullName;
        }

        public Hero()
        {
            
        }

        public void Attack(Monster monster)
        {
            
        }
    }
}