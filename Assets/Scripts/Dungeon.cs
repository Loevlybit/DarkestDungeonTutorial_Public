using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dungeon 
{
    private DungeonStructure structure;

    public Dungeon(DungeonStructure structure)
    {
        this.structure = structure;
    }

    public IEnumerable<Room> GetRooms()
    {
        return structure.rooms;
    }

    public IEnumerable<Corridor> GetCorridors()
    {
        return structure.corridors;
    }
}
