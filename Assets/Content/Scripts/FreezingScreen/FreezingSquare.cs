using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FreezingSquare : MonoBehaviour
{
    [SerializeField] private BoxCollider _boxCollider;
    [SerializeField] private ScriptableRendererFeature _freezingScreen;
    [SerializeField] private Material _freezingScreenMT;
    private bool isEntry;
    private bool isFrozen = false;
    
    public float MinReachDistance = 0.05f;

    private void Update()
    {
        var currentValue = _freezingScreenMT.GetFloat("_Value");
        
        if (isFrozen == true && currentValue != 1f)
        {
            _freezingScreenMT.SetFloat("_Value", Mathf.Lerp(currentValue, 1, 0.1f));

            if (currentValue >= 0.98f)
            {
                _freezingScreenMT.SetFloat("_Value", 1);
            }
        }

        if (isFrozen == false && currentValue != 0f)
        {
            _freezingScreenMT.SetFloat("_Value", Mathf.Lerp(currentValue, 0, 0.005f));

            if (currentValue <= 0.05f)
            {
                _freezingScreenMT.SetFloat("_Value", 0);
                _freezingScreen.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isEntry = _boxCollider.isTrigger;
        
        isFrozen = true;
        _freezingScreen.SetActive(true);
    }
    
    private void OnTriggerExit(Collider other)
    {
        isEntry = !_boxCollider.isTrigger;
        
        isFrozen = false;
    }
    
    
}
