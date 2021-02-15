using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class ActionQueue
{
    int index;
    List<IActionItem> items = new List<IActionItem>();
    Dictionary<int, string> results = new Dictionary<int, string>();
    public void Add(IActionItem item)
    {
        items.Add(item);
    }

    public IEnumerator run()
    {
        int i = 0;
        
        foreach (IActionItem item in items)
        {
            string result =  item.use();
            results.Add(i, result);
            i++;
            yield return result;
        }
    }
}

