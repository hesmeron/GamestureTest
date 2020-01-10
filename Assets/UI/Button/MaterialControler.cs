using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MaterialControler : MonoBehaviour
{
    Material material;
    float time = 0.2f;
    float currentTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        material = meshRenderer.material;
        material = new Material(material);
        meshRenderer.material = material;
    }

    private void OnMouseOver()
    {
        float brightness = Mathf.Clamp01(currentTime/time) /3;
        material.SetFloat("_Brightness", brightness);
        currentTime += Time.deltaTime;
    }
    private void OnMouseExit()
    {
        material.SetFloat("_Brightness", 0);
        currentTime = 0;
    }
}
