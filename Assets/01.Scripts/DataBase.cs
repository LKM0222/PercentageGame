using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBase : MonoBehaviour
{
    public float dmg;
    public float atkSpd; //defalut = 2.5, max = 0.1 (수정할수도 있음)

    public Sprite[] itemSprite = new Sprite[0];
    //필요한게 일단 아이템에 대한 정보를 어떻게 데이터베이스에 저장할건지
    //일단 구현된 아이템들은 데이터베이스에 저장할거긴 한데 이 아이템들의 구조체가 필요함
    //뭔가 시스템이 돌아가는거 같지만 뭔가 애매한부분이 존재한다....
    //지금 장비창에 이미지가 들어가는거까지 되어있는데 지금 아이템을 미리 정비 해둬야 나중에 코드가 안꼬일듯 함.
    //아이템을 장비할때, 필요한 아이템의 부위, 아이템 코드를 대략적으로 정리해두고, 이를 인벤토리에 어떻게 넣을건지
    //미리 생각해야됨
    //장비창에 맞는 슬롯에 아이템을 계속 추가해둬야 나중에 맞는 부위에 아이템을 끼워 넣기 편할것.
    //또 생각나는건 또 적어둠.

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
