using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillingCam : MonoBehaviour
{
    public ApplicationManager am;
    public GameObject particleEffect;
    private Vector2 touchpos;
    private RaycastHit hit;
    private Camera cam;
    [SerializeField] private Text countText;
    private int _score;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount <= 0)
            return;
        touchpos = Input.GetTouch(0).position;
        Ray ray = cam.ScreenPointToRay(touchpos);
        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObj = hit.collider.gameObject;
            if (hitObj.tag == "Bird")
            {
                var clone = Instantiate(particleEffect, hitObj.transform.position, Quaternion.identity);
                Destroy(hitObj);
                _score++;
                countText.text = "Score: " + _score;
                am._birdCount--;
            }
        }
    }
}
