using UnityEngine;
using System.Collections;

public class TriggerBase : MonoBehaviour
{
    public Material _matA;
    public Material _matB;

    private MeshRenderer _render;
    private bool _matCurA;

    void Awake()
    {
        _render = this.transform.GetComponent<MeshRenderer>();
        _matCurA = true;
        SwitchMat();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        _matCurA = !_matCurA;
        SwitchMat();
    }

    private void SwitchMat()
    {
        if (_render != null)
        {
            _render.sharedMaterial = _matCurA ? _matA : _matB;
        }
    }
}