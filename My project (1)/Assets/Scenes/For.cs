using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    public GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void active()
    {
        if( Sphere.activeSelf)
        {
            Sphere.SetActive(false);
        }
        else
        {
            Sphere.SetActive(true);
        }
    }
}
