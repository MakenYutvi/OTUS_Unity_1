using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderDissolution : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimeOfDissolution;
   // public Shader Shader;
    public Material _Material;
    void Start()
    {
        _Material = GetComponentInChildren<Material>();
        Debug.Log(_Material.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
