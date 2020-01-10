using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolographControler : MonoBehaviour
{
    [SerializeField]
    List<Material> materials = new List<Material>();
    [SerializeField]
    float opacity = -1;
    float targetOpacity = -1;
    float smooth = 5f;
    [SerializeField]
    float treshold;
    bool isDecreasing;
    // Start is called before the first frame update
    private void Update()
    {
        opacity = Mathf.Lerp(opacity, targetOpacity, Time.deltaTime * smooth);
        if(opacity != targetOpacity)
        {
            foreach (var m in materials)
            {
                m.SetFloat("_DotProduct", opacity); ;
            }
        }
        if (isDecreasing && opacity - targetOpacity < treshold)
        {
            gameObject.SetActive(false);
        }
  
    }

    public void SetOpacity(float opacity)
    {
        isDecreasing = (opacity < targetOpacity);      
        targetOpacity = opacity;
    }
}
