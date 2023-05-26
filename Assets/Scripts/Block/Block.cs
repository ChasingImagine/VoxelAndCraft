using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;





public class Block : MonoBehaviour
{
    public  List<GameObject> block;
  
    public GameObject previewBlock;

    int secilen = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray,out hit ,50.0f)) {

            if (hit.transform.tag == "Buildtable")
            {
                Vector3 prewPos = hit.point;
                previewBlock.transform.position= new Vector3(Mathf.Round(prewPos.x), Mathf.Round(prewPos.y), Mathf.Round(prewPos.z));



                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Vector3 buildPos = hit.point;
                    GameObject Build =Instantiate(block[secilen], buildPos, block[secilen].transform.rotation);
                 



                    Build.transform.rotation = new Quaternion(0, 0, 0, 0);
                    Build.transform.position = new Vector3(Mathf.Round(buildPos.x), Mathf.Round(buildPos.y), Mathf.Round(buildPos.z));
                  
                }


                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    Destroy(hit.transform.gameObject);

                    BlockProprties asd = block[secilen].GetComponent<BlockProprties>();
                    Debug.Log(asd.stackGurub);
                }


            }


            if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
            {
                secilen = 0;
            }
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                secilen = 1;
            }




        }



       


    }
}
