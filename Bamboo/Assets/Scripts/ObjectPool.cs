using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    [SerializeField]
    private GameObject poolingObjectPrefab;

    private Queue<Bullet> poolingObjectQueue = new Queue<Bullet>();

    private void Awake() {
        Instance = this;
    }

    private Bullet CreateNewObject() {
        var newObj = Instantiate(poolingObjectPrefab).GetComponent<Bullet>();
        newObj.gameObject.SetActive(false);
        return newObj;
    }

    public static Bullet GetObject() {
        if (Instance.poolingObjectQueue.Count > 0) {
            var obj = Instance.poolingObjectQueue.Dequeue();
            obj.transform.SetParent(null);
            obj.gameObject.SetActive(true);
            return obj;
        } else {
            var newObj = Instance.CreateNewObject();
            newObj.transform.SetParent(null);
            newObj.gameObject.SetActive(true);
            return newObj;
        }
    }

    public static void ReturnObject(Bullet bullet) {
        bullet.gameObject.SetActive(false);
        bullet.transform.SetParent(Instance.transform);
        Instance.poolingObjectQueue.Enqueue(bullet);
    }
}
