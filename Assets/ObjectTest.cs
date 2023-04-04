using System;
using UnityEngine;

[Serializable]
public class ObjectTest : AbstractObjectTest, InterfaceObjectTest
{
    [SerializeField] int testInteger2;
    [SerializeField] bool testBoolean;
}