using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject dropBlock;
    Rigidbody rb;
    public float moves=5;
    float rotateAmount = 1f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    

    public void StartAction()
    {
        StartCoroutine("Waitting");
    }

    public IEnumerator Waitting()
    {
        for (int i = 0; i < dropBlock.transform.childCount; i++)
        {
            ActionsOrder(dropBlock.transform.GetChild(i).name);
            yield return new WaitForSecondsRealtime(0.5f);

        }
    }

    public void ActionsOrder(string condition)
    {
        
        if (condition == "MoveForward")
        {
            rb.velocity = new Vector3(0, 0, moves);
            Debug.Log("MoveForward");

        }
         else if (condition == "MoveBackWard")
        {
            rb.velocity = new Vector3(0, 0, -moves);

            Debug.Log("MoveBackWard");


        }
         else if (condition == "MoveRight")
        {
            rb.velocity = new Vector3(moves, 0, 0);
            Debug.Log("MoveRight");


        }
         else if (condition == "MoveLeft")
        {
            rb.velocity = new Vector3(-moves, 0, 0);
            Debug.Log("MoveLeft");


        }
        else if(condition == "Rotate")
        {
            transform.Rotate(0, 90, 0);
            Debug.Log("Rotate");

        }



    }
}
