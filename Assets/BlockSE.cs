using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSE : MonoBehaviour
{
    //�I�[�f�B�I�\�[�X�R���|�[�l���g�擾�̂��߂̕ϐ�
    AudioSource audioSource;

    //�I�[�f�B�I�N���b�v�w��
    public AudioClip block;

    // Start is called before the first frame update
    void Start()
    {
        //�I�[�f�B�I�\�[�X�R���|�[�l���g�擾
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�����蔻��ɂ���ăI�[�f�B�I�Đ�
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "SE")
        {
            audioSource.PlayOneShot(block, 1.0f);
        }
    }
}
