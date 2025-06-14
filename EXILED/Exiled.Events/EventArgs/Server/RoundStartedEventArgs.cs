// -----------------------------------------------------------------------
// <copyright file="RoundStartedEventArgs.cs" company="ExMod Team">
// Copyright (c) ExMod Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.EventArgs.Server
{
    using System;

    using Exiled.API.Features;

    /// <summary>
    /// Contains information about the round start event.
    /// </summary>
    public class RoundStartedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoundStartedEventArgs"/> class.
        /// </summary>
        /// <param name="player">A representative player from the server at round start, or <c>null</c> if no players are present.</param>
        /// <param name="roundStartTime">The UTC time when the round started.</param>
        /// <param name="playerCount">The number of non-NPC, non-host players in the server at round start.</param>
        /// <param name="keepRoundOnOne">Indicates whether the round continues with one player remaining.</param>
        public RoundStartedEventArgs(Player player, DateTime roundStartTime, int playerCount, bool keepRoundOnOne)
        {
            Player = player;
            RoundStartTime = roundStartTime;
            PlayerCount = playerCount;
            KeepRoundOnOne = keepRoundOnOne;
        }

        /// <summary>
        /// Gets a representative player from the server at round start, or <c>null</c> if no players are present.
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// Gets the UTC time when the round started.
        /// </summary>
        public DateTime RoundStartTime { get; }

        /// <summary>
        /// Gets the number of players in the server at the time the round started.
        /// </summary>
        public int PlayerCount { get; }

        /// <summary>
        /// Gets a value indicating whether the round continues with one player remaining.
        /// </summary>
        public bool KeepRoundOnOne { get; }
    }
}