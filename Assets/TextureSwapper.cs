using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSwapper : MonoBehaviour
{
    [SerializeField]
    public Texture activeTexture;
    [SerializeField]
    public Texture inactiveTexture;
    [SerializeField]
    public Material material;

    private void OnEnable()
    {
        material.mainTexture = activeTexture;
    }

    private void OnDisable()
    {
        material.mainTexture = inactiveTexture;

    }
}
