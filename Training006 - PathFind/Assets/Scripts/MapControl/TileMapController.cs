using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapController : MonoBehaviour
{
    protected string tileMapObjName = default;

    protected MapBoard mapController = default;
    protected Tilemap tilemap = default;
    protected List<GameObject> allTileObjs = default;

    //! Awake Ÿ�ӿ� �ʱ�ȭ �� ������ ��ӹ��� Ŭ�������� �������Ѵ�.

    public virtual void InitAwake(MapBoard mapController_)
    {
        mapController = mapController_;
        tilemap = gameObject.FindChildComponent<Tilemap>(tileMapObjName);

        // ���簢�� ���·� �ʱ�ȭ �� Ÿ���� ĳ���ؼ� ������ �ִ´�.
        allTileObjs = tilemap.gameObject.GetChildrenObjs();

        if(allTileObjs.IsValid())
        {
            allTileObjs.Sort(GFunc.CompareTileObjToLocalPos2D);
        }
        else
        {
            allTileObjs = new List<GameObject>();            
        }
    }

    
}
