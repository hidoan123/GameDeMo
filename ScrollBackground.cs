using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    public float textureScale = 2f;

    private Vector2 savedOffset;
    private new Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        savedOffset = renderer.sharedMaterial.GetTextureOffset("_MainTex");

        float aspectRatio = (float)Screen.width / Screen.height;
        float scaleY = transform.localScale.y / transform.localScale.x / aspectRatio * textureScale;
        renderer.sharedMaterial.SetTextureScale("_MainTex", new Vector2(textureScale, scaleY));
    }

    private void Update()
    {
        float y = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(savedOffset.x, y);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

    private void OnDisable()
    {
        renderer.sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
        renderer.sharedMaterial.SetTextureScale("_MainTex", new Vector2(1f, 1f));
    }
}
