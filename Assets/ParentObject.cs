using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ParentObject : MonoBehaviour
{

    public GameObject ownChild;
    public LayerMask child;
    void Start()
    {
        ownChild = transform.Find("Sphere").gameObject;
    }

    void Update()
    {

        Collider[] box = Physics.OverlapBox(transform.position, new Vector3(0.4f, 0.4f, 0.4f), Quaternion.identity, child);

        for (int i = 0; i < box.Length; i++) 
        {
            if (box[i])
            {
                if (box[i].gameObject != ownChild)
                {
                    Destroy(ownChild);
                    GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(1, 1, 1));
    }
}
