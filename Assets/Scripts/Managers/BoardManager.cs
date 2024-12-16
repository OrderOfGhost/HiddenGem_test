using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardManager : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase rockTile;      
    public int boardWidth = 10;   
    public int boardHeight = 10;

    void Start()
    {
        GenerateBoard();
    }   

    public void GenerateBoard()
    {
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), rockTile);
            }
        }
    }

    public void ClearBoard()
    {
        tilemap.ClearAllTiles();
    }
}
