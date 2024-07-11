using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingSprite : MonoBehaviour
{
    public Vector2 scrollSpeed = new Vector2(0, 0);
    Vector2 offsett;

    Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        scroll();
    }

    void scroll()
    {
        offsett = scrollSpeed * Time.deltaTime;
        material.mainTextureOffset += offsett;
    }
}
