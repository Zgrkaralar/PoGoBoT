﻿#region using directives

using POGOProtos.Enums;

#endregion

namespace PoGoBoT.Logic.Event
{
    public class TransferPokemonEvent : IEvent
    {
        public int BestCp;
        public double BestPerfection;
        public int Cp;
        public PokemonId Id;
        public double Perfection;
        public int FamilyCandies;
    }
}