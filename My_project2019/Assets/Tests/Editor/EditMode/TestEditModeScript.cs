using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestEditModeScript {
    // A Test behaves as an ordinary method
    [Test]
    public void TestEditModeScriptSimplePasses () {
        // Use the Assert class to test conditions
        // 必ず成功を返す
        Assert.That (true);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestEditModeScriptWithEnumeratorPasses () {

        yield return null;
    }
}