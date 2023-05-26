using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class SaveAndLoad : MonoBehaviour

{
    Dictionary<Transform, GameObject> World=new Dictionary<Transform, GameObject>();
    ArrayList block = new ArrayList();
    string path = Application.dataPath + "/Saves/World.json";
    GameObject BlockObject;


    public void Start()
    {
       // block.Add(BlockObject);
    }



    public void BlockLoad()
    {

        // GameObject Build = Instantiate(block, buildPos, transform.rotation);


        if (World != null)
        {

            Dictionary<Transform, GameObject>.KeyCollection keyList = World.Keys;

            foreach (Transform keys in keyList)
            {
                Console.WriteLine(keys);

                GameObject Build = Instantiate(BlockObject, keys.position, keys.rotation);

            }


        }


    }

    public void BlockDestroy(Transform destroyingObject)
    {
        World.Remove(destroyingObject);

    }

    public void BlockAdd(GameObject addObject)
    {
        World.Add(gameObject.transform, gameObject);
    }

  
    public void WorldLoad()
    {
       

        if (File.Exists(path))
        {
            string worldData = File.ReadAllText(path);
            
            World = JsonUtility.FromJson<Dictionary<Transform,GameObject>>(worldData);
            Debug.Log(World);
        }
        else
        {
            Debug.Log("dosya bulunamadý");
        }


    }


    public void WorldSave()
    {
        string save = JsonUtility.ToJson(World);
        File.WriteAllText(path,save);
    }











}
