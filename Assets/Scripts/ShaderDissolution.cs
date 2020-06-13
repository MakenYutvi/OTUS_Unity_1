using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderDissolution : MonoBehaviour
{
    // Start is called before the first frame update
    public float _TimeOfDissolution;
    // public Shader Shader;
    private MeshRenderer[] _MeshRenderer;
    private SkinnedMeshRenderer[] _SkinnedMeshRenderer;

    private float _stepOfDissoluton;
    private float _Dissolve_amount;
    private bool _IsDead = false;
    void Start()
    {
        _MeshRenderer = GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer i in _MeshRenderer)
        {
            Debug.Log(i.name);
            i.material.SetFloat("Dissolve_amount", 2.0f);
            _stepOfDissoluton = 2.0f / _TimeOfDissolution;
            _Dissolve_amount = 2.0f;
        }
        _SkinnedMeshRenderer = GetComponentsInChildren<SkinnedMeshRenderer>();
        foreach (SkinnedMeshRenderer i in _SkinnedMeshRenderer)
        {
            Debug.Log(i.name);
            i.material.SetFloat("Dissolve_amount", 2.0f);
            _stepOfDissoluton = 2.0f / _TimeOfDissolution;
            _Dissolve_amount = 2.0f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (_IsDead)
        {
            foreach (MeshRenderer i in _MeshRenderer)
            {
                if (_TimeOfDissolution > 0)
                {
                    _TimeOfDissolution -= Time.deltaTime;
                    _Dissolve_amount = _Dissolve_amount - _Dissolve_amount * _stepOfDissoluton * Time.deltaTime;
                    i.material.SetFloat("Dissolve_amount", _Dissolve_amount);
                }
                else
                {
                    i.material.SetFloat("Dissolve_amount", 0);
                }
            }

            foreach (SkinnedMeshRenderer i in _SkinnedMeshRenderer)
            {
                if (_TimeOfDissolution > 0)
                {
                    _TimeOfDissolution -= Time.deltaTime;
                    _Dissolve_amount = _Dissolve_amount - _Dissolve_amount * _stepOfDissoluton * Time.deltaTime;
                    i.material.SetFloat("Dissolve_amount", _Dissolve_amount);
                }
                else
                {
                    i.material.SetFloat("Dissolve_amount", 0);
                }
            }

        }
    }

    public void Dissolution()
    {
        _IsDead = true;
    }
}
