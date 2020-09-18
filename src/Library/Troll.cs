using System;
using System.Collections;

namespace MiddleEarth
{
    /*
        Justificación de implementación de parte 3 (Cobrando Poder),
        para todos los personajes:
        Se utilizó el patrón expert para tomar la decisión de colocar los métodos
        de obtener ataque y defensa en esta misma clase, ya que es ella la que conoce
        que items posee el personaje. También se utilizó el patrón expert para incluír
        los métodos de curar al personaje y de recibir daño, ya que es el que conoce
        su propia cantidad de vida y su armadura.
        Si bien podrían haber varias razones de cambio de esta clase como (por ejemplo
        agregar items, cambiar el calculo del daño, cambiar la cantidad de vida) se
        priorizó el uso del patrón expert ya que hace mas coherente a esta clase, además
        de haberlo hecho de otra forma, nuestro codigo hubiera quedado menos sintetizado,
        lo que hubiera hecho que fuera menos reutilazable y mantenible.
    */
    public class Troll
    {
        public Troll(string name)
        {
            this.Name = name;
            this.Health = 150;

        }
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }
        private int health;
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if(value >= 0)
                {
                    this.health = value;
                }
                else
                {
                    this.health = 0;
                }
            }
        }
        public WoodenHammer Hammer{get;set;}
        public IronArmor Armor{get;set;}

        public void ChangeWeapon(WoodenHammer hammer)
        {
            this.Hammer = hammer;
        }
        public void RemoveWeapon()
        {
            this.Hammer = null;
        }
        public void ChangeArmor(IronArmor armor)
        {
            this.Armor = armor;
        }
        public void RemoveArmor()
        {
            this.Armor = null;
        }
        public void Heal()
        {
            Troll newTroll = new Troll("NewTroll");
            this.Health = newTroll.Health;
        }
        public int GetAttack()
        {
            return this.Hammer.Attack;
        }
        public void ReceiveDamage(int damage)
        {
            if(this.Armor.Defense >= damage)
            {
                this.Armor.Defense -= damage;
            }
            else
            {
                damage -= this.Armor.Defense;
                this.Armor.Defense = 0;
                this.Health -= damage;
            }
        }
    }
}