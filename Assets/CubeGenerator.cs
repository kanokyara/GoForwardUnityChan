using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{

    //キューブのPrefab
    public GameObject cubePrefab;

    //時間計測用の変数
    private float delta = 0;

    //キューブの生成間隔
    private float span = 1.0f;

    //キューブの生成位置：X座標
    private float genPosX = 12;

    //キューブの生成位置オフセット
    private float offsetY = 0.3f;

    //キューブの縦方向の間隔
    private float spaceY = 6.9f;

    //キューブの生成位置オフセット
    private float offsetX = 0.5f;

    //キューブの横方向の間隔
    private float spaceX = 0.4f;

    //キューブの生成個数の上限
    private int maxBlockNum = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.delta += Time.deltaTime;

        // span秒以上の時間が経過したかを調べる
        if (this.delta > this.span)
        {
            //時間計測リセット
            this.delta = 0;
            // 生成するキューブ数をランダムに決める(1D4)
            int n = Random.Range(1, maxBlockNum + 1);

            //指定した数だけキューブを生成する
            for (int i = 0; i < n; i++)
            {
                //キューブの生成(Vector2は2D用)
                //this.offsetY + i * this.spaceYで降ってくるときに縦が重ならないようにする
                GameObject go = Instantiate(cubePrefab);
                go.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
            }
            //次のキューブまでの生成時間を決める
            //オフセットと間隔の値に、1D4から決められたint nの数値を掛けることで生成時間を決める
            this.span = this.offsetX + this.spaceX * n;
            //掛け算が優先されるため、まずspaceX * nで最低値を決めて、そこにoffsetXを足している

        }
    }
}
