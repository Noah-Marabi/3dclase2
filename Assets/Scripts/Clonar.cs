using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonar : MonoBehaviour
{
    public GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        ClonarCubo();
    }
    void ClonarCubo()
    {
        Instantiate(cubePrefab);
    }
}
