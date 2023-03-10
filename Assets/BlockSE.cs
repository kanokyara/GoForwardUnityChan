using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSE : MonoBehaviour
{
    //オーディオソースコンポーネント取得のための変数
    AudioSource audioSource;

    //オーディオクリップ指定
    public AudioClip block;

    // Start is called before the first frame update
    void Start()
    {
        //オーディオソースコンポーネント取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //当たり判定によってオーディオ再生
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "SE")
        {
            audioSource.PlayOneShot(block, 1.0f);
        }
    }
}
