

/*using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public int worldWidth = 100;
    public int worldHeight = 100;
    public int worldDepth = 100;
    public float scale = 20f;
    public float heightScale = 10f;

    void Start()
    {
        for (int x = 0; x < worldWidth; x++)
        {
            for (int z = 0; z < worldDepth; z++)
            {
                float xCoord = (float)x / worldWidth * scale;
                float zCoord = (float)z / worldDepth * scale;
                float height = Mathf.PerlinNoise(xCoord, zCoord) * heightScale;

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, height, z);
                cube.transform.parent = transform;
            }
        }
    }
}
*/



/*
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public int worldWidth = 100;  // dünya geniþliði
    public int worldHeight = 100;  // dünya yüksekliði
    public int worldDepth = 100;  // dünya derinliði
    public float scale = 20f;  // Perlin noise algoritmasýnýn ölçeklenmesi
    public float heightScale = 10f;  // Yükseklik ölçeði

    void Start()
    {
        // Dünya geniþliði ve derinliði boyunca döngü
        for (int x = 0; x < worldWidth; x++)
        {
            for (int z = 0; z < worldDepth; z++)
            {
                // Perlin noise algoritmasýnýn x ve z koordinatlarýný hesapla
                float xCoord = (float)x / worldWidth * scale;
                float zCoord = (float)z / worldDepth * scale;

                // Perlin noise algoritmasýný kullanarak yüksekliði hesapla
                float height = Mathf.PerlinNoise(xCoord, zCoord) * heightScale;

                // Küp nesnesi oluþtur
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

                // Küp nesnesinin pozisyonunu ayarla
                cube.transform.position = new Vector3(x, height, z);

                // Küp nesnesini "transform" nesnesine baðla
                cube.transform.parent = transform;

                // Alt kýsýmlarý doldur
                for (int y = 0; y < height; y++)
                {
                    GameObject fillCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    fillCube.transform.position = new Vector3(x, y, z);
                    fillCube.transform.parent = transform;
                }
            }
        }
    }
}
*/


/*
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject fillCubePrefab;
    public GameObject[] minePrefabs;
    public int worldWidth = 100;
    public int worldHeight = 100;
    public int worldDepth = 100;
    public float scale = 20f;
    public float heightScale = 10f;
    public float mineThreshold = 0.7f;

    public int seed;  // Tohum deðeri

    void Start()
    {
        Random.InitState(seed);  // Tohum deðerini ayarlama

        for (int x = 0; x < worldWidth; x++)
        {
            for (int z = 0; z < worldDepth; z++)
            {
                float xCoord = (float)x / worldWidth * scale;
                float zCoord = (float)z / worldDepth * scale;

                float height = Mathf.PerlinNoise(xCoord, zCoord) * heightScale;

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, height, z);
                cube.transform.parent = transform;

                for (int y = 0; y < height; y++)
                {
                    GameObject fillCube = Instantiate(fillCubePrefab, new Vector3(x, y, z), Quaternion.identity);
                    fillCube.transform.parent = transform;
                }

                if (height >= mineThreshold)
                {
                    int randomMineIndex = Random.Range(0, minePrefabs.Length);
                    GameObject mine = Instantiate(minePrefabs[randomMineIndex], new Vector3(x, height, z), Quaternion.identity);
                    mine.transform.parent = transform;
                }
            }
        }
    }
}
*/



/*

using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject fillCubePrefab;
    public GameObject[] minePrefabs;
    public GameObject cavePrefab;
    public int worldWidth = 100;
    public int worldHeight = 100;
    public int worldDepth = 100;
    public float scale = 20f;
    public float heightScale = 10f;
    public float mineThreshold = 0.7f;
    public float caveThreshold = 0.3f;






    public int seed;  // Tohum deðeri

    void Start()
    {
        Random.InitState(seed);  // Tohum deðerini ayarlama

        for (int x = 0; x < worldWidth; x++)
        {
            for (int z = 0; z < worldDepth; z++)
            {
                float xCoord = (float)x / worldWidth * scale;
                float zCoord = (float)z / worldDepth * scale;

                float height = Mathf.PerlinNoise(xCoord, zCoord) * heightScale;

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, height, z);
                cube.transform.parent = transform;

                for (int y = 0; y < height; y++)
                {
                    GameObject fillCube = Instantiate(fillCubePrefab, new Vector3(x, y, z), Quaternion.identity);
                    fillCube.transform.parent = transform;
                }

                if (height >= mineThreshold)
                {
                    int randomMineIndex = Random.Range(0, minePrefabs.Length);
                    GameObject mine = Instantiate(minePrefabs[randomMineIndex], new Vector3(x, height, z), Quaternion.identity);
                    mine.transform.parent = transform;
                }

                if (height <= caveThreshold)
                {
                    GameObject cave = Instantiate(cavePrefab, new Vector3(x, height, z), Quaternion.identity);
                    cave.transform.parent = transform;
                }
            }
        }
    }
}
*/



