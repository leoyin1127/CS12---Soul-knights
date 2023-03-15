using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BoxStatus: MonoBehaviour
{
    //local place of the tile within the tilemap
    public Vector3Int LocalPlace { get; set; }

    //creates a POCO model (Plain Old CLR object) allow to assign
    //to specific groups in a data source
    public Vector3 WorldLocation { get; set; }

    //represent the type of tile in tilemap
    public TileBase TileBase { get; set; }

    //a Tilemap object that represents the Tilemap that
    //the tile belongs to
    public Tilemap TilemapMember { get; set; }

    //name of the tile
    public string Name { get; set; }

    // Below is needed for Breadth First Searching
    //explores all the nodes at the same level
    //before moving on to the next level

    //whether the tile has been explored or not
    public bool IsExplored { get; set; }

    public BoxStatus ExploredFrom { get; set; }

    public int Cost { get; set; }
}