

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
    public int worldWidth = 100;  // d�nya geni�li�i
    public int worldHeight = 100;  // d�nya y�ksekli�i
    public int worldDepth = 100;  // d�nya derinli�i
    public float scale = 20f;  // Perlin noise algoritmas�n�n �l�eklenmesi
    public float heightScale = 10f;  // Y�kseklik �l�e�i

    void Start()
    {
        // D�nya geni�li�i ve derinli�i boyunca d�ng�
        for (int x = 0; x < worldWidth; x++)
        {
            for (int z = 0; z < worldDepth; z++)
            {
                // Perlin noise algoritmas�n�n x ve z koordinatlar�n� hesapla
                float xCoord = (float)x / worldWidth * scale;
                float zCoord = (float)z / worldDepth * scale;

                // Perlin noise algoritmas�n� kullanarak y�ksekli�i hesapla
                float height = Mathf.PerlinNoise(xCoord, zCoord) * heightScale;

                // K�p nesnesi olu�tur
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

                // K�p nesnesinin pozisyonunu ayarla
                cube.transform.position = new Vector3(x, height, z);

                // K�p nesnesini "transform" nesnesine ba�la
                cube.transform.parent = transform;

                // Alt k�s�mlar� doldur
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

    public int seed;  // Tohum de�eri

    void Start()
    {
        Random.InitState(seed);  // Tohum de�erini ayarlama

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






    public int seed;  // Tohum de�eri

    void Start()
    {
        Random.InitState(seed);  // Tohum de�erini ayarlama

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

   
public int seed;  // Tohum de�eri

    void Start()
    {
        Random.InitState(seed);  // Tohum de�erini ayarlama

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

    public int seed;  // Tohum de�eri

    private Transform cubesParent;

    void Start()
    {
        Random.InitState(seed);  // Tohum de�erini ayarlama

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
    public int seed;  // Tohum de�eri

    private Transform[,,] fillCubeArray;

    void Start()
    {
        Random.InitState(seed);  // Tohum de�erini ayarlama

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

    public int seed;  // Tohum de�eri

    private Transform fillCubeParent;
    private Transform mineParent;

    void Start()
    {
        Random.InitState(seed);  // Tohum de�erini ayarlama

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