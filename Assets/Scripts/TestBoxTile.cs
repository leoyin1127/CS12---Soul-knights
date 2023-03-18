using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class TestBoxTile : MonoBehaviour
{
    private BoxStatus boxStatus;
    private ShootScript shootScript;

    // Update is called once per frame
    void Update()
    {
        shootScript = GameObject.FindObjectOfType<ShootScript>();
        if (shootScript != null)
        {
            List<Vector3> bulletPositions = shootScript.bulletPositions;
            print(bulletPositions.Count);
            foreach (Vector3 position in bulletPositions)
            {
                Debug.Log(position);
                Vector3 point = position;
                var worldPoint = new Vector3Int(Mathf.FloorToInt(point.x), Mathf.FloorToInt(point.y), 0);
                //Debug.Log(System.String.Format("bulletpos: {0},{1}",worldPoint.x,worldPoint.y));

                var tiles = StoreBoxData.instance.tiles; // Dictionary of tiles

                //find point in tiles that collides with the bullet
                if (tiles.TryGetValue(worldPoint, out boxStatus))
                {
                    print("bulletpos" + point);
                    print("Tile " + boxStatus.Name);
                    boxStatus.TilemapMember.SetTileFlags(boxStatus.LocalPlace, TileFlags.None);
                    boxStatus.TilemapMember.SetTile(boxStatus.LocalPlace, null);
                }

                
            }
        }
    }
}
