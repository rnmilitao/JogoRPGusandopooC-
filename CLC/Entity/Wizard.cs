namespace Aula_1.CLC.Entity
{
    public class Wizard : Hero
    {     
        public Wizard (string Name, int Level, string Herotype) : base (Name, Level, Herotype)
        {

        }
        public override string Attack(){
            return (this.Name + " - " + "Lançou magia");
        }
        public string Attack(int Bonus){
            if (Bonus > 6){
                return (this.Name + " Lançou magia super efetiva com bonus de " + Bonus);
            }
            else{
                return (this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus);
            }
        }
    }
}