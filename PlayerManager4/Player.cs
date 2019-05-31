using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerManager4
{
    public class Player : IComparable<Player>
    {
        // Properties (auto implementadas criam automaticamente uma variavel de suporte)
        public string Name { get; }
        public int Score { get; set; }

        // Constructor
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return $"Name = {Name} & Score = {Score}";
        }

        public int CompareTo(Player other)
        {
            if (other == null) return -1;
            return other.Score - Score;
        }
    }
}
