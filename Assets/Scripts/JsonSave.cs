using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonSave : MonoBehaviour
{

    CharacterStarts Ali = new CharacterStarts("ali", 12, 6);

    // Start is called before the first frame update
    void Start()
    {
        jsonKaydet();
    }

    void jsonKaydet()
    {
        string kayit = JsonUtility.ToJson(Ali);
        // Debug.Log(kayit);
       // jsonYukle(kayit);

        File.WriteAllText(Application.dataPath + "/Saves/kulanici.json", kayit);
        jsonYukle();
    }


    void jsonYukle(/*string veri*/ )
    {
        string yol = Application.dataPath + "/Saves/kulanici.json";


        //CharacterStarts temp = new CharacterStarts();
        //temp = JsonUtility.FromJson<CharacterStarts>(veri);
        // Debug.Log(temp.altinSayi);

        if (File.Exists(yol))
        {
            string okunanVeri = File.ReadAllText(yol);
            CharacterStarts temp = new CharacterStarts();
            temp = JsonUtility.FromJson<CharacterStarts>(okunanVeri);
             Debug.Log(temp.altinSayi);
        }
        else
        {
            Debug.Log("dosya bulunamadý");
        }

     


    }




}
