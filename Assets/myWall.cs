using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myWall : MonoBehaviour
{
    public GameObject Block;
    public int width = 10;
    public int height = 4;
    void Start()
    {
        for (int y=0; y<height; ++y)
        {
            for (int x=0; x<width; ++x)
            {
                Vector3 offset = new Vector3(x, y, 0);
                Instantiate(Block, transform.position + offset, Quaternion.identity);
            }
        }
    }
}