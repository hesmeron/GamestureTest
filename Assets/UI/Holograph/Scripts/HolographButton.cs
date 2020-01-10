using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolographButton : MonoBehaviour
{
    [SerializeField]
    HolographControler controler;
    [SerializeField]
    float opacity;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        controler.gameObject.SetActive(true);
        controler.SetOpacity(opacity);
    }
}
