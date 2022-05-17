using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject theGoal;
    public int objectQuantity;
    public int objectToGenerate;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateObjects());
    }

    IEnumerator GenerateObjects()
    {
         while(objectQuantity < 1)
        {
            objectToGenerate = Random.Range(1,4);
            if(objectToGenerate == 1)
            {
                Instantiate(theGoal, new Vector3(286, 1, -235), Quaternion.identity);
            }
            if (objectToGenerate == 2)
            {
                Instantiate(theGoal, new Vector3(233, 1, -259), Quaternion.identity);
            }
            if (objectToGenerate == 3)
            {
                Instantiate(theGoal, new Vector3(126, 1, -268), Quaternion.identity);
            }

            yield return new WaitForSeconds(0.1f);
            objectQuantity += 1;
        }
        
               

    }
}

    
