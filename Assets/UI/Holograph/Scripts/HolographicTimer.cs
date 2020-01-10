using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolographicTimer : MonoBehaviour
{
    [SerializeField]
    float lifespan = 3f;
    [SerializeField]
    HolographControler controler;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        controler.gameObject.SetActive(true);
        controler.SetOpacity(0.19f);
        StartCoroutine(SwitchOff());
    }

    IEnumerator SwitchOff()
    {
        yield return new WaitForSeconds(lifespan);
        controler.SetOpacity(-1);
    }
}
