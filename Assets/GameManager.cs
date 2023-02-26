using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject[] cubes;
    GameObject randomChild;
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    public void RandomizeSize()
    {
        GameObject currentCube = cubes[Random.Range(0, cubes.Length)];
        currentCube.GetComponent<Renderer>().material.color = Color.red;
        randomChild = currentCube.transform.Find("Sphere").gameObject;
        randomChild.transform.localScale = new Vector3(Random.Range(0.6f, 4f), 0.6f, Random.Range(0.6f, 4f));
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
