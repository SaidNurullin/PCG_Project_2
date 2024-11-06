using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digger : MonoBehaviour
{

    private int gridWidth = 20;
    private int gridHeight = 20;
    private int numOfRooms = 5;
    private int minRoomSize;
    private int maxRoomSize;
    private int minCorridorSize;
    private int maxCorridorSize;
    private bool randomizeRoomSizes;
    private bool randomizeCorridorSizes;


    private bool[,] grid;

    // Digger position
    private int diggerX, diggerY;

    private Vector2 direction;

    private SpriteRenderer imageRenderer;

    private List<Vector2> directions;
    private List<int> dimentions;
    private List<int> lengths;

    private List<Vector2> coordinates;

    private int rooms = 0;


    public bool[,] GenerateMap(int _gridWidth, int _gridHeight, int _numOfRooms, int _minRoomSize, int _maxRoomSize, int _minCorridorSize, int _maxCorridorSize, bool _randomizeRoomSizes, bool _randomizeCorridorSizes)
    {
        gridWidth = _gridWidth;
        gridHeight = _gridHeight;
        numOfRooms = _numOfRooms;
        minRoomSize = _minRoomSize;
        maxRoomSize = _maxRoomSize;
        minCorridorSize = _minCorridorSize;
        maxCorridorSize = _maxCorridorSize;
        randomizeRoomSizes = _randomizeRoomSizes;
        randomizeCorridorSizes = _randomizeCorridorSizes;

        if(minRoomSize > maxRoomSize)
        {
            throw new UnityException("Incorrect room sizes");
        }

        if(minCorridorSize > maxCorridorSize)
        {
            throw new UnityException("Incorrect corridor sizes");
        }


        directions = new();
        directions.Add(Vector2.up);
        directions.Add(Vector2.down);
        directions.Add(Vector2.left);
        directions.Add(Vector2.right);

        dimentions = new();
        for(int i = minRoomSize; i <= maxRoomSize; i += 2)
        {
            dimentions.Add(i);
        }

        lengths = new();

        for (int i = minCorridorSize; i <= maxCorridorSize; i++)
        {
            lengths.Add(i);
        }

        Debug.Log(dimentions.Count);
        Debug.Log(lengths.Count);

        coordinates = new();

        imageRenderer = GetComponent<SpriteRenderer>();

        while (rooms != numOfRooms) 
        {
            rooms = 0;
            grid = new bool[gridWidth, gridHeight];
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    grid[x, y] = false;
                }
            }

            diggerX = gridWidth / 2;
            diggerY = gridHeight / 2;

            int randomIndex = Random.Range(0, directions.Count);

            direction = directions[randomIndex];
            Dig();
        }


        CreateTexture();

        return grid;
    }


    private void Dig()
    {
        // Continue digging until no rooms or corridors are placed
        while (true)
        {
            if (rooms == numOfRooms) break;

            // Flags for room and corridor placement
            bool placedRoom = false;
            bool placedCorridor = false;

            if (RoomPlacement()) placedRoom = true;
            if (CorridorPlacement()) placedCorridor = true;

            if (!(placedRoom || placedCorridor))
            {
                if (BackTrack())
                {
                    CorridorPlacement();
                }
                else break;
            }
        }
    }

    private bool RoomPlacement()
    {
        bool placedRoom = false;

        // Room placement
        if (randomizeRoomSizes)
        {
            int randWidth = dimentions[Random.Range(0, dimentions.Count)];
            int randHeight = dimentions[Random.Range(0, dimentions.Count)];
            if (CheckRoom(randWidth, randHeight))
            {
                PlaceRoom(randWidth, randHeight);
                placedRoom = true;
            }
        }
        else
        {
            for (int i = maxRoomSize; i >= minRoomSize; i -= 2)
            {
                for (int j = maxRoomSize; j >= minRoomSize; j -= 2)
                {
                    if (CheckRoom(i, j))
                    {
                        PlaceRoom(i, j);
                        placedRoom = true;
                        break;
                    }
                }
                if (placedRoom) break;
            }
        }

        return placedRoom;
    }

    private bool CorridorPlacement()
    {
        bool placedCorridor = false;

        if (randomizeCorridorSizes)
        {
            int randLength = lengths[Random.Range(0, lengths.Count)];
            if (CheckCorridor(randLength, direction))
            {
                PlaceCorridor(randLength, direction);
                placedCorridor = true;
            }
        }
        else
        {
            for (int length = maxCorridorSize; length >= minCorridorSize; length--)
            {

                if (CheckCorridor(length, direction))
                {
                    PlaceCorridor(length, direction);
                    placedCorridor = true;
                    break;
                }
            }
        }

        return placedCorridor;
    }



    private bool CheckRoom(int width, int height)
    {
        int X = diggerX;
        int Y = diggerY;

        if (direction == Vector2.left)
        {
            X -= width / 2;
        }
        else if (direction == Vector2.right)
        {
            X += width / 2;
        }
        else if (direction == Vector2.down)
        {
            Y += height / 2;
        }
        else if (direction == Vector2.up)
        {
            Y -= height / 2;
        }

        int counter = 0;

        for (int x = X - width / 2 - 1; x < X + width / 2 + 1; x++)
        {
            for (int y = Y - height / 2 - 1; y < Y + height / 2 + 1; y++)
            {
                if(x >= gridWidth || x < 0 || y >= gridHeight || y < 0 || grid[x, y])
                {
                    counter++;
                }
            }
        }
        if (counter > 1) return false;

        return true;
    }

    private void PlaceRoom(int width, int height)
    {
        rooms += 1;

        int X = diggerX;
        int Y = diggerY;

        if (direction == Vector2.left)
        {
            X -= width / 2;
        }
        else if (direction == Vector2.right)
        {
            X += width / 2;
        }
        else if (direction == Vector2.down)
        {
            Y += height / 2;
        }
        else if (direction == Vector2.up)
        {
            Y -= height / 2;
        }

        for (int x = X - width / 2; x < X + width / 2; x++)
        {
            for (int y = Y - height / 2; y < Y + height / 2; y++)
            {
                grid[x, y] = true;
            }
        }

        ChooseDirection();

        diggerX = X;
        diggerY = Y;

        coordinates.Add(new(diggerX, diggerY));

        if (direction == Vector2.left)
        {
            diggerX -= (width / 2 + 1);
        }
        else if (direction == Vector2.right)
        {
            diggerX += (width / 2);
        }
        else if (direction == Vector2.down)
        {
            diggerY += (height / 2);
        }
        else if (direction == Vector2.up)
        {
            diggerY -= (height / 2 + 1);
        }

    }

    private bool CheckCorridor(int length, Vector2 direction)
    {
        int X = diggerX;
        int Y = diggerY;

        if (direction == Vector2.left)
        {
            for (int x = X; x >= X - length - 1; x--)
            {
                if (x < 0 || grid[x, Y]) return false;
            }
        }
        else if (direction == Vector2.right)
        {
            for (int x = X; x < X + length + 1; x++)
            {
                if(x >= gridWidth || grid[x, Y]) return false;
            }
        }
        else if (direction == Vector2.down)
        {
            for (int y = Y; y < Y + length + 1; y++)
            {
                if(y >= gridHeight || grid[X, y]) return false;
            }
        }
        else if (direction == Vector2.up)
        {
            for (int y = Y; y >= Y - length - 1; y--)
            {
                if(y < 0 || grid[X, y]) return false;
            }
        }

        return true;
    }

    private void PlaceCorridor(int length, Vector2 direction)
    {
        int X = diggerX;
        int Y = diggerY;

        if (direction == Vector2.left)
        {
            diggerX -= length;
            for (int x = X; x >= X - length; x--)
            {
                grid[x, Y] = true;
            }
        }
        else if(direction == Vector2.right)
        {
            diggerX += length;
            for (int x = X; x < X + length; x++)
            {
                grid[x, Y] = true;
            }
        }
        else if (direction == Vector2.down)
        {
            diggerY += length;
            for (int y = Y; y < Y + length; y++)
            {
                grid[X, y] = true;
            }
        }
        else if (direction == Vector2.up)
        {
            diggerY -= length;
            for (int y = Y; y >= Y - length; y--)
            {
                grid[X, y] = true;
            }
        }

        //ChooseDirection();

        //if (direction == Vector2.left)
        //{
        //    diggerX -= 1;
        //}
        //else if (direction == Vector2.right)
        //{
        //    diggerX += 1;
        //}
        //else if (direction == Vector2.down)
        //{
        //    diggerY += 1;
        //}
        //else if (direction == Vector2.up)
        //{
        //    diggerY -= 1;
        //}
    }

    private void ChooseDirection()
    {
        List<Vector2> remaining_directions = new(directions);

        remaining_directions.Remove(-1 * direction);

        int randomIndex = Random.Range(0, remaining_directions.Count);

        direction = remaining_directions[randomIndex];
    }

    private bool BackTrack()
    {

        if (coordinates.Count == 0) return false;

        diggerX = (int)coordinates[coordinates.Count - 1][0];
        diggerY = (int)coordinates[coordinates.Count - 1][1];

        coordinates.RemoveAt(coordinates.Count - 1);

        ChooseDirection();

        while(grid[diggerX, diggerY])
        {
            diggerX += (int)direction[0];
            diggerY += -1 * (int)direction[1];

            if(diggerX >= gridWidth || diggerX < 0 || diggerY >= gridHeight || diggerY < 0)
            {
                return BackTrack();
            }
        }


        return true;
    }

    private void CreateTexture()
    {
        Texture2D texture = new Texture2D(gridWidth, gridHeight);

        // Convert the bool array to pixel data
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                // Set pixel color based on the bool value
                Color pixelColor = grid[x, y] ? Color.white : Color.black;
                texture.SetPixel(x, gridHeight - y - 1, pixelColor);
            }
        }

        texture.filterMode = FilterMode.Point;

        // Apply the changes to the texture
        texture.Apply();

        // Create a Sprite from the texture
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

        // Assign the Sprite to the SpriteRenderer
        imageRenderer.sprite = sprite;
    }



}
