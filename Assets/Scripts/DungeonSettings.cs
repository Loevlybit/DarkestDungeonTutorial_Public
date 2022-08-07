using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DungeonSettings", menuName ="Create/New Dungeon Settings")]
public class DungeonSettings : ScriptableObject
{
    [SerializeField] public int minNumberOfRooms, maxNumberOfRooms;
}
