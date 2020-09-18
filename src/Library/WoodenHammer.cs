namespace MiddleEarth
{
    public class WoodenHammer
    {
        /*
            Esta clase solo tiene la responsabilidad de conocer el ataque y la defensa de
            un item en especifico, también tiene implementado un constructor para dicho item.
            De esta manera estaría cumpliendo con el SRP ya que su único motivo de cambio sería
            que cambiaran sus propiedades o la validación de las mismas.
        */
        private int attack;
        public int Attack
        {
            get
            {
                return this.attack;
            }
            set
            {
                if(value >= 0)
                {
                    this.attack = value;
                }
                else
                {
                    this.attack = 0;
                }
            }
        }
        private int defense;
        public int Defense
        {
            get
            {
                return this.defense;
            }
            set
            {
                if(value >= 0)
                {
                    this.defense = value;
                }
                else
                {
                    this.defense = 0;
                }
            }
        }
        public WoodenHammer(int newAttack, int newDefense)
        {
            this.Attack = newAttack;
            this.Defense = newDefense;
        }
    }
}