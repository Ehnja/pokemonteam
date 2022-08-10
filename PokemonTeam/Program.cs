using System;
using System.Collections.Generic;

namespace PokemonTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemon = new List<Pokemon>();
            Pokemon pokemon1 = new Pokemon("Hypno", 53, 120, "Psychic", "Tackle", 80, 45, 55, 75, 40);
            Pokemon pokemon2 = new Pokemon("Ditto", 68, 127, "Normal", "Transform", 50, 10, 10, 20, 20);
            Pokemon pokemon3 = new Pokemon("Kingler", 26, 133, "Water", "Bubble", 70, 35, 60, 35, 40);
            Pokemon pokemon4 = new Pokemon("Marowak", 54, 114, "Ground", "Bite", 85, 65, 55, 30, 25);
            Pokemon pokemon5 = new Pokemon("Kangaskhan", 85, 142, "Normal", "Stomp", 55, 40, 70, 40, 50);
            Pokemon pokemon6 = new Pokemon("Moltres", 59, 111, "Fire and Flying", "Ember", 90, 60, 50, 85, 60);
            pokemon.Add(pokemon1);
            pokemon.Add(pokemon2);
            pokemon.Add(pokemon3);
            pokemon.Add(pokemon4);
            pokemon.Add(pokemon5);
            pokemon.Add(pokemon6);
            for (int i = 0; i < pokemon.Count; i++)
            {
                Console.WriteLine(pokemon[i].ToString());
                
            }
        }
    }    
    public class Pokemon
    {
        public string name = "Hypno";
        public int lvl = 00;
        public int hp = 00;
        public string type = "fire";
        public string move = "Tackle";
        public int attack = 00;
        public int specialAttack = 00;
        public int defense = 00;
        public int specialDefense = 00;
        public int speed = 00;
        public int evasion = 00;
        public override string ToString()
        {
            return (name + " LVL:" + lvl + "\nHP: " + hp + "\nA " + type + " type\n" + "Moves:\n" + move + "\n" +
                "Stats:\nSpeed: " + speed + "\nAttack: " + attack + "    Special Attack: " + specialAttack + "\nDefense: " + defense + "    Special Defense: " + specialDefense
                + "\n________________________________________________________________________________________________________________________\n");
        }
        public Pokemon(string name, int lvl, int hp, string type, string move, int speed, int attack, int specialAttack, int defense, int specialDefense)
        {
            this.name = name;
            this.lvl = lvl;
            this.hp = hp;
            this.type = type;
            this.move = move;
            this.speed = speed;
            this.attack = attack;
            this.specialAttack = specialAttack;
            this.defense = defense;
            this.specialDefense = specialDefense;
        }        
    }
    public class Attacks
    {
        public string name = "Tackle";
        public int pp = 10;
        public int power = 20;
        public int accuracy = 1;
        public Attacks(string name)
        {
            this.name = name;
        }
    }
}
