namespace Aula_1.CLC.Entity
{
    public class Hero
    {
        public string Name;
        public int Level;
        public string Herotype;

        public Hero (string Name, int Level, string Herotype){
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
        }

        public override string ToString(){
           return (this.Name + " - " + this.Level + " - " + this.Herotype);
        }

        public virtual string Attack(){
            return (this.Name + " - " + "Atacou com sua espada");

        }
    }
}