using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestPlayerPos
{
    // A Test behaves as an ordinary method
    [UnityTest]
    public IEnumerator TestPlayerPosWithEnumeratorPasses()
    {
        yield return new WaitForSeconds(3);
        
        
    }
}
