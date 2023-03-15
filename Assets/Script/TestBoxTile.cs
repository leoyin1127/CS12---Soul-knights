using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TestBoxTile : MonoBehaviour
{
    private BoxStatus boxStatus;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var worldPoint = new Vector3Int(Mathf.FloorToInt(point.x), Mathf.FloorToInt(point.y), 0);

            var tiles = StoreBoxData.instance.tiles; // This is our Dictionary of tiles

            if (tiles.TryGetValue(worldPoint, out boxStatus))
            {
                print("mousepos" + point);
                print("Tile " + boxStatus.Name + " costs: " + boxStatus.Cost);
                boxStatus.TilemapMember.SetTileFlags(boxStatus.LocalPlace, TileFlags.None);
                boxStatus.TilemapMember.SetColor(boxStatus.LocalPlace, Color.green);
            }
            else
            {
                Debug.LogError("Box was not found");
            }

        }
    }
}