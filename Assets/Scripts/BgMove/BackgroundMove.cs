using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BackgroundMove : MonoBehaviour
{
    RawImage img;
    public float speed = 0.1f;
    // Use this for initialization
    void Start()
    {
        this.img = this.GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        Rect r = this.img.uvRect;
        r.y += this.speed * Time.deltaTime;
        this.img.uvRect = r;
    }
}
