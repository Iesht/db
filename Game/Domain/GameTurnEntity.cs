using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Game.Domain
{
    public class GameTurnEntity
    {
        public GameTurnEntity()
        {
            Id = Guid.NewGuid();
            Timestamp = DateTime.UtcNow;
        }
        
        [BsonElement]
        public Guid Id
        {
            get; 
            // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Local For MongoDB
            private set;
        }

        [BsonElement]
        public DateTime Timestamp { get; private set; }
        
        [BsonElement]
        public Guid GameId {get; set;}
        
        [BsonElement]
        public int TurnIndex {get; set;}

        [BsonElement]
        public Dictionary<Guid, PlayerDecision> Decisions { get; set; } = new();
        
        [BsonElement]
        public Guid? WinnerId {get; set;}
        
        [BsonElement]
        public bool IsDraw { get; set; }
    }
}