/*

using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject fillCubePrefab;
    public GameObject[] minePrefabs;
    public int worldWidth = 100;
    public int worldHeight = 100;
    public int worldDepth = 100;
    public float scale = 20f;
    public float heightScale = 10f;
    public float mineThreshold = 0.7f;
    public int gap = 2;

   
public int seed;  // Tohum deðeri

    void Start()
    {
        Random.InitState(seed);  // Tohum deðerini ayarlama

        for (int x = 0; x < worldWidth; x++)
        {
            for (int z = 0; z < worldDepth; z++)
            {
                float xCoord = (float)x / worldWidth * scale;
                float zCoord = (float)z / worldDepth * scale;

                float height = Mathf.PerlinNoise(xCoord, zCoord) * heightScale;

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, height, z);
                cube.transform.parent = transform;

                int filledHeight = (int)height + gap;
                for (int y = 0; y < filledHeight; y++)
                {
                    GameObject fillCube = Instantiate(fillCubePrefab, new Vector3(x, y, z), Quaternion.identity);
                    fillCube.transform.parent = transform;
                }

                if (height >= mineThreshold)
                {
                    int randomMineIndex = Random.Range(0, minePrefabs.Length);
                    GameObject mine = Instantiate(minePrefabs[randomMineIndex], new Vector3(x, height, z), Quaternion.identity);
                    mine.transform.parent = transform;
                }
            }
        }
    }
}

*/





/*

using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject fillCubePrefab;
    public GameObject[] minePrefabs;
    public int worldWidth = 100;
    public int worldHeight = 100;
    public int worldDepth = 100;
    public float scale = 20f;
    public float heightScale = 10f;
    public float mineThreshold = 0.7f;

    public int seed;  // Tohum deðeri

    private Transform cubesParent;

    void Start()
    {
        Random.InitState(seed);  // Tohum deðerini ayarlama

        cubesParent = new GameObject("Cubes").transform;

        for (int x = 0; x < worldWidth; x++)
        {
            for (int z = 0; z < worldDepth; z++)
            {
                float xCoord = (float)x / worldWidth * scale;
                float zCoord = (float)z / worldDepth * scale;

                float height = Mathf.PerlinNoise(xCoord, zCoord) * heightScale;

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, height, z);
                cube.transform.parent = cubesParent;

                for (int y = 0; y < height; y++)
                {
                    GameObject fillCube = Instantiate(fillCubePrefab, new Vector3(x, y, z), Quaternion.identity);
                    fillCube.transform.parent = cubesParent;
                }

                if (height >= mineThreshold)
                {
                    int randomMineIndex = Random.Range(0, minePrefabs.Length);
                    GameObject mine = Instantiate(minePrefabs[randomMineIndex], new Vector3(x, height, z), Quaternion.identity);
                    mine.transform.parent = cubesParent;
                }
            }
        }
    }
}
*/






/*

using UnityEngine.UIElements;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject fillCubePrefab;
    public GameObject[] minePrefabs;
    public int worldWidth = 100;
    public int worldHeight = 100;
    public int worldDepth = 100;
    public float scale = 20f;
    public float heightScale = 10f;
    public float mineThreshold = 0.7f;
    public int seed;  // Tohum deðeri

    private Transform[,,] fillCubeArray;

    void Start()
    {
        Random.InitState(seed);  // Tohum deðerini ayarlama

        fillCubeArray = new Transform[worldWidth, worldHeight, worldDepth];

        for (int x = 0; x < worldWidth; x++)
        {
            for (int z = 0; z < worldDepth; z++)
            {
                float xCoord = (float)x / worldWidth * scale;
                float zCoord = (float)z / worldDepth * scale;

                float height = Mathf.PerlinNoise(xCoord, zCoord) * heightScale;

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, height, z);
                cube.transform.parent = transform;

                for (int y = 0; y < height; y++)
                {
                    GameObject fillCube = Instantiate(fillCubePrefab, new Vector3(x, y, z), Quaternion.identity);
                    fillCubeArray[x, y, z] = fillCube.transform;
                    fillCube.transform.parent = transform;
                }

                if (height >= mineThreshold)
                {
                    int randomMineIndex = Random.Range(0, minePrefabs.Length);
                    GameObject mine = Instantiate(minePrefabs[randomMineIndex], new Vector3(x, height, z), Quaternion.identity);
                    mine.transform.parent = transform;
                }
            }
        }
    }

    void Update()
    {
        for (int x = 0; x < worldWidth; x++)
        {
            for (int y = 0; y < worldHeight; y++)
            {
                for (int z = 0; z < worldDepth; z++)
                {
                    if (fillCubeArray[x, y, z] != null)
                    {
                        fillCubeArray[x, y, z].gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}



*/



using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject fillCubePrefab;
    public GameObject[] minePrefabs;
    public int worldWidth = 100;
    public int worldHeight = 100;
    public int worldDepth = 100;
    public float scale = 20f;
    public float heightScale = 10f;
    public float mineThreshold = 0.7f;
    int say = 0;

    public int seed;  // Tohum deðeri

    private Transform fillCubeParent;
    private Transform mineParent;

    void Start()
    {
        Random.InitState(seed);  // Tohum deðerini ayarlama

        fillCubeParent = new GameObject("Fill Cube Parent").transform;
        mineParent = new GameObject("Mine Parent").transform;

        for (int x = 0; x < worldWidth; x++)
        {
            for (int z = 0; z < worldDepth; z++)
            {
                float xCoord = (float)x / worldWidth * scale;
                float zCoord = (float)z / worldDepth * scale;

                float height = Mathf.PerlinNoise(xCoord, zCoord) * heightScale;

                /*GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, height, z);
                cube.transform.parent = transform;
                */
                for (int y = 0; y < height; y++)
                {
                    GameObject fillCube = Instantiate(fillCubePrefab, new Vector3(x, y, z), Quaternion.identity, fillCubeParent);
                    say++;
                    Debug.Log(say);
                }

                if (height >= mineThreshold)
                {
                    int randomMineIndex = Random.Range(0, minePrefabs.Length);
                    GameObject mine = Instantiate(minePrefabs[randomMineIndex], new Vector3(x, height, z), Quaternion.identity, mineParent);
                    say++;
                    Debug.Log(say);
                }
            }
        }
    }






}