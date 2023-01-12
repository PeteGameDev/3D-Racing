using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Test : MonoBehaviour
{
    public GameObject surface;
    // Start is called before the first frame update
    void Start()
    {
        var temp = surface.GetComponent<NavMeshSurface>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
