using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public interface ICollectableBehavior
{
    void OnCollected(GameObject player);
}